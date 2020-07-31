using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MimikaraGoiN2
{
    public partial class Form1 : Form
    {   
        private int selectedUnit;
        private Excel.Application xlApp;
        private Excel.Workbook xlWorkbook;
        private Excel._Worksheet xlWorksheet;
        private Excel.Range xlRange;
        private List<string> lstWords;
        private List<string> lstExample;
        private List<string> lstEng;
        private List<string> lstVie;
        private List<string> lstFurigana;
        int questionIdx;
        int score;

        public Form1()
        {
            InitializeComponent();
            comboBoxUnitLoad();
            eventInit();
            openWorkbook();
            this.lstWords = new List<string>();
            this.lstEng = new List<string>();
            this.lstVie = new List<string>();
            this.lstExample = new List<string>();
            this.lstFurigana = new List<string>();
            LockUnit();
            questionIdx = 1;
            score = 0;
        }

        private void openWorkbook()
        {
            xlApp = new Excel.Application();
            string fileName = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\list.xlsx");
            xlWorkbook = xlApp.Workbooks.Open(fileName);
        }

        private void LockUnit()
        {
            this.buttonUnitSelect.Enabled = false;
            this.buttonFuriganaSelect.Enabled = false;
            this.buttonNextQuestion.Enabled = false;
            this.textBoxExample.Multiline = true;
        }

        private void eventInit()
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(HMI_FormClosing);
            this.comboBoxUnit.SelectedIndexChanged += new EventHandler(unitBoxSelected);
        }
        private void comboBoxUnitLoad()
        {
            this.comboBoxUnit.Text = "選択";
            String[] unitList = { "一", "二", "三", "四", "五", "六", "七", "八", "九", "十", "十一", "十二", "十三" };
            comboBoxUnit.Items.AddRange(unitList);
        }

        private void unitBoxSelected(Object sender, EventArgs e)
        {
            buttonUnitSelect.Enabled = true;
        }

        private void buttonUnitSelect_Click(object sender, EventArgs e)
        {
            selectedUnit = comboBoxUnit.SelectedIndex;
            importDataXls();
            questionIdx = 0;
            showQuestion(questionIdx);
        }

        private void importDataXls()
        {
            xlWorksheet = xlWorkbook.Sheets[selectedUnit + 1];
            xlRange = xlWorksheet.UsedRange;
            enlistXls(lstWords, 1);
            enlistXls(lstExample, 2);
            enlistXls(lstEng, 3);
            enlistXls(lstVie, 4);
            enlistXls(lstFurigana, 5);
            MessageBox.Show("始めましょう");
        }

        private void enlistXls(List<string> list, int colIdx)
        {
            String str = "一";
            int rowIdx = 2;
            while(true)
            {
                str = xlWorksheet.Cells[rowIdx, colIdx].Text;
                if (str.Equals("x"))
                {
                    break;
                }
                list.Add(str);
                rowIdx = rowIdx + 1;
            }
        }

        private void showQuestion(int questionIdx)
        {
            textBoxVie.Text = lstVie[questionIdx];
            string correct = lstFurigana[questionIdx];
            lstFurigana.RemoveAt(questionIdx);
            // Random wrong options
            int idx1 = getRandomInt(lstFurigana.Count());
            string str1 = lstFurigana[idx1];
            lstFurigana.RemoveAt(idx1);
            int idx2 = getRandomInt(lstFurigana.Count());
            string str2 = lstFurigana[idx2];
            lstFurigana.RemoveAt(idx2);
            int idx3 = getRandomInt(lstFurigana.Count());
            string str3 = lstFurigana[idx3];
            lstFurigana.Insert(idx2, str2);
            lstFurigana.Insert(idx1, str1);
            lstFurigana.Insert(questionIdx, correct);
            // Shuffle options
            string[] options = new string[4];
            options[0] = correct;
            options[1] = str1;
            options[2] = str2;
            options[3] = str3;
            int j = getRandomInt(4);
            string tmp = options[j];
            options[j] = options[0];
            options[0] = tmp;
            // Show options on check box
            checkBoxA.Checked = false;
            checkBoxB.Checked = false;
            checkBoxC.Checked = false;
            checkBoxD.Checked = false;
            checkBoxA.Text = options[0].ToString();
            checkBoxB.Text = options[1].ToString();
            checkBoxC.Text = options[2].ToString();
            checkBoxD.Text = options[3].ToString();
            // Lock next question
            buttonFuriganaSelect.Enabled = true;
            buttonNextQuestion.Enabled = false;
            // Clear text
            textBoxResult.Text = "";
            textBoxWord.Text = "";
            textBoxEng.Text = "";
            textBoxExample.Text = "";
        }

        private int getRandomInt(int range)
        {
            Random random = new Random(); ;
            int x = random.Next() % range;
            return x;
        }

        private void clearDataXls()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        private void HMI_FormClosing(object sender, EventArgs e)
        {
            if (xlWorksheet != null) clearDataXls();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            questionIdx++;
            if (questionIdx != lstVie.Count())
            {
                showQuestion(questionIdx);
            }
            else
            {
                MessageBox.Show("スコア　" + score + "/" + lstFurigana.Count());
                LockUnit();
            }
        }

        bool isCheckBoxTrue(CheckBox box)
        {
            if(box.Checked)
            {
                if (box.Text.Equals(lstFurigana[questionIdx]))
                {
                    return true;
                }
                return false;
            }
            else
            {
                if(box.Text.Equals(lstFurigana[questionIdx]))
                {
                    return false;
                }
                return true;
            }
        }

        void showInfo()
        {
            textBoxWord.Text = lstWords[questionIdx];
            textBoxEng.Text = lstEng[questionIdx];
            textBoxExample.Text = lstExample[questionIdx];
        }

        private void buttonFuriganaSelect_Click(object sender, EventArgs e)
        {
            bool checkBoxTrue = isCheckBoxTrue(checkBoxA) && isCheckBoxTrue(checkBoxB)
                && isCheckBoxTrue(checkBoxC) && isCheckBoxTrue(checkBoxD);
            if(checkBoxTrue)
            {
                textBoxResult.Text = "🔴" + lstFurigana[questionIdx];
                score++;
            }
            else
            {
                textBoxResult.Text = "✘" + lstFurigana[questionIdx];
            }
            buttonNextQuestion.Enabled = true;
            buttonFuriganaSelect.Enabled = false;
            textBoxWord.Text = lstWords[questionIdx];
            textBoxExample.Text = lstExample[questionIdx];
            textBoxEng.Text = lstEng[questionIdx];
            textBoxScore.Text = score.ToString() + "/" + lstFurigana.Count().ToString();
        }
    }
}

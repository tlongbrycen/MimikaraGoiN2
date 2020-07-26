using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Form1()
        {
            InitializeComponent();
            comboBoxUnitLoad();
            eventInit();
            xlApp = new Excel.Application();
            xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\tlong\source\repos\MimikaraGoiN2\MimikaraGoiN2\bin\x64\Release\listN2.xlsx");
            this.lstWords = new List<string>();
            this.lstEng = new List<string>();
            this.lstVie = new List<string>();
            this.lstExample = new List<string>();
            this.lstFurigana = new List<string>();
            this.buttonUnitSelect.Enabled = false;
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
            String[] unitList = { "一", "二" };
            comboBoxUnit.Items.AddRange(unitList);
        }

        private void unitBoxSelected(Object sender, EventArgs e)
        {
            buttonUnitSelect.Enabled = true;
        }

        private void buttonUnitSelect_Click(object sender, EventArgs e)
        {
            selectedUnit = comboBoxUnit.SelectedIndex;
            //MessageBox.Show(selectedUnit.ToString()); // Debug
            importDataXls();
            
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
            //MessageBox.Show(lstFurigana[5]); // Debug
            MessageBox.Show("はじめましう");
        }

        private void enlistXls(List<string> list, int colIdx)
        {
            String str = "一";
            int rowIdx = 1;
            do
            {
                str = xlWorksheet.Cells[rowIdx, colIdx].Text;
                list.Add(str);
                rowIdx = rowIdx + 1;
            }
            while (!str.Equals("x"));
        }

        private void clearDataXls()
        {
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        private void HMI_FormClosing(object sender, EventArgs e)
        {
            clearDataXls();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

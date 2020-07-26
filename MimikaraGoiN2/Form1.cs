using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MimikaraGoiN2
{
    public partial class Form1 : Form
    {
        private int selectedUnit;
        
        public Form1()
        {
            InitializeComponent();
            comboBoxUnitLoad();
        }
        private void comboBoxUnitLoad()
        {
            this.comboBoxUnit.Text = "一";
            String[] unitList = { "一", "二" };
            comboBoxUnit.Items.AddRange(unitList);
        }

        private void buttonUnitSelect_Click(object sender, EventArgs e)
        {
            selectedUnit = comboBoxUnit.SelectedIndex;
            //MessageBox.Show(selectedUnit.ToString());
        }

        private void importData()
        {

        }
    }
}

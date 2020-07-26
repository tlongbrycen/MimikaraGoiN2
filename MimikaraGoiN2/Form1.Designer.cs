using System;

namespace MimikaraGoiN2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUnitSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(105, 12);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(317, 23);
            this.comboBoxUnit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "第";
            // 
            // buttonUnitSelect
            // 
            this.buttonUnitSelect.Location = new System.Drawing.Point(443, 13);
            this.buttonUnitSelect.Name = "buttonUnitSelect";
            this.buttonUnitSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonUnitSelect.TabIndex = 2;
            this.buttonUnitSelect.Text = "選択";
            this.buttonUnitSelect.UseVisualStyleBackColor = true;
            this.buttonUnitSelect.Click += new System.EventHandler(this.buttonUnitSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 262);
            this.Controls.Add(this.buttonUnitSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUnit);
            this.Name = "Form1";
            this.Text = "耳から覚える語彙N2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUnitSelect;
    }
}


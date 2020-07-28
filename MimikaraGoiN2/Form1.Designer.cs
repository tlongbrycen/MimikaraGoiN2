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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.buttonFuriganaSelect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEng = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxExample = new System.Windows.Forms.TextBox();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiếng Việt";
            // 
            // textBoxVie
            // 
            this.textBoxVie.Location = new System.Drawing.Point(105, 50);
            this.textBoxVie.Name = "textBoxVie";
            this.textBoxVie.Size = new System.Drawing.Size(413, 22);
            this.textBoxVie.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "フリガナ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxD);
            this.panel1.Controls.Add(this.checkBoxA);
            this.panel1.Controls.Add(this.checkBoxC);
            this.panel1.Controls.Add(this.checkBoxB);
            this.panel1.Location = new System.Drawing.Point(105, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 112);
            this.panel1.TabIndex = 10;
            // 
            // checkBoxD
            // 
            this.checkBoxD.AutoSize = true;
            this.checkBoxD.Location = new System.Drawing.Point(13, 84);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(39, 19);
            this.checkBoxD.TabIndex = 14;
            this.checkBoxD.Text = "D";
            this.checkBoxD.UseVisualStyleBackColor = true;
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSize = true;
            this.checkBoxA.Location = new System.Drawing.Point(13, 9);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(38, 19);
            this.checkBoxA.TabIndex = 11;
            this.checkBoxA.Text = "A";
            this.checkBoxA.UseVisualStyleBackColor = true;
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Location = new System.Drawing.Point(13, 59);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(39, 19);
            this.checkBoxC.TabIndex = 13;
            this.checkBoxC.Text = "C";
            this.checkBoxC.UseVisualStyleBackColor = true;
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Location = new System.Drawing.Point(13, 34);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(39, 19);
            this.checkBoxB.TabIndex = 12;
            this.checkBoxB.Text = "B";
            this.checkBoxB.UseVisualStyleBackColor = true;
            // 
            // buttonFuriganaSelect
            // 
            this.buttonFuriganaSelect.Location = new System.Drawing.Point(443, 78);
            this.buttonFuriganaSelect.Name = "buttonFuriganaSelect";
            this.buttonFuriganaSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonFuriganaSelect.TabIndex = 11;
            this.buttonFuriganaSelect.Text = "選択";
            this.buttonFuriganaSelect.UseVisualStyleBackColor = true;
            this.buttonFuriganaSelect.Click += new System.EventHandler(this.buttonFuriganaSelect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "単語";
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(105, 207);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(413, 22);
            this.textBoxWord.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "English";
            // 
            // textBoxEng
            // 
            this.textBoxEng.Location = new System.Drawing.Point(105, 245);
            this.textBoxEng.Name = "textBoxEng";
            this.textBoxEng.Size = new System.Drawing.Size(413, 22);
            this.textBoxEng.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "例";
            // 
            // textBoxExample
            // 
            this.textBoxExample.Location = new System.Drawing.Point(105, 286);
            this.textBoxExample.Name = "textBoxExample";
            this.textBoxExample.Size = new System.Drawing.Size(413, 22);
            this.textBoxExample.TabIndex = 17;
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Location = new System.Drawing.Point(443, 112);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(75, 23);
            this.buttonNextQuestion.TabIndex = 18;
            this.buttonNextQuestion.Text = "次";
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 401);
            this.Controls.Add(this.buttonNextQuestion);
            this.Controls.Add(this.textBoxExample);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEng);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonFuriganaSelect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUnitSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUnit);
            this.Name = "Form1";
            this.Text = "日本語勉強";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUnitSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.Button buttonFuriganaSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEng;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxExample;
        private System.Windows.Forms.Button buttonNextQuestion;
    }
}


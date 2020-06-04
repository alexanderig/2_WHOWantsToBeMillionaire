namespace Millionare
{
    partial class AdminAddForm
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
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRec = new System.Windows.Forms.Button();
            this.buttonCanc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(11, 31);
            this.textBoxQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(503, 20);
            this.textBoxQuestion.TabIndex = 0;
            this.textBoxQuestion.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(11, 80);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(286, 20);
            this.textBoxAnswer.TabIndex = 1;
            this.textBoxAnswer.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(11, 130);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(286, 20);
            this.textBoxA.TabIndex = 2;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(11, 176);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(286, 20);
            this.textBoxB.TabIndex = 3;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(11, 221);
            this.textBoxC.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(286, 20);
            this.textBoxC.TabIndex = 4;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(314, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(199, 185);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите цену вопроса";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(16, 158);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(121, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "500 000 - 1 000 000";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 128);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(106, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "64 000 - 250 000";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 98);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "4 000 - 32 000";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 65);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "500 - 2 000";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 37);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "100 - 300";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите вопрос:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите Ответ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Неправильный вариант А:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Неправильный вариант Б:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Неправильный вариант С:";
            // 
            // buttonRec
            // 
            this.buttonRec.Location = new System.Drawing.Point(57, 258);
            this.buttonRec.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRec.Name = "buttonRec";
            this.buttonRec.Size = new System.Drawing.Size(84, 29);
            this.buttonRec.TabIndex = 11;
            this.buttonRec.Text = "Записать";
            this.buttonRec.UseVisualStyleBackColor = true;
            this.buttonRec.Click += new System.EventHandler(this.buttonRec_Click);
            // 
            // buttonCanc
            // 
            this.buttonCanc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCanc.Location = new System.Drawing.Point(358, 258);
            this.buttonCanc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCanc.Name = "buttonCanc";
            this.buttonCanc.Size = new System.Drawing.Size(84, 29);
            this.buttonCanc.TabIndex = 12;
            this.buttonCanc.Text = "Отмена";
            this.buttonCanc.UseVisualStyleBackColor = true;
            // 
            // AdminAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 303);
            this.Controls.Add(this.buttonCanc);
            this.Controls.Add(this.buttonRec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.textBoxQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ввод новых вопросов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRec;
        private System.Windows.Forms.Button buttonCanc;
    }
}
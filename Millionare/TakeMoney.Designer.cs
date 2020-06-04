namespace Millionare
{
    partial class TakeMoney
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.SlateBlue;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderA,
            this.columnHeaderB,
            this.columnHeaderC});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.ForeColor = System.Drawing.SystemColors.Menu;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(440, 385);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderA
            // 
            this.columnHeaderA.Text = "Дата";
            this.columnHeaderA.Width = 156;
            // 
            // columnHeaderB
            // 
            this.columnHeaderB.Text = "Имя";
            this.columnHeaderB.Width = 177;
            // 
            // columnHeaderC
            // 
            this.columnHeaderC.Text = "Забрал";
            this.columnHeaderC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderC.Width = 103;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(89, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(276, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxB
            // 
            this.textBoxB.BackColor = System.Drawing.Color.SlateBlue;
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.ForeColor = System.Drawing.Color.White;
            this.textBoxB.Location = new System.Drawing.Point(169, 403);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(178, 26);
            this.textBoxB.TabIndex = 1;
            this.textBoxB.Text = "Ваше имя";
            this.textBoxB.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxB_PreviewKeyDown);
            // 
            // textBoxC
            // 
            this.textBoxC.BackColor = System.Drawing.Color.SlateBlue;
            this.textBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxC.ForeColor = System.Drawing.Color.White;
            this.textBoxC.Location = new System.Drawing.Point(353, 403);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.ReadOnly = true;
            this.textBoxC.Size = new System.Drawing.Size(99, 26);
            this.textBoxC.TabIndex = 3;
            this.textBoxC.TabStop = false;
            this.textBoxC.WordWrap = false;
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.Color.SlateBlue;
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.ForeColor = System.Drawing.Color.White;
            this.textBoxA.Location = new System.Drawing.Point(12, 403);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(151, 26);
            this.textBoxA.TabIndex = 4;
            this.textBoxA.TabStop = false;
            this.textBoxA.WordWrap = false;
            // 
            // TakeMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Millionare.Properties.Resources._4137_960x600;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 500);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TakeMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Зал Славы";
            this.Shown += new System.EventHandler(this.TakeMoney_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderA;
        private System.Windows.Forms.ColumnHeader columnHeaderB;
        private System.Windows.Forms.ColumnHeader columnHeaderC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxA;
    }
}
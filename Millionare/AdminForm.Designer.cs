namespace Millionare
{
    partial class AdminForm
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Вопросы весом 100 - 300", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Вопросы весом 500 - 2 000", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Вопросы весом 4 000 - 32 000", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Вопросы весом 64 000 - 250 000", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Вопросы весом 500 000 - 1 000 000", System.Windows.Forms.HorizontalAlignment.Left);
            this.QlistView = new System.Windows.Forms.ListView();
            this.columnQuestion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVarB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVarC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVarD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QlistView
            // 
            this.QlistView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnQuestion,
            this.columnAnswer,
            this.columnVarB,
            this.columnVarC,
            this.columnVarD});
            this.QlistView.GridLines = true;
            listViewGroup1.Header = "Вопросы весом 100 - 300";
            listViewGroup1.Name = "listQgroup1";
            listViewGroup2.Header = "Вопросы весом 500 - 2 000";
            listViewGroup2.Name = "listQgroup2";
            listViewGroup3.Header = "Вопросы весом 4 000 - 32 000";
            listViewGroup3.Name = "listQgroup3";
            listViewGroup4.Header = "Вопросы весом 64 000 - 250 000";
            listViewGroup4.Name = "listQgroup4";
            listViewGroup5.Header = "Вопросы весом 500 000 - 1 000 000";
            listViewGroup5.Name = "listQgroup5";
            this.QlistView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.QlistView.LabelWrap = false;
            this.QlistView.Location = new System.Drawing.Point(9, 19);
            this.QlistView.Margin = new System.Windows.Forms.Padding(2);
            this.QlistView.MultiSelect = false;
            this.QlistView.Name = "QlistView";
            this.QlistView.Size = new System.Drawing.Size(1013, 289);
            this.QlistView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.QlistView.TabIndex = 0;
            this.QlistView.UseCompatibleStateImageBehavior = false;
            this.QlistView.View = System.Windows.Forms.View.Details;
            this.QlistView.DoubleClick += new System.EventHandler(this.QlistView_DoubleClick);
            // 
            // columnQuestion
            // 
            this.columnQuestion.Text = "Вопрос";
            this.columnQuestion.Width = 400;
            // 
            // columnAnswer
            // 
            this.columnAnswer.Text = "Ответ";
            this.columnAnswer.Width = 150;
            // 
            // columnVarB
            // 
            this.columnVarB.Text = "Вариант Б";
            this.columnVarB.Width = 150;
            // 
            // columnVarC
            // 
            this.columnVarC.Text = "Вариант С";
            this.columnVarC.Width = 150;
            // 
            // columnVarD
            // 
            this.columnVarD.Text = "Вариант Д";
            this.columnVarD.Width = 150;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAdd.Location = new System.Drawing.Point(235, 323);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(93, 31);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEdit.Location = new System.Drawing.Point(384, 323);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(93, 31);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDel.Location = new System.Drawing.Point(534, 323);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(93, 31);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonExit.Location = new System.Drawing.Point(683, 323);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(93, 31);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 366);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.QlistView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(754, 332);
            this.Name = "AdminForm";
            this.Text = "Управление вопросами";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView QlistView;
        private System.Windows.Forms.ColumnHeader columnQuestion;
        private System.Windows.Forms.ColumnHeader columnAnswer;
        private System.Windows.Forms.ColumnHeader columnVarB;
        private System.Windows.Forms.ColumnHeader columnVarC;
        private System.Windows.Forms.ColumnHeader columnVarD;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonExit;
    }
}
namespace Millionare
{
    partial class MainWindowForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TakeMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.AdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button5050 = new System.Windows.Forms.Button();
            this.buttonZal = new System.Windows.Forms.Button();
            this.buttonZvonok = new System.Windows.Forms.Button();
            this.buttonStartQuestion = new System.Windows.Forms.Button();
            this.buttonTakeMoney = new System.Windows.Forms.Button();
            this.buttonExitGame = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.progressBarA = new System.Windows.Forms.ProgressBar();
            this.progressBarB = new System.Windows.Forms.ProgressBar();
            this.progressBarC = new System.Windows.Forms.ProgressBar();
            this.progressBarD = new System.Windows.Forms.ProgressBar();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(959, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GameToolStripMenuItem
            // 
            this.GameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartGameToolStripMenuItem,
            this.StopGameToolStripMenuItem,
            this.TakeMoneyToolStripMenuItem,
            this.toolStripMenuItem1,
            this.AdminToolStripMenuItem,
            this.toolStripMenuItem2,
            this.ExitToolStripMenuItem});
            this.GameToolStripMenuItem.Name = "GameToolStripMenuItem";
            this.GameToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.GameToolStripMenuItem.Text = "Игра";
            // 
            // StartGameToolStripMenuItem
            // 
            this.StartGameToolStripMenuItem.Name = "StartGameToolStripMenuItem";
            this.StartGameToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.StartGameToolStripMenuItem.Text = "Начать игру";
            this.StartGameToolStripMenuItem.Click += new System.EventHandler(this.StartGameToolStripMenuItem_Click);
            // 
            // StopGameToolStripMenuItem
            // 
            this.StopGameToolStripMenuItem.Name = "StopGameToolStripMenuItem";
            this.StopGameToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.StopGameToolStripMenuItem.Text = "Остановить игру";
            this.StopGameToolStripMenuItem.Click += new System.EventHandler(this.StopGameToolStripMenuItem_Click);
            // 
            // TakeMoneyToolStripMenuItem
            // 
            this.TakeMoneyToolStripMenuItem.Name = "TakeMoneyToolStripMenuItem";
            this.TakeMoneyToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.TakeMoneyToolStripMenuItem.Text = "Забрать деньги/Зал Славы";
            this.TakeMoneyToolStripMenuItem.Click += new System.EventHandler(this.TakeMoneyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 6);
            // 
            // AdminToolStripMenuItem
            // 
            this.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem";
            this.AdminToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.AdminToolStripMenuItem.Text = "Режим Администратора";
            this.AdminToolStripMenuItem.Click += new System.EventHandler(this.AdminToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // button5050
            // 
            this.button5050.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5050.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5050.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5050.FlatAppearance.BorderSize = 0;
            this.button5050.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5050.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5050.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5050.Location = new System.Drawing.Point(127, 104);
            this.button5050.Margin = new System.Windows.Forms.Padding(2);
            this.button5050.Name = "button5050";
            this.button5050.Size = new System.Drawing.Size(45, 44);
            this.button5050.TabIndex = 1;
            this.button5050.TabStop = false;
            this.toolTip1.SetToolTip(this.button5050, "50/50");
            this.button5050.UseVisualStyleBackColor = false;
            this.button5050.Click += new System.EventHandler(this.button5050_Click);
            // 
            // buttonZal
            // 
            this.buttonZal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonZal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonZal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonZal.FlatAppearance.BorderSize = 0;
            this.buttonZal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonZal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonZal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZal.Location = new System.Drawing.Point(127, 169);
            this.buttonZal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZal.Name = "buttonZal";
            this.buttonZal.Size = new System.Drawing.Size(45, 44);
            this.buttonZal.TabIndex = 2;
            this.buttonZal.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonZal, "Помощь зала");
            this.buttonZal.UseVisualStyleBackColor = false;
            this.buttonZal.Click += new System.EventHandler(this.buttonZal_Click);
            // 
            // buttonZvonok
            // 
            this.buttonZvonok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonZvonok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonZvonok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonZvonok.FlatAppearance.BorderSize = 0;
            this.buttonZvonok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonZvonok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonZvonok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZvonok.Location = new System.Drawing.Point(127, 231);
            this.buttonZvonok.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZvonok.Name = "buttonZvonok";
            this.buttonZvonok.Size = new System.Drawing.Size(45, 44);
            this.buttonZvonok.TabIndex = 3;
            this.buttonZvonok.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonZvonok, "Звонок другу");
            this.buttonZvonok.UseVisualStyleBackColor = false;
            this.buttonZvonok.Click += new System.EventHandler(this.buttonZvonok_Click);
            // 
            // buttonStartQuestion
            // 
            this.buttonStartQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonStartQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStartQuestion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonStartQuestion.FlatAppearance.BorderSize = 0;
            this.buttonStartQuestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonStartQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonStartQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartQuestion.ForeColor = System.Drawing.Color.White;
            this.buttonStartQuestion.Location = new System.Drawing.Point(204, 370);
            this.buttonStartQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartQuestion.Name = "buttonStartQuestion";
            this.buttonStartQuestion.Size = new System.Drawing.Size(567, 87);
            this.buttonStartQuestion.TabIndex = 8;
            this.buttonStartQuestion.TabStop = false;
            this.buttonStartQuestion.Text = "Для начала игры тыкните здесь";
            this.toolTip1.SetToolTip(this.buttonStartQuestion, "Вопрос");
            this.buttonStartQuestion.UseVisualStyleBackColor = false;
            this.buttonStartQuestion.Click += new System.EventHandler(this.buttonStartQuestion_Click);
            // 
            // buttonTakeMoney
            // 
            this.buttonTakeMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTakeMoney.BackgroundImage = global::Millionare.Properties.Resources.TakeMoney;
            this.buttonTakeMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTakeMoney.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTakeMoney.FlatAppearance.BorderSize = 0;
            this.buttonTakeMoney.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTakeMoney.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTakeMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTakeMoney.Location = new System.Drawing.Point(83, 39);
            this.buttonTakeMoney.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTakeMoney.Name = "buttonTakeMoney";
            this.buttonTakeMoney.Size = new System.Drawing.Size(57, 47);
            this.buttonTakeMoney.TabIndex = 9;
            this.buttonTakeMoney.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonTakeMoney, "Забрать деньги/Зал Славы");
            this.buttonTakeMoney.UseVisualStyleBackColor = false;
            this.buttonTakeMoney.Click += new System.EventHandler(this.buttonTakeMoney_Click);
            // 
            // buttonExitGame
            // 
            this.buttonExitGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExitGame.BackgroundImage = global::Millionare.Properties.Resources.ExitGame;
            this.buttonExitGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExitGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExitGame.FlatAppearance.BorderSize = 0;
            this.buttonExitGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExitGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitGame.Location = new System.Drawing.Point(11, 39);
            this.buttonExitGame.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExitGame.Name = "buttonExitGame";
            this.buttonExitGame.Size = new System.Drawing.Size(57, 47);
            this.buttonExitGame.TabIndex = 10;
            this.buttonExitGame.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonExitGame, "Прервать игру");
            this.buttonExitGame.UseVisualStyleBackColor = false;
            this.buttonExitGame.Click += new System.EventHandler(this.buttonExitGame_Click);
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonA.FlatAppearance.BorderSize = 0;
            this.buttonA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonA.ForeColor = System.Drawing.Color.White;
            this.buttonA.Location = new System.Drawing.Point(178, 492);
            this.buttonA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(274, 36);
            this.buttonA.TabIndex = 4;
            this.buttonA.TabStop = false;
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonB.FlatAppearance.BorderSize = 0;
            this.buttonB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonB.ForeColor = System.Drawing.Color.White;
            this.buttonB.Location = new System.Drawing.Point(509, 492);
            this.buttonB.Margin = new System.Windows.Forms.Padding(2);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(274, 36);
            this.buttonB.TabIndex = 5;
            this.buttonB.TabStop = false;
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonC.FlatAppearance.BorderSize = 0;
            this.buttonC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonC.ForeColor = System.Drawing.Color.White;
            this.buttonC.Location = new System.Drawing.Point(179, 547);
            this.buttonC.Margin = new System.Windows.Forms.Padding(2);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(274, 36);
            this.buttonC.TabIndex = 6;
            this.buttonC.TabStop = false;
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonD.FlatAppearance.BorderSize = 0;
            this.buttonD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonD.ForeColor = System.Drawing.Color.White;
            this.buttonD.Location = new System.Drawing.Point(510, 547);
            this.buttonD.Margin = new System.Windows.Forms.Padding(2);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(274, 36);
            this.buttonD.TabIndex = 7;
            this.buttonD.TabStop = false;
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // labelScore
            // 
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelScore.Location = new System.Drawing.Point(787, 324);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(135, 20);
            this.labelScore.TabIndex = 12;
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTip.ForeColor = System.Drawing.Color.White;
            this.labelTip.Location = new System.Drawing.Point(217, 90);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(40, 24);
            this.labelTip.TabIndex = 13;
            this.labelTip.Text = "Tip";
            this.labelTip.Visible = false;
            // 
            // progressBarA
            // 
            this.progressBarA.Location = new System.Drawing.Point(217, 125);
            this.progressBarA.Name = "progressBarA";
            this.progressBarA.Size = new System.Drawing.Size(163, 23);
            this.progressBarA.Step = 1;
            this.progressBarA.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarA.TabIndex = 14;
            this.progressBarA.Visible = false;
            // 
            // progressBarB
            // 
            this.progressBarB.Location = new System.Drawing.Point(217, 154);
            this.progressBarB.Name = "progressBarB";
            this.progressBarB.Size = new System.Drawing.Size(163, 23);
            this.progressBarB.Step = 1;
            this.progressBarB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarB.TabIndex = 15;
            this.progressBarB.Visible = false;
            // 
            // progressBarC
            // 
            this.progressBarC.Location = new System.Drawing.Point(217, 183);
            this.progressBarC.Name = "progressBarC";
            this.progressBarC.Size = new System.Drawing.Size(163, 23);
            this.progressBarC.Step = 1;
            this.progressBarC.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarC.TabIndex = 16;
            this.progressBarC.Visible = false;
            // 
            // progressBarD
            // 
            this.progressBarD.Location = new System.Drawing.Point(217, 212);
            this.progressBarD.Name = "progressBarD";
            this.progressBarD.Size = new System.Drawing.Size(163, 23);
            this.progressBarD.Step = 1;
            this.progressBarD.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarD.TabIndex = 17;
            this.progressBarD.Visible = false;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.ForeColor = System.Drawing.Color.White;
            this.labelA.Location = new System.Drawing.Point(386, 125);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(53, 20);
            this.labelA.TabIndex = 18;
            this.labelA.Text = "label1";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelA.Visible = false;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.ForeColor = System.Drawing.Color.White;
            this.labelB.Location = new System.Drawing.Point(386, 154);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(53, 20);
            this.labelB.TabIndex = 19;
            this.labelB.Text = "label2";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelB.Visible = false;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC.ForeColor = System.Drawing.Color.White;
            this.labelC.Location = new System.Drawing.Point(386, 184);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(53, 20);
            this.labelC.TabIndex = 20;
            this.labelC.Text = "label3";
            this.labelC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelC.Visible = false;
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelD.ForeColor = System.Drawing.Color.White;
            this.labelD.Location = new System.Drawing.Point(386, 213);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(53, 20);
            this.labelD.TabIndex = 21;
            this.labelD.Text = "label4";
            this.labelD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelD.Visible = false;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Millionare.Properties.Resources.frontwall2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(959, 604);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.progressBarD);
            this.Controls.Add(this.progressBarC);
            this.Controls.Add(this.progressBarB);
            this.Controls.Add(this.progressBarA);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonExitGame);
            this.Controls.Add(this.buttonTakeMoney);
            this.Controls.Add(this.buttonStartQuestion);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonZvonok);
            this.Controls.Add(this.buttonZal);
            this.Controls.Add(this.button5050);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра Кто хочет стать миллионером";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button5050;
        private System.Windows.Forms.Button buttonZal;
        private System.Windows.Forms.Button buttonZvonok;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonStartQuestion;
        private System.Windows.Forms.Button buttonTakeMoney;
        private System.Windows.Forms.Button buttonExitGame;
        private System.Windows.Forms.ToolStripMenuItem StartGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TakeMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.ProgressBar progressBarA;
        private System.Windows.Forms.ProgressBar progressBarB;
        private System.Windows.Forms.ProgressBar progressBarC;
        private System.Windows.Forms.ProgressBar progressBarD;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
    }
}


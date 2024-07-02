namespace Finals
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblmessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guessBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playAgainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lyliaGIF = new System.Windows.Forms.PictureBox();
            this.confettiGIF = new System.Windows.Forms.PictureBox();
            this.congratsGIF = new System.Windows.Forms.PictureBox();
            this.cryGIF = new System.Windows.Forms.PictureBox();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblAgain = new System.Windows.Forms.Label();
            this.lblTimeleft = new System.Windows.Forms.Label();
            this.lblScoreval = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.lblShowtimeleft = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lyliaGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confettiGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congratsGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cryGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // bCheck
            // 
            this.bCheck.BackColor = System.Drawing.Color.Khaki;
            this.bCheck.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCheck.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bCheck.Location = new System.Drawing.Point(240, 261);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(153, 56);
            this.bCheck.TabIndex = 0;
            this.bCheck.Text = "CHECK";
            this.bCheck.UseVisualStyleBackColor = false;
            this.bCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lylia forgot the exact number of lemons she bought from Mr. Orange.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Her mother would be furious if she find out!";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(164, 95);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(300, 26);
            this.title.TabIndex = 5;
            this.title.Text = "Guess the number of lemons";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(229, 224);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(172, 31);
            this.txtAnswer.TabIndex = 7;
            this.txtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "number range (1-100)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(525, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Your goal is to save Lylia from getting driven out of their house. ";
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.BackColor = System.Drawing.Color.Transparent;
            this.lblmessage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.Location = new System.Drawing.Point(32, 329);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 20);
            this.lblmessage.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Guess:";
            // 
            // guessBar
            // 
            this.guessBar.BackColor = System.Drawing.SystemColors.Control;
            this.guessBar.ForeColor = System.Drawing.Color.Green;
            this.guessBar.Location = new System.Drawing.Point(483, 44);
            this.guessBar.Name = "guessBar";
            this.guessBar.Size = new System.Drawing.Size(155, 28);
            this.guessBar.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playAgainToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // playAgainToolStripMenuItem
            // 
            this.playAgainToolStripMenuItem.Name = "playAgainToolStripMenuItem";
            this.playAgainToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.playAgainToolStripMenuItem.Text = "Play Again";
            this.playAgainToolStripMenuItem.Click += new System.EventHandler(this.playAgainToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // lyliaGIF
            // 
            this.lyliaGIF.BackColor = System.Drawing.Color.Transparent;
            this.lyliaGIF.Image = ((System.Drawing.Image)(resources.GetObject("lyliaGIF.Image")));
            this.lyliaGIF.Location = new System.Drawing.Point(496, 278);
            this.lyliaGIF.Name = "lyliaGIF";
            this.lyliaGIF.Size = new System.Drawing.Size(203, 165);
            this.lyliaGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lyliaGIF.TabIndex = 12;
            this.lyliaGIF.TabStop = false;
            // 
            // confettiGIF
            // 
            this.confettiGIF.BackColor = System.Drawing.Color.Transparent;
            this.confettiGIF.Image = ((System.Drawing.Image)(resources.GetObject("confettiGIF.Image")));
            this.confettiGIF.Location = new System.Drawing.Point(0, 27);
            this.confettiGIF.Name = "confettiGIF";
            this.confettiGIF.Size = new System.Drawing.Size(671, 396);
            this.confettiGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.confettiGIF.TabIndex = 13;
            this.confettiGIF.TabStop = false;
            // 
            // congratsGIF
            // 
            this.congratsGIF.BackColor = System.Drawing.Color.Transparent;
            this.congratsGIF.Image = ((System.Drawing.Image)(resources.GetObject("congratsGIF.Image")));
            this.congratsGIF.Location = new System.Drawing.Point(32, 100);
            this.congratsGIF.Name = "congratsGIF";
            this.congratsGIF.Size = new System.Drawing.Size(568, 156);
            this.congratsGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.congratsGIF.TabIndex = 14;
            this.congratsGIF.TabStop = false;
            // 
            // cryGIF
            // 
            this.cryGIF.BackColor = System.Drawing.Color.Transparent;
            this.cryGIF.Image = ((System.Drawing.Image)(resources.GetObject("cryGIF.Image")));
            this.cryGIF.Location = new System.Drawing.Point(468, 276);
            this.cryGIF.Name = "cryGIF";
            this.cryGIF.Size = new System.Drawing.Size(247, 152);
            this.cryGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cryGIF.TabIndex = 15;
            this.cryGIF.TabStop = false;
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(145, 260);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(385, 29);
            this.lblWin.TabIndex = 16;
            this.lblWin.Text = "You nailed it! You saved Lylia.";
            // 
            // lblAgain
            // 
            this.lblAgain.AutoSize = true;
            this.lblAgain.BackColor = System.Drawing.Color.Transparent;
            this.lblAgain.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgain.Location = new System.Drawing.Point(164, 289);
            this.lblAgain.Name = "lblAgain";
            this.lblAgain.Size = new System.Drawing.Size(345, 29);
            this.lblAgain.TabIndex = 17;
            this.lblAgain.Text = "Play Again? Click on Menu.";
            // 
            // lblTimeleft
            // 
            this.lblTimeleft.AutoSize = true;
            this.lblTimeleft.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeleft.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeleft.Location = new System.Drawing.Point(12, 395);
            this.lblTimeleft.Name = "lblTimeleft";
            this.lblTimeleft.Size = new System.Drawing.Size(79, 22);
            this.lblTimeleft.TabIndex = 18;
            this.lblTimeleft.Text = "Time left:";
            // 
            // lblScoreval
            // 
            this.lblScoreval.AutoSize = true;
            this.lblScoreval.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreval.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreval.Location = new System.Drawing.Point(99, 395);
            this.lblScoreval.Name = "lblScoreval";
            this.lblScoreval.Size = new System.Drawing.Size(37, 22);
            this.lblScoreval.TabIndex = 20;
            this.lblScoreval.Text = "120";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.BackColor = System.Drawing.Color.Transparent;
            this.lblShow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(242, 333);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(100, 23);
            this.lblShow.TabIndex = 22;
            this.lblShow.Text = "Time left:";
            // 
            // lblShowtimeleft
            // 
            this.lblShowtimeleft.AutoSize = true;
            this.lblShowtimeleft.BackColor = System.Drawing.Color.Transparent;
            this.lblShowtimeleft.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowtimeleft.Location = new System.Drawing.Point(346, 333);
            this.lblShowtimeleft.Name = "lblShowtimeleft";
            this.lblShowtimeleft.Size = new System.Drawing.Size(34, 23);
            this.lblShowtimeleft.TabIndex = 23;
            this.lblShowtimeleft.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(671, 423);
            this.Controls.Add(this.lblShowtimeleft);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.lblAgain);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.congratsGIF);
            this.Controls.Add(this.confettiGIF);
            this.Controls.Add(this.cryGIF);
            this.Controls.Add(this.lyliaGIF);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.guessBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTimeleft);
            this.Controls.Add(this.lblScoreval);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lyliaGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confettiGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congratsGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cryGIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar guessBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playAgainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox lyliaGIF;
        private System.Windows.Forms.PictureBox confettiGIF;
        private System.Windows.Forms.PictureBox congratsGIF;
        private System.Windows.Forms.PictureBox cryGIF;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblAgain;
        private System.Windows.Forms.Label lblTimeleft;
        private System.Windows.Forms.Label lblScoreval;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label lblShowtimeleft;
        private System.Windows.Forms.Timer timer1;
    }
}


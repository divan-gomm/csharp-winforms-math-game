namespace MysticMathsGame__Divan_Gomm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.lblEnemyHP = new System.Windows.Forms.Label();
            this.lblAttackType = new System.Windows.Forms.Label();
            this.btnBasicStrike = new System.Windows.Forms.Button();
            this.btnPrimeStrike = new System.Windows.Forms.Button();
            this.btnModulusStrike = new System.Windows.Forms.Button();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.lbScores = new System.Windows.Forms.ListBox();
            this.pgbEnemyHP = new System.Windows.Forms.ProgressBar();
            this.pgbPlayerHP = new System.Windows.Forms.ProgressBar();
            this.lblScoreheader = new System.Windows.Forms.Label();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.pnlEnemy = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.rtbBattleLog = new System.Windows.Forms.RichTextBox();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Papyrus", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Crimson;
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeader.Location = new System.Drawing.Point(83, 28);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(331, 81);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Mystic Math";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.ForeColor = System.Drawing.Color.White;
            this.lblEnterName.Location = new System.Drawing.Point(3, 132);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(156, 21);
            this.lblEnterName.TabIndex = 1;
            this.lblEnterName.Text = "Enter Player Name:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(166, 132);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(173, 20);
            this.txtPlayerName.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(357, 130);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            this.btnConfirm.Enter += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.Maroon;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(58, 168);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 40);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Papyrus", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(418, 243);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 37);
            this.lblMessage.TabIndex = 5;
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerHP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHP.ForeColor = System.Drawing.Color.Snow;
            this.lblPlayerHP.Location = new System.Drawing.Point(62, 274);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(142, 25);
            this.lblPlayerHP.TabIndex = 6;
            this.lblPlayerHP.Text = "Player HP: 100";
            // 
            // lblEnemyHP
            // 
            this.lblEnemyHP.AutoSize = true;
            this.lblEnemyHP.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyHP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHP.ForeColor = System.Drawing.Color.Snow;
            this.lblEnemyHP.Location = new System.Drawing.Point(680, 274);
            this.lblEnemyHP.Name = "lblEnemyHP";
            this.lblEnemyHP.Size = new System.Drawing.Size(146, 25);
            this.lblEnemyHP.TabIndex = 7;
            this.lblEnemyHP.Text = "Enemy HP: 100";
            // 
            // lblAttackType
            // 
            this.lblAttackType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAttackType.AutoSize = true;
            this.lblAttackType.BackColor = System.Drawing.Color.Transparent;
            this.lblAttackType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAttackType.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttackType.ForeColor = System.Drawing.Color.Snow;
            this.lblAttackType.Location = new System.Drawing.Point(382, 313);
            this.lblAttackType.Name = "lblAttackType";
            this.lblAttackType.Size = new System.Drawing.Size(129, 25);
            this.lblAttackType.TabIndex = 8;
            this.lblAttackType.Text = "Attack Types:";
            // 
            // btnBasicStrike
            // 
            this.btnBasicStrike.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBasicStrike.BackColor = System.Drawing.Color.Maroon;
            this.btnBasicStrike.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasicStrike.ForeColor = System.Drawing.Color.White;
            this.btnBasicStrike.Location = new System.Drawing.Point(376, 356);
            this.btnBasicStrike.Name = "btnBasicStrike";
            this.btnBasicStrike.Size = new System.Drawing.Size(135, 38);
            this.btnBasicStrike.TabIndex = 9;
            this.btnBasicStrike.Text = "Basic Strike";
            this.btnBasicStrike.UseVisualStyleBackColor = false;
            this.btnBasicStrike.Click += new System.EventHandler(this.btnBasicStrike_Click);
            // 
            // btnPrimeStrike
            // 
            this.btnPrimeStrike.BackColor = System.Drawing.Color.Maroon;
            this.btnPrimeStrike.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeStrike.ForeColor = System.Drawing.Color.White;
            this.btnPrimeStrike.Location = new System.Drawing.Point(376, 400);
            this.btnPrimeStrike.Name = "btnPrimeStrike";
            this.btnPrimeStrike.Size = new System.Drawing.Size(135, 38);
            this.btnPrimeStrike.TabIndex = 10;
            this.btnPrimeStrike.Text = "Prime Strike";
            this.btnPrimeStrike.UseVisualStyleBackColor = false;
            this.btnPrimeStrike.Click += new System.EventHandler(this.btnPrimeStrike_Click);
            // 
            // btnModulusStrike
            // 
            this.btnModulusStrike.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModulusStrike.BackColor = System.Drawing.Color.Maroon;
            this.btnModulusStrike.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulusStrike.ForeColor = System.Drawing.Color.White;
            this.btnModulusStrike.Location = new System.Drawing.Point(376, 444);
            this.btnModulusStrike.Name = "btnModulusStrike";
            this.btnModulusStrike.Size = new System.Drawing.Size(135, 38);
            this.btnModulusStrike.TabIndex = 11;
            this.btnModulusStrike.Text = "Modulus Strike";
            this.btnModulusStrike.UseVisualStyleBackColor = false;
            this.btnModulusStrike.Click += new System.EventHandler(this.btnModulusStrike_Click);
            // 
            // btnClearScores
            // 
            this.btnClearScores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearScores.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClearScores.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearScores.Location = new System.Drawing.Point(760, 172);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(96, 23);
            this.btnClearScores.TabIndex = 17;
            this.btnClearScores.Text = "Clear Scores";
            this.btnClearScores.UseVisualStyleBackColor = false;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // lbScores
            // 
            this.lbScores.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lbScores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbScores.BackColor = System.Drawing.Color.LightSlateGray;
            this.lbScores.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScores.ForeColor = System.Drawing.Color.White;
            this.lbScores.FormattingEnabled = true;
            this.lbScores.Location = new System.Drawing.Point(746, 45);
            this.lbScores.Name = "lbScores";
            this.lbScores.Size = new System.Drawing.Size(128, 121);
            this.lbScores.TabIndex = 16;
            // 
            // pgbEnemyHP
            // 
            this.pgbEnemyHP.BackColor = System.Drawing.Color.Red;
            this.pgbEnemyHP.Location = new System.Drawing.Point(685, 302);
            this.pgbEnemyHP.Maximum = 120;
            this.pgbEnemyHP.Name = "pgbEnemyHP";
            this.pgbEnemyHP.Size = new System.Drawing.Size(130, 23);
            this.pgbEnemyHP.TabIndex = 15;
            // 
            // pgbPlayerHP
            // 
            this.pgbPlayerHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pgbPlayerHP.Location = new System.Drawing.Point(67, 302);
            this.pgbPlayerHP.Name = "pgbPlayerHP";
            this.pgbPlayerHP.Size = new System.Drawing.Size(130, 23);
            this.pgbPlayerHP.TabIndex = 14;
            // 
            // lblScoreheader
            // 
            this.lblScoreheader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScoreheader.AutoSize = true;
            this.lblScoreheader.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreheader.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreheader.ForeColor = System.Drawing.Color.Snow;
            this.lblScoreheader.Location = new System.Drawing.Point(741, 17);
            this.lblScoreheader.Name = "lblScoreheader";
            this.lblScoreheader.Size = new System.Drawing.Size(133, 25);
            this.lblScoreheader.TabIndex = 18;
            this.lblScoreheader.Text = "SCOREBOARD";
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayer.BackgroundImage = global::MysticMathsGame__Divan_Gomm.Properties.Resources.FireMage11;
            this.pnlPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPlayer.Location = new System.Drawing.Point(12, 340);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(250, 260);
            this.pnlPlayer.TabIndex = 19;
            // 
            // pnlEnemy
            // 
            this.pnlEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pnlEnemy.BackgroundImage = global::MysticMathsGame__Divan_Gomm.Properties.Resources.Goblin_1;
            this.pnlEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlEnemy.Location = new System.Drawing.Point(624, 340);
            this.pnlEnemy.Name = "pnlEnemy";
            this.pnlEnemy.Size = new System.Drawing.Size(250, 260);
            this.pnlEnemy.TabIndex = 20;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCenter.BackColor = System.Drawing.Color.Transparent;
            this.pnlCenter.Controls.Add(this.btnQuit);
            this.pnlCenter.Controls.Add(this.btnStart);
            this.pnlCenter.Controls.Add(this.lblHeader);
            this.pnlCenter.Controls.Add(this.txtPlayerName);
            this.pnlCenter.Controls.Add(this.lblEnterName);
            this.pnlCenter.Controls.Add(this.btnConfirm);
            this.pnlCenter.Location = new System.Drawing.Point(196, -3);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(474, 218);
            this.pnlCenter.TabIndex = 22;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Maroon;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(294, 168);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(120, 40);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // rtbBattleLog
            // 
            this.rtbBattleLog.BackColor = System.Drawing.Color.LightSlateGray;
            this.rtbBattleLog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBattleLog.ForeColor = System.Drawing.Color.DarkRed;
            this.rtbBattleLog.Location = new System.Drawing.Point(297, 512);
            this.rtbBattleLog.Name = "rtbBattleLog";
            this.rtbBattleLog.ReadOnly = true;
            this.rtbBattleLog.Size = new System.Drawing.Size(283, 78);
            this.rtbBattleLog.TabIndex = 16;
            this.rtbBattleLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MysticMathsGame__Divan_Gomm.Properties.Resources.backgrnd_Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 612);
            this.Controls.Add(this.lblAttackType);
            this.Controls.Add(this.btnBasicStrike);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnModulusStrike);
            this.Controls.Add(this.rtbBattleLog);
            this.Controls.Add(this.btnPrimeStrike);
            this.Controls.Add(this.pgbPlayerHP);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.lblPlayerHP);
            this.Controls.Add(this.pgbEnemyHP);
            this.Controls.Add(this.lblEnemyHP);
            this.Controls.Add(this.pnlEnemy);
            this.Controls.Add(this.pnlPlayer);
            this.Controls.Add(this.lblScoreheader);
            this.Controls.Add(this.lbScores);
            this.Controls.Add(this.btnClearScores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mystic Math Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Label lblEnemyHP;
        private System.Windows.Forms.Label lblAttackType;
        private System.Windows.Forms.Button btnBasicStrike;
        private System.Windows.Forms.Button btnPrimeStrike;
        private System.Windows.Forms.Button btnModulusStrike;
        private System.Windows.Forms.ProgressBar pgbEnemyHP;
        private System.Windows.Forms.ProgressBar pgbPlayerHP;
        private System.Windows.Forms.ListBox lbScores;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Label lblScoreheader;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Panel pnlEnemy;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.RichTextBox rtbBattleLog;
        private System.Windows.Forms.Button btnQuit;
    }
}


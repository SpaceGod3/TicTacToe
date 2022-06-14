namespace TicTacToe {
    partial class FTicTacToe {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panelControls = new System.Windows.Forms.Panel();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.groupBoxScore = new System.Windows.Forms.GroupBox();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2Score = new System.Windows.Forms.Label();
            this.labelPlayer1Score = new System.Windows.Forms.Label();
            this.labelTimeValue = new System.Windows.Forms.Label();
            this.labelPlayerNumber = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelSessionNumber = new System.Windows.Forms.Label();
            this.labelSession = new System.Windows.Forms.Label();
            this.tableLayoutPanelField = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelControls.SuspendLayout();
            this.groupBoxScore.SuspendLayout();
            this.tableLayoutPanelField.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelControls.Controls.Add(this.buttonContinue);
            this.panelControls.Controls.Add(this.buttonNewGame);
            this.panelControls.Controls.Add(this.groupBoxScore);
            this.panelControls.Controls.Add(this.labelTimeValue);
            this.panelControls.Controls.Add(this.labelPlayerNumber);
            this.panelControls.Controls.Add(this.labelTime);
            this.panelControls.Controls.Add(this.labelPlayer);
            this.panelControls.Controls.Add(this.labelSessionNumber);
            this.panelControls.Controls.Add(this.labelSession);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControls.Location = new System.Drawing.Point(334, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(231, 339);
            this.panelControls.TabIndex = 0;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContinue.Location = new System.Drawing.Point(62, 250);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(134, 28);
            this.buttonContinue.TabIndex = 2;
            this.buttonContinue.Text = "Продовжити";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewGame.Location = new System.Drawing.Point(62, 284);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(134, 28);
            this.buttonNewGame.TabIndex = 2;
            this.buttonNewGame.Text = "Нова гра";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            // 
            // groupBoxScore
            // 
            this.groupBoxScore.Controls.Add(this.labelPlayer2);
            this.groupBoxScore.Controls.Add(this.labelPlayer1);
            this.groupBoxScore.Controls.Add(this.labelPlayer2Score);
            this.groupBoxScore.Controls.Add(this.labelPlayer1Score);
            this.groupBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxScore.Location = new System.Drawing.Point(26, 86);
            this.groupBoxScore.Name = "groupBoxScore";
            this.groupBoxScore.Size = new System.Drawing.Size(187, 95);
            this.groupBoxScore.TabIndex = 1;
            this.groupBoxScore.TabStop = false;
            this.groupBoxScore.Text = "Рахунок";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer2.Location = new System.Drawing.Point(19, 61);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(89, 20);
            this.labelPlayer2.TabIndex = 0;
            this.labelPlayer2.Text = "Гравець 2:";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer1.Location = new System.Drawing.Point(19, 31);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(89, 20);
            this.labelPlayer1.TabIndex = 0;
            this.labelPlayer1.Text = "Гравець 1:";
            // 
            // labelPlayer2Score
            // 
            this.labelPlayer2Score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer2Score.Location = new System.Drawing.Point(122, 61);
            this.labelPlayer2Score.Name = "labelPlayer2Score";
            this.labelPlayer2Score.Size = new System.Drawing.Size(48, 20);
            this.labelPlayer2Score.TabIndex = 0;
            // 
            // labelPlayer1Score
            // 
            this.labelPlayer1Score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer1Score.Location = new System.Drawing.Point(122, 31);
            this.labelPlayer1Score.Name = "labelPlayer1Score";
            this.labelPlayer1Score.Size = new System.Drawing.Size(48, 20);
            this.labelPlayer1Score.TabIndex = 0;
            // 
            // labelTimeValue
            // 
            this.labelTimeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeValue.Location = new System.Drawing.Point(131, 197);
            this.labelTimeValue.Name = "labelTimeValue";
            this.labelTimeValue.Size = new System.Drawing.Size(65, 20);
            this.labelTimeValue.TabIndex = 0;
            this.labelTimeValue.Text = "00:00";
            // 
            // labelPlayerNumber
            // 
            this.labelPlayerNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPlayerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayerNumber.Location = new System.Drawing.Point(131, 51);
            this.labelPlayerNumber.Name = "labelPlayerNumber";
            this.labelPlayerNumber.Size = new System.Drawing.Size(65, 20);
            this.labelPlayerNumber.TabIndex = 0;
            this.labelPlayerNumber.Text = "1 (X)";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(22, 201);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(46, 20);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Час:";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer.Location = new System.Drawing.Point(22, 51);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(84, 20);
            this.labelPlayer.TabIndex = 0;
            this.labelPlayer.Text = "Гравець:";
            // 
            // labelSessionNumber
            // 
            this.labelSessionNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSessionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSessionNumber.Location = new System.Drawing.Point(131, 27);
            this.labelSessionNumber.Name = "labelSessionNumber";
            this.labelSessionNumber.Size = new System.Drawing.Size(65, 20);
            this.labelSessionNumber.TabIndex = 0;
            // 
            // labelSession
            // 
            this.labelSession.AutoSize = true;
            this.labelSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSession.Location = new System.Drawing.Point(22, 27);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(65, 20);
            this.labelSession.TabIndex = 0;
            this.labelSession.Text = "Сеанс:";
            // 
            // tableLayoutPanelField
            // 
            this.tableLayoutPanelField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(224)))));
            this.tableLayoutPanelField.ColumnCount = 3;
            this.tableLayoutPanelField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelField.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelField.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanelField.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanelField.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanelField.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanelField.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanelField.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanelField.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanelField.Controls.Add(this.label9, 2, 2);
            this.tableLayoutPanelField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelField.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelField.Name = "tableLayoutPanelField";
            this.tableLayoutPanelField.RowCount = 3;
            this.tableLayoutPanelField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelField.Size = new System.Drawing.Size(334, 339);
            this.tableLayoutPanelField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.labelCell_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(114, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 107);
            this.label2.TabIndex = 0;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.labelCell_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(225, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 107);
            this.label3.TabIndex = 0;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.labelCell_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 107);
            this.label4.TabIndex = 0;
            this.label4.Text = "X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.labelCell_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(114, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 107);
            this.label5.TabIndex = 0;
            this.label5.Text = "X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.labelCell_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(225, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 107);
            this.label6.TabIndex = 0;
            this.label6.Text = "X";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.labelCell_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 107);
            this.label7.TabIndex = 0;
            this.label7.Text = "X";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.labelCell_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(114, 229);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 107);
            this.label8.TabIndex = 0;
            this.label8.Text = "X";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.labelCell_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(225, 229);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 107);
            this.label9.TabIndex = 0;
            this.label9.Text = "X";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.labelCell_Click);
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // FTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 339);
            this.Controls.Add(this.tableLayoutPanelField);
            this.Controls.Add(this.panelControls);
            this.Name = "FTicTacToe";
            this.Text = "Хрестики-нулики";
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.groupBoxScore.ResumeLayout(false);
            this.groupBoxScore.PerformLayout();
            this.tableLayoutPanelField.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxScore;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2Score;
        private System.Windows.Forms.Label labelPlayer1Score;
        private System.Windows.Forms.Label labelTimeValue;
        private System.Windows.Forms.Label labelPlayerNumber;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelSessionNumber;
        private System.Windows.Forms.Label labelSession;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Button buttonContinue;
    }
}


namespace MarksmanshipTracker
{
    partial class MainForm
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
      this.btnExit = new System.Windows.Forms.Button();
      this.btnPeople = new System.Windows.Forms.Button();
      this.btnShips = new System.Windows.Forms.Button();
      this.btnGames = new System.Windows.Forms.Button();
      this.btnSessions = new System.Windows.Forms.Button();
      this.btnReports = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnExit
      // 
      this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExit.Location = new System.Drawing.Point(15, 186);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(945, 60);
      this.btnExit.TabIndex = 0;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // btnPeople
      // 
      this.btnPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPeople.Location = new System.Drawing.Point(15, 17);
      this.btnPeople.Name = "btnPeople";
      this.btnPeople.Size = new System.Drawing.Size(340, 60);
      this.btnPeople.TabIndex = 1;
      this.btnPeople.Text = "People";
      this.btnPeople.UseVisualStyleBackColor = true;
      this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
      // 
      // btnShips
      // 
      this.btnShips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnShips.Location = new System.Drawing.Point(370, 17);
      this.btnShips.Name = "btnShips";
      this.btnShips.Size = new System.Drawing.Size(275, 60);
      this.btnShips.TabIndex = 2;
      this.btnShips.Text = "Ships";
      this.btnShips.UseVisualStyleBackColor = true;
      this.btnShips.Click += new System.EventHandler(this.btnShips_Click);
      // 
      // btnGames
      // 
      this.btnGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGames.Location = new System.Drawing.Point(672, 17);
      this.btnGames.Name = "btnGames";
      this.btnGames.Size = new System.Drawing.Size(288, 60);
      this.btnGames.TabIndex = 3;
      this.btnGames.Text = "Games";
      this.btnGames.UseVisualStyleBackColor = true;
      this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
      // 
      // btnSessions
      // 
      this.btnSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSessions.Location = new System.Drawing.Point(15, 97);
      this.btnSessions.Name = "btnSessions";
      this.btnSessions.Size = new System.Drawing.Size(443, 60);
      this.btnSessions.TabIndex = 4;
      this.btnSessions.Text = "Sessions";
      this.btnSessions.UseVisualStyleBackColor = true;
      this.btnSessions.Click += new System.EventHandler(this.btnSessions_Click);
      // 
      // btnReports
      // 
      this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnReports.Location = new System.Drawing.Point(481, 101);
      this.btnReports.Name = "btnReports";
      this.btnReports.Size = new System.Drawing.Size(479, 56);
      this.btnReports.TabIndex = 5;
      this.btnReports.Text = "Reports";
      this.btnReports.UseVisualStyleBackColor = true;
      this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(977, 261);
      this.Controls.Add(this.btnReports);
      this.Controls.Add(this.btnSessions);
      this.Controls.Add(this.btnGames);
      this.Controls.Add(this.btnShips);
      this.Controls.Add(this.btnPeople);
      this.Controls.Add(this.btnExit);
      this.Name = "MainForm";
      this.Text = "Marksmanship Tracker";
      this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button btnPeople;
    private System.Windows.Forms.Button btnShips;
    private System.Windows.Forms.Button btnGames;
    private System.Windows.Forms.Button btnSessions;
    private System.Windows.Forms.Button btnReports;
  }
}


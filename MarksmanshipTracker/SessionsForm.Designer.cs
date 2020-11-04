namespace MarksmanshipTracker
{
  partial class SessionsForm
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.dpSessionDate = new System.Windows.Forms.DateTimePicker();
      this.cboGame = new System.Windows.Forms.ComboBox();
      this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cboTrmnPlayer = new System.Windows.Forms.ComboBox();
      this.bindingSourceTRMNPerson = new System.Windows.Forms.BindingSource(this.components);
      this.txtMinutes = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.btnAddPlayer = new System.Windows.Forms.Button();
      this.btnSaveNew = new System.Windows.Forms.Button();
      this.btnRemove = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.dgvPlayers = new System.Windows.Forms.DataGridView();
      this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SessionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Minutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.trmnPlayerBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.btnImportLog = new System.Windows.Forms.Button();
      this.fsImportFile = new System.Windows.Forms.OpenFileDialog();
      this.btnEdit = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTRMNPerson)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trmnPlayerBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(12, 355);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(130, 40);
      this.btnSave.TabIndex = 0;
      this.btnSave.Text = "Save and Close";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(328, 355);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(130, 40);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Close/Cancel";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // dpSessionDate
      // 
      this.dpSessionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dpSessionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dpSessionDate.Location = new System.Drawing.Point(100, 26);
      this.dpSessionDate.Name = "dpSessionDate";
      this.dpSessionDate.Size = new System.Drawing.Size(107, 26);
      this.dpSessionDate.TabIndex = 2;
      // 
      // cboGame
      // 
      this.cboGame.DataSource = this.gameBindingSource;
      this.cboGame.DisplayMember = "GameName";
      this.cboGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cboGame.FormattingEnabled = true;
      this.cboGame.Location = new System.Drawing.Point(255, 25);
      this.cboGame.Name = "cboGame";
      this.cboGame.Size = new System.Drawing.Size(173, 28);
      this.cboGame.TabIndex = 3;
      this.cboGame.ValueMember = "Id";
      // 
      // gameBindingSource
      // 
      this.gameBindingSource.DataSource = typeof(MarksmanshipTracker.Game);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(98, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Session Date";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(252, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(70, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Game Played";
      // 
      // cboTrmnPlayer
      // 
      this.cboTrmnPlayer.DataSource = this.bindingSourceTRMNPerson;
      this.cboTrmnPlayer.DisplayMember = "Name";
      this.cboTrmnPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cboTrmnPlayer.FormattingEnabled = true;
      this.cboTrmnPlayer.Location = new System.Drawing.Point(100, 87);
      this.cboTrmnPlayer.Name = "cboTrmnPlayer";
      this.cboTrmnPlayer.Size = new System.Drawing.Size(185, 28);
      this.cboTrmnPlayer.TabIndex = 6;
      this.cboTrmnPlayer.ValueMember = "Id";
      this.cboTrmnPlayer.SelectedValueChanged += new System.EventHandler(this.cboTrmnPlayer_SelectedValueChanged);
      // 
      // bindingSourceTRMNPerson
      // 
      this.bindingSourceTRMNPerson.AllowNew = false;
      this.bindingSourceTRMNPerson.DataSource = typeof(MarksmanshipTracker.TrmnPerson);
      // 
      // txtMinutes
      // 
      this.txtMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMinutes.Location = new System.Drawing.Point(328, 89);
      this.txtMinutes.Name = "txtMinutes";
      this.txtMinutes.Size = new System.Drawing.Size(100, 26);
      this.txtMinutes.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(97, 71);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(71, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "TRMN Player";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(325, 71);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(44, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Minutes";
      // 
      // btnAddPlayer
      // 
      this.btnAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddPlayer.Location = new System.Drawing.Point(497, 130);
      this.btnAddPlayer.Name = "btnAddPlayer";
      this.btnAddPlayer.Size = new System.Drawing.Size(115, 36);
      this.btnAddPlayer.TabIndex = 12;
      this.btnAddPlayer.Text = "Add Player";
      this.btnAddPlayer.UseVisualStyleBackColor = true;
      this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
      // 
      // btnSaveNew
      // 
      this.btnSaveNew.Location = new System.Drawing.Point(168, 355);
      this.btnSaveNew.Name = "btnSaveNew";
      this.btnSaveNew.Size = new System.Drawing.Size(130, 40);
      this.btnSaveNew.TabIndex = 14;
      this.btnSaveNew.Text = "Save and Add Another";
      this.btnSaveNew.UseVisualStyleBackColor = true;
      this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
      // 
      // btnRemove
      // 
      this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRemove.Location = new System.Drawing.Point(497, 172);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(138, 36);
      this.btnRemove.TabIndex = 15;
      this.btnRemove.Text = "Remove Player";
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // btnClear
      // 
      this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClear.Location = new System.Drawing.Point(497, 214);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(91, 36);
      this.btnClear.TabIndex = 16;
      this.btnClear.Text = "Clear List";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // dgvPlayers
      // 
      this.dgvPlayers.AllowUserToAddRows = false;
      this.dgvPlayers.AutoGenerateColumns = false;
      this.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonName,
            this.PersonId,
            this.SessionId,
            this.Minutes});
      this.dgvPlayers.DataSource = this.trmnPlayerBindingSource;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvPlayers.DefaultCellStyle = dataGridViewCellStyle1;
      this.dgvPlayers.Location = new System.Drawing.Point(12, 130);
      this.dgvPlayers.Name = "dgvPlayers";
      this.dgvPlayers.Size = new System.Drawing.Size(479, 219);
      this.dgvPlayers.TabIndex = 17;
      // 
      // PersonName
      // 
      this.PersonName.DataPropertyName = "Name";
      this.PersonName.HeaderText = "Name";
      this.PersonName.Name = "PersonName";
      // 
      // PersonId
      // 
      this.PersonId.DataPropertyName = "PersonId";
      this.PersonId.HeaderText = "PersonId";
      this.PersonId.Name = "PersonId";
      this.PersonId.Visible = false;
      // 
      // SessionId
      // 
      this.SessionId.DataPropertyName = "SessionId";
      this.SessionId.HeaderText = "SessionId";
      this.SessionId.Name = "SessionId";
      this.SessionId.Visible = false;
      // 
      // Minutes
      // 
      this.Minutes.DataPropertyName = "Minutes";
      this.Minutes.HeaderText = "Minutes";
      this.Minutes.Name = "Minutes";
      // 
      // trmnPlayerBindingSource
      // 
      this.trmnPlayerBindingSource.DataSource = typeof(MarksmanshipTracker.TrmnPlayer);
      // 
      // btnImportLog
      // 
      this.btnImportLog.Location = new System.Drawing.Point(487, 355);
      this.btnImportLog.Name = "btnImportLog";
      this.btnImportLog.Size = new System.Drawing.Size(134, 40);
      this.btnImportLog.TabIndex = 18;
      this.btnImportLog.Text = "Import Session Log";
      this.btnImportLog.UseVisualStyleBackColor = true;
      this.btnImportLog.Click += new System.EventHandler(this.btnImportLog_Click);
      // 
      // fsImportFile
      // 
      this.fsImportFile.Filter = "CSV files|*.csv";
      // 
      // btnEdit
      // 
      this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEdit.Location = new System.Drawing.Point(501, 21);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(110, 32);
      this.btnEdit.TabIndex = 19;
      this.btnEdit.Text = "Edit Session";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // SessionsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(649, 402);
      this.Controls.Add(this.btnEdit);
      this.Controls.Add(this.btnImportLog);
      this.Controls.Add(this.dgvPlayers);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnRemove);
      this.Controls.Add(this.btnSaveNew);
      this.Controls.Add(this.btnAddPlayer);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtMinutes);
      this.Controls.Add(this.cboTrmnPlayer);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cboGame);
      this.Controls.Add(this.dpSessionDate);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnSave);
      this.Name = "SessionsForm";
      this.Text = "SessionsForm";
      this.Load += new System.EventHandler(this.SessionsForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTRMNPerson)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trmnPlayerBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.DateTimePicker dpSessionDate;
    private System.Windows.Forms.ComboBox cboGame;
    private System.Windows.Forms.BindingSource gameBindingSource;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cboTrmnPlayer;
    private System.Windows.Forms.TextBox txtMinutes;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnAddPlayer;
    private System.Windows.Forms.BindingSource bindingSourceTRMNPerson;
    private System.Windows.Forms.Button btnSaveNew;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.DataGridView dgvPlayers;
    private System.Windows.Forms.BindingSource trmnPlayerBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
    private System.Windows.Forms.DataGridViewTextBoxColumn PersonId;
    private System.Windows.Forms.DataGridViewTextBoxColumn SessionId;
    private System.Windows.Forms.DataGridViewTextBoxColumn Minutes;
    private System.Windows.Forms.Button btnImportLog;
    private System.Windows.Forms.OpenFileDialog fsImportFile;
    private System.Windows.Forms.Button btnEdit;
  }
}
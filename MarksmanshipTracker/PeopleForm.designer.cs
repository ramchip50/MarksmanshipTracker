namespace MarksmanshipTracker
{
  partial class PeopleForm
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
      this.btnClose = new System.Windows.Forms.Button();
      this.dgvPeople = new System.Windows.Forms.DataGridView();
      this.rMNIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cboBranchDGV = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.cboShipDGV = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.shipsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.cboRankDGV = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.ranksBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.btnSave = new System.Windows.Forms.Button();
      this.btnImport = new System.Windows.Forms.Button();
      this.fsImportFile = new System.Windows.Forms.OpenFileDialog();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.shipsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ranksBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(746, 482);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(130, 40);
      this.btnClose.TabIndex = 0;
      this.btnClose.Text = "Cancel/Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // dgvPeople
      // 
      this.dgvPeople.AutoGenerateColumns = false;
      this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rMNIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.cboBranchDGV,
            this.cboShipDGV,
            this.cboRankDGV});
      this.dgvPeople.DataSource = this.peopleBindingSource;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvPeople.DefaultCellStyle = dataGridViewCellStyle1;
      this.dgvPeople.Location = new System.Drawing.Point(12, 3);
      this.dgvPeople.Name = "dgvPeople";
      this.dgvPeople.Size = new System.Drawing.Size(864, 470);
      this.dgvPeople.TabIndex = 4;
      this.dgvPeople.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPeople_DataError);
      this.dgvPeople.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvPeople_EditingControlShowing);
      // 
      // rMNIdDataGridViewTextBoxColumn
      // 
      this.rMNIdDataGridViewTextBoxColumn.DataPropertyName = "RMNId";
      this.rMNIdDataGridViewTextBoxColumn.HeaderText = "RMNId";
      this.rMNIdDataGridViewTextBoxColumn.Name = "rMNIdDataGridViewTextBoxColumn";
      // 
      // firstNameDataGridViewTextBoxColumn
      // 
      this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
      this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
      this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
      // 
      // lastNameDataGridViewTextBoxColumn
      // 
      this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
      this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
      this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
      // 
      // cboBranchDGV
      // 
      this.cboBranchDGV.DataPropertyName = "BranchId";
      this.cboBranchDGV.DataSource = this.branchesBindingSource;
      this.cboBranchDGV.DisplayMember = "BranchName";
      this.cboBranchDGV.HeaderText = "Branch";
      this.cboBranchDGV.Name = "cboBranchDGV";
      this.cboBranchDGV.ValueMember = "Id";
      // 
      // branchesBindingSource
      // 
      this.branchesBindingSource.DataSource = typeof(MarksmanshipTracker.Branch);
      // 
      // cboShipDGV
      // 
      this.cboShipDGV.DataPropertyName = "ShipId";
      this.cboShipDGV.DataSource = this.shipsBindingSource;
      this.cboShipDGV.DisplayMember = "ShipName";
      this.cboShipDGV.HeaderText = "Ship";
      this.cboShipDGV.Name = "cboShipDGV";
      this.cboShipDGV.ValueMember = "Id";
      // 
      // shipsBindingSource
      // 
      this.shipsBindingSource.DataSource = typeof(MarksmanshipTracker.Ship);
      // 
      // cboRankDGV
      // 
      this.cboRankDGV.DataPropertyName = "RankId";
      this.cboRankDGV.DataSource = this.ranksBindingSource;
      this.cboRankDGV.DisplayMember = "RankName";
      this.cboRankDGV.HeaderText = "Rank";
      this.cboRankDGV.Name = "cboRankDGV";
      this.cboRankDGV.ValueMember = "Id";
      // 
      // ranksBindingSource
      // 
      this.ranksBindingSource.DataSource = typeof(MarksmanshipTracker.Rank);
      // 
      // peopleBindingSource
      // 
      this.peopleBindingSource.DataSource = typeof(MarksmanshipTracker.Person);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(11, 482);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(130, 40);
      this.btnSave.TabIndex = 5;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnImport
      // 
      this.btnImport.Location = new System.Drawing.Point(215, 483);
      this.btnImport.Name = "btnImport";
      this.btnImport.Size = new System.Drawing.Size(124, 38);
      this.btnImport.TabIndex = 6;
      this.btnImport.Text = "Import People";
      this.btnImport.UseVisualStyleBackColor = true;
      this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
      // 
      // fsImportFile
      // 
      this.fsImportFile.Filter = "CSV files|*.csv";
      // 
      // PeopleForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(888, 536);
      this.Controls.Add(this.btnImport);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.dgvPeople);
      this.Controls.Add(this.btnClose);
      this.Name = "PeopleForm";
      this.Text = "PeopleForm";
      this.Load += new System.EventHandler(this.PeopleForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.shipsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ranksBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.DataGridView dgvPeople;
    private System.Windows.Forms.BindingSource branchesBindingSource;
    private System.Windows.Forms.BindingSource shipsBindingSource;
    private System.Windows.Forms.BindingSource peopleBindingSource;
    private System.Windows.Forms.BindingSource ranksBindingSource;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.DataGridViewTextBoxColumn rMNIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewComboBoxColumn cboBranchDGV;
    private System.Windows.Forms.DataGridViewComboBoxColumn cboShipDGV;
    private System.Windows.Forms.DataGridViewComboBoxColumn cboRankDGV;
    private System.Windows.Forms.Button btnImport;
    private System.Windows.Forms.OpenFileDialog fsImportFile;
  }
}
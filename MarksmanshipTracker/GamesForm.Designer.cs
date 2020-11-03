namespace MarksmanshipTracker
{
  partial class GamesForm
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gameNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.RMNWeapon = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.RMAWeapon = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.btnClose = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnSave.Location = new System.Drawing.Point(33, 307);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(130, 40);
      this.btnSave.TabIndex = 0;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.gameNameDataGridViewTextBoxColumn,
            this.RMNWeapon,
            this.RMAWeapon});
      this.dataGridView1.DataSource = this.gamesBindingSource;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView1.Location = new System.Drawing.Point(3, 1);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(612, 300);
      this.dataGridView1.TabIndex = 1;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      this.idDataGridViewTextBoxColumn.Visible = false;
      // 
      // gameNameDataGridViewTextBoxColumn
      // 
      this.gameNameDataGridViewTextBoxColumn.DataPropertyName = "GameName";
      this.gameNameDataGridViewTextBoxColumn.HeaderText = "GameName";
      this.gameNameDataGridViewTextBoxColumn.Name = "gameNameDataGridViewTextBoxColumn";
      // 
      // RMNWeapon
      // 
      this.RMNWeapon.DataPropertyName = "RMNWeapon";
      this.RMNWeapon.HeaderText = "RMNWeapon";
      this.RMNWeapon.Name = "RMNWeapon";
      // 
      // RMAWeapon
      // 
      this.RMAWeapon.DataPropertyName = "RMAWeapon";
      this.RMAWeapon.HeaderText = "RMAWeapon";
      this.RMAWeapon.Name = "RMAWeapon";
      // 
      // gamesBindingSource
      // 
      this.gamesBindingSource.DataSource = typeof(MarksmanshipTracker.Game);
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.Location = new System.Drawing.Point(443, 307);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(130, 40);
      this.btnClose.TabIndex = 2;
      this.btnClose.Text = "Close/Cancel";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // GamesForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(614, 355);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.btnSave);
      this.Name = "GamesForm";
      this.Text = "GamesForm";
      this.Load += new System.EventHandler(this.GamesForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.BindingSource gamesBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn gameNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn RMNWeapon;
    private System.Windows.Forms.DataGridViewTextBoxColumn RMAWeapon;
    private System.Windows.Forms.Button btnClose;
  }
}
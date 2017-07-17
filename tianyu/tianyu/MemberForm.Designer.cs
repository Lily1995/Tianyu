namespace tianyu
{
    partial class MemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvMemberInformation = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.冻结ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解冻ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.labChoice = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInformation)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(386, 67);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvMemberInformation
            // 
            this.dgvMemberInformation.AllowUserToAddRows = false;
            this.dgvMemberInformation.AllowUserToResizeColumns = false;
            this.dgvMemberInformation.AllowUserToResizeRows = false;
            this.dgvMemberInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberInformation.BackgroundColor = System.Drawing.Color.White;
            this.dgvMemberInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberInformation.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvMemberInformation.Location = new System.Drawing.Point(16, 111);
            this.dgvMemberInformation.Name = "dgvMemberInformation";
            this.dgvMemberInformation.ReadOnly = true;
            this.dgvMemberInformation.RowHeadersVisible = false;
            this.dgvMemberInformation.RowTemplate.Height = 23;
            this.dgvMemberInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberInformation.Size = new System.Drawing.Size(561, 208);
            this.dgvMemberInformation.TabIndex = 21;
            this.dgvMemberInformation.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberInformation_CellMouseLeave);
            this.dgvMemberInformation.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMemberInformation_CellMouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.冻结ToolStripMenuItem,
            this.解冻ToolStripMenuItem,
            this.tsmiDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // 冻结ToolStripMenuItem
            // 
            this.冻结ToolStripMenuItem.Name = "冻结ToolStripMenuItem";
            this.冻结ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.冻结ToolStripMenuItem.Text = "冻结";
            this.冻结ToolStripMenuItem.Click += new System.EventHandler(this.冻结ToolStripMenuItem_Click);
            // 
            // 解冻ToolStripMenuItem
            // 
            this.解冻ToolStripMenuItem.Name = "解冻ToolStripMenuItem";
            this.解冻ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.解冻ToolStripMenuItem.Text = "解冻";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(100, 22);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // labChoice
            // 
            this.labChoice.AutoSize = true;
            this.labChoice.BackColor = System.Drawing.Color.Transparent;
            this.labChoice.ForeColor = System.Drawing.Color.Black;
            this.labChoice.Location = new System.Drawing.Point(70, 50);
            this.labChoice.Name = "labChoice";
            this.labChoice.Size = new System.Drawing.Size(101, 12);
            this.labChoice.TabIndex = 17;
            this.labChoice.Text = "请选择会员类型：";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(305, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(386, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cboStyle
            // 
            this.cboStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Location = new System.Drawing.Point(171, 46);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(116, 20);
            this.cboStyle.TabIndex = 20;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(305, 67);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "退出界面";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(592, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvMemberInformation);
            this.Controls.Add(this.labChoice);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cboStyle);
            this.Controls.Add(this.btnRegister);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询会员信息";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInformation)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvMemberInformation;
        private System.Windows.Forms.Label labChoice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 冻结ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解冻ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.Button button1;
    }
}
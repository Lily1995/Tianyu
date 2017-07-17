namespace tianyu
{
    partial class SelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labchoice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改影片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订票 = new System.Windows.Forms.Button();
            this.dgvSerch = new System.Windows.Forms.DataGridView();
            this.刷新 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerch)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(159, 44);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(124, 21);
            this.dateTimePicker.TabIndex = 13;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // labchoice
            // 
            this.labchoice.AutoSize = true;
            this.labchoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labchoice.Location = new System.Drawing.Point(76, 48);
            this.labchoice.Name = "labchoice";
            this.labchoice.Size = new System.Drawing.Size(77, 12);
            this.labchoice.TabIndex = 12;
            this.labchoice.Text = "按日期查询：";
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(306, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改影片ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.订票ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // 修改影片ToolStripMenuItem
            // 
            this.修改影片ToolStripMenuItem.Name = "修改影片ToolStripMenuItem";
            this.修改影片ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改影片ToolStripMenuItem.Text = "修改影片";
            this.修改影片ToolStripMenuItem.Click += new System.EventHandler(this.修改影片ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 订票ToolStripMenuItem
            // 
            this.订票ToolStripMenuItem.Name = "订票ToolStripMenuItem";
            this.订票ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.订票ToolStripMenuItem.Text = "订票";
            this.订票ToolStripMenuItem.Click += new System.EventHandler(this.订票ToolStripMenuItem_Click);
            // 
            // 订票
            // 
            this.订票.Location = new System.Drawing.Point(495, 44);
            this.订票.Name = "订票";
            this.订票.Size = new System.Drawing.Size(75, 23);
            this.订票.TabIndex = 31;
            this.订票.Text = "订票";
            this.订票.UseVisualStyleBackColor = true;
            this.订票.Click += new System.EventHandler(this.订票_Click);
            // 
            // dgvSerch
            // 
            this.dgvSerch.AllowUserToAddRows = false;
            this.dgvSerch.AllowUserToDeleteRows = false;
            this.dgvSerch.AllowUserToResizeColumns = false;
            this.dgvSerch.AllowUserToResizeRows = false;
            this.dgvSerch.BackgroundColor = System.Drawing.Color.White;
            this.dgvSerch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSerch.Location = new System.Drawing.Point(34, 87);
            this.dgvSerch.MultiSelect = false;
            this.dgvSerch.Name = "dgvSerch";
            this.dgvSerch.ReadOnly = true;
            this.dgvSerch.RowTemplate.Height = 23;
            this.dgvSerch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSerch.Size = new System.Drawing.Size(677, 238);
            this.dgvSerch.TabIndex = 10;
            this.dgvSerch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSerch_CellClick);
            // 
            // 刷新
            // 
            this.刷新.Location = new System.Drawing.Point(399, 44);
            this.刷新.Name = "刷新";
            this.刷新.Size = new System.Drawing.Size(75, 23);
            this.刷新.TabIndex = 32;
            this.刷新.Text = "刷新";
            this.刷新.UseVisualStyleBackColor = true;
            this.刷新.Click += new System.EventHandler(this.刷新_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(735, 373);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.刷新);
            this.Controls.Add(this.dgvSerch);
            this.Controls.Add(this.订票);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labchoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电影查询";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labchoice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改影片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订票ToolStripMenuItem;
        private System.Windows.Forms.Button 订票;
        private System.Windows.Forms.DataGridView dgvSerch;
        private System.Windows.Forms.Button 刷新;
        private System.Windows.Forms.Button button2;
    }
}
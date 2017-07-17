namespace tianyu
{
    partial class SearchOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchOrderForm));
            this.grpFilms = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRearch = new System.Windows.Forms.Button();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.grpFilms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFilms
            // 
            this.grpFilms.Controls.Add(this.dateTimePicker);
            this.grpFilms.Controls.Add(this.btnReturn);
            this.grpFilms.Controls.Add(this.btnRefresh);
            this.grpFilms.Controls.Add(this.btnRearch);
            this.grpFilms.Location = new System.Drawing.Point(12, 210);
            this.grpFilms.Name = "grpFilms";
            this.grpFilms.Size = new System.Drawing.Size(601, 78);
            this.grpFilms.TabIndex = 7;
            this.grpFilms.TabStop = false;
            this.grpFilms.Text = "按时间查询订票信息";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(33, 32);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(115, 21);
            this.dateTimePicker.TabIndex = 7;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(505, 32);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(407, 32);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRearch
            // 
            this.btnRearch.Location = new System.Drawing.Point(180, 32);
            this.btnRearch.Name = "btnRearch";
            this.btnRearch.Size = new System.Drawing.Size(75, 23);
            this.btnRearch.TabIndex = 5;
            this.btnRearch.Text = "查找";
            this.btnRearch.UseVisualStyleBackColor = true;
            this.btnRearch.Click += new System.EventHandler(this.btnRearch_Click);
            // 
            // dgvTicket
            // 
            this.dgvTicket.AllowUserToAddRows = false;
            this.dgvTicket.AllowUserToDeleteRows = false;
            this.dgvTicket.AllowUserToResizeColumns = false;
            this.dgvTicket.AllowUserToResizeRows = false;
            this.dgvTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTicket.BackgroundColor = System.Drawing.Color.White;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(1, 2);
            this.dgvTicket.MultiSelect = false;
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.ReadOnly = true;
            this.dgvTicket.RowHeadersVisible = false;
            this.dgvTicket.RowTemplate.Height = 23;
            this.dgvTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTicket.Size = new System.Drawing.Size(618, 191);
            this.dgvTicket.TabIndex = 8;
            this.dgvTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellContentClick);
            // 
            // SearchOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(621, 299);
            this.Controls.Add(this.dgvTicket);
            this.Controls.Add(this.grpFilms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询订票信息";
            this.Load += new System.EventHandler(this.SearchOrderForm_Load);
            this.grpFilms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFilms;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRearch;
        private System.Windows.Forms.DataGridView dgvTicket;
    }
}
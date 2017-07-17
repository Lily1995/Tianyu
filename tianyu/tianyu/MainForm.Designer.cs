namespace tianyu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiManageMent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilms = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMember = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMemberInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsmiLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsbtnUptade = new System.Windows.Forms.Button();
            this.btnSeOrder = new System.Windows.Forms.Button();
            this.btnFilms = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManageMent,
            this.tsmiTickets,
            this.tsmiMember,
            this.tsmiExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiManageMent
            // 
            this.tsmiManageMent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilms,
            this.tsmiAdd,
            this.tsmiUpdate,
            this.tsmiDelete});
            this.tsmiManageMent.Name = "tsmiManageMent";
            this.tsmiManageMent.Size = new System.Drawing.Size(68, 21);
            this.tsmiManageMent.Text = "影片管理";
            // 
            // tsmiFilms
            // 
            this.tsmiFilms.Name = "tsmiFilms";
            this.tsmiFilms.Size = new System.Drawing.Size(124, 22);
            this.tsmiFilms.Text = "影片信息";
            this.tsmiFilms.Click += new System.EventHandler(this.tsmiFilms_Click);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(124, 22);
            this.tsmiAdd.Text = "新增影片";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(124, 22);
            this.tsmiUpdate.Text = "修改影片";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(124, 22);
            this.tsmiDelete.Text = "删除影片";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiTickets
            // 
            this.tsmiTickets.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOrder,
            this.tsmiSearch});
            this.tsmiTickets.Name = "tsmiTickets";
            this.tsmiTickets.Size = new System.Drawing.Size(68, 21);
            this.tsmiTickets.Text = "售票管理";
            // 
            // tsmiOrder
            // 
            this.tsmiOrder.Name = "tsmiOrder";
            this.tsmiOrder.Size = new System.Drawing.Size(148, 22);
            this.tsmiOrder.Text = "订票";
            this.tsmiOrder.Click += new System.EventHandler(this.tsmiOrder_Click);
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(148, 22);
            this.tsmiSearch.Text = "订票信息查询";
            this.tsmiSearch.Click += new System.EventHandler(this.tsmiSearch_Click);
            // 
            // tsmiMember
            // 
            this.tsmiMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRegister,
            this.tsmiMemberInfor});
            this.tsmiMember.Name = "tsmiMember";
            this.tsmiMember.Size = new System.Drawing.Size(68, 21);
            this.tsmiMember.Text = "会员管理";
            // 
            // tsmiRegister
            // 
            this.tsmiRegister.Name = "tsmiRegister";
            this.tsmiRegister.Size = new System.Drawing.Size(148, 22);
            this.tsmiRegister.Text = "会员注册";
            this.tsmiRegister.Click += new System.EventHandler(this.tsmiRegister_Click);
            // 
            // tsmiMemberInfor
            // 
            this.tsmiMemberInfor.Name = "tsmiMemberInfor";
            this.tsmiMemberInfor.Size = new System.Drawing.Size(148, 22);
            this.tsmiMemberInfor.Text = "会员信息查询";
            this.tsmiMemberInfor.Click += new System.EventHandler(this.tsmiMemberInfor_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(44, 21);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "今日推荐";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(535, 635);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 39);
            this.label3.TabIndex = 19;
            this.label3.Text = "欢迎进入天娱票务系统";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(914, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsmiLogin
            // 
            this.tsmiLogin.Name = "tsmiLogin";
            this.tsmiLogin.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(854, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 529);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tsbtnUptade
            // 
            this.tsbtnUptade.BackgroundImage = global::tianyu.Properties.Resources._1;
            this.tsbtnUptade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbtnUptade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tsbtnUptade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnUptade.Location = new System.Drawing.Point(6, 32);
            this.tsbtnUptade.Name = "tsbtnUptade";
            this.tsbtnUptade.Size = new System.Drawing.Size(142, 49);
            this.tsbtnUptade.TabIndex = 7;
            this.tsbtnUptade.Text = "新增及修改影片";
            this.tsbtnUptade.UseVisualStyleBackColor = true;
            this.tsbtnUptade.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSeOrder
            // 
            this.btnSeOrder.BackgroundImage = global::tianyu.Properties.Resources._3;
            this.btnSeOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSeOrder.Location = new System.Drawing.Point(315, 32);
            this.btnSeOrder.Name = "btnSeOrder";
            this.btnSeOrder.Size = new System.Drawing.Size(125, 49);
            this.btnSeOrder.TabIndex = 6;
            this.btnSeOrder.Text = "查询订票信息";
            this.btnSeOrder.UseVisualStyleBackColor = true;
            this.btnSeOrder.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFilms
            // 
            this.btnFilms.BackgroundImage = global::tianyu.Properties.Resources._2;
            this.btnFilms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFilms.Location = new System.Drawing.Point(169, 32);
            this.btnFilms.Name = "btnFilms";
            this.btnFilms.Size = new System.Drawing.Size(125, 49);
            this.btnFilms.TabIndex = 4;
            this.btnFilms.Text = "查询电影信息";
            this.btnFilms.UseVisualStyleBackColor = true;
            this.btnFilms.Click += new System.EventHandler(this.btnFilms_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(914, 700);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tsbtnUptade);
            this.Controls.Add(this.btnSeOrder);
            this.Controls.Add(this.btnFilms);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "天娱电影售票管理系统";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tsbtnUptade;
        private System.Windows.Forms.Button btnSeOrder;
        private System.Windows.Forms.Button btnFilms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageMent;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilms;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiTickets;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiMember;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegister;
        private System.Windows.Forms.ToolStripMenuItem tsmiMemberInfor;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsmiLogin;


    }
}
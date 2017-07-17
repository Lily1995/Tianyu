namespace tianyu
{
    partial class RegistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistForm));
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPeopleId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labPhone = new System.Windows.Forms.Label();
            this.labPeopleId = new System.Windows.Forms.Label();
            this.labType = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labNumber = new System.Windows.Forms.Label();
            this.labClew = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "钻石会员",
            "金卡会员",
            "银卡会员"});
            this.cboType.Location = new System.Drawing.Point(120, 77);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(164, 20);
            this.cboType.TabIndex = 21;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 155);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(164, 21);
            this.txtPhone.TabIndex = 25;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtPeopleId
            // 
            this.txtPeopleId.Location = new System.Drawing.Point(120, 115);
            this.txtPeopleId.MaxLength = 18;
            this.txtPeopleId.Name = "txtPeopleId";
            this.txtPeopleId.Size = new System.Drawing.Size(164, 21);
            this.txtPeopleId.TabIndex = 22;
            this.txtPeopleId.TextChanged += new System.EventHandler(this.txtPeopleId_TextChanged);
            this.txtPeopleId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeopleId_KeyPress);
            this.txtPeopleId.Leave += new System.EventHandler(this.txtPeopleId_Leave);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 21);
            this.txtName.TabIndex = 20;
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPhone.Location = new System.Drawing.Point(22, 158);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(70, 12);
            this.labPhone.TabIndex = 29;
            this.labPhone.Text = "联系电话：";
            // 
            // labPeopleId
            // 
            this.labPeopleId.AutoSize = true;
            this.labPeopleId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPeopleId.Location = new System.Drawing.Point(35, 124);
            this.labPeopleId.Name = "labPeopleId";
            this.labPeopleId.Size = new System.Drawing.Size(57, 12);
            this.labPeopleId.TabIndex = 27;
            this.labPeopleId.Text = "身份证：";
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labType.Location = new System.Drawing.Point(22, 80);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(70, 12);
            this.labType.TabIndex = 24;
            this.labType.Text = "会员类型：";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labName.Location = new System.Drawing.Point(48, 42);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(44, 12);
            this.labName.TabIndex = 23;
            this.labName.Text = "姓名：";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(180, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(62, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "注册";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNumber.ForeColor = System.Drawing.Color.Maroon;
            this.labNumber.Location = new System.Drawing.Point(292, 160);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(148, 12);
            this.labNumber.TabIndex = 34;
            this.labNumber.Text = "请输入有效的联系方式！";
            // 
            // labClew
            // 
            this.labClew.AutoSize = true;
            this.labClew.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labClew.ForeColor = System.Drawing.Color.Maroon;
            this.labClew.Location = new System.Drawing.Point(291, 122);
            this.labClew.Name = "labClew";
            this.labClew.Size = new System.Drawing.Size(109, 12);
            this.labClew.TabIndex = 33;
            this.labClew.Text = "请输入有效证件！";
            // 
            // RegistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(442, 280);
            this.Controls.Add(this.labNumber);
            this.Controls.Add(this.labClew);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPeopleId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.labPeopleId);
            this.Controls.Add(this.labType);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员注册";
            this.Load += new System.EventHandler(this.RegistForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPeopleId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Label labPeopleId;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.Label labClew;
    }
}
namespace tianyu
{
    partial class ExitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitForm));
            this.lblExit1 = new System.Windows.Forms.Label();
            this.btnNO = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.rdoExit2 = new System.Windows.Forms.RadioButton();
            this.rdoExit1 = new System.Windows.Forms.RadioButton();
            this.picpicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExit1
            // 
            this.lblExit1.AutoSize = true;
            this.lblExit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExit1.Location = new System.Drawing.Point(152, 39);
            this.lblExit1.Name = "lblExit1";
            this.lblExit1.Size = new System.Drawing.Size(114, 20);
            this.lblExit1.TabIndex = 12;
            this.lblExit1.Text = "确定要退出吗?";
            this.lblExit1.Click += new System.EventHandler(this.lblExit1_Click);
            // 
            // btnNO
            // 
            this.btnNO.Location = new System.Drawing.Point(201, 165);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(75, 23);
            this.btnNO.TabIndex = 11;
            this.btnNO.Text = "取消";
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(105, 165);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rdoExit2
            // 
            this.rdoExit2.AutoSize = true;
            this.rdoExit2.Location = new System.Drawing.Point(164, 120);
            this.rdoExit2.Name = "rdoExit2";
            this.rdoExit2.Size = new System.Drawing.Size(71, 16);
            this.rdoExit2.TabIndex = 9;
            this.rdoExit2.Text = "换班退出";
            this.rdoExit2.UseVisualStyleBackColor = true;
            this.rdoExit2.CheckedChanged += new System.EventHandler(this.rdoExit2_CheckedChanged);
            this.rdoExit2.Click += new System.EventHandler(this.rdoExit2_Click);
            // 
            // rdoExit1
            // 
            this.rdoExit1.AutoSize = true;
            this.rdoExit1.Location = new System.Drawing.Point(164, 75);
            this.rdoExit1.Name = "rdoExit1";
            this.rdoExit1.Size = new System.Drawing.Size(71, 16);
            this.rdoExit1.TabIndex = 8;
            this.rdoExit1.Text = "直接退出";
            this.rdoExit1.UseVisualStyleBackColor = true;
            this.rdoExit1.CheckedChanged += new System.EventHandler(this.rdoExit1_CheckedChanged);
            this.rdoExit1.Click += new System.EventHandler(this.rdoExit1_Click);
            // 
            // picpicture
            // 
            this.picpicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picpicture.BackgroundImage")));
            this.picpicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picpicture.Image = global::tianyu.Properties.Resources.AI;
            this.picpicture.Location = new System.Drawing.Point(27, 36);
            this.picpicture.Name = "picpicture";
            this.picpicture.Size = new System.Drawing.Size(119, 100);
            this.picpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picpicture.TabIndex = 13;
            this.picpicture.TabStop = false;
            this.picpicture.Click += new System.EventHandler(this.picpicture_Click);
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(331, 225);
            this.Controls.Add(this.picpicture);
            this.Controls.Add(this.lblExit1);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rdoExit2);
            this.Controls.Add(this.rdoExit1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExitForm";
            ((System.ComponentModel.ISupportInitialize)(this.picpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picpicture;
        private System.Windows.Forms.Label lblExit1;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rdoExit2;
        private System.Windows.Forms.RadioButton rdoExit1;
    }
}
namespace GUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pLeft = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNameStore = new System.Windows.Forms.Label();
            this.pTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnThongBao = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtRole = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pBDaiDien = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pTopTop = new System.Windows.Forms.Panel();
            this.pContent = new System.Windows.Forms.Panel();
            this.pLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pTop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // pLeft
            // 
            this.pLeft.BackColor = System.Drawing.Color.White;
            this.pLeft.Controls.Add(this.btnDangXuat);
            this.pLeft.Controls.Add(this.panel1);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 0);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(267, 450);
            this.pLeft.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.ImageKey = "log-out.png";
            this.btnDangXuat.ImageList = this.imageList1;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 382);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(267, 68);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "log-out.png");
            this.imageList1.Images.SetKeyName(1, "notification-bell.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNameStore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 124);
            this.panel1.TabIndex = 0;
            // 
            // txtNameStore
            // 
            this.txtNameStore.AutoSize = true;
            this.txtNameStore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameStore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNameStore.Location = new System.Drawing.Point(39, 38);
            this.txtNameStore.Name = "txtNameStore";
            this.txtNameStore.Size = new System.Drawing.Size(173, 48);
            this.txtNameStore.TabIndex = 0;
            this.txtNameStore.Text = "ElecStore";
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.panel3);
            this.pTop.Controls.Add(this.panel2);
            this.pTop.Controls.Add(this.pTopTop);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(267, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(533, 124);
            this.pTop.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 51);
            this.panel3.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnThongBao);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(132, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(101, 51);
            this.panel8.TabIndex = 2;
            // 
            // btnThongBao
            // 
            this.btnThongBao.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThongBao.FlatAppearance.BorderSize = 0;
            this.btnThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongBao.ImageKey = "notification-bell.png";
            this.btnThongBao.ImageList = this.imageList1;
            this.btnThongBao.Location = new System.Drawing.Point(0, 0);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(51, 51);
            this.btnThongBao.TabIndex = 2;
            this.btnThongBao.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(233, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 51);
            this.panel5.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.txtRole);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 28);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(190, 23);
            this.panel7.TabIndex = 1;
            // 
            // txtRole
            // 
            this.txtRole.AutoSize = true;
            this.txtRole.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtRole.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(124, 0);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(66, 21);
            this.txtRole.TabIndex = 0;
            this.txtRole.Text = "Chức vụ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.txtUserName);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(190, 24);
            this.panel6.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(16, 0);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(174, 25);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "Họ tên người dùng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pBDaiDien);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(423, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(110, 51);
            this.panel4.TabIndex = 0;
            // 
            // pBDaiDien
            // 
            this.pBDaiDien.BackColor = System.Drawing.Color.Silver;
            this.pBDaiDien.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBDaiDien.Image = ((System.Drawing.Image)(resources.GetObject("pBDaiDien.Image")));
            this.pBDaiDien.Location = new System.Drawing.Point(0, 0);
            this.pBDaiDien.Name = "pBDaiDien";
            this.pBDaiDien.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pBDaiDien.Size = new System.Drawing.Size(54, 51);
            this.pBDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBDaiDien.TabIndex = 0;
            this.pBDaiDien.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 33);
            this.panel2.TabIndex = 1;
            // 
            // pTopTop
            // 
            this.pTopTop.BackColor = System.Drawing.Color.White;
            this.pTopTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTopTop.Location = new System.Drawing.Point(0, 0);
            this.pTopTop.Name = "pTopTop";
            this.pTopTop.Size = new System.Drawing.Size(533, 40);
            this.pTopTop.TabIndex = 0;
            // 
            // pContent
            // 
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(267, 124);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(533, 326);
            this.pContent.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.pLeft);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.pLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pTop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBDaiDien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtNameStore;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pTopTop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pBDaiDien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label txtRole;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnThongBao;
    }
}
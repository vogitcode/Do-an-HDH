
namespace ChildrenControl
{
    partial class TaoTaiKhoan
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
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNguoiDung = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTaoTK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Location = new System.Drawing.Point(171, 107);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(237, 20);
            this.textBoxMatKhau.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập mật khẩu";
            // 
            // comboBoxNguoiDung
            // 
            this.comboBoxNguoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNguoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNguoiDung.FormattingEnabled = true;
            this.comboBoxNguoiDung.Items.AddRange(new object[] {
            "Parent",
            "Child"});
            this.comboBoxNguoiDung.Location = new System.Drawing.Point(171, 146);
            this.comboBoxNguoiDung.Name = "comboBoxNguoiDung";
            this.comboBoxNguoiDung.Size = new System.Drawing.Size(121, 27);
            this.comboBoxNguoiDung.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Loại tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tạo tài khoản";
            // 
            // buttonTaoTK
            // 
            this.buttonTaoTK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaoTK.Location = new System.Drawing.Point(323, 210);
            this.buttonTaoTK.Name = "buttonTaoTK";
            this.buttonTaoTK.Size = new System.Drawing.Size(126, 35);
            this.buttonTaoTK.TabIndex = 10;
            this.buttonTaoTK.Text = "Tạo tài khoản";
            this.buttonTaoTK.UseVisualStyleBackColor = true;
            this.buttonTaoTK.Click += new System.EventHandler(this.buttonTaoTK_Click);
            // 
            // TaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTaoTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxNguoiDung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMatKhau);
            this.Name = "TaoTaiKhoan";
            this.Text = "TaoTaiKhoan";
            this.Load += new System.EventHandler(this.TaoTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNguoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTaoTK;
    }
}
namespace IAmAMachine
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
            this.btnTonKho = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnDieuChuyenKho = new System.Windows.Forms.Button();
            this.btnDieuChinhTon = new System.Windows.Forms.Button();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTonKho
            // 
            this.btnTonKho.BackColor = System.Drawing.Color.Green;
            this.btnTonKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTonKho.FlatAppearance.BorderSize = 0;
            this.btnTonKho.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTonKho.ForeColor = System.Drawing.Color.White;
            this.btnTonKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTonKho.Location = new System.Drawing.Point(2, 31);
            this.btnTonKho.Margin = new System.Windows.Forms.Padding(2);
            this.btnTonKho.Name = "btnTonKho";
            this.btnTonKho.Size = new System.Drawing.Size(156, 34);
            this.btnTonKho.TabIndex = 3;
            this.btnTonKho.Text = "Tồn kho ban đầu";
            this.btnTonKho.UseVisualStyleBackColor = false;
            this.btnTonKho.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.BackColor = System.Drawing.Color.Green;
            this.btnNhaCungCap.FlatAppearance.BorderSize = 0;
            this.btnNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btnNhaCungCap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaCungCap.Location = new System.Drawing.Point(2, 67);
            this.btnNhaCungCap.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(156, 34);
            this.btnNhaCungCap.TabIndex = 6;
            this.btnNhaCungCap.Text = "Từ nhà cung cấp";
            this.btnNhaCungCap.UseVisualStyleBackColor = false;
            this.btnNhaCungCap.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 34);
            this.panel1.TabIndex = 3;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Green;
            this.sidePanel.Controls.Add(this.btnDieuChinhTon);
            this.sidePanel.Controls.Add(this.btnDieuChuyenKho);
            this.sidePanel.Controls.Add(this.panel1);
            this.sidePanel.Controls.Add(this.btnNhaCungCap);
            this.sidePanel.Controls.Add(this.btnTonKho);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(160, 500);
            this.sidePanel.TabIndex = 0;
            // 
            // btnDieuChuyenKho
            // 
            this.btnDieuChuyenKho.BackColor = System.Drawing.Color.Green;
            this.btnDieuChuyenKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDieuChuyenKho.ForeColor = System.Drawing.Color.White;
            this.btnDieuChuyenKho.Location = new System.Drawing.Point(0, 106);
            this.btnDieuChuyenKho.Name = "btnDieuChuyenKho";
            this.btnDieuChuyenKho.Size = new System.Drawing.Size(158, 33);
            this.btnDieuChuyenKho.TabIndex = 7;
            this.btnDieuChuyenKho.Text = "Điều chuyển kho";
            this.btnDieuChuyenKho.UseVisualStyleBackColor = false;
            this.btnDieuChuyenKho.Click += new System.EventHandler(this.btnDieuChuyenKho_Click);
            // 
            // btnDieuChinhTon
            // 
            this.btnDieuChinhTon.BackColor = System.Drawing.Color.Green;
            this.btnDieuChinhTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDieuChinhTon.ForeColor = System.Drawing.Color.White;
            this.btnDieuChinhTon.Location = new System.Drawing.Point(2, 145);
            this.btnDieuChinhTon.Name = "btnDieuChinhTon";
            this.btnDieuChinhTon.Size = new System.Drawing.Size(155, 34);
            this.btnDieuChinhTon.TabIndex = 8;
            this.btnDieuChinhTon.Text = "Điều chỉnh tồn";
            this.btnDieuChinhTon.UseVisualStyleBackColor = false;
            this.btnDieuChinhTon.Click += new System.EventHandler(this.btnDieuChinhTon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1086, 500);
            this.Controls.Add(this.sidePanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Nhập kho";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTonKho;
        private System.Windows.Forms.Button btnNhaCungCap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnDieuChuyenKho;
        private System.Windows.Forms.Button btnDieuChinhTon;
    }
}


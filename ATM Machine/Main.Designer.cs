namespace ATM_Machine
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.WithdrwalBtn = new System.Windows.Forms.Button();
            this.DepBtn = new System.Windows.Forms.Button();
            this.TransBtn = new System.Windows.Forms.Button();
            this.BalInqBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SPB = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SPB)).BeginInit();
            this.SuspendLayout();
            // 
            // WithdrwalBtn
            // 
            this.WithdrwalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(127)))));
            this.WithdrwalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WithdrwalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrwalBtn.ForeColor = System.Drawing.Color.White;
            this.WithdrwalBtn.Location = new System.Drawing.Point(1138, 83);
            this.WithdrwalBtn.Name = "WithdrwalBtn";
            this.WithdrwalBtn.Size = new System.Drawing.Size(303, 87);
            this.WithdrwalBtn.TabIndex = 18;
            this.WithdrwalBtn.Text = "Withdrawal";
            this.WithdrwalBtn.UseVisualStyleBackColor = false;
            this.WithdrwalBtn.Click += new System.EventHandler(this.WithdrwalBtn_Click);
            // 
            // DepBtn
            // 
            this.DepBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(127)))));
            this.DepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DepBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepBtn.ForeColor = System.Drawing.Color.White;
            this.DepBtn.Location = new System.Drawing.Point(1138, 181);
            this.DepBtn.Name = "DepBtn";
            this.DepBtn.Size = new System.Drawing.Size(303, 87);
            this.DepBtn.TabIndex = 19;
            this.DepBtn.Text = "Deposit";
            this.DepBtn.UseVisualStyleBackColor = false;
            this.DepBtn.Click += new System.EventHandler(this.DepBtn_Click);
            // 
            // TransBtn
            // 
            this.TransBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(127)))));
            this.TransBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TransBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransBtn.ForeColor = System.Drawing.Color.White;
            this.TransBtn.Location = new System.Drawing.Point(1138, 279);
            this.TransBtn.Name = "TransBtn";
            this.TransBtn.Size = new System.Drawing.Size(303, 87);
            this.TransBtn.TabIndex = 20;
            this.TransBtn.Text = "Transfer";
            this.TransBtn.UseVisualStyleBackColor = false;
            this.TransBtn.Click += new System.EventHandler(this.TransBtn_Click);
            // 
            // BalInqBtn
            // 
            this.BalInqBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(127)))));
            this.BalInqBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BalInqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalInqBtn.ForeColor = System.Drawing.Color.White;
            this.BalInqBtn.Location = new System.Drawing.Point(1138, 377);
            this.BalInqBtn.Name = "BalInqBtn";
            this.BalInqBtn.Size = new System.Drawing.Size(303, 87);
            this.BalInqBtn.TabIndex = 21;
            this.BalInqBtn.Text = "Balance Inquiry";
            this.BalInqBtn.UseVisualStyleBackColor = false;
            this.BalInqBtn.Click += new System.EventHandler(this.BalInqBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(127)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(1138, 682);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(303, 87);
            this.ExitBtn.TabIndex = 22;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 42);
            this.label1.TabIndex = 23;
            this.label1.Text = "24/7 Access to your money just got easier.\r\n";
            // 
            // AmountTB
            // 
            this.AmountTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTB.Location = new System.Drawing.Point(226, 481);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(318, 55);
            this.AmountTB.TabIndex = 26;
            this.AmountTB.Tag = "";
            this.AmountTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountTB_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(307, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 39);
            this.label2.TabIndex = 25;
            this.label2.Text = "Amount";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "coins-logo-blue-500x500-4-500x445.png");
            this.imageList1.Images.SetKeyName(1, "GCash-Logo.png");
            this.imageList1.Images.SetKeyName(2, "MasterCard_Logo.svg.png");
            this.imageList1.Images.SetKeyName(3, "PayMaya_Logo.png");
            this.imageList1.Images.SetKeyName(4, "Paypal-logo.png");
            this.imageList1.Images.SetKeyName(5, "visa-logo-visa-icon-transparent-free-png.png");
            // 
            // SPB
            // 
            this.SPB.Location = new System.Drawing.Point(70, 155);
            this.SPB.Name = "SPB";
            this.SPB.Size = new System.Drawing.Size(620, 260);
            this.SPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SPB.TabIndex = 27;
            this.SPB.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 950;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(163, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 55);
            this.label3.TabIndex = 28;
            this.label3.Text = "₱";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1471, 853);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SPB);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BalInqBtn);
            this.Controls.Add(this.TransBtn);
            this.Controls.Add(this.DepBtn);
            this.Controls.Add(this.WithdrwalBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.SPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WithdrwalBtn;
        private System.Windows.Forms.Button DepBtn;
        private System.Windows.Forms.Button TransBtn;
        private System.Windows.Forms.Button BalInqBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox SPB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}
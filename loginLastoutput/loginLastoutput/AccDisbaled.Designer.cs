namespace loginLastoutput
{
    partial class AccDisbaled
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccDisbaled));
            BtnOkay = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BtnOkay
            // 
            BtnOkay.BorderRadius = 15;
            BtnOkay.BorderThickness = 1;
            BtnOkay.CustomizableEdges = customizableEdges1;
            BtnOkay.DisabledState.BorderColor = Color.DarkGray;
            BtnOkay.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnOkay.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnOkay.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnOkay.FillColor = Color.DarkSlateGray;
            BtnOkay.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnOkay.ForeColor = Color.White;
            BtnOkay.Location = new Point(12, 132);
            BtnOkay.Name = "BtnOkay";
            BtnOkay.PressedColor = Color.Teal;
            BtnOkay.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnOkay.Size = new Size(96, 35);
            BtnOkay.TabIndex = 0;
            BtnOkay.Text = "Okay";
            BtnOkay.Click += BtnOkay_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.DarkSlateGray;
            guna2HtmlLabel1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(12, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(83, 28);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "Warning";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(101, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(186, 21);
            label1.TabIndex = 4;
            label1.Text = "Log in attempts failed.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(146, 21);
            label2.TabIndex = 5;
            label2.Text = "Account Disabled";
            // 
            // AccDisbaled
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(279, 181);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(BtnOkay);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AccDisbaled";
            Padding = new Padding(20, 0, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccDisbaled";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnOkay;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}
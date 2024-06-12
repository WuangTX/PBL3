namespace QLQA.Model
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProduct));
            this.lblName = new System.Windows.Forms.Label();
            this.guna2ShadowPanelValid = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnCheck = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2ShadowPanelValid.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(1, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(155, 36);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Product Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ShadowPanelValid
            // 
            this.guna2ShadowPanelValid.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanelValid.Controls.Add(this.btnCheck);
            this.guna2ShadowPanelValid.Controls.Add(this.guna2Panel1);
            this.guna2ShadowPanelValid.Controls.Add(this.txtImage);
            this.guna2ShadowPanelValid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanelValid.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanelValid.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanelValid.Name = "guna2ShadowPanelValid";
            this.guna2ShadowPanelValid.Radius = 5;
            this.guna2ShadowPanelValid.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2ShadowPanelValid.Size = new System.Drawing.Size(156, 174);
            this.guna2ShadowPanelValid.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheck.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnCheck.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCheck.Image = global::QLQA.Properties.Resources.icons8_done_604;
            this.btnCheck.Location = new System.Drawing.Point(126, 6);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(25, 25);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblName);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 138);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(156, 36);
            this.guna2Panel1.TabIndex = 2;
            // 
            // txtImage
            // 
            this.txtImage.BackColor = System.Drawing.Color.Transparent;
            this.txtImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtImage.Image = ((System.Drawing.Image)(resources.GetObject("txtImage.Image")));
            this.txtImage.ImageRotate = 0F;
            this.txtImage.Location = new System.Drawing.Point(7, 9);
            this.txtImage.Name = "txtImage";
            this.txtImage.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.txtImage.Size = new System.Drawing.Size(146, 126);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImage.TabIndex = 1;
            this.txtImage.TabStop = false;
            this.txtImage.UseTransparentBackground = true;
            this.txtImage.Click += new System.EventHandler(this.txtImage_Click);
            this.txtImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtImage_MouseDown);
            this.txtImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtImage_MouseUp);
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2ShadowPanelValid);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(156, 174);
            this.guna2ShadowPanelValid.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox txtImage;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanelValid;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCheck;
    }
}

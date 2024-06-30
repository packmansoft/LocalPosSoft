namespace Resto
{
    partial class Form1
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.ultraButton5 = new Infragistics.Win.Misc.UltraButton();
            this.SuspendLayout();
            // 
            // ultraButton5
            // 
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            appearance1.BackColor2 = System.Drawing.Color.Gray;
            appearance1.BackColorAlpha = Infragistics.Win.Alpha.UseAlphaLevel;
            appearance1.BackColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            appearance1.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance1.BackHatchStyle = Infragistics.Win.BackHatchStyle.Horizontal;
            this.ultraButton5.Appearance = appearance1;
            this.ultraButton5.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button3D;
            appearance2.BackColor = System.Drawing.Color.Green;
            appearance2.BackColor2 = System.Drawing.Color.White;
            this.ultraButton5.HotTrackAppearance = appearance2;
            this.ultraButton5.Location = new System.Drawing.Point(361, 107);
            this.ultraButton5.Name = "ultraButton5";
            appearance3.BackColor = System.Drawing.Color.Red;
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ultraButton5.PressedAppearance = appearance3;
            this.ultraButton5.Size = new System.Drawing.Size(123, 61);
            this.ultraButton5.TabIndex = 0;
            this.ultraButton5.Text = "ultraButton1";
            this.ultraButton5.UseAppStyling = false;
            this.ultraButton5.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.ultraButton5.Paint += new System.Windows.Forms.PaintEventHandler(this.ultraButton5_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 410);
            this.Controls.Add(this.ultraButton5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraButton ultraButton5;
    }
}


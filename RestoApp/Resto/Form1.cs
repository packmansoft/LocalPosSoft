using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.Misc;
using System.Drawing.Drawing2D;

namespace Resto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCustomButton();
        }
        private UltraButton ultraButton2;
        private void Form1_Load(object sender, EventArgs e)
        {
            //ultraButton1.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            //ultraButton1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.FlatBorderless;


        }
        private void InitializeCustomButton()
        {
            this.ultraButton2 = new Infragistics.Win.Misc.UltraButton();
            this.SuspendLayout();
            // 
            // ultraButton1
            // 
            this.ultraButton2.Location = new System.Drawing.Point(50, 50);
            this.ultraButton2.Name = "ultraButton1";
            this.ultraButton2.Size = new System.Drawing.Size(200, 50);
            this.ultraButton2.TabIndex = 0;
            this.ultraButton2.Text = "Round Corner Button";
            this.ultraButton2.Paint += new PaintEventHandler(this.ultraButton1_Paint);
            // 
            // RoundCornerButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 150);
            this.Controls.Add(this.ultraButton2);
            this.Name = "RoundCornerButtonForm";
            this.Text = "Round Corner UltraButton";
            this.ResumeLayout(false);
        }

        private void ultraButton1_Paint(object sender, PaintEventArgs e)
        {
            UltraButton button = sender as UltraButton;
            Graphics g = e.Graphics;

            // Set the smoothing mode to anti-alias for smooth edges
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Define the rectangle area for the button
            Rectangle rect = new Rectangle(0, 0, button.Width, button.Height);

            // Define the radius for the round corners
            int cornerRadius = 20;

            // Create a GraphicsPath to define the round corners
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Fill the button background
                using (Brush brush = new SolidBrush(button.Appearance.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Draw the button border
                using (Pen pen = new Pen(button.Appearance.BorderColor))
                {
                    g.DrawPath(pen, path);
                }
            }

            // Draw the button text
            TextRenderer.DrawText(g, button.Text, button.Font, rect, button.Appearance.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void ultraButton5_Paint(object sender, PaintEventArgs e)
        {
            
            UltraButton button = sender as UltraButton;
            if (button == null)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, button.Width, button.Height);
            int radius = 20; // Adjust the radius for round corners

            // Draw the button with rounded corners
            using (GraphicsPath path = GetRoundedRectanglePath(rect, radius))
            using (SolidBrush brush = new SolidBrush(button.BackColor))
            using (Pen pen = new Pen(button.ForeColor, 1))
            {
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(pen, path);
            }

            // Draw the text
            TextRenderer.DrawText(e.Graphics, button.Text, button.Font, rect, button.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        
    }
        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}


using System;

namespace DigitalClock
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
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.hourprocess = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.minuteprocess = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.secondprocess = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblday = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CloseBtn = new Guna.UI.WinForms.GunaCircleButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.hourprocess.SuspendLayout();
            this.minuteprocess.SuspendLayout();
            this.secondprocess.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // hourprocess
            // 
            this.hourprocess.BackColor = System.Drawing.Color.Transparent;
            this.hourprocess.Controls.Add(this.minuteprocess);
            this.hourprocess.FillColor = System.Drawing.Color.DimGray;
            this.hourprocess.FillThickness = 15;
            this.hourprocess.Location = new System.Drawing.Point(63, 37);
            this.hourprocess.Maximum = 24;
            this.hourprocess.Name = "hourprocess";
            this.hourprocess.ProgressColor = System.Drawing.Color.Lime;
            this.hourprocess.ProgressColor2 = System.Drawing.Color.Magenta;
            this.hourprocess.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.hourprocess.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.hourprocess.ProgressThickness = 15;
            this.hourprocess.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.hourprocess.ShadowDecoration.Parent = this.hourprocess;
            this.hourprocess.Size = new System.Drawing.Size(367, 367);
            this.hourprocess.TabIndex = 0;
            this.hourprocess.UseTransparentBackground = true;
            this.hourprocess.Value = 10;
            // 
            // minuteprocess
            // 
            this.minuteprocess.BackColor = System.Drawing.Color.Transparent;
            this.minuteprocess.Controls.Add(this.secondprocess);
            this.minuteprocess.FillColor = System.Drawing.Color.DimGray;
            this.minuteprocess.FillThickness = 15;
            this.minuteprocess.Location = new System.Drawing.Point(21, 21);
            this.minuteprocess.Maximum = 60;
            this.minuteprocess.Name = "minuteprocess";
            this.minuteprocess.ProgressColor = System.Drawing.Color.Yellow;
            this.minuteprocess.ProgressColor2 = System.Drawing.Color.YellowGreen;
            this.minuteprocess.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.minuteprocess.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.minuteprocess.ProgressThickness = 15;
            this.minuteprocess.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.minuteprocess.ShadowDecoration.Parent = this.minuteprocess;
            this.minuteprocess.Size = new System.Drawing.Size(323, 322);
            this.minuteprocess.TabIndex = 1;
            this.minuteprocess.UseTransparentBackground = true;
            this.minuteprocess.Value = 60;
            // 
            // secondprocess
            // 
            this.secondprocess.Animated = true;
            this.secondprocess.BackColor = System.Drawing.Color.Transparent;
            this.secondprocess.Controls.Add(this.lbltime);
            this.secondprocess.FillColor = System.Drawing.Color.DimGray;
            this.secondprocess.FillThickness = 15;
            this.secondprocess.ForeColor = System.Drawing.Color.Gold;
            this.secondprocess.Location = new System.Drawing.Point(21, 21);
            this.secondprocess.Maximum = 60;
            this.secondprocess.Name = "secondprocess";
            this.secondprocess.ProgressColor = System.Drawing.Color.Magenta;
            this.secondprocess.ProgressColor2 = System.Drawing.Color.MediumPurple;
            this.secondprocess.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.secondprocess.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.secondprocess.ProgressThickness = 15;
            this.secondprocess.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.secondprocess.ShadowDecoration.Parent = this.secondprocess;
            this.secondprocess.Size = new System.Drawing.Size(280, 280);
            this.secondprocess.TabIndex = 2;
            this.secondprocess.UseTransparentBackground = true;
            this.secondprocess.Value = 10;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gold;
            this.lblDate.Location = new System.Drawing.Point(157, 407);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(181, 21);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "DATE";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblday
            // 
            this.lblday.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.ForeColor = System.Drawing.Color.Gold;
            this.lblday.Location = new System.Drawing.Point(132, 427);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(237, 29);
            this.lblday.TabIndex = 0;
            this.lblday.Text = "DAY";
            this.lblday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Gold;
            this.lbltime.Location = new System.Drawing.Point(54, 121);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(179, 37);
            this.lbltime.TabIndex = 0;
            this.lbltime.Text = "00.00.00 AM";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CloseBtn
            // 
            this.CloseBtn.AnimationHoverSpeed = 0.07F;
            this.CloseBtn.AnimationSpeed = 0.03F;
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.BaseColor = System.Drawing.Color.Red;
            this.CloseBtn.BorderColor = System.Drawing.Color.Black;
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseBtn.FocusedColor = System.Drawing.Color.Empty;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Image = null;
            this.CloseBtn.ImageSize = new System.Drawing.Size(52, 52);
            this.CloseBtn.Location = new System.Drawing.Point(477, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CloseBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CloseBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.CloseBtn.OnHoverImage = null;
            this.CloseBtn.OnPressedColor = System.Drawing.Color.Black;
            this.CloseBtn.Size = new System.Drawing.Size(14, 14);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Click += new System.EventHandler(this.gunaCircleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(503, 475);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.hourprocess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.hourprocess.ResumeLayout(false);
            this.minuteprocess.ResumeLayout(false);
            this.secondprocess.ResumeLayout(false);
            this.secondprocess.PerformLayout();
            this.ResumeLayout(false);

        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar hourprocess;
        private Guna.UI2.WinForms.Guna2CircleProgressBar minuteprocess;
        private Guna.UI2.WinForms.Guna2CircleProgressBar secondprocess;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaCircleButton CloseBtn;
        private System.Windows.Forms.Timer timer2;
    }
}


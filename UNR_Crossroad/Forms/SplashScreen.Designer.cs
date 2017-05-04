namespace UNR_Crossroad.Forms
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.lbLoad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLoad
            // 
            this.lbLoad.BackColor = System.Drawing.Color.Transparent;
            this.lbLoad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbLoad.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoad.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbLoad.Location = new System.Drawing.Point(0, 291);
            this.lbLoad.Name = "lbLoad";
            this.lbLoad.Size = new System.Drawing.Size(1060, 305);
            this.lbLoad.TabIndex = 1;
            this.lbLoad.Text = "Start loading...";
            this.lbLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 596);
            this.Controls.Add(this.lbLoad);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Label lbLoad;
    }
}
namespace Dictantus
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
            this.labelDictant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDictant
            // 
            this.labelDictant.AutoSize = true;
            this.labelDictant.BackColor = System.Drawing.Color.Transparent;
            this.labelDictant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDictant.Location = new System.Drawing.Point(241, 194);
            this.labelDictant.Name = "labelDictant";
            this.labelDictant.Size = new System.Drawing.Size(50, 13);
            this.labelDictant.TabIndex = 0;
            this.labelDictant.Text = "Диктант";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dictantus.Properties.Resources.BM8mMQSNdNw;
            this.ClientSize = new System.Drawing.Size(415, 278);
            this.Controls.Add(this.labelDictant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Shown += new System.EventHandler(this.SplashScreen_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDictant;
    }
}
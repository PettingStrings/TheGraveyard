namespace CatacombsOfAgony
{
    partial class FrmLevels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevels));
            this.picLvl1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLvl1)).BeginInit();
            this.SuspendLayout();
            // 
            // picLvl1
            // 
            this.picLvl1.BackColor = System.Drawing.SystemColors.Menu;
            this.picLvl1.Location = new System.Drawing.Point(128, 68);
            this.picLvl1.Name = "picLvl1";
            this.picLvl1.Size = new System.Drawing.Size(112, 105);
            this.picLvl1.TabIndex = 0;
            this.picLvl1.TabStop = false;
            this.picLvl1.Click += new System.EventHandler(this.picLvl1_Click);
            // 
            // FrmLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picLvl1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLevels";
            this.Text = "frmLevels";
            this.Load += new System.EventHandler(this.FrmLevels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLvl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLvl1;
    }
}
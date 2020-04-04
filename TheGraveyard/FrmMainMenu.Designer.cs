namespace TheGraveyard
{
    partial class FrmMainMenu
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.picMoon = new System.Windows.Forms.PictureBox();
            this.lblPlay = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMoon)).BeginInit();
            this.SuspendLayout();
            // 
            // picMoon
            // 
            this.picMoon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMoon.Location = new System.Drawing.Point(12, 12);
            this.picMoon.Name = "picMoon";
            this.picMoon.Size = new System.Drawing.Size(80, 80);
            this.picMoon.TabIndex = 0;
            this.picMoon.TabStop = false;
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.Location = new System.Drawing.Point(357, 141);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(85, 54);
            this.lblPlay.TabIndex = 1;
            this.lblPlay.Text = "Enter\r\nThe\r\nCatacombs";
            this.lblPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 428);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(41, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "version";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(748, 428);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(40, 13);
            this.lblAccount.TabIndex = 3;
            this.lblAccount.Text = "Accedi";
            this.lblAccount.Click += new System.EventHandler(this.lblAccount_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.picMoon);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainMenu";
            this.Text = "C.O.A.-Main Menu";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMoon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMoon;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAccount;
    }
}


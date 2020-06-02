namespace TheGraveyard.Levels
{
    partial class FrmScore
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
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timScore = new System.Windows.Forms.Timer(this.components);
            this.lblKills = new System.Windows.Forms.Label();
            this.lblDeaths = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblContinue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(217, 80);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 37);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "0";
            this.lblScore.Click += new System.EventHandler(this.LblScore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "SCORE:";
            // 
            // timScore
            // 
            this.timScore.Tick += new System.EventHandler(this.TimScore_Tick);
            // 
            // lblKills
            // 
            this.lblKills.AutoSize = true;
            this.lblKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKills.Location = new System.Drawing.Point(12, 186);
            this.lblKills.Name = "lblKills";
            this.lblKills.Size = new System.Drawing.Size(65, 29);
            this.lblKills.TabIndex = 2;
            this.lblKills.Text = "Kills:";
            this.lblKills.Visible = false;
            // 
            // lblDeaths
            // 
            this.lblDeaths.AutoSize = true;
            this.lblDeaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeaths.Location = new System.Drawing.Point(12, 233);
            this.lblDeaths.Name = "lblDeaths";
            this.lblDeaths.Size = new System.Drawing.Size(94, 29);
            this.lblDeaths.TabIndex = 3;
            this.lblDeaths.Text = "Deaths:";
            this.lblDeaths.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 283);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 29);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time:";
            this.lblTime.Visible = false;
            // 
            // lblContinue
            // 
            this.lblContinue.AutoSize = true;
            this.lblContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinue.Location = new System.Drawing.Point(276, 283);
            this.lblContinue.Name = "lblContinue";
            this.lblContinue.Size = new System.Drawing.Size(109, 29);
            this.lblContinue.TabIndex = 5;
            this.lblContinue.Text = "Continue";
            this.lblContinue.Visible = false;
            this.lblContinue.Click += new System.EventHandler(this.LblContinue_Click);
            // 
            // FrmScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(397, 321);
            this.Controls.Add(this.lblContinue);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDeaths);
            this.Controls.Add(this.lblKills);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FrmScore";
            this.Text = "FrmScore";
            this.Load += new System.EventHandler(this.FrmScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timScore;
        private System.Windows.Forms.Label lblKills;
        private System.Windows.Forms.Label lblDeaths;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblContinue;
    }
}
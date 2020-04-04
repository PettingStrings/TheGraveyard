using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TheGraveyard
{
    public enum MODE { LOGIN,SIGNIN };
    public partial class FrmAccesso : Form
    {
        Random rnd = new Random();
        string code;
        public FrmAccesso()
        {
            InitializeComponent();
        }

        private void FrmAccesso_Load(object sender, EventArgs e)
        {
            lblCode.Hide();
            txtCode.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (code == null)
            {
                code = $"{(int)rnd.Next(0, 9)}{(int)rnd.Next(0, 9)}{(int)rnd.Next(0, 9)}{(int)rnd.Next(0, 9)}{(int)rnd.Next(0, 9)}{(int)rnd.Next(0, 9)}";
                Program.account.Email = "danutzzu2002.ro@gmail.com";
                Program.account.SendMail(Program.account.Email, "Verification code", $"Your code: {code}");
                MessageBox.Show($"Email sent to: {Program.account.Email}");
                lblCode.Show();
                txtCode.Show();
                lblCrateAcc.Text = "Check Code";
            }
            else if (code == txtCode.Text)
            {
                MessageBox.Show("Account successfully created!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong code");
            }
        }
    }
}

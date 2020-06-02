using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGraveyard.Cls.MyQueries;

namespace TheGraveyard
{
    public partial class FrmAccesso : Form
    {
        private enum LOGIN_ERR {NONE, USED_EMAIL, WRONG_PASSWORD};
        public FrmAccesso()
        {
            InitializeComponent();
        }

        private void FrmAccesso_Load(object sender, EventArgs e)
        {
            txtEmail.MaxLength = ClsPlayerAcc.SIZE_EMAIL;
            txtPassword.MaxLength = ClsPlayerAcc.SIZE_PASSWORD;
            txtUsername.MaxLength = ClsPlayerAcc.SIZE_USERNAME;

            if(Program.conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Errore di connessione al database :(");
                this.Close();
            }
            lblLoginSignup.Location = new Point((Width - lblLoginSignup.Width) / 2, lblLoginSignup.Location.Y);
        }

        private void RadioLogin_CheckedChanged(object sender, EventArgs e)
        {
            lblUsername.Hide();
            txtUsername.Hide();
            lblLoginSignup.Text = "Login";
            //Centro la label
            lblLoginSignup.Location = new Point((Width - lblLoginSignup.Width) / 2,lblLoginSignup.Location.Y);
        }

        private void RadioSignUp_CheckedChanged(object sender, EventArgs e)
        {
            lblUsername.Show();
            txtUsername.Show();
            lblLoginSignup.Text = "Sign Up";
            lblLoginSignup.Location = new Point((Width - lblLoginSignup.Width) / 2, lblLoginSignup.Location.Y);
        }

        private void LblLoginSignup_Click(object sender, EventArgs e)
        {
            if (!AllCompleted())
            {
                MessageBox.Show("Completa tutti i campi!");
                return;
            }

            if (txtUsername.Text.Contains(' '))
            {
                MessageBox.Show("L'username non può contenere spazi");
                return;
            }

            if (!txtEmail.Text.Contains('@'))
            {
                MessageBox.Show("Email non valida, manca '@'");
                return;
            }

            if (radioLogin.Checked)
                Login();
            else
                SignUp();
        }

        private void SignUp()
        {
            if (EmailExists())
            {
                MessageBox.Show("E-mail già in uso");
                return;
            }

            Program.cmd.CommandText = MyQueries.AddAccount(
                txtEmail.Text,txtUsername.Text,txtPassword.Text);
            Program.cmd.ExecuteNonQuery();
            MessageBox.Show("Account creato con successo!");
            Login(true);
        }
        //FromsSignUp è true se prima è stato creato un account
        private void Login(bool fromSignUp = false)
        {
            if(!fromSignUp)
                if(!AccountExists())
                { MessageBox.Show("Combinazione email - password non trovata"); return; }

            if (Program.LoadFromDatabase(txtEmail.Text, txtPassword.Text))
            {
                MessageBox.Show("Login avvenuto con successo");
                this.Close();
            }
            else
                MessageBox.Show("Problemi a prendere dati dal DB");
        }

        private bool EmailExists()
        {
            Program.cmd.CommandText = MyQueries.EmailExists(txtEmail.Text);
            return (int)Program.cmd.ExecuteScalar() != 0;
        }

        private bool AccountExists()
        {
            Program.cmd.CommandText = MyQueries.AccountExists(txtEmail.Text, txtPassword.Text);
            return (int)Program.cmd.ExecuteScalar() > 0;
        }

        private bool AllCompleted()
        {
            //Se l'email è stata inserita, la password è stata inserita e ( è selezionato login? se si ritorna 
            // Se l'username è stato inserito, sennò ritorna false)
            bool resp = String.IsNullOrWhiteSpace(txtEmail.Text) && String.IsNullOrWhiteSpace(txtPassword.Text)
                && (radioSignUp.Checked ? String.IsNullOrWhiteSpace(txtUsername.Text) : false);
            return !resp;
        }

    }
}

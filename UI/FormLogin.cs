using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private UsuarioBusiness usuarioBusiness = new UsuarioBusiness();

        private void btnLoggear_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBusiness.InstanciarUsuario(txtUsuario.Text, txtPassword.Text);

                FormUserProfile userProfile = new FormUserProfile();

                this.Hide();

                userProfile.ShowDialog();

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AVISO");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

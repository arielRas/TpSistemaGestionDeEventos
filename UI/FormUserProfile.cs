using Entity;
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
    public partial class FormUserProfile : Form
    {
        public FormUserProfile()
        {
            InitializeComponent();
        }

        private void FormUserProfile_Load(object sender, EventArgs e)
        {
            //PRUEBA PARA VER SI INSTANCIA EL USUARIO CORRECTAMENTE
            MessageBox.Show($"{UsuarioEntity.GetInstance().Nombre} {UsuarioEntity.GetInstance().Apellido} {UsuarioEntity.GetInstance().Email}");
        }
    }
}

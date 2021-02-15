using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.ERP
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contraseña;

            usuario = textBox1.Text;
            contraseña = textBox2.Text;

            if (usuario == "Admin" && contraseña == "123456" || usuario == "Invitado" && contraseña == "000000")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

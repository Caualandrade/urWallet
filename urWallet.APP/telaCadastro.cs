using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using urWallet.BLL;
using urWallet.MODEL;

namespace urWallet.APP
{
    public partial class telaCadastro : Form
    {
        public telaCadastro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string senha = textBox2.Text;
            Usuario usuario = new Usuario();
            usuario.user = user;
            usuario.Senha = senha;
            usuario.Saldo = (decimal?)0;
            if (UsuarioRepository.verificarUsuario(usuario))
            {
                MessageBox.Show("Usuário já cadastrado");
            }
            else
            {
                UsuarioRepository.Add(usuario);
                MessageBox.Show("Usuário adicionado com sucesso");
            }
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }
    }
}

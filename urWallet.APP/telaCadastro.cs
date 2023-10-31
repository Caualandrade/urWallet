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
            string user = textBox1.Text;
            string senha = textBox2.Text;
            Usuario usuario = new Usuario();
            usuario.user = user;
            usuario.Senha = senha;
            UsuarioRepository.Add(usuario);
            MessageBox.Show("Usuário adicionado com sucesso");
        }
    }
}

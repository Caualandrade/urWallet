using System.ComponentModel;
using System.Runtime.CompilerServices;
using urWallet.BLL;
using urWallet.MODEL;

namespace urWallet.APP
{
    public partial class telaLogin : Form
    {

        public static int idUser { get; set; }



        public telaLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = this.textBox1.Text;
            string senha = this.textBox2.Text;

            Usuario usuario = new Usuario();
            usuario.user = email;
            usuario.Senha = senha;
            try
            {
                if (UsuarioRepository.verificarUsuario(usuario))
                {
                    idUser = UsuarioRepository.onlineUsuario(usuario);
                    TelaWallet tw = new TelaWallet();
                    tw.conectar(idUser);
                    tw.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Usuário inexistente/inválido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Senha incorreta");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            telaCadastro telaCadastro = new telaCadastro();
            telaCadastro.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void telaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
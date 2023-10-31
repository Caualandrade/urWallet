using urWallet.BLL;
using urWallet.MODEL;

namespace urWallet.APP
{
    public partial class telaLogin : Form
    {
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

            if (UsuarioRepository.verificarUsuario(usuario))
            {
                TelaWallet tw = new TelaWallet();
                tw.Show();
            }
            else
            {
                MessageBox.Show("Usuário não cadastrado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            telaCadastro telaCadastro = new telaCadastro();
            telaCadastro.Show();
        }
    }
}
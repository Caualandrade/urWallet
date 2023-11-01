using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using urWallet.BLL;
using urWallet.MODEL;

namespace urWallet.APP
{
    public partial class telaFinanca : Form
    {

        int idUser = telaLogin.idUser;

        public telaFinanca()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Usuario conectarFinanca(int id)
        {
            Usuario usuario = UsuarioRepository.GetByID(id);
            return usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            try
            {
               
                Financa f = new Financa();
                Usuario usuario = UsuarioRepository.GetByID(idUser);
                if (radioButton1.Checked)
                {
                    f.Tipo = radioButton1.Text;
                }
                else
                {
                    f.Tipo = radioButton2.Text;
                }
                f.Data = dateTimePicker1.Value;
                f.Valor = decimal.Parse(textBoxValor.Text);
                f.Categoria = listBox1.SelectedItem.ToString();
                f.Descricao = textBoxDescricao.Text;

                FinancaRepository.Add(f);

                if (f.Categoria.Equals("Receita"))
                {
                    usuario.Saldo += f.Valor;
                    UsuarioRepository.Update(usuario);
                }
                else
                {
                    usuario.Saldo -= f.Valor;
                    UsuarioRepository.Update(usuario);
                }

                UserFinanca userFinanca = new UserFinanca();
                userFinanca.IdFinanca = f.Id;
                userFinanca.IdUser = usuario.Id;
                UserFinancaRepository.Add(userFinanca);
                MessageBox.Show("Finança cadastrada com sucesso");
                TelaWallet tl = new TelaWallet();
                tl.Show();
                tl.conectar(idUser);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campo vazio ou inválido");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Id " + idUser);
        }

        private void textBoxDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaWallet tela = new TelaWallet();
            tela.Show();
        }
    }
}

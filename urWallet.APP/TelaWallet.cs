using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using urWallet.BLL;
using urWallet.MODEL;

namespace urWallet.APP
{
    public partial class TelaWallet : Form
    {

        int idUser = telaLogin.idUser;

        public TelaWallet()
        {
            InitializeComponent();
            GerarGrade();
            PopularGrade();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            telaFinanca tf = new telaFinanca();
            tf.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        public void conectar(int id)
        {
            label4.Text = "Olá, " + UsuarioRepository.GetByID(id).user;
            label5.Text = "R$ " + UsuarioRepository.GetByID(id).Saldo;

        }

        private void TelaWallet_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.conectar(idUser);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void GerarGrade()
        {
            listView1.Columns.Add("Tipo", 75).TextAlign = HorizontalAlignment.Left;
            listView1.Columns.Add("Categoria", 150).TextAlign = HorizontalAlignment.Left;
            listView1.Columns.Add("Valor", 100).TextAlign = HorizontalAlignment.Left;
            listView1.Columns.Add("Data", 100).TextAlign = HorizontalAlignment.Left;
            listView1.Columns.Add("Descrição", 150).TextAlign = HorizontalAlignment.Left;
            listView1.View = View.Details;

            listView1.FullRowSelect = true;
            listView1.GridLines = true;
        }

        private void PopularGrade()
        {

            List<UserFinanca> lista = new List<UserFinanca>();
            lista = UserFinancaRepository.GetAll();
            foreach (UserFinanca comparativa in lista)
            {
                if (UsuarioRepository.GetByID(idUser).Id == comparativa.IdUser.Value)
                {
                    string[] item = new string[5];

                    Financa fincanca = FinancaRepository.GetByID(comparativa.IdFinanca.Value);
                    item[0] = fincanca.Tipo;
                    item[1] = fincanca.Categoria;
                    item[2] = fincanca.Valor.ToString();
                    DateTime dataHora = (DateTime)fincanca.Data;
                    string dataFormatada = dataHora.ToString("dd/MM/yyyy");
                    item[3] = dataFormatada;
                    item[4] = fincanca.Descricao.ToUpper();

                    listView1.Items.Add(new ListViewItem(item));

                }
            }

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Selected)
                {
                    listView1.Items.RemoveAt(item.Index);

                }
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            telaLogin tela = new telaLogin();
            tela.Show();
            this.Close();
        }
    }
}

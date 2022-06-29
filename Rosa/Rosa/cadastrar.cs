using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Rosa
{
    public partial class Cadastrar : Form
    {
        DAOCadastro cadastro;
        Ciclo cicloo;
        public Cadastrar()
        {
            InitializeComponent();
            cadastro = new DAOCadastro();// Abrindo a conexão com o Banco de dados 
            cicloo = new Ciclo();

        }// Fim do metodo de construtor
        public void Limpar()
        {
            
            CodigoBox.Text = "" + cadastro.ConsultarCodigo();//Código
            NomeBox.Text = "";//CPF
            MenoPausaBox.Text = "";//Nome
            MenarcaBox.Text = "";//Telefone
            DataBox.Text = "";//Telefone
            PesoBox.Text = "";//Endereço
            
        }//fim do método limpar
        private void NomeBox_TextChanged(object sender, EventArgs e)
        {

        }// caixa de infomação do nome

        private void DataBox_TextChanged(object sender, EventArgs e)
        {

        }// Caixa de informação do Data de nacimento

        private void PesoBox_TextChanged(object sender, EventArgs e)
        {

        }// Caixa de informação Peso 

        private void MenarcaBox_TextChanged(object sender, EventArgs e)
        {

        }//Caixa de infomação menarca 

        private void MenoPausaBox_TextChanged(object sender, EventArgs e)
        {

        }//Caixa de informação da menopausa

        private void CodigoBox_TextChanged(object sender, EventArgs e)
        {

        }//Caixa de informação do codigo 

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CodigoBox.ReadOnly == false)
                {

                    InativarCampos();
                }
                else
                {

                    string nome = (NomeBox.Text);
                    string menopausa = (MenoPausaBox.Text);
                    string menarca = (MenarcaBox.Text);
                    string dataN = (DataBox.Text);
                    decimal peso = Convert.ToDecimal(PesoBox.Text);
                    //Chamar o método inserir que foi Criado na classe cadastrar
                    cadastro.InserirCA(nome, menopausa, menarca, dataN, peso);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("" + er);
            }

        }//Fim do Cadastrar

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void ciclo_Click(object sender, EventArgs e)
        {
            cicloo.ShowDialog();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {

        }
        public void AtivarCampos()
        {
            CodigoBox.ReadOnly = false;//Código
            NomeBox.ReadOnly = true;
            MenoPausaBox.ReadOnly = true;//CPF
            MenarcaBox.ReadOnly = true;//Nome
            DataBox.ReadOnly = true;//Telefone
            PesoBox.ReadOnly = true;//Endereço
        }//fim do ativar

        public void InativarCampos()
        {
            CodigoBox.ReadOnly = true;//Código
            NomeBox.ReadOnly = false;//Código
            MenoPausaBox.ReadOnly = false;//CPF
            MenarcaBox.ReadOnly = false;//Nome
            DataBox.ReadOnly = false;//Telefone
            PesoBox.ReadOnly = false;//Endereço
        }//fim do Inativar

        public void AtivarTodosOsCampos()
        {
            CodigoBox.ReadOnly = false;//Código
            NomeBox.ReadOnly = false;//Código
            MenoPausaBox.ReadOnly = false;//CPF
            MenarcaBox.ReadOnly = false;//Nome
            DataBox.ReadOnly = false;//Telefone
            PesoBox.ReadOnly = false;//Endereço
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            if (CodigoBox.ReadOnly == true)
            {
                AtivarCampos();
            }
            else
            {
               NomeBox.Text = "" + cadastro.ConsultarNome(Convert.ToInt32(NomeBox.Text));//Preenchendo o campo CPF
                DataBox.Text = cadastro.ConsultarNData(Convert.ToInt32(DataBox.Text));//Preenchendo o campo nome
                PesoBox.Text = cadastro.ConsultarPeso(Convert.ToInt32(PesoBox.Text));//Prenchendo o campo telefone
                MenarcaBox.Text = cadastro.ConsultarMenarca(Convert.ToInt32(MenarcaBox.Text)); 
                MenoPausaBox.Text = cadastro.ConsultarMenoPausa(Convert.ToInt32(MenoPausaBox.Text));
            }
        }
    }
}


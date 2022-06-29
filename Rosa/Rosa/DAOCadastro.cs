using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace Rosa
{
    class DAOCadastro
    {
        //Declarar os vetores...
        public int[] vetorCodigo;
        public string[] vetorNome;
        public string[] vetorDataN;
        public decimal[] vetorPeso;
        public string[] vetorMenarca;
        public string[] vetorMenopausa;


        public MySqlConnection ConexaoCa;
        public int i;//Declarando o contador do for e do while
        private int contadorCA;
        private int contarCodigo;
        public string dados;
        public string ComandoCA;
        public string resultadoCA;
        public MySqlConnection CCadastrar;
        private string msg;

        public DAOCadastro()
        {
            ConexaoCa = new MySqlConnection("server=localhost;DataBase=Rosa1;Uid=root;password=");
            try
            {
                ConexaoCa.Open();// tentando Conectar ao Banco de dados
                
            }
            catch (Exception e)
            {
                MessageBox.Show("algo deu errado!" + e);
                ConexaoCa.Close();//Fechando Aa conexão com o banco de dados 
            }
        }//Fim DAOCadastro

        public void InserirCA(int codigo, string nome, string menopausa, string menarca, DateTime dataN, decimal peso)
        {
            try
            {
                dados = "('','" + nome + "','" + menopausa + "','" + menarca + "','" + dataN + "','" + peso + "')";
                ComandoCA = "insert into Rosa1(codigo, nome, menopausa, menarca, dataN, peso) values " + dados;

                //Executar o comando da base de dados 
                MySqlCommand sql = new MySqlCommand(ComandoCA, ConexaoCa);
                resultadoCA = "" + sql.ExecuteNonQuery();
                resultadoCA = "" + sql.ExecuteNonQuery();
                if (resultadoCA == "1")
                {
                    MessageBox.Show("Cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não Cadastrado!");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado!\n\n" + e);
            }
        }// fim do inserir

        internal void InserirCA(string nome, string menopausa, string menarca, DateTime dataN, decimal peso)
        {
            throw new NotImplementedException();
        }

        internal void InserirCA(string nome, string menopausa, string menarca, string dataN, decimal peso)
        {
            throw new NotImplementedException();
        }

        public void PreencherVetor()
        {
            string query = "select * from Paciente";//Comando para coletar dados do banco de dados

            //Instanciando os vetores...
            vetorCodigo = new int[100];
            vetorNome = new string[100];
            vetorDataN = new string[100];
            vetorPeso = new decimal[100];
            vetorMenarca = new string[100];
            vetorMenopausa = new string[100];


            //Preencher os vetores criados anteriormente, ou seja, dar valores iniciais para os vetores
            for (i = 0; i < 100; i++)
            {
                vetorCodigo[i] = 0;
                vetorNome[i] = "";
                vetorDataN[i] = "";
                vetorPeso[i] = 0;
                vetorMenarca[i] = "";
                vetorMenopausa[i] = "";

            }//fim do for
             //Realizar os comandos de consulta ao Banco de Dados
            MySqlCommand coletar = new MySqlCommand(query, CCadastrar);
            //Ler os dados de acordo com o que está no Banco de Dados
            MySqlDataReader leitura = coletar.ExecuteReader(); //Variável leitura, faz uma consulta ao BD

            i = 0;//Declaração do contador 0
            contadorCA = 0;//Declarar o contador 0 para o while
            contarCodigo = 0;//Instanciando o contador para o código
            //Preencher os vetores com dados do banco de dados
            while (leitura.Read())//Enquanto for verdadeiro, executa o que está no while
            {
                vetorCodigo[i] = Convert.ToInt32(leitura["codigo"]);
                vetorNome[i] = leitura["nome"] + "";
                vetorDataN[i] = leitura["dataN"]+ "";
                vetorPeso[i] = Convert.ToDecimal(leitura["peso"]);
                vetorMenarca[i] = leitura["menarca"] + "";
                vetorMenopausa[i] = leitura["menopausa"] + "";

                contarCodigo = contadorCA;//Armazenando a última posição do contador
                i++;//Contador sai da posição zero e vai se incrementando
                contadorCA++;//Contar os loops do while

            }
        }// Fim  do Preencher  

        public string ConsultarTudo()
        {
            PreencherVetor();//Primeira Coisa -> Preencher os vetor com dados do BD
            msg = "";
            for (i = 0; i < contadorCA; i++)
            {
                //Armazenar temporariamente os dados do BD na variável MSG
                msg += "Código: " + vetorCodigo[i] +
                       ", Nome: " + vetorNome[i] +
                       ", Data de Nascimento : " + vetorDataN[i] +
                       ", Peso : " + vetorPeso[i] +       
                       ", Menarca : " + vetorMenarca[i] +
                       ", Menopausa : " + vetorMenopausa[i] +

                       "\n\n";
            }//fim do for
            return msg;//Retorna todos os dados armazenados na variável msg
        }//fim do consultarTudo

        public int ConsultarCodigo()
        {
            PreencherVetor();//Preencher os vetores com os dados do BD
            return vetorCodigo[contarCodigo];
        }//fim do consultarCodigo

        public string ConsultarNome(int cod)
        {
            PreencherVetor();
            for (i = 0; i < contadorCA; i++)
            {
                if (vetorCodigo[i] == cod)
                {
                    return vetorNome[i];
                }
            }//fim do for
            return "Nome não encontrado!";
        }//fim do consultarNome



        public string ConsultarNData(int cod)
        {
            PreencherVetor();
            for (i = 0; i < contadorCA; i++)
            {
                if (vetorCodigo[i] == cod)
                {
                    msg = "" + vetorDataN[i];
                    return msg;
                }
            }
            return "Código não encontrado";
        }
       

        public string ConsultarPeso(int cod)
        {
            PreencherVetor();
            for (i = 0; i < contadorCA; i++)
            {
                if (vetorCodigo[i] == cod)
                {
                    msg = "" + vetorPeso[i];
                    return msg ;
                }
            }
            return "Peso não encontrado!";
        }//fim do consultarTelefone

        public string ConsultarMenarca(int cod)
        {
            PreencherVetor();
            for (i = 0; i < contadorCA; i++)
            {
                if (vetorCodigo[i] == cod)
                {
                    return vetorMenarca[i];
                }
            }
            return "Endereço não encontrado!";
        }//fim do consultarEndereco

        public string ConsultarMenoPausa(int cod)
        {
            PreencherVetor();
            for (i = 0; i < contadorCA; i++)
            {
                if (vetorCodigo[i] == cod)
                {
                    return vetorMenopausa[i];
                }
            }
            return "Endereço não encontrado!";
        }//fim do consultarEndereco

        public string Atualizar(int cod, string campo, string novoDado)
        {
            try
            {
                string query = "update Paciente set " + campo + " = '" + novoDado + "' where codigo = '" + cod + "'";

                MySqlCommand sql = new MySqlCommand(query, CCadastrar);
                string resultado = "" + sql.ExecuteNonQuery();
                if (resultado == "1")
                {
                    return "Atualizado!";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
            return "Não Atualizado!";
        }//fim do atualizar

    }// Fim Classe
}//Fim do projeto

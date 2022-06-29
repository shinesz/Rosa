using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Rosa
{
    class DAO
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public string resultado;


        //Declarar os vetores...
        public int[] vetorCodigo;
        public string[] vetorNome;


        public string[] vetorDataN;
        public decimal[] vetorPeso;
        public string[] vetorHormonios;
        public string[] vetorCicloMenstrual;
        public string[] vetorVidaSexual;
        public string[] vetorMenarca;
        public string[] vetorGravidez;
        public string[] vetorMenopausa;

        public int i;//Declarando o contador do for e do while
        public int contador;//Utilizado para contar as voltas do while
        public string msg;
        public int contarCodigo;
        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=Rosa1;Uid=root;password=");
            try
            {
                conexao.Open();//Tentando conectar ao BD

            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);//Enviando a mesagem de erro aos usuários
                conexao.Close();//fechando a conexão com o banco de dados
            }
        }//fim do DAOPessoa

        public void Inserir(string nome, string dataN, decimal peso, string hormonios, string cicloMenstrual, string vidaSexual, string menarca, string gravidez, string menopausa)
        {
            try
            {
                //Preparar os dados para inserir no banco
                dados = "('','" + nome + "','" + dataN + "','" + peso + "','" + hormonios + "','" + cicloMenstrual + "','" + vidaSexual + "','" + menarca + "','" + gravidez + "','" + menopausa + "')";
                comando = "Insert into Paciente( nome, dataN, peso, hormonios, cicloMenstrual, vidaSexual, menarca, gravidez, menopausa ) values " + dados;

                //Executar o comando na base de dados
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                resultado = "" + sql.ExecuteNonQuery();
                if (resultado == "1")
                {
                    MessageBox.Show("Cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não Cadastrado!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//fim do método inserir

        public void PreencherVetor()
        {
            string query = "select * from Paciente";//Comando para coletar dados do banco de dados

            //Instanciando os vetores...
            vetorCodigo = new int[100];
            vetorNome = new string[100];
            vetorDataN = new string[100];
            vetorPeso = new decimal[100];
            vetorHormonios = new string[100];
            vetorCicloMenstrual = new string[100];
            vetorVidaSexual = new string[100];
            vetorMenarca = new string[100];
            vetorGravidez = new string[100];
            vetorMenopausa = new string[100];


            //Preencher os vetores criados anteriormente, ou seja, dar valores iniciais para os vetores
            for (i = 0; i < 100; i++)
            {
                vetorCodigo[i] = 0;
                vetorNome[i] = "";
                vetorDataN[i] = "";
                vetorPeso[i] = 0;
                vetorHormonios[i] = "";
                vetorCicloMenstrual[i] = "";
                vetorVidaSexual[i] = "";
                vetorMenarca[i] = "";
                vetorMenopausa[i] = "";

            }//fim do for

            //Realizar os comandos de consulta ao Banco de Dados
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Ler os dados de acordo com o que está no Banco de Dados
            MySqlDataReader leitura = coletar.ExecuteReader(); //Variável leitura, faz uma consulta ao BD

            i = 0;//Declaração do contador 0
            contador = 0;//Declarar o contador 0 para o while
            contarCodigo = 0;//Instanciando o contador para o código
            //Preencher os vetores com dados do banco de dados
            while (leitura.Read())//Enquanto for verdadeiro, executa o que está no while
            {
                vetorCodigo[i] = Convert.ToInt32(leitura["codigo"]);
                vetorNome[i] = leitura["nome"] + "";
                vetorDataN[i] = leitura["dataN"]+ "" ;
                vetorPeso[i] = Convert.ToDecimal(leitura["peso"]);
                vetorHormonios[i] = leitura["hormonios"] + "";
                vetorCicloMenstrual[i] = leitura["cicloMenstrual"] + "";
                vetorVidaSexual[i] = leitura["vidaSexual"] + "";
                vetorMenarca[i] = leitura["menarca"] + "";
                vetorGravidez[i] = leitura["gravidez"] + "";
                vetorMenopausa[i] = leitura["menopausa"] + "";

                contarCodigo = contador;//Armazenando a última posição do contador
                i++;//Contador sai da posição zero e vai se incrementando
                contador++;//Contar os loops do while
            }//fim do while

            leitura.Close();//Fechar a conexão e leitura do banco de dados
        }//fim do preencherVetor

        //Criar um consultar Tudo por MessageBox


        public string ConsultarTudo()
        {
            PreencherVetor();//Primeira Coisa -> Preencher os vetor com dados do BD
            msg = "";
            for (i = 0; i < contador; i++)
            {
                //Armazenar temporariamente os dados do BD na variável MSG
                msg += "Código: " + vetorCodigo[i] +
                       ", Nome: " + vetorNome[i] +
                       ", Data de Nascimento : " + vetorDataN[i] +
                       ", Peso : " + vetorPeso[i] +
                       ", Menarca : " + vetorMenarca[i] +
                       ", gravidez : " + vetorGravidez[i] +
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
            for (i = 0; i < contador; i++)
            {
                if (vetorCodigo[i] == cod)
                {
                    return vetorNome[i];
                }
            }//fim do for
            return "Nome não encontrado!";
        }//fim do consultarNome

        public string ConsultarHormonios(int cod)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (vetorCodigo[i] == cod)
                {
                    return vetorHormonios[i];
                }
            }
            return "Telefone não encontrado!";
        }//fim do consultarTelefone

        public string ConsultarCiclo(int cod)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (vetorCodigo[i] == cod)
                {
                    return vetorCicloMenstrual[i];
                }
            }
            return "Endereço não encontrado!";
        }//fim do consultarEndereco

        public string Atualizar(int cod, string campo, string novoDado)
        {
            try
            {
                string query = "update Paciente set " + campo + " = '" + novoDado + "' where codigo = '" + cod + "'";

                MySqlCommand sql = new MySqlCommand(query, conexao);
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


        public void Deletar(int cod)
        {
            try
            {
                string query = "delete from Pacientes where codigo = '" + cod + "'";
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();

                if (resultado == "1")
                {
                    MessageBox.Show("Deletado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não Deletado!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        }//fim do deletar


    }//fim class

}// fim projeto
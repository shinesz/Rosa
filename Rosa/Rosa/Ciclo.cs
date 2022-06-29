using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace Rosa
{
    public partial class Ciclo : Form
    {
        Form2 calenda;
        Cadastrar crd;
        public Ciclo()
        {
          
            InitializeComponent();
            
            
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            crd = new Cadastrar();
            crd.ShowDialog();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {

        }// Fim Do Botão Atualizar

        private void Calendario_Click(object sender, EventArgs e)
        {
            calenda = new Form2();
            calenda.ShowDialog();
        }

        private void Ciclo_Load(object sender, EventArgs e)
        {

        }
    }// Fim Da Classe
}// Fim do Projeto 

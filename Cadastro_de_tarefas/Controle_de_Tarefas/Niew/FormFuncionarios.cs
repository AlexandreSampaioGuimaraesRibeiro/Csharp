using Controle_de_Tarefas.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Tarefas.Niew
{
    public partial class FormFuncionarios : Form
    {
        //tabela para informações
        DataTable tabelaFuncionarios = new DataTable();
        //tabela do controler
        FuncionariosController funcionariosController = new FuncionariosController();
        public FormFuncionarios()
        {
            InitializeComponent();
            //colocando colunas
            tabelaFuncionarios.Columns.Add("nome");
            tabelaFuncionarios.Columns.Add("email");
            tabelaFuncionarios.Columns.Add("ID", typeof(int));
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtNomeFun.Clear();
            TxtCodigo.Clear();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //variaveis para armazena
            string nome = txtNomeFun.Text;
            string email = txtEmail.Text;
            // numero aleatório para o codigo de segurança
            Random codgo = new Random();
            int codigoseguranca = codgo.Next(10000, 100000);
            TxtCodigo.Text = codigoseguranca.ToString();
            //garantindo que nada seja null
            if(string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Escreva o nome do funcionário");
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Escreva o e-mail do funcionário");
                return;
            }
            //enviar informações para ca classe controle
            try
            {
                funcionariosController.cadastrarfuncionarios(nome,email,codigoseguranca);
                //mostrar ao usuário
                MessageBox.Show($"O funcionário: {nome}, como o e-mail: {email} foi cadastrado com sucesso!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"erro em: {ex.Message}");
            }
            tabelaFuncionarios.Clear();
            var listagem = funcionariosController.listafuncionarios();
            foreach ( var i in listagem )
            {
                tabelaFuncionarios.Rows.Add( i.nome,i.email,i.codigo_de_seguranca);
            }
            txtEmail.Clear();
            txtNomeFun.Clear();
            TxtCodigo.Clear();
        }
    }
}

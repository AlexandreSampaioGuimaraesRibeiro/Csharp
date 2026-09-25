/*
 * Created by SharpDevelop.
 * User: Aluno_Noite
 * Date: 25/11/2025
 * Time: 19:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Controle_de_Tarefas.Controller;
using Controle_de_Tarefas.Model;

namespace Controle_de_Tarefas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class FormTarefas : Form
	{	// tabela para guardar as informações
		DataTable tabelaTarefas = new DataTable();
		// iniciando o codigo de controle
		TarefaController tarefaController = new TarefaController();
		public FormTarefas()
		{
			//iniciando componente
			InitializeComponent();
			//criando colunas
			tabelaTarefas.Columns.Add("Tarefa:");
			tabelaTarefas.Columns.Add("Data:");
			tabelaTarefas.Columns.Add("Status:");
			tabelaTarefas.Columns.Add("Responsavel");
			//ligando tabela ao grid
			GridControleTarefas.DataSource = tabelaTarefas;
			//redimencionar as linhas
			GridControleTarefas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			//ficar auto redimencionado
			GridControleTarefas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // mais liso :
			GridControleTarefas.BorderStyle = BorderStyle.None;
            //mudar a cor
            GridControleTarefas.BackgroundColor = Color.FromArgb(10,10,10);
			//da celula
			GridControleTarefas.DefaultCellStyle.BackColor = Color.White;
			//do que está escreito na celula
			GridControleTarefas.DefaultCellStyle.ForeColor = Color.Black;
			//personalizando cabesorio
			GridControleTarefas.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
			GridControleTarefas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
			GridControleTarefas.EnableHeadersVisualStyles = false;

        }

        private void btnCadastrarTarefa_Click(object sender, EventArgs e)
        {
			// colocando os valores em váriaveis para armazenalos
			string tarefa = txtTarefa.Text;
			string data = DtpData.Value.ToShortDateString();
			string status = cmbStatus.Text;
			string responsavel = txtResponsavel.Text;
			//if para garantir que as vatiaveis não são nulas
			if(string.IsNullOrEmpty(tarefa))
			{
				MessageBox.Show("Escreva a tarefa correspondente!");
				return;
			}
			if(string.IsNullOrEmpty(status))
			{
				MessageBox.Show("Escolha o status correspondente!");
				return;
			}
			if (string.IsNullOrEmpty(responsavel))
			{
				MessageBox.Show("Escreva o responsavel");
				return; 
			}
			//enviar as informações para a classe Controller
			try
			{
				tarefaController.TarefaCadastroController(tarefa, data,status, responsavel);
				//mostrando ao usuario
				MessageBox.Show($"Tarefa: {tarefa}, com a data de: {data} e o responsavel:{responsavel}, salva com sucesso");

			}
			catch (Exception ex)
			{
				MessageBox.Show($"erro em:{ex.Message}");
			}
			tabelaTarefas.Clear();
			var listagem = tarefaController.lista_tarefa();
			foreach (var i in listagem)
			{
				tabelaTarefas.Rows.Add(i.nome_tarefa,i.data,i.status,i.responsavel);
			}
            //limpar tudo
            txtTarefa.Clear();
			cmbStatus.SelectedIndex = - 1;
        }
    }
}

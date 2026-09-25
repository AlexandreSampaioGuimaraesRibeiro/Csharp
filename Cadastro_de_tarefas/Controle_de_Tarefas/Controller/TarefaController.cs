/*
 * Created by SharpDevelop.
 * User: Aluno_Noite
 * Date: 25/11/2025
 * Time: 21:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using Controle_de_Tarefas.Model;

namespace Controle_de_Tarefas.Controller
{
	/// <summary>
	/// Description of TarefaController.
	/// </summary>
	internal class TarefaController
	{	//Criando a lista de tarefas
		List<TarefaModel> tarefaModels = new List<TarefaModel>();
		
		

        //função para modificar a lista de tarefas criada anteriormente
        public void TarefaCadastroController(string nome_tarefa, string data, string status,string responsavel)
		{
			//if para garantir que nenhum dado null seja salvo na lista de tarefas
			if(string.IsNullOrWhiteSpace(nome_tarefa)||string.IsNullOrWhiteSpace(data)||string.IsNullOrWhiteSpace(status)||string.IsNullOrEmpty(responsavel))
			{
				return;
			}
			//salvando na lista todos os dados obtidos
			TarefaModel tarefaas = new TarefaModel(nome_tarefa,data,status,responsavel);
			tarefaModels.Add(tarefaas);
			
		}
		//função para voltar a lista preenchida
		public List<TarefaModel> lista_tarefa()
		{
			return tarefaModels;
		}
	}
}

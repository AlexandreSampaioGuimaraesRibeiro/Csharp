/*
 * Created by SharpDevelop.
 * User: Aluno_Noite
 * Date: 25/11/2025
 * Time: 21:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Controle_de_Tarefas.Model
{
	/// <summary>
	/// Description of TarefaModel.
	/// </summary>
	public class TarefaModel
	{
        //criando, dando nome e fazendo con que as classes sejão publicas e que possam
        //ser utilizadas e modificadas de forma segura em qualquer lugar do codigo
        public string nome_tarefa { get; set; }
		public string data { get; set; }
		public string status { get; set; }
        public string responsavel { get; set; }
        //Construtor de variaveis
		public TarefaModel(string nome_tarefa, string data, string status, string responsavel)
        {
            //Diferenciando as classes das variaveis e dando e atribuindo o valor das variaveis a elas
            this.nome_tarefa = nome_tarefa;
            this.data = data;
            this.status = status;
            this.responsavel = responsavel;
        }
    }
}

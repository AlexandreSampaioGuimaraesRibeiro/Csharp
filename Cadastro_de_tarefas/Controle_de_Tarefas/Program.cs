/*
 * Created by SharpDevelop.
 * User: Aluno_Noite
 * Date: 25/11/2025
 * Time: 19:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using Controle_de_Tarefas.Niew;
using System;
using System.Windows.Forms;

namespace Controle_de_Tarefas
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Niew.Menu());
		}
		
	}
}

using Controle_de_Tarefas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Tarefas.Controller
{
    internal class FuncionariosController
    {
        List <FuncionariosModel> listafuncionario = new List<FuncionariosModel> ();
        public void cadastrarfuncionarios(string nomeFuncionario, string email, int codigo_segurança)
        {
            if(string.IsNullOrEmpty(nomeFuncionario)||string.IsNullOrEmpty(email)||codigo_segurança==0)
            {
                return;
            }
            FuncionariosModel funcionarios = new FuncionariosModel (nomeFuncionario,email,codigo_segurança);
            listafuncionario.Add (funcionarios);
        }
        public List<FuncionariosModel> listafuncionarios()
        {
            return listafuncionario; 
        }
    }
}

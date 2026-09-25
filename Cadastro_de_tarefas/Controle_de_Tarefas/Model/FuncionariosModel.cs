using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Tarefas.Model
{
    internal class FuncionariosModel
    {
        string nome {  get; set; }
        string email { get; set; }
        int codigo_de_seguranca { get; set; }

        public FuncionariosModel(string nome,string email, int codigo_de_seguranca) 
        {
            this.nome = nome;
            this.email = email;
            this.codigo_de_seguranca = codigo_de_seguranca;
        }
    }
}

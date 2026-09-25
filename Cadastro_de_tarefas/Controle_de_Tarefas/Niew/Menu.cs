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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void smiControledetarefas_Click(object sender, EventArgs e)
        {
            if(this is FormTarefas)
            
            return;
            
            FormTarefas formTarefas = new FormTarefas();
            formTarefas.ShowDialog();
            
        }

        private void smiCadastrarfuncionarios_Click(object sender, EventArgs e)
        {
            if(this is FormFuncionarios)
            
            return;
            
            FormFuncionarios formcadastrar = new FormFuncionarios();
            formcadastrar.ShowDialog();
            
        }
    }
}

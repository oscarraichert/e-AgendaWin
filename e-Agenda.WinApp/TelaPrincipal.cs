using e_Agenda.WinApp.TelasCompromisso;
using e_Agenda.WinApp.TelasContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipal : Form
    {
        public TelaTarefas telaTarefas;
        public TelaContatos telaContatos;
        public TelaCompromissos telaCompromissos;

        public TelaPrincipal()
        {
            InitializeComponent();
            telaTarefas = new();
            telaContatos = new();
            telaCompromissos = new(telaContatos);
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            telaTarefas.ShowDialog();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            telaContatos.ShowDialog();
        }

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            telaCompromissos.ShowDialog();
        }
    }
}

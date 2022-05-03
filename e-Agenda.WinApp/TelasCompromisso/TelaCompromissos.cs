﻿using e_Agenda.WinApp.Entidades;
using e_Agenda.WinApp.Repositorios;
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

namespace e_Agenda.WinApp.TelasCompromisso
{
    public partial class TelaCompromissos : Form
    {
        public TelaContatos TelaContatos;
        public TelaNovoCompromisso telaNovo;
        public RepositorioCompromisso repositorioCompromisso;

        public TelaCompromissos(TelaContatos telaContatos)
        {
            TelaContatos = telaContatos;
            repositorioCompromisso = new();
            InitializeComponent();
            AtualizarCompromissos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            telaNovo = new(TelaContatos);

            telaNovo.ShowDialog();

            if (telaNovo.DialogResult == DialogResult.OK)
            {
                repositorioCompromisso.AdicionarCompromisso(telaNovo.compromisso);
                AtualizarCompromissos();
            }
        }

        private void AtualizarCompromissos()
        {
            listBoxCompromissos.Items.Clear();

            foreach (Compromisso compromiso in repositorioCompromisso.Compromissos)
            {
                listBoxCompromissos.Items.Add(compromiso);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = (Compromisso)listBoxCompromissos.SelectedItem;

            repositorioCompromisso.RemoverCompromisso(compromisso);

            AtualizarCompromissos();
        }
    }
}

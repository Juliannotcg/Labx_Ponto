﻿using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Enums;
using LabxPonto_View.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabxPonto_View.Views.Usuário
{
    public partial class frmUsuario : frmBase
    {
        private UsuarioServico servico;
        private frmUsuarioCadastro cadastro;
        private Usuario usuario;
        AppDataContext context;

        public frmUsuario(AppDataContext con)
        {
            InitializeComponent();
            servico = new UsuarioServico(con);
            usuario = new Usuario();
            context = con;
        }

        public void preencherGrid()
        {
            dgUsuario.DataSource = servico.GetUsuarioGrid();
        }

        private void btNovo_Click_1(object sender, EventArgs e)
        {
            frmUsuarioCadastro janela = new frmUsuarioCadastro(Operacao.Inserir, context);
            janela.Show();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            preencherGrid();
        }
    }
}

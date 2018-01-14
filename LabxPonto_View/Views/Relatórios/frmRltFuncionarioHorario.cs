using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model.Report;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabxPonto_View.Views.Relatórios
{
    public partial class frmRltFuncionarioHorario : MetroForm
    {
        public frmRltFuncionarioHorario()
        {
            InitializeComponent();
        }

        private void frmRltFuncionarioHorario_Load(object sender, EventArgs e)
        {
            using (var Context = new AppDataContext())
            {
                var resposta = (from c in Context.Funcionarios
                                select new DadosRelatorioFuncionario()
                                {
                                    Id = c.Id,
                                    Nome = c.Nome,
                                    SobreNome = c.SobreNome,
                                    RG = c.RG,
                                    CPF = c.CPF,
                                    EstadoCivil = c.EstadoCivil,
                                    Telefone = c.Telefone,
                                    LocalTrabalho = c.LocalTrabalho,
                                    DataNascimento = c.DataNascimento,
                                    Funcao = c.Funcao.NomeFuncao,
                                    Empresa = c.Empresa.NomeFantasia,
                                    NumeroFolha = c.NumeroFolha,
                                    InicioTurno = c.Horario.InicioTurno,
                                    FimTurno = c.Horario.FimTurno,
                                    InicioAlmoco = c.Horario.InicioAlmoco,
                                    FimAlmoco = c.Horario.FimAlmoco,
                                    Data = c.Horario.Data
                                }).ToArray();

                var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetHorasFuncionario", resposta);

                this.reportViewer.LocalReport.DataSources.Clear();
                this.reportViewer.LocalReport.DataSources.Add(dataSource);
            }

            this.reportViewer.RefreshReport();
        }
    }
}

using LabxPonto_Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_View.Views.Biometria
{
    public class frmVerificarBiometrica:frmLeituraBiometrica
    {
        public Funcionario funcionario { get; set; }
        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Verificação  Biométrica";
            Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
            UpdateStatus(0);
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                Verificator.Verify(features, Template, ref result);
                UpdateStatus(result.FARAchieved);
                if (result.Verified)
                {
                    MakeReport("A impressão digital foi verificada.");
                    MetroFramework.MetroMessageBox.Show(this, "A impressão digital foi verificada com sucesso.","Verificação biométrica", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                }
                else
                {
                    MakeReport("A impressão digital não foi verificada.");
                    MetroFramework.MetroMessageBox.Show(this, "A impressão digital não encontrada. Tente novamente.", "Verificação biométrica", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);

                }
            }
        }

        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("Taxa de aceitação falsa (FAR) = {0}", FAR));
        }

        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;

    }
}

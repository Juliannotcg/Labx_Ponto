using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_View.Views.Biometria
{
    public class frmInscricaoBiometrica:frmLeituraBiometrica
    {
        public delegate void OnTemplateEventHandler(DPFP.Template template);

        public event OnTemplateEventHandler OnTemplate;

        protected override void Init()
        {
            base.Init();
            base.Text = "Inscrição biométrica";
            Enroller = new DPFP.Processing.Enrollment();            // Create an enrollment.
            UpdateStatus();
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            // Check quality of the sample and add to enroller if it's good
            if (features != null) try
                {
                    MakeReport("A inscrição biométrica foi realizada.");
                    Enroller.AddFeatures(features);     // Add feature set to template.
                }
                finally
                {
                    UpdateStatus();

                    // Check if template has been created.
                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:   // report success and stop capturing
                            OnTemplate(Enroller.Template);
                            //SetPrompt("Click Close, and then click Fingerprint Verification.");
                            Stop();
                            break;

                        case DPFP.Processing.Enrollment.Status.Failed:  // report failure and restart capturing
                            Enroller.Clear();
                            Stop();
                            UpdateStatus();
                            OnTemplate(null);
                            Start();
                            break;
                    }
                }
        }

        private void UpdateStatus()
        {
            if (Enroller.FeaturesNeeded > 0)
            {
                if (Enroller.FeaturesNeeded == 4)
                    MetroFramework.MetroMessageBox.Show(this, "Será necessário capturar a imagem digital pelo menos por 4 vezes.\n Pressione OK e coloque o dedo no leitor", "Captura biométrica", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                else
                    if (Enroller.FeaturesNeeded == 1)
                    MetroFramework.MetroMessageBox.Show(this, "A digital foi capturada.\nSó falta mais uma vez.\nPressione OK e coloque novamente o mesmo dedo no leitor", "Captura biométrica", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                else
                    MetroFramework.MetroMessageBox.Show(this, "A digital foi capturada.\nSó faltam mais " + Enroller.FeaturesNeeded + " vezes.\nPressione OK e coloque novamente o mesmo dedo no leitor", "Captura biométrica", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);

            }
            // Show number of samples needed.
            SetStatus(String.Format("Quantidade de imagens necessárias: {0}", Enroller.FeaturesNeeded));
        }

        private DPFP.Processing.Enrollment Enroller;
    }
}

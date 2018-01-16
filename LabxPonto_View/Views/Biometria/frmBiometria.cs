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
using DPFP;
using DPFP.Capture;

namespace LabxPonto_View.Views.Biometria
{
    public partial class frmBiometria : frmBaseCadastro, DPFP.Capture.EventHandler
    {
        Bitmap img = null;
        SampleConversion sp = new SampleConversion();
        Capture cp = new Capture();
        Sample sample = new Sample();
        public frmBiometria()
        {
            InitializeComponent();
            cp.StartCapture();
            cp.EventHandler = this;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBiometriaLer_Click(object sender, EventArgs e)
        {

        }

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            sp.ConvertToPicture(Sample, ref img);
            imgDigital.Image = img;
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            img = null;
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
        }

        private void frmBiometria_FormClosing(object sender, FormClosingEventArgs e)
        {
            cp.StopCapture();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtCpf.Text.Length == 11)
            {
                long CPF = Convert.ToInt64(txtCpf.Text);
                string CPFFormatado = String.Format(@"{0:000\.000\.000\-00}", CPF);
                txtCpf.Text = CPFFormatado;
            }
        }
    }
}

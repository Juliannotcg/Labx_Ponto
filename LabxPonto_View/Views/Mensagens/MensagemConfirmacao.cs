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

namespace LabxPonto_View.Views.Mensagens
{
    public partial class MensagemConfirmacao : MetroForm
    {
        int timeLeft;
        public MensagemConfirmacao(string msg)
        {
            timeLeft = 3;
            InitializeComponent();
            this.txtMensagens.Text = msg;
            Timer timer = new Timer(); // cria um temporizador para fechar o form
            TimeSpan tempo = TimeSpan.FromSeconds(3);
            timer1.Start();

            timer.Interval = 3000; // milisegundos para executar
            timer.Tick += delegate
            { // atribui o evento Tick ao timer
                this.DialogResult = DialogResult.Yes; // Atribui DialogResult ao form. Isso 
                                                      // fecha o formulário
            };
            timer.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                lbTempo.Text = timeLeft.ToString();
            }
        }
    }
}

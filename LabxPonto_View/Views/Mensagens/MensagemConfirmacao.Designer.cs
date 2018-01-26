namespace LabxPonto_View.Views.Mensagens
{
    partial class MensagemConfirmacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtMensagens = new MetroFramework.Controls.MetroLabel();
            this.lbTempo = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtMensagens
            // 
            this.txtMensagens.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txtMensagens.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txtMensagens.Location = new System.Drawing.Point(23, 31);
            this.txtMensagens.Name = "txtMensagens";
            this.txtMensagens.Size = new System.Drawing.Size(445, 107);
            this.txtMensagens.TabIndex = 100;
            this.txtMensagens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMensagens.WrapToLine = true;
            // 
            // lbTempo
            // 
            this.lbTempo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbTempo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbTempo.Location = new System.Drawing.Point(23, 147);
            this.lbTempo.Name = "lbTempo";
            this.lbTempo.Size = new System.Drawing.Size(445, 23);
            this.lbTempo.TabIndex = 101;
            this.lbTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MensagemConfirmacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 176);
            this.Controls.Add(this.lbTempo);
            this.Controls.Add(this.txtMensagens);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MensagemConfirmacao";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel txtMensagens;
        private MetroFramework.Controls.MetroLabel lbTempo;
    }
}
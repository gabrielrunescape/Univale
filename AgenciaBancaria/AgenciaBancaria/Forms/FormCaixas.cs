using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgenciaBancaria.Forms {
    public partial class FormCaixas : Form {
        #region Variaveis (Globais)
        public double Pagar = 0;
        public double Receber = 0;
        public bool Automatico { get; set; }
        public bool Error { get; set; }
        #endregion
        public FormCaixas(int caixa) {
            InitializeComponent();

            label1.Text += caixa;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            try {
                Pagar = double.Parse(tbPagar.Text);
                Receber = double.Parse(tbReceber.Text);
                Automatico = checkBox.Checked;

                if (Pagar <= 0 || Receber <= 0) {
                    MessageBox.Show("Valor não aceito!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Error = true;
                } else {
                    this.Close();
                    Error = false;
                }
            } catch (Exception) {
                MessageBox.Show("Valor não aceito!", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Error = true;
            }
        }
    }
}

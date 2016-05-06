using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using AgenciaBancaria.Source;
using System.Collections.Generic;

namespace AgenciaBancaria.Forms {
    public partial class FormFila : Form {
        #region Variaveis (globais)
        public int Caixa { get; set; }
        public int[] Guichetiers;
        public Pessoa Pessoa = new Pessoa();
        #endregion
        public FormFila() {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e) {
            try {
                Caixa = int.Parse(upDown.Value.ToString());
                //Caixa--;

                if (upDown.Value >= 1) {
                    for (int i = 0; i < Guichetiers.Count(); i++) {
                        if (Guichetiers[i] == Caixa) {
                            if (rbPagamento.Checked == false && rbReceber.Checked == false) {
                                MessageBox.Show("Você deve escolher a operação a ser feita", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } else {
                                if (rbPagamento.Checked) {
                                    Pessoa.Operação = "Pagamento";
                                } else {
                                    Pessoa.Operação = "Recebimento / Saque";
                                }

                                Pessoa.Documento = int.Parse(tbDocumento.Text);
                                Pessoa.Valor = double.Parse(tbValor.Text);

                                this.Close();
                                i = Guichetiers.Count();
                            }
                        }

                        if ((i + 1 == Guichetiers.Count()) && (Guichetiers[i] != Caixa)) {
                            MessageBox.Show("O caixa escolhido não está aberto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                } else {
                    MessageBox.Show("Digite um valor maior igual a 1!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception) {
                MessageBox.Show("Um valor foi informado incorretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using AgenciaBancaria.Source;
using System.Collections.Generic;

namespace AgenciaBancaria.Forms {
    public partial class FormAtendimento : Form {
        #region Variaveis (Globais)
        public Caixa Caixa;
        private Pessoa Pessoa;
        private double pagamento;
        private String transação;
        #endregion

        #region Construtores
        public FormAtendimento(int doc, String trans, double valor) {
            InitializeComponent();

            labelTrans.Text += trans;
            labelDoc.Text += doc;
            labelValor.Text += valor;

            if (trans == "Pagamento") {
                transação = "Recebimento";
            } else {
                transação = "Pagamento";
            }

            pagamento = valor;
        }

        public FormAtendimento(Pessoa pers, Caixa guichet) {
            InitializeComponent();

            labelTrans.Text += pers.Operação;
            labelDoc.Text += pers.Documento;
            labelValor.Text += pers.Valor;

            if (pers.Operação == "Pagamento") {
                transação = "Recebimento";
            } else {
                transação = "Pagamento";
            }

            Pessoa = pers;
            Caixa = guichet;
            pagamento = pers.Valor;
        }
        #endregion

        #region Metódos
        private void btnPagar_Click(object sender, EventArgs e) {
            try {
                double pagamento = double.Parse(tbPagamento.Text);
                double troco = pagamento - this.pagamento;

                if (troco >= 0) {
                    Caixa.Atendimentos.Empilha(Pessoa);
                    this.Close();
                } else {
                    MessageBox.Show("Você ainda tem a receber R$ " + troco, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            } catch (Exception) {
                MessageBox.Show("Você digitou um valor inválido", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbPagamento_TextChanged(object sender, EventArgs e) {
            try {
                double pagamento = double.Parse(tbPagamento.Text);
                double troco = pagamento - this.pagamento;

                if (troco >= 0) {
                    labelTroco.ForeColor = Color.Green;
                    labelTroco.Text = "R$ " + troco;
                } else {
                    labelTroco.ForeColor = Color.Red;
                    labelTroco.Text = "R$ " + troco;
                }
            } catch (Exception) {
                MessageBox.Show("Informe um valor válido!", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDispensar_Click(object sender, EventArgs e) {
            Caixa = null;

            this.Close();
        }
        #endregion
    }
}

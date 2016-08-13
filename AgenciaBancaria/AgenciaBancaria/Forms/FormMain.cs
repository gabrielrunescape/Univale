using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.ComponentModel;
using AgenciaBancaria.Source;
using System.Collections.Generic;

namespace AgenciaBancaria.Forms {
    public partial class FormMain : Form {
        #region Variaveis (Globais)
        private int caixas = -1;
        private int[] caixas_abertos;
        private ListaEstatica Guichetiers = new ListaEstatica();
        #endregion

        public FormMain() {
            InitializeComponent();
        }

        #region Metódos
        private void btnAbrir_Click(object sender, EventArgs e) {
            InputForm input = new InputForm("Entre com o número de caixas para serem abertos", "Abrir caixas");
            input.ShowDialog();

            if (input.inputText != null) {
                try {
                    this.caixas = int.Parse(input.inputText);

                    if (this.caixas > 0) {
                        double pagar = 0;
                        double receber = 0;
                        int incrementador = 0;
                        bool auto_preenc = false;
                        caixas_abertos = new int[caixas];

                        Caixa guichet;
                        FormCaixas cajas;
                        Guichetiers.Inicializar();

                        while (incrementador < caixas) {
                            int numCaixa = incrementador + 1;

                            if (auto_preenc == false) {
                                cajas = new FormCaixas(numCaixa);
                                cajas.ShowDialog();

                                guichet = new Caixa();

                                if (cajas.Error == true) {
                                    incrementador--;
                                } else {
                                    pagar = cajas.Pagar;
                                    receber = cajas.Receber;
                                    auto_preenc = cajas.Automatico;

                                    guichet.IniciarCaixa(numCaixa, pagar, receber);
                                }
                            } else {
                                guichet = new Caixa();
                                guichet.IniciarCaixa(numCaixa, pagar, receber);
                            }

                            Guichetiers.Inserir(guichet, Guichetiers.Quant_elem());
                            incrementador++;
                        }

                        for (int i = 0; i < Guichetiers.Quant_elem(); i++) {
                            caixas_abertos[i] = Guichetiers.Elemento(i).Número;
                        }

                        btnAbrir.Enabled = false;
                    } else {
                        MessageBox.Show("São aceito somente números maiores que 0!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                } catch (Exception ex) {
                    MessageBox.Show("São aceito somente números inteiros!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnFila_Click(object sender, EventArgs e) {
            FormFila fila = new FormFila();

            fila.Guichetiers = caixas_abertos;
            fila.ShowDialog();

            if (fila.Pessoa != null && fila.Caixa != null) {
                Caixa temp = (Caixa) Guichetiers.Elemento(Guichetiers.busca_bin(fila.Caixa));
                temp.Fila.Enfileira(fila.Pessoa);

                int pos = Guichetiers.busca_bin(fila.Caixa);

                Guichetiers.Excluir(pos);
                Guichetiers.Inserir(temp, pos);
            }
        }

        private void btnAtender_Click(object sender, EventArgs e) {
            InputForm input = new InputForm("Digite o número do caixa para atender:", "Atendimento");
            input.ShowDialog();

            if (input.inputText != null) {
                try {
                    int caixa = int.Parse(input.inputText);

                    for (int i = 0; i < caixas_abertos.Count(); i++) {
                        bool encontrado = false;

                        if (caixas_abertos[i] == caixa) {
                            Caixa caja = Guichetiers.Elemento(Guichetiers.busca_bin(caixa));

                            if (caja.Fila.Vazia() != true) {
                                Pessoa persona = (Pessoa) caja.Fila.Desenfileira();

                                FormAtendimento atend = new FormAtendimento(persona, caja);
                                atend.ShowDialog();

                                if (atend.Caixa != null) {
                                    Guichetiers.Inserir(atend.Caixa, i);
                                }
                            } else {
                                MessageBox.Show("Não existem pessoas na fila!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                Guichetiers.Inserir(caja, Guichetiers.busca_bin(caixa));
                            }

                            encontrado = true;
                        }

                        if ((i + 1 == caixas_abertos.Count()) && (caixas_abertos[i] != caixa) && encontrado == false) {
                            MessageBox.Show("O caixa escolhido não está aberto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                } catch (Exception) {
                    MessageBox.Show("O número informado não é válido!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            InputForm input = new InputForm("Digite o número do caixa para ser fechado:", "Fechamento de caixa");
            input.ShowDialog();

            if (input.inputText != null) {
                try {
                    int caixa = int.Parse(input.inputText);
                    int[] temp = new int[caixas_abertos.Length];

                    for (int i = 0; i < caixas_abertos.Length; i++) {
                        if (caixa == caixas_abertos[i]) {
                            bool pessoas = Guichetiers.Elemento(Guichetiers.busca_bin(caixa)).Fila.Vazia();
                            DialogResult confirmacao = DialogResult.No;

                            if (pessoas == false) {
                                String msg = "Ainda existem pessoas na fila.\nDeseja fechar o caixa?";
                                confirmacao = MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            } 

                            if (confirmacao == DialogResult.No) {
                                temp[i] = caixas_abertos[i];
                            }
                        } else {
                            if ((i + 1) == caixas_abertos.Length) {
                                MessageBox.Show("O caixa informado não está aberto!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } else {
                                temp[i] = caixas_abertos[i];
                            }
                        }
                    }

                    caixas_abertos = temp;
                } catch (Exception) {
                    MessageBox.Show("Valor informado inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnRelatório_Click(object sender, EventArgs e) {
            InputForm input = new InputForm("Digite o número do para realizar o relatório:", "Relatório de caixa");
            input.ShowDialog();

            if (input.inputText != null) {
                try {
                    int caixa = int.Parse(input.inputText);
                    Caixa guichet = Guichetiers.Elemento(Guichetiers.busca_bin(caixa));

                    SaveFileDialog save = new SaveFileDialog();

                    save.Title = "Salvar arquivo em";
                    save.Filter = "Arquivo PDF|.pdf";
                    save.FilterIndex = 0;
                    save.FileName = "Relatório_Caixa_" + guichet.Número + "_" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
                    save.DefaultExt = ".pdf";
                    
                    DialogResult resultado = save.ShowDialog();

                    if (resultado == DialogResult.OK) {
                        double pag = 0;
                        double rec = 0;
                        String texto = "Relatório do Caixa " + guichet.Número + "\n";

                        texto += "\nSaldo inicial para recebimentos: " + guichet.Receber;
                        texto += "\nSaldo inicial para pagamentos: " + guichet.Pagar + "\n";

                        while (!guichet.Atendimentos.Vazia()) {
                            Pessoa aux = (Pessoa)guichet.Atendimentos.Desempilha();

                            texto += "\nAtendimento documento: " + aux.Documento;
                            texto += "\nCliente realizou " + aux.Operação;

                            if (aux.Operação == "Pagamento") {
                                texto += "\nO banco recebeu R$ " + aux.Valor + "\n";
                                rec += aux.Valor;
                            } else {
                                texto += "\nO banco pagou R$ " + aux.Valor + "\n";
                                pag += aux.Valor;
                            }
                        }


                        texto += "\nTotal pago no caixa " + guichet.Número + ": R$ " + pag;
                        texto += "\nTotal arrecadado no caixa " + guichet.Número + ": R$ " + rec;

                        double total = guichet.Pagar + guichet.Receber + rec - pag;
                        texto += "\n\nMontante total do caixa " + guichet.Número + ": R$ " + total;

                        GerarPDF(save.FileName, texto);
                    }

                    /*for (int i = 0; i < caixas_abertos.Length; i++) {
                        if (caixa == caixas_abertos[i]) {
                            Caixa guichet = Guichetiers.Elemento(i);*/



                    /*Console.WriteLine("\n\nRelatório do Caixa " + guichet.Número + "\n");
                    Console.WriteLine("\nSaldo inicial para recebimentos: " + guichet.Receber);
                    Console.WriteLine("\nSaldo inicial para pagamentos: " + guichet.Pagar + "\n");

                    while (!guichet.Atendimentos.Vazia()) {
                        Pessoa aux = (Pessoa) guichet.Atendimentos.Desempilha();

                        Console.WriteLine("\nAtendimento documento: " + aux.Documento);
                        Console.WriteLine("Cliente realizou " + aux.Operação);

                        if (aux.Operação == "Pagamento") {
                            Console.WriteLine("O banco recebeu R$ " + aux.Valor);
                            rec += aux.Valor;
                        } else {
                            Console.WriteLine("O banco pagou R$ " + aux.Valor);
                            pag += aux.Valor;
                        }
                    }

                    Console.WriteLine("\nTotal pago no caixa {0}: R$ {1}", guichet.Número, pag);
                    Console.WriteLine("Total arrecadado no caixa {0}: R$ {1}", guichet.Número, rec);

                    double total = guichet.Pagar + guichet.Receber + rec - pag;
                    Console.WriteLine("\nMontante total do caixa {0}: R$ {1}", guichet.Número, total);*/
                    
                            /*i = caixas_abertos.Length + 1;
                        } else {
                            if ((i + 1) == caixas_abertos.Length) {
                                MessageBox.Show("O caixa informado está aberto!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }*/
                } catch (NullReferenceException) {
                    MessageBox.Show("Foi informado um valor de caixa inválido e/ou inexistente!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (Exception) {
                    MessageBox.Show("Valor informádo inválido!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void GerarPDF(String caminho, String texto) {
            Document documento = new Document();

            PdfWriter.GetInstance(documento, new FileStream(caminho, FileMode.Create));

            try {
                Paragraph p = new Paragraph(texto);

                documento.Open();
                documento.Add(p);
                documento.Close();

                MessageBox.Show("Relatório gerado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(@caminho);
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro");
            }
        }

        private void btnSair_Click(object sender, EventArgs e) {
            DialogResult dr = MessageBox.Show("Deseja sair do programa?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes) {
                Application.Exit();
            }
        }
        #endregion
    }
}

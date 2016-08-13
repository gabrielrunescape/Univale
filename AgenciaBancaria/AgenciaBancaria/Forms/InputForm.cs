using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgenciaBancaria.Forms {
    public partial class InputForm : Form {
        public String inputText { get; set; } // Usado para passar e receber valores do textBox

        #region Construtores
        public InputForm(String Mensagem) {
            InitializeComponent();

            label.Text = Mensagem;
        }

        public InputForm(String Mensagem, String titulo) {
            InitializeComponent();

            label.Text = Mensagem;
            this.Text = titulo;
        }
        #endregion

        #region Metódos
        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            inputText = tbInput.Text;

            this.Close();
        }
        #endregion
    }
}

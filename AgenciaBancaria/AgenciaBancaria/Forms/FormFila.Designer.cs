namespace AgenciaBancaria.Forms {
    partial class FormFila {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.upDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPagamento = new System.Windows.Forms.RadioButton();
            this.rbReceber = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entre com o número do caixa no qual será atendido: ";
            // 
            // upDown
            // 
            this.upDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.upDown.Location = new System.Drawing.Point(314, 12);
            this.upDown.Name = "upDown";
            this.upDown.Size = new System.Drawing.Size(48, 24);
            this.upDown.TabIndex = 1;
            this.upDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o número do documento a ser pago:";
            // 
            // rbPagamento
            // 
            this.rbPagamento.AutoSize = true;
            this.rbPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbPagamento.Location = new System.Drawing.Point(15, 81);
            this.rbPagamento.Name = "rbPagamento";
            this.rbPagamento.Size = new System.Drawing.Size(89, 19);
            this.rbPagamento.TabIndex = 3;
            this.rbPagamento.TabStop = true;
            this.rbPagamento.Text = "Pagamento";
            this.rbPagamento.UseVisualStyleBackColor = true;
            // 
            // rbReceber
            // 
            this.rbReceber.AutoSize = true;
            this.rbReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbReceber.Location = new System.Drawing.Point(249, 81);
            this.rbReceber.Name = "rbReceber";
            this.rbReceber.Size = new System.Drawing.Size(113, 19);
            this.rbReceber.TabIndex = 4;
            this.rbReceber.TabStop = true;
            this.rbReceber.Text = "Receber / Sacar";
            this.rbReceber.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Escolha a operação a ser feita:";
            // 
            // tbDocumento
            // 
            this.tbDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbDocumento.Location = new System.Drawing.Point(15, 142);
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.Size = new System.Drawing.Size(347, 24);
            this.tbDocumento.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Digite o valor a ser pago do documento:";
            // 
            // tbValor
            // 
            this.tbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbValor.Location = new System.Drawing.Point(15, 206);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(221, 24);
            this.tbValor.TabIndex = 8;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnFinalizar.Location = new System.Drawing.Point(249, 184);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(113, 47);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // FormFila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(377, 248);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbReceber);
            this.Controls.Add(this.rbPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.upDown);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recepção Fila";
            ((System.ComponentModel.ISupportInitialize)(this.upDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown upDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPagamento;
        private System.Windows.Forms.RadioButton rbReceber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button btnFinalizar;
    }
}
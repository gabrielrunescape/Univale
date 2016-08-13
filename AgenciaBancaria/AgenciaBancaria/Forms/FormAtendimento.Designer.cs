namespace AgenciaBancaria.Forms {
    partial class FormAtendimento {
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
            this.labelDoc = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTroco = new System.Windows.Forms.Label();
            this.tbPagamento = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnDispensar = new System.Windows.Forms.Button();
            this.labelTrans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDoc
            // 
            this.labelDoc.AutoSize = true;
            this.labelDoc.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.labelDoc.Location = new System.Drawing.Point(12, 52);
            this.labelDoc.Name = "labelDoc";
            this.labelDoc.Size = new System.Drawing.Size(242, 30);
            this.labelDoc.TabIndex = 0;
            this.labelDoc.Text = "Número do documento: ";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.labelValor.Location = new System.Drawing.Point(14, 102);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(243, 30);
            this.labelValor.TabIndex = 1;
            this.labelValor.Text = "Valor do documento: R$ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pagamento: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Troco: ";
            // 
            // labelTroco
            // 
            this.labelTroco.AutoSize = true;
            this.labelTroco.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.labelTroco.ForeColor = System.Drawing.Color.Red;
            this.labelTroco.Location = new System.Drawing.Point(93, 218);
            this.labelTroco.Name = "labelTroco";
            this.labelTroco.Size = new System.Drawing.Size(53, 37);
            this.labelTroco.TabIndex = 4;
            this.labelTroco.Text = "R$ ";
            // 
            // tbPagamento
            // 
            this.tbPagamento.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.tbPagamento.Location = new System.Drawing.Point(148, 155);
            this.tbPagamento.Name = "tbPagamento";
            this.tbPagamento.Size = new System.Drawing.Size(336, 39);
            this.tbPagamento.TabIndex = 5;
            this.tbPagamento.TextChanged += new System.EventHandler(this.tbPagamento_TextChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(322, 275);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(162, 55);
            this.btnPagar.TabIndex = 6;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnDispensar
            // 
            this.btnDispensar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDispensar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispensar.Location = new System.Drawing.Point(148, 275);
            this.btnDispensar.Name = "btnDispensar";
            this.btnDispensar.Size = new System.Drawing.Size(162, 55);
            this.btnDispensar.TabIndex = 7;
            this.btnDispensar.Text = "Dispensar";
            this.btnDispensar.UseVisualStyleBackColor = true;
            this.btnDispensar.Click += new System.EventHandler(this.btnDispensar_Click);
            // 
            // labelTrans
            // 
            this.labelTrans.AutoSize = true;
            this.labelTrans.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.labelTrans.Location = new System.Drawing.Point(12, 9);
            this.labelTrans.Name = "labelTrans";
            this.labelTrans.Size = new System.Drawing.Size(115, 30);
            this.labelTrans.TabIndex = 8;
            this.labelTrans.Text = "Operação: ";
            // 
            // FormAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(496, 342);
            this.Controls.Add(this.labelTrans);
            this.Controls.Add(this.btnDispensar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.tbPagamento);
            this.Controls.Add(this.labelTroco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Atendimento de caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDoc;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTroco;
        private System.Windows.Forms.TextBox tbPagamento;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnDispensar;
        private System.Windows.Forms.Label labelTrans;
    }
}
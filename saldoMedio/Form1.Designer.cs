namespace saldoMedio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSaldoM = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnCredito = new System.Windows.Forms.Button();
            this.lblCredito = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSaldoM
            // 
            this.lblSaldoM.AutoSize = true;
            this.lblSaldoM.Location = new System.Drawing.Point(12, 27);
            this.lblSaldoM.Name = "lblSaldoM";
            this.lblSaldoM.Size = new System.Drawing.Size(57, 25);
            this.lblSaldoM.TabIndex = 0;
            this.lblSaldoM.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(90, 27);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(123, 31);
            this.txtSaldo.TabIndex = 1;
            // 
            // btnCredito
            // 
            this.btnCredito.Location = new System.Drawing.Point(12, 109);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(228, 34);
            this.btnCredito.TabIndex = 4;
            this.btnCredito.Text = "Crédito";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(21, 170);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(59, 25);
            this.lblCredito.TabIndex = 5;
            this.lblCredito.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 209);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldoM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSaldoM;
        private TextBox txtSaldo;
        private Button btnCredito;
        private Label lblCredito;
    }
}
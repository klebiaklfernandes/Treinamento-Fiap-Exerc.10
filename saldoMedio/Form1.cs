namespace saldoMedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnCredito_Click(object sender, EventArgs e)
        {
            double saldo, credito;

           


            if (double.TryParse(txtSaldo.Text, out saldo) == false)
            {
                MessageBox.Show($"Digite um número válido!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSaldo.Clear();
                txtSaldo.Focus();
                lblCredito.Text = ""; //limpa a label
            }
            if (saldo <= 200)
            {
                credito = 0;
            }
            else if (saldo <= 400)
            {
                credito = saldo * 0.2;
            }
            else if (saldo <= 600)
            {
                credito = saldo * 0.3;
            }
            else
            {
                credito = saldo * 0.4;
            }
            lblCredito.Text = $"O crédito é de: R${credito.ToString("0.00")}";
        }
    }
}
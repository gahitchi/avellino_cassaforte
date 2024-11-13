namespace cassaforte
{
    public partial class Form1 : Form
    {
        Cassaforte cassaforte;

        public Form1()
        {
            InitializeComponent();
        }

        private void TBcodiceUtente_TextChanged(object sender, EventArgs e)
        {
            if (TBcodiceUtente.Text.Length <= 5)
            {
                cassaforte.CodiceUtente = TBcodiceUtente.ToString();
            }
            else
            {
                MessageBox.Show("lunghezza massima consentita superata");
                TBcodiceUtente.Text = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cassaforte = new Cassaforte("cassaforte4", "safe casseforti", "cassaforte ultrasafe", "123456789101112");
        }

        private void TBcodiceAccesso_TextChanged(object sender, EventArgs e)
        {
            cassaforte.CodiceAccesso = TBcodiceAccesso.ToString();

            else if (TBcodiceAccesso.Text.Length > 5)
            {
                MessageBox.Show("lunghezza massima consentita superata");
                TBcodiceAccesso.Text = null;
            }
            if (TBcodiceAccesso.Text.Length == 5)
            {
                cassaforte.sblocca(cassaforte.CodiceAccesso, cassaforte.CodiceUtente);
            }
            if (TBcodiceAccesso.Text == cassaforte.CodiceSegreto) 
            {
                MessageBox.Show("cassaforte sbloccata");
            }
        }
    }
}

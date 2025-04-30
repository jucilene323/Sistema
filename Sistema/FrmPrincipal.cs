using System.Threading;

namespace Sistema
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            //Cria uma thread para rodar o form splash
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            t.Interrupt();
            CloseForm();
            InitializeComponent();
        }
        public void StartForm()
        {
            Application.Run(new FrmSplashScreen());
        }
        public void CloseForm()
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.ShowDialog();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresas empresas = new FrmEmpresas();
            empresas.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos produtos = new FrmProdutos();
            produtos.ShowDialog();
        }
    }
}

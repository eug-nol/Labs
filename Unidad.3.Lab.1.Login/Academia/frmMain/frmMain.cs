using Academia;

namespace frmMain
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            frmLogin appLogin = new frmLogin();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }

        }
    }
}

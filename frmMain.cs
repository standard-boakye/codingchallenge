namespace CodingChallenge
{
    public partial class frmMain : Form
    {
        private short iFormLoaded;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnufarmers_Click(object sender, EventArgs e)
        {

            mnufarmers.ForeColor = Color.Green;

            frmFarmers frmfarmers = new frmFarmers();
            iFormLoaded = FormState(frmfarmers);
            if (iFormLoaded == 0)
            {
                frmfarmers.MdiParent = this;
                frmfarmers.Show();
            }
        }








        private short FormState(Form frmForm)
        {
            short iMode, iState;

            iMode = 0;
            foreach (Form objForm in this.MdiChildren)
            {
                if (objForm.Name == frmForm.Name)
                {
                    iMode = 1;
                    break;
                }
            }
            iState = iMode;
            return iState;
        }

 






    }
}
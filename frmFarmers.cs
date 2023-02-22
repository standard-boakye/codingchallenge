using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingChallenge
{
    public partial class frmFarmers : Form
    {
        public frmFarmers()
        {
            InitializeComponent();
        }

        private void frmFarmers_Load(object sender, EventArgs e)
        {
            rbtnMale.Checked= true;
            cboRegion.Items.AddRange(new object[] { "Western Region", "Greater Accra Region", "Eastern Region", "Ashanti Region" });
            this.tbcntlFarmers.SelectTab(tbpgPersonalDetails);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (TextBox txtbx in this.tbpgPersonalDetails.Controls.OfType<TextBox>())
            {
                txtbx.Text = string.Empty;
            }
            cboRegion.Text = string.Empty;
            dtDateOfBirth.Text = DateTime.Today.ToString("yyyy-MM-dd");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtName.Text == string.Empty)
            {
                errorProvider.SetError(txtName, "Sorry this field cannot be empty, please enter name");
                okProvider.SetError(txtName, string.Empty);
                return;
            }
            else 
            {
                errorProvider.SetError(txtName, string.Empty);
                okProvider.SetError(txtName, "name field not empty");
            }

            if (txtLastName.Text == string.Empty)
            {
                errorProvider.SetError(txtLastName, "Sorry this field cannot be empty, please enter last name");
                okProvider.SetError(txtLastName, string.Empty);
                return;
            }
            else 
            {
                errorProvider.SetError(txtLastName, string.Empty);
                okProvider.SetError(txtLastName, "last name field not empty");
            }


            if (txtBirthPlace.Text == string.Empty)
            {
                errorProvider.SetError(txtLastName, "Sorry this field cannot be empty, please enter last name");
                okProvider.SetError(txtLastName, string.Empty);
                return;
            }
            else
            {
                errorProvider.SetError(txtLastName, string.Empty);
                okProvider.SetError(txtLastName, "last name field not empty");
            }



            if (dtDateOfBirth.Value.ToString("yyyy-MM-dd") == DateTime.Today.ToString("yyyy-MM-dd"))
            {
                errorProvider.SetError(dtDateOfBirth, "Sorry date of birth cannot be the same as today, please select date of birth");
                okProvider.SetError(dtDateOfBirth, string.Empty);
            }
            else
            {
                errorProvider.SetError(dtDateOfBirth, string.Empty);
                okProvider.SetError(dtDateOfBirth, "date of birth not today");
            }

            if (txtHouseNumber.Text == string.Empty)
            {
                errorProvider.SetError(txtHouseNumber, "Sorry this field cannot be empty, please enter house number");
                okProvider.SetError(txtHouseNumber, string.Empty);
                return;
            }
            else
            {
                errorProvider.SetError(txtHouseNumber, string.Empty);
                okProvider.SetError(txtHouseNumber, "house number field not empty");
            }

            if (txtCommunity.Text == string.Empty)
            {
                errorProvider.SetError(txtCommunity, "Sorry this field cannot be empty, please enter community");
                okProvider.SetError(txtCommunity, string.Empty);
                return;
            }
            else
            {
                errorProvider.SetError(txtCommunity, string.Empty);
                okProvider.SetError(txtCommunity, "community field not empty");
            }

            if (txtOccupation.Text == string.Empty)
            {
                errorProvider.SetError(txtOccupation, "Sorry this field cannot be empty, please enter occupation");
                okProvider.SetError(txtOccupation, string.Empty);
                return;
            }
            else
            {
                errorProvider.SetError(txtOccupation, string.Empty);
                okProvider.SetError(txtOccupation, "occupation field not empty");
            }


            if (txtDistrict.Text == string.Empty)
            {
                errorProvider.SetError(txtDistrict, "Sorry this field cannot be empty, please enter district");
                okProvider.SetError(txtDistrict, string.Empty);
                return;
            }
            else
            {
                errorProvider.SetError(txtDistrict, string.Empty);
                okProvider.SetError(txtDistrict, "distict field not empty");
            }


            if (cboRegion.Text == string.Empty)
            {
                errorProvider.SetError(cboRegion, "Sorry this field cannot be empty, please select the region");
                okProvider.SetError(cboRegion, string.Empty);
            }
            else
            {
                errorProvider.SetError(cboRegion, string.Empty);
                okProvider.SetError(cboRegion, "region selected");
            }

            if (txtMaritalStatus.Text == string.Empty)
            {
                errorProvider.SetError(txtMaritalStatus, "Sorry this field cannot be empty, please enter marital status");
                okProvider.SetError(txtMaritalStatus, string.Empty);
                return;
            }
            else
            {
                errorProvider.SetError(txtMaritalStatus, string.Empty);
                okProvider.SetError(txtMaritalStatus, "Marital Status field not empty");
            }

            //Once fields are validated successfully POST data to the downstream DATA STORE 


        }

        private void lblUploadPhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OpenFileDialog fldPictureFiles = new OpenFileDialog();

                fldPictureFiles.Reset();
                fldPictureFiles.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                fldPictureFiles.CheckFileExists = true;
                fldPictureFiles.CheckPathExists = true;

                fldPictureFiles.Title = "Please select photo";
                fldPictureFiles.Filter = "All Pictures (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.gif)|*.gif|(*.bmp)|*.bmp";
                fldPictureFiles.Multiselect = false;
                fldPictureFiles.RestoreDirectory = true;
                fldPictureFiles.ValidateNames = true;

                //if (fldPictureFiles.ShowDialog() == DialogResult.OK) ;
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTakePhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please grant permission to access camera", "Camera Access", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }




    }
}

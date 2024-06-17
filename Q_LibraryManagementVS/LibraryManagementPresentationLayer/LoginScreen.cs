using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementBackEndLayer;

namespace LibraryManagementPresentationLayer
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        public static clsAdmin CurrentAdmin = new clsAdmin();



        void IsTextsEmpty(object sender, EventArgs e)
        {
            
            btnLogin.Enabled = (txtUserName.Text == "" || txtPassword.Text == "") ? false : true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!clsAdmin.CheckLogin(txtUserName.Text,txtPassword.Text))
            {
                MessageBox.Show("اسم المستخدم او كلمة المرور خاطئة !", "فشل تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            //CurrentAdmin = clsAdmin.GetAdminObjectByUserNameAndPassword(txtUserName.Text, txtPassword.Text);


        }
    }
}

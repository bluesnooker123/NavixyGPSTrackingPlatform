using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RestSharp;

namespace Navixy
{
    public partial class Start : MetroFramework.Forms.MetroForm
    {
        public Start()
        {
            InitializeComponent();

            this.BringToFront();
            this.login_user.Select();
            this.Select();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(login_user.Text))
            {
                MessageBox.Show("Please enter your username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MetroFramework.MetroMessageBox.Show(this, "Please enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                login_user.Focus();
                return;
            }
            if (string.IsNullOrEmpty(login_password.Text))
            {
                MessageBox.Show("Please enter your password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                login_password.Focus();
                return;
            }
            try
            {
                string send_str = "https://api.navixy.com/v2/user/auth?login=" + login_user.Text + "&password=" + login_password.Text;
                //var client = new RestClient("https://api.navixy.com/v2/user/auth?login=tm@thingsmobile.com&password=thingsmobile");
                var client = new RestClient(send_str);
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);


                string[] temp = response.Content.Split(',');
                if (temp[0] == "{\"success\":false")
                {
                    MessageBox.Show("Your username and password don't match", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    login_password.Text = "";
                    this.login_password.Select();
                }
                else
                {
                    using (frmMain frm = new frmMain())
                    {
                        this.Hide();
                        frm.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Start_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
        }
    }
}

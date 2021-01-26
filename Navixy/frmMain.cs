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
using Newtonsoft.Json;

namespace Navixy
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            using (frmLogin frm = new frmLogin())
            {
                this.Hide();
                frm.ShowDialog();
                Show_Data(frm.m_hash);
            }
            //this.Focus();
            //MessageBox.Show(this.ToString());
            //this.BringToFront();
            //this.Select();

        }
        private void Show_Data(string val_hash)
        {
            try
            {
                string send_str = "https://api.eu.navixy.com/v2/tracker/list?hash=" + val_hash;
                //var client = new RestClient("https://api.eu.navixy.com/v2/tracker/list?hash=9db6f021f1edbe63fa8775bdf7b230d7");
                var client = new RestClient(send_str);
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);

                string[] temp = response.Content.Split(',');
                if (temp[0] == "{\"success\":false")
                {
                    MessageBox.Show("Can not load data with your hash value", "Load data failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    response_data_form val_response = JsonConvert.DeserializeObject<response_data_form>(response.Content);
                    MessageBox.Show(val_response.list[1].source.model);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

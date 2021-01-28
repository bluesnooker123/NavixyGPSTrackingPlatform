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
using BrightIdeasSoftware;

namespace Navixy
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public string m_hash;
        response_data_form m_response;
        public string filePath = @"db.csv";
        public StringBuilder m_data;
        public frmMain()
        {
            InitializeComponent();

            this.FormClosing += frmMain_Closing;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            using (frmLogin frm = new frmLogin())
            {
                this.Hide();
                frm.ShowDialog();
                m_hash = frm.m_hash;
            }
            //btn_start.BringToFront();
            //btn_start.Select();
            //this.WindowState = FormWindowState.Minimized;
            //this.WindowState = FormWindowState.Normal;



            //MessageBox.Show(this.OwnedForms[0].ToString());
            //this.Activate();
            //            this.Activate();
            //MessageBox.Show(this.ToString());
            //this.BringToFront();
            //this.Select();

        }
        private void Load_Data(string val_hash)
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
                    m_response = JsonConvert.DeserializeObject<response_data_form>(response.Content);
                    //MessageBox.Show(val_response.list[1].source.model);
                    Save_Data();
                    Show_Data();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Save_Data()
        {
            string[] org_lines = { };
            if (System.IO.File.Exists(filePath))
                org_lines = System.IO.File.ReadAllLines(filePath);

            StringBuilder temp_stringArray1 = new StringBuilder();
            var lines_without_header = org_lines.AsEnumerable().Skip(1);
            foreach (string line in lines_without_header.ToArray())
                temp_stringArray1.AppendLine(line);

            DateTime cur_datetime = DateTime.Now;
            //foreach (string line in sorted.ToArray())
            //{
            //    string[] temp_arr = line.Split(',').ToArray();
            //    string temp_month_1 = cur_datetime.Year.ToString() + " " + cur_datetime.ToString("MMM");
            //    string temp_month_2 = DateTime.Parse(temp_arr[2]).Year.ToString() + " " + DateTime.Parse(temp_arr[2]).ToString("MMM");

            //}
            string single_line = "";
            for (int i = 0; i < m_response.list.Count; i++)
            {
                single_line = m_response.list[i].source.device_id + "," + m_response.list[i].source.phone + "," + cur_datetime.ToString() + "," + m_response.list[i].source.blocked + "," + "false";
                temp_stringArray1.AppendLine(single_line);
            }

            
            string seperater = "\r\n";
            string[] merged_str_array = temp_stringArray1.ToString().Split(seperater.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            //MessageBox.Show(merged_str_array[0].Split(',')[0]);

            var sorted = merged_str_array.AsEnumerable().Select(line => new
            {
                SortKey_IMEI = line.Split(',')[0],
                SortKey_date = DateTime.Parse(line.Split(',')[2]),
                Line = line
            })
            .OrderBy(x => x.SortKey_IMEI)
            .ThenBy(x => x.SortKey_date)
            .Select(x => x.Line);

            StringBuilder result_str = new StringBuilder();
            result_str = Remove_Duplicated_Month(sorted.ToArray());

            System.IO.File.WriteAllText(filePath, result_str.ToString());
            MessageBox.Show("Save to \"" + filePath + "\" successfully!", "success");

            m_data = result_str;
        }
        private StringBuilder Remove_Duplicated_Month(string[] lines)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("IMEI,Phone Number,Modified Date,Blocked,SIM Block");
            for (int i = 0; i < lines.Length-1; i++)
            {
                if (!((lines[i].Split(',')[0] == lines[i + 1].Split(',')[0]) &&
                    (DateTime.Parse(lines[i].Split(',')[2]).Month == DateTime.Parse(lines[i + 1].Split(',')[2]).Month)))
                {
                    result.AppendLine(lines[i]);
                }
            }
            result.AppendLine(lines[lines.Length-1]);
            return result;
        }
        private void Show_Data()
        {
            string seperater = "\r\n";
            string[] str_array = m_data.ToString().Split(seperater.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            MessageBox.Show(str_array.Length.ToString());
            int i = 0;
            foreach (string line in str_array.AsEnumerable().Skip(1).ToArray())
            {
                objectListView1.AddObject(new { aspect_IMEI = line.Split(',')[0], aspect_Phone = line.Split(',')[1], aspect_Feb = "", aspect_Mar = "", aspect_Apr = "", aspect_May = "", aspect_Jun = "", aspect_J = "", aspect_Jul = "", aspect_Aug = "", aspect_Sep = "", aspect_Oct = "", aspect_Nov = "", aspect_Dec = "", aspect_Blocked = line.Split(',')[3], aspect_SIM_Block = line.Split(',')[4] });

                //i++;
                //if (i > 5)
                //    break;
            }
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            Load_Data(m_hash);
        }
        private void frmMain_Closing(object sender, FormClosingEventArgs e)
        {
         //   MessageBox.Show(e.CloseReason.ToString());
            if (e.CloseReason == CloseReason.FormOwnerClosing)  //for Shadow Form
            {
                e.Cancel = true;
            }
            //if (this.m_hash == null)
            //    System.Windows.Forms.Application.Exit();
        }

    }
}

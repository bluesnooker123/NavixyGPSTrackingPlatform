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
using XPTable;
using XPTable.Models;

namespace Navixy
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public string m_hash;
        response_data_form m_response;
        public string filePath = @"db.csv";
        public StringBuilder m_data;

        //private PropertyGrid rowStylePropertyGrid;
        //private PropertyGrid cellStylePropertyGrid;
        //private XPTable.Models.RowStyle rowStyle;
        //private CellStyle cellStyle;

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

            Initialize_Table();
            
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
        private void Initialize_Table()
        {
            this.table.BeginUpdate();

            NumberColumn column0 = new NumberColumn("#", 50);
            TextColumn column1 = new TextColumn("IMEI",160);
            TextColumn column2 = new TextColumn("PHONE",160);
            ColorColumn column3 = new ColorColumn("Jan", 23);
            ColorColumn column4 = new ColorColumn("Feb", 23);
            ColorColumn column5 = new ColorColumn("Mar", 23);
            ColorColumn column6 = new ColorColumn("Apr", 23);
            ColorColumn column7 = new ColorColumn("May", 23);
            ColorColumn column8 = new ColorColumn("Jun", 23);
            ColorColumn column9 = new ColorColumn("Jul", 23);
            ColorColumn column10 = new ColorColumn("Aug", 23);
            ColorColumn column11 = new ColorColumn("Sep", 23);
            ColorColumn column12 = new ColorColumn("Oct", 23);
            ColorColumn column13 = new ColorColumn("Nov", 23);
            ColorColumn column14 = new ColorColumn("Dec", 23);
            TextColumn column15 = new TextColumn("BLOCKED", 130);
            CheckBoxColumn column16 = new CheckBoxColumn("SIM BLOCK", 130);

            column0.Alignment = ColumnAlignment.Center;
            column1.Alignment = ColumnAlignment.Center;
            column2.Alignment = ColumnAlignment.Center;
            column3.Alignment = ColumnAlignment.Center;
            column4.Alignment = ColumnAlignment.Center;
            column5.Alignment = ColumnAlignment.Center;
            column6.Alignment = ColumnAlignment.Center;
            column7.Alignment = ColumnAlignment.Center;
            column8.Alignment = ColumnAlignment.Center;
            column9.Alignment = ColumnAlignment.Center;
            column10.Alignment = ColumnAlignment.Center;
            column11.Alignment = ColumnAlignment.Center;
            column12.Alignment = ColumnAlignment.Center;
            column13.Alignment = ColumnAlignment.Center;
            column14.Alignment = ColumnAlignment.Center;
            column15.Alignment = ColumnAlignment.Center;
            column16.Alignment = ColumnAlignment.Center;

            column3.ShowColorName = false;
            column3.ShowDropDownButton = false;
            column3.Sortable = false;
            column4.ShowColorName = false;
            column4.ShowDropDownButton = false;
            column4.Sortable = false;
            column5.ShowColorName = false;
            column5.ShowDropDownButton = false;
            column5.Sortable = false;
            column6.ShowColorName = false;
            column6.ShowDropDownButton = false;
            column6.Sortable = false;
            column7.ShowColorName = false;
            column7.ShowDropDownButton = false;
            column7.Sortable = false;
            column8.ShowColorName = false;
            column8.ShowDropDownButton = false;
            column8.Sortable = false;
            column9.ShowColorName = false;
            column9.ShowDropDownButton = false;
            column9.Sortable = false;
            column10.ShowColorName = false;
            column10.ShowDropDownButton = false;
            column10.Sortable = false;
            column11.ShowColorName = false;
            column11.ShowDropDownButton = false;
            column11.Sortable = false;
            column12.ShowColorName = false;
            column12.ShowDropDownButton = false;
            column12.Sortable = false;
            column13.ShowColorName = false;
            column13.ShowDropDownButton = false;
            column13.Sortable = false;
            column14.ShowColorName = false;
            column14.ShowDropDownButton = false;
            column14.Sortable = false;

            column15.Sortable = false;
            //column16.Alignment = ce;
            




            this.columnModel.Columns.AddRange(new Column[] { column0, column1, column2, column3, column4, column5, column6, column7, column8, column9, column10, column11, column12, column13, column14 ,column15, column16});


            //this.rowStyle = new XPTable.Models.RowStyle();
            //this.rowStyle.BackColor = Color.FromArgb(192, Color.LightBlue);
            //this.rowStyle.ForeColor = Color.Red;
            //this.rowStyle.Font = new Font("Times New Roman", 9.25f, FontStyle.Italic);

            this.table.EndUpdate();

            //this.rowStylePropertyGrid.SelectedObject = this.rowStyle;
            //this.cellStylePropertyGrid.SelectedObject = this.cellStyle;

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
            string single_line = "";
            for (int i = 0; i < m_response.list.Count; i++)
            {
                single_line = m_response.list[i].source.device_id + "," + m_response.list[i].source.phone + "," + cur_datetime.ToString() + "," + m_response.list[i].source.blocked + "," + "false";
                temp_stringArray1.AppendLine(single_line);
            }

            
            string seperater = "\r\n";
            string[] merged_str_array = temp_stringArray1.ToString().Split(seperater.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

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

            //List<Row> table_data;

            int i = 1;
            foreach (string line in str_array.AsEnumerable().Skip(1).ToArray())
            {
                row_data te = new row_data();
                te.v_IMEI = line.Split(',')[0];
                te.v_PHONE = line.Split(',')[1];
                te.v_Jan = Color.Red;
                te.v_Feb = Color.Green;
                te.v_Mar = Color.Red;
                te.v_Apr = Color.Red;
                te.v_May = Color.Red;
                te.v_Jun = Color.Red;
                te.v_Jul = Color.Red;
                te.v_Aug = Color.Red;
                te.v_Sep = Color.Green;
                te.v_Oct = Color.Red;
                te.v_Nov = Color.Red;
                te.v_Dec = Color.Red;
                te.v_BLOCKED = "Mar 2021";
                te.v_SIM_BLOCK = true;
                //Row temp = new Row(new Cell[] { new Cell(i), new Cell(line.Split(',')[0]), new Cell(line.Split(',')[1]) , new Cell(Color.Red), new Cell(Color.Green), new Cell(Color.Red), new Cell(Color.Green), new Cell(Color.Red), new Cell(Color.Green), new Cell(Color.Red), new Cell(Color.Green), new Cell(Color.Red), new Cell(Color.Green), new Cell(Color.Red), new Cell(Color.Green) });

                CellStyle checkbox_cellstyle = new CellStyle();
                checkbox_cellstyle.Padding = new CellPadding(60, 0, 0, 0);
                Row temp = new Row(new Cell[] { new Cell(i), new Cell(te.v_IMEI), new Cell(te.v_PHONE), new Cell(te.v_Jan), new Cell(te.v_Feb), new Cell(te.v_Mar), new Cell(te.v_Apr), new Cell(te.v_May), new Cell(te.v_Jun), new Cell(te.v_Jul), new Cell(te.v_Aug), new Cell(te.v_Sep), new Cell(te.v_Oct), new Cell(te.v_Nov), new Cell(te.v_Dec) ,new Cell(te.v_BLOCKED), new Cell(te.v_SIM_BLOCK, checkbox_cellstyle)});
                this.table.TableModel.Rows.Add(temp);
                //table_data.Add(temp);
                //objectListView1.AddObject(new { aspect_IMEI = line.Split(',')[0], aspect_Phone = line.Split(',')[1], aspect_Feb = "", aspect_Mar = "", aspect_Apr = "", aspect_May = "", aspect_Jun = "", aspect_J = "", aspect_Jul = "", aspect_Aug = "", aspect_Sep = "", aspect_Oct = "", aspect_Nov = "", aspect_Dec = "", aspect_Blocked = line.Split(',')[3], aspect_SIM_Block = line.Split(',')[4] });

                i++;
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

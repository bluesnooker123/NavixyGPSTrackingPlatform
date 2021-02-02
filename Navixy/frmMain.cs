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
        public string m_user;
        public string m_hash;
        response_data_form m_response;
        public string filePath = @"DB\db.csv";
        public StringBuilder m_data;
        public List<row_data> m_data_list;
        public Dictionary<string, string> m_dict_IMEI_SIM;
        public bool flag_hide_show_SIM_status = false;  //true: hide  ,  false: show
        public List<Row> m_hiddenRows;

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
                m_user = frm.m_user;
                m_hash = frm.m_hash;
                filePath = @"DB\" + m_user + "_db.csv";
            }

            Initialize_Table();
            m_dict_IMEI_SIM = new Dictionary<string, string>();
            m_hiddenRows = new List<Row>();

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

            //column15.Sortable = false;
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
                    this.table.TableModel.Rows.Clear();
                    Save_Data();
                    Show_Data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Save_Data()    //save data to .csv file
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
                single_line = m_user + "," + m_response.list[i].source.device_id + "," + m_response.list[i].source.phone + "," + cur_datetime.ToString() + "," + m_response.list[i].source.blocked;
                temp_stringArray1.AppendLine(single_line);
            }

            
            string seperater = "\r\n";
            string[] merged_str_array = temp_stringArray1.ToString().Split(seperater.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            var sorted = merged_str_array.AsEnumerable().Select(line => new
            {
                SortKey_IMEI = line.Split(',')[1],
                SortKey_date = DateTime.Parse(line.Split(',')[3]),
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
            result.AppendLine("User Name,IMEI,Phone Number,Modified Date,Blocked");
            for (int i = 0; i < lines.Length-1; i++)
            {
                if (!((lines[i].Split(',')[1] == lines[i + 1].Split(',')[1]) &&
                    (DateTime.Parse(lines[i].Split(',')[3]).Month == DateTime.Parse(lines[i + 1].Split(',')[3]).Month)))
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

            //MessageBox.Show(str_array.Length.ToString());

            int data_list_index = -1;
            var data_list = new List<row_data>();
            var unique_list = new List<string>();
            bool flag_is_blocked = false;
            foreach (string line in str_array.AsEnumerable().Skip(1).ToArray())
            {
                if (DateTime.Parse(line.Split(',')[3]).Year != DateTime.Now.Year)       //Only Get Current Year's data from .csv file
                    continue;
                string str_IMEI = line.Split(',')[1];
                if(!unique_list.Contains(str_IMEI))
                {
                    flag_is_blocked = false;
                    row_data te = new row_data();
                    te.v_IMEI = line.Split(',')[1];
                    te.v_PHONE = line.Split(',')[2];

                    te = Set_Blocked_Color(te, DateTime.Parse(line.Split(',')[3]).Month, line.Split(',')[4]);
                    if ((line.Split(',')[4] == "True") || (line.Split(',')[4] == "TRUE"))
                    {
                        te.v_BLOCKED = DateTime.Parse(line.Split(',')[3]).ToString("MMM yyyy");
                        flag_is_blocked = true;
                    }

                    te.v_SIM_BLOCK = (m_dict_IMEI_SIM.FirstOrDefault(x => x.Key == te.v_IMEI).Value == "True") ? true : false; 

                    data_list_index++;
                    data_list.Add(te);
                    unique_list.Add(str_IMEI);
                    
                }
                else
                {
                    data_list[data_list_index] = Set_Blocked_Color(data_list[data_list_index], DateTime.Parse(line.Split(',')[3]).Month, line.Split(',')[4]);
                    if(!flag_is_blocked)
                        if ((line.Split(',')[4] == "True") || (line.Split(',')[4] == "TRUE"))
                            data_list[data_list_index].v_BLOCKED = DateTime.Parse(line.Split(',')[3]).ToString("MMM yyyy");
                }
            }

            CellStyle checkbox_cellstyle = new CellStyle();
            checkbox_cellstyle.Padding = new CellPadding(60, 0, 0, 0);
            int i = 1;
            foreach (row_data row in data_list)
            {
                Row temp = new Row(new Cell[] { new Cell(i++), new Cell(row.v_IMEI), new Cell(row.v_PHONE), new Cell(row.v_Jan), new Cell(row.v_Feb), new Cell(row.v_Mar), new Cell(row.v_Apr), new Cell(row.v_May), new Cell(row.v_Jun), new Cell(row.v_Jul), new Cell(row.v_Aug), new Cell(row.v_Sep), new Cell(row.v_Oct), new Cell(row.v_Nov), new Cell(row.v_Dec), new Cell(row.v_BLOCKED), new Cell("",row.v_SIM_BLOCK, checkbox_cellstyle) });
                this.table.TableModel.Rows.Add(temp);
            }
            m_data_list = data_list;
        }
        private row_data Set_Blocked_Color(row_data org, int month, string blocked_status)
        {
            row_data te = org;

            switch (month)
            {
                case 1:
                    {
                        te.v_Jan = ((blocked_status == "True") || (blocked_status == "TRUE")) ? Color.Red : Color.Green;
                        break;
                    }
                case 2:
                    {
                        te.v_Feb = ((blocked_status == "True") || (blocked_status == "TRUE")) ? Color.Red : Color.Green;
                        break;
                    }
                case 3:
                    {
                        te.v_Mar = ((blocked_status == "True") || (blocked_status == "TRUE")) ? Color.Red : Color.Green;
                        break;
                    }
                case 4:
                    {
                        te.v_Apr = ((blocked_status == "True") || (blocked_status == "TRUE")) ? Color.Red : Color.Green;
                        break;
                    }
                case 5:
                    {
                        te.v_May = ((blocked_status == "True") || (blocked_status == "TRUE")) ? Color.Red : Color.Green;
                        break;
                    }
                case 6:
                    {
                        te.v_Jun = ((blocked_status == "True") || (blocked_status == "TRUE")) ? Color.Red : Color.Green;
                        break;
                    }
                case 7:
                    {
                        te.v_Jul = ((blocked_status == "True") || (blocked_status == "TRUE")) ? Color.Red : Color.Green;
                        break;
                    }
                case 8:
                    {
                        te.v_Aug = ((blocked_status == "True") || (blocked_status == "TRUE")) ? Color.Red : Color.Green;
                        break;
                    }
                case 9:
                    {
                        te.v_Sep = ((blocked_status == "True") || (blocked_status == "TRUE")) ? Color.Red : Color.Green;
                        break;
                    }
                case 10:
                    {
                        te.v_Oct = ((blocked_status == "True") || (blocked_status == "TRUE")) ? Color.Red : Color.Green;
                        break;
                    }
                case 11:
                    {
                        te.v_Nov = ((blocked_status == "True") || (blocked_status == "TRUE")) ? Color.Red : Color.Green;
                        break;
                    }
                case 12:
                    {
                        te.v_Dec = ((blocked_status == "True") || (blocked_status == "TRUE")) ? Color.Red : Color.Green;
                        break;
                    }
                default:
                    break;
            }

            return te;
        }
        private void Save_SIM_Data()
        {
            if(m_data_list == null)
            {
                MessageBox.Show("Please read data first", "No data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string filePath = @"DB\" + m_user + "_db_SIM.csv";
            StringBuilder result_str = new StringBuilder();
            result_str.AppendLine("User Name,IMEI,SIM BLOCK,Modified Date");
            
            DateTime cur_datetime = DateTime.Now;
            string single_line = "";

            //MessageBox.Show(this.table.TableModel.Rows);
            foreach (Row row in this.table.TableModel.Rows)
            {
                single_line = m_user + "," + row.Cells[1].Text + "," + row.Cells[16].Checked + "," + cur_datetime.ToString();
                result_str.AppendLine(single_line);
            }
            System.IO.File.WriteAllText(filePath, result_str.ToString());
            MessageBox.Show("Save to \"" + filePath + "\" successfully!", "success");

        }
        void Read_SIM_Data()   //read SIM BLOCK checked status from .csv file and set it to dictionary value ( m_dict_IMEI_SIM )
        {
            string filePath = @"DB\" + m_user + "_db_SIM.csv";
            if (!System.IO.File.Exists(filePath))
                return;
            string[] org_lines = { };
            org_lines = System.IO.File.ReadAllLines(filePath);

            
            for (int i = 0; i < org_lines.Length; i ++)
            {
                m_dict_IMEI_SIM.Add(org_lines[i].Split(',')[1], org_lines[i].Split(',')[2]);
            }
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            m_dict_IMEI_SIM.Clear();
            Read_SIM_Data();
            Load_Data(m_hash);
        }
        private void btn_save_SIM_Click(object sender, EventArgs e)
        {
            Save_SIM_Data();
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

        private void btn_hide_show_SIM_Click(object sender, EventArgs e)
        {
            if(flag_hide_show_SIM_status)   //true: hide => current status is 'hide' status
            {
                foreach (Row row in m_hiddenRows)
                {
                    this.table.TableModel.Rows.Add(row);
                }

                flag_hide_show_SIM_status = false;  //set current status to "show" status
                btn_hide_show_SIM.Text = "Hide Blocked SIM";
                this.table.Sort(0,SortOrder.Ascending);
            }
            else    //false: show => current status is 'show' status
            {
                if(m_hiddenRows.Count != 0)
                    m_hiddenRows.Clear();
                List < Row > temp_array = new List<Row>();
                foreach (Row row in this.table.TableModel.Rows)
                    temp_array.Add(row);
                foreach (Row row in temp_array)
                {
                    if (row.Cells[16].Checked == true)
                    {
                        m_hiddenRows.Add(row);
                        this.table.TableModel.Rows.Remove(row);
                    }
                }
                flag_hide_show_SIM_status = true;  //set current status to "hide" status
                btn_hide_show_SIM.Text = "Show Blocked SIM";
            }
            this.table.Invalidate();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navixy
{
    class response_data_list_source_form
    {
        public string id { get; set; }
        public string device_id { get; set; }
        public string model { get; set; }
        public bool blocked { get; set; }
        public string tariff_id { get; set; }
        public string phone { get; set; }
        public string status_listing_id { get; set; }
        public string creation_date { get; set; }
        public string tariff_end_date { get; set; }
    }
    class response_data_list_form
    {
        public string id { get; set; }
        public string label { get; set; }
        public string group_id { get; set; }
        public response_data_list_source_form source { get; set; }
        public List<string> tag_bindings { get; set; }
        public string clone { get; set; }

    }
    class response_data_form
    {
        public string success { get; set; }
        public List<response_data_list_form> list { get; set; }

    }
}

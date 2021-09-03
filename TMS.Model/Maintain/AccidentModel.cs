using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model.Maintain
{
    /// <summary>
    /// 事故记录
    /// </summary>
    public class AccidentModel
    {

        public int id            { get; set; }
        public string title         { get; set; }
        public string license_plate { get; set; }
        public string Incident      { get; set; }
        public DateTime accident_date { get; set; }
        public float compensation  { get; set; }
        public float net_loss      { get; set; }
        public string describe    { get; set; }
        public string direct        { get; set; }
        public string comment       { get; set; }
        public DateTime create_time { get; set; }

    }
}

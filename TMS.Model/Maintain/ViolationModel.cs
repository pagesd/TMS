using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model.Maintain
{
    /// <summary>
    /// 违章记录
    /// </summary>
    public class ViolationModel
    {

        public int id              { get; set; }
        public string title           { get; set; }
        public string license_plate   { get; set; }
        public string violation_name  { get; set; }
        public DateTime violation_date  { get; set; }
        public string violation_intro { get; set; }
        public string result          { get; set; }
        public string comment         { get; set; }
        public DateTime create_time     { get; set; }

    }
}

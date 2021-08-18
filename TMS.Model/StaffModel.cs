using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    /// <summary>
    /// 员工登记
    /// </summary>
    public class StaffModel
    {
        public int id            { get; set; }
        public string name          { get; set; }
        public bool sex           { get; set; }
        public string phone         { get; set; }
        public string academy       { get; set; }
        public string specialty     { get; set; }
        public string address       { get; set; }
        public string education     { get; set; }
        public string face          { get; set; }
        public string nation        { get; set; }
        public string native_place  { get; set; }
        public string marriage      { get; set; }
        public DateTime birthday      { get; set; }
        public string email         { get; set; }
        public string identity_card { get; set; }
        public int department    { get; set; }
        public int position      { get; set; }
        public int type { get; set; }
        public DateTime create_time { get; set; }
    }               
}

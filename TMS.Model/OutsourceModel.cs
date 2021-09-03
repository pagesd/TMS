using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    /// <summary>
    /// 基础  外协管理
    /// </summary>
    public class OutsourceModel
    {
        public int outsourceId   { get; set; }
        public string unit_Name     { get; set; }
        public string email         { get; set; }
        public string fixed_line    { get; set; }
        public string phone         { get; set; }
        public string site          { get; set; }
        public DateTime creation_time { get; set; }
        public string comment { get; set; }

    }
}

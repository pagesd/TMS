using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model.Maintain
{
    /// <summary>
    /// 轮胎使用记录
    /// </summary>
    public class TyreModel
    {

        public int id            { get; set; }
        public string license_plate { get; set; }
        public string brand         { get; set; }
        public string standard      { get; set; }
        public int number        { get; set; }
        public string user          { get; set; }
        public DateTime use_time      { get; set; }
        public string comment       { get; set; }
        public DateTime create_time   { get; set; }

    }
}

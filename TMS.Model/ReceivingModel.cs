using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    /// <summary>
    /// 物资领用
    /// </summary>
    public class ReceivingModel
    {
        public int id           { get; set; }
        public string name         { get; set; }
        public string useis        { get; set; }
        public string comment      { get; set; }
        public string select       { get; set; }
        public string recipient    { get; set; }
        public DateTime receive_time { get; set; }
        public DateTime create_time  { get; set; }
        public int state        { get; set; }
        public string approver     { get; set; }


    }
}

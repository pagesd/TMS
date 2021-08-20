using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    /// <summary>
    /// 通用合同管理
    /// </summary>
    public class UniversalModel
    {

        public int id             { get; set; }
        public string contracId      { get; set; }
        public string name           { get; set; }
        public string unit           { get; set; }
        public string principal      { get; set; }
        public int category       { get; set; }
        public DateTime signed_time    { get; set; }
        public string agent          { get; set; }
        public float contract_money { get; set; }
        public string contract_intro { get; set; }
        public string clause         { get; set; }
        public string contract_text  { get; set; }
        public DateTime creation_time  { get; set; }
        public int state          { get; set; }
        public string approver { get; set; }

    }
}

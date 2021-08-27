using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    public class ReceivableModel
    {

        public int id            { get; set; }
        public string odd           { get; set; }
        public string unit          { get; set; }
        public int way           { get; set; }
        public int tonnage       { get; set; }
        public float price         { get; set; }
        public float money         { get; set; }
        public DateTime business_time { get; set; }
        public string agent         { get; set; }
        public string comment       { get; set; }
        public string collator      { get; set; }
        public DateTime proof_time    { get; set; }
        public DateTime create_time   { get; set; }
        public int state { get; set; }


    }
}

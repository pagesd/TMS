using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    public class CarriagecontractModel
    {
        public int id               { get; set; }
        public string contractId       { get; set; }
        public string Name             { get; set; }
        public string unit             { get; set; }
        public string principal        { get; set; }
        public string path             { get; set; }
        public float price            { get; set; }
        public int full_price       { get; set; }
        public int full_money       { get; set; }
        public DateTime Signing_time     { get; set; }
        public string agent            { get; set; }
        public DateTime creation_time    { get; set; }
        public int state            { get; set; }
        public string approval         { get; set; }
        public float contract_time    { get; set; }
        public string contract_explain { get; set; }
        public string contract_clause { get; set; }
        public string contract_text { get; set; }
        public int zt { get; set; }
    }                
}

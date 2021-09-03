using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    public class ShipperModel
    {

        public int shipperId     { get; set; }
        public string name          { get; set; }
        public string phone         { get; set; }
        public string unitName      { get; set; }
        public string Address       { get; set; }
        public DateTime valid_time    { get; set; }
        public string valid_image   { get; set; }
        public string comment       { get; set; }
        public DateTime creation_time { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model.Maintain
{
    public class MaintainModel
    {

        public int id            { get; set; }
        public string Name          { get; set; }
        public string type          { get; set; }
        public string license_plate { get; set; }
        public float money         { get; set; }
        public string principal     { get; set; }
        public string describe    { get; set; }
        public DateTime maintain_time { get; set; }
        public string comment       { get; set; }
        public DateTime create_time   { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model.Maintain
{
    public class UpkeepModel
    {

        public int id               { get; set; }
        public string name             { get; set; }
        public string license_plate    { get; set; }
        public float money            { get; set; }
        public string principal        { get; set; }
        public int mileage          { get; set; }
        public DateTime maintain_time    { get; set; }
        public int maintain_mileage { get; set; }
        public DateTime new_mileage      { get; set; }
        public string maintain_item    { get; set; }
        public string comment          { get; set; }
        public DateTime create_time      { get; set; }

    }
}

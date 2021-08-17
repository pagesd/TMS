using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    /// <summary>
    /// 车辆管理
    /// </summary>
    public class VehicleModel
    {

        public int VehicleId       { get; set; }
        public string BrandId         { get; set; }
        public string Plate_number    { get; set; }
        public string Name            { get; set; }
        public string Company         { get; set; }
        public string Long_g            { get; set; }
        public string Color           { get; set; }
        public DateTime Buy_tiem        { get; set; }
        public string Certificate     { get; set; }
        public DateTime Expire_time     { get; set; }
        public DateTime Yearexpire_time { get; set; }
        public string Maintain        { get; set; }
        public string Yehicle_image   { get; set; }
        public string Insurance_image { get; set; }

    }
}

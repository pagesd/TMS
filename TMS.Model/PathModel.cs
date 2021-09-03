﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    /// <summary>
    /// 线路
    /// </summary>
    public class PathModel
    {
        public int pathId         { get; set; }
        public string path_Name      { get; set; }
        public string origin         { get; set; }
        public string origin_intro   { get; set; }
        public string terminus       { get; set; }
        public string terminus_intro { get; set; }
        public bool isoutsource    { get; set; }
        public string Name           { get; set; }
        public string comment        { get; set; }
        public DateTime creation_time  { get; set; }
        public bool state          { get; set; }
        public string phone          { get; set; }
        public string unit { get; set; }
    }
}

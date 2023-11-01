using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class VehicleMakeModel
    {
        public int VehicleMakeID { get; set; }
        public string VehicleMakeTitle { get; set; }
        public string Company { get; set; }
        public bool isDeleted { get; set; }
    }
}

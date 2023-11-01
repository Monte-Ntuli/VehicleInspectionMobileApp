using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class VehicleTypeModel
    {
        [Key]
        public int VehicleTypeID { get; set; }
        public string VehicleTypeTitle { get; set; }
        public string Company { get; set; }
        public int QuestionaireID { get; set; }
        public bool hasQuestionaire { get; set; }
        public bool isDeleted { get; set; }
    }
}

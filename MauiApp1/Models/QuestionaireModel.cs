using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class QuestionaireModel
    {
        public int QuestionaireID { get; set; }
        public string Title { get; set; }
        public int VehicleTypeID { get; set; }
        public string Company { get; set; }
        public bool isDeleted { get; set; }
    }
}

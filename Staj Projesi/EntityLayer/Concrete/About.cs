using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EntityLayer.Concrete
{
    public class About
    {[Key]
        public int AboutID { get; set; }//ID ile erişeceğiz claslara
        public string? AboutDetails1 { get; set; }
        public string? AboutDetails2 { get; set; }
        public string? AboutImage1 { get; set; }//Resimleri yol olarak çekeceğiz
        public string? AboutImage2 { get; set; }
        public string? AboutMapLocation { get; set; }
        public bool AboutStatus { get; set; }//
    }
}

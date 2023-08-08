using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Başlık { get; set; }
        public DateTime Tarih{ get; set; }
        public string Açıklama{ get; set; }
        public string BlogImage{ get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }
       
    }
}
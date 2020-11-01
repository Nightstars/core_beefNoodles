using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_beefNoodles.Models
{
    public class Noodle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDexcription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsInstock { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService {
    public class Settings {
        public Guid ID { get; set; }
        public decimal PricePerHour { get; set; } = 44.5M;
        [NotMapped]
        public Dictionary<string, string> TasksValuesPairs { get; set; }
    }
}

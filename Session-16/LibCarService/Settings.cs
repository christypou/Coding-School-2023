using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService {
    public class Settings {
        public decimal PricePerHour { get; set; } = 44.5M;
        public Dictionary<string, string> TasksValuesPairs { get; set; }
    }
}

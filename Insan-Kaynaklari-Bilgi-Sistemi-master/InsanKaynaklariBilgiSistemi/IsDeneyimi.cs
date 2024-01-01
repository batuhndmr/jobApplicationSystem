using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariBilgiSistemi
{
    // IsDeneyimi sınıfı, bir kişinin iş deneyimini temsil eder.
    public class IsDeneyimi
    {
        // IsAd, kişinin çalıştığı işyerinin adını temsil eder.
        public string IsAd { get; set; }

        // IsAdres, kişinin çalıştığı işyerinin adresini temsil eder.
        public string IsAdres { get; set; }

        // Gorev, kişinin çalıştığı işyerindeki görevini temsil eder.
        public string Gorev { get; set; }
    }
}

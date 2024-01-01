using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariBilgiSistemi
{
    // Ilan sınıfı, iş ilanlarını temsil eder ve ilanlara başvuran adayları HeapBasvuru nesnesi üzerinden yönetir.
    public class Ilan
    {
        // Ilan sınıfının parametresiz constructor'ı. HeapBasvuru nesnesi başlatılır.
        public Ilan()
        {
            heapBasvuru = new HeapBasvuru(100);
        }

        // IlanId, iş ilanının benzersiz kimliğini temsil eder.
        public int IlanId { get; set; }

        // IsTanimi, iş ilanının içeriğini temsil eder.
        public string IsTanimi { get; set; }

        // ElemanOzellik, aranan elemanın özelliklerini temsil eder.
        public string ElemanOzellik { get; set; }

        // Sirket, iş ilanını yayınlayan şirketi temsil eder.
        public Sirket sirket { get; set; }

        // HeapBasvuru, iş ilanına başvuran adayları yönetmek için kullanılan HeapBasvuru nesnesidir.
        public HeapBasvuru heapBasvuru;
    }
}

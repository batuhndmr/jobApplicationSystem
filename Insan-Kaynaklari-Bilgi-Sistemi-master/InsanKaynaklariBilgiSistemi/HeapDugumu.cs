using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariBilgiSistemi
{
    // HeapDugumu sınıfı, heap (kuyruk) yapısındaki her bir düğümü temsil eder.
    public class HeapDugumu
    {
        // Deger, bu heap düğümüne atanmış olan değeri temsil eder.
        public object Deger { get; set; }

        // HeapDugumu sınıfının constructor'ı. Bir değer alarak yeni bir heap düğümü oluşturur.
        public HeapDugumu(object deger)
        {
            this.Deger = deger;
        }
    }
}

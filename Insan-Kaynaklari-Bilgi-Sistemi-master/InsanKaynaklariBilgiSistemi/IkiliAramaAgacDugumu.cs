using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariBilgiSistemi
{
    // IkiliAramaAgacDugumu sınıfı, ikili arama ağacındaki (binary search tree) her bir düğümü temsil eder.
    public class IkiliAramaAgacDugumu
    {
        // veri, bu ikili arama ağacı düğümüne atanmış olan değeri temsil eder.
        public object veri;

        // sol, düğümün sol alt ağacındaki düğümü temsil eder.
        public IkiliAramaAgacDugumu sol;

        // sag, düğümün sağ alt ağacındaki düğümü temsil eder.
        public IkiliAramaAgacDugumu sag;

        // IkiliAramaAgacDugumu sınıfının parametresiz constructor'ı. Herhangi bir değer ataması yapmaz.
        public IkiliAramaAgacDugumu()
        {
        }

        // IkiliAramaAgacDugumu sınıfının parametreli constructor'ı. Bir değer alarak yeni bir ikili arama ağacı düğümü oluşturur.
        public IkiliAramaAgacDugumu(object veri)
        {
            this.veri = veri;
            sol = null;
            sag = null;
        }
    }
}


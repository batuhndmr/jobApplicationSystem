using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariBilgiSistemi
{
    // Eğitim sınıfı, bir kişinin eğitim bilgilerini temsil eder.
    public class Egitim
    {
        // OkulAdi, öğrencinin katıldığı okulun adını tutar.
        public string OkulAdi { get; set; }

        // Bolum, öğrencinin okuduğu bölümü tutar.
        public string Bolum { get; set; }

        // BaslangicTarih, eğitimin başlangıç tarihini (yıl olarak) tutar.
        public int BaslangicTarih { get; set; }

        // BitisTarih, eğitimin bitiş tarihini (yıl olarak) tutar.
        public int BitisTarih { get; set; }

        // NotOrtalamasi, öğrencinin eğitim sürecindeki genel not ortalamasını tutar.
        public double NotOrtalamasi { get; set; }
    }
}

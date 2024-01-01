using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariBilgiSistemi
{
    // HashDugumu sınıfı, bir hash tablosu içindeki her bir düğümü temsil eder.
    public class HashDugumu
    {
        // Constructor: HashDugumu sınıfının başlatıcı metodu. Bir anahtar ve bir değer alarak yeni bir düğüm oluşturur.
        public HashDugumu(int anahtar, object deger)
        {
            // Anahtar, bu düğümün benzersiz kimliğini temsil eder.
            this.anahtar = anahtar;

            // Değer, bu düğüme atanmış olan değeri temsil eder.
            this.deger = deger;

            // Next, bu düğümden sonraki düğümü gösteren referansı temsil eder. Başlangıçta null olarak ayarlanmıştır.
            this.next = null;
        }

        // Anahtar, bu düğümün benzersiz kimliğini temsil eder. Sadece get metodu ile erişilebilir ve set edilebilir.
        private int anahtar;
        public int Anahtar { get { return anahtar; } set { anahtar = value; } }

        // Deger, bu düğüme atanmış olan değeri temsil eder. Sadece get metodu ile erişilebilir ve set edilebilir.
        private object deger;
        public object Deger { get { return deger; } set { deger = value; } }

        // Next, bu düğümden sonraki düğümü gösteren referansı temsil eder. Sadece get metodu ile erişilebilir ve set edilebilir.
        private HashDugumu next;
        public HashDugumu Next { get { return next; } set { next = value; } }
    }
}

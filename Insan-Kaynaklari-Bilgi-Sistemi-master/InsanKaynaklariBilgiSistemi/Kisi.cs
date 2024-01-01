using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariBilgiSistemi
{
    // Kisi sınıfı, bir kişiyi temsil eder ve kişinin özgeçmiş bilgilerini içerir.
    public class Kisi
    {
        // Kisi sınıfının constructor'ı. Yapıcı metot, sınıfın özelliklerini başlatır ve örnek oluşturulduğunda çağrılır.
        public Kisi()
        {
            // Yeni bir LinkedListIsDeneyimi ve LinkedListEgitim nesnesi oluşturulur.
            this.Deneyimler = new LinkedListIsDeneyimi();
            this.EgitimBilgisi = new LinkedListEgitim();

            // Yabancı dil bilgisi için bir Liste (List<string>) oluşturulur.
            this.YabanciDil = new List<string>();
        }

        // Ad, kişinin adını temsil eder.
        public string Ad { get; set; }

        // Adres, kişinin adresini temsil eder.
        public string Adres { get; set; }

        // Telefon, kişinin telefon numarasını temsil eder.
        public string Telefon { get; set; }

        // Eposta, kişinin eposta adresini temsil eder.
        public string Eposta { get; set; }

        // Uyruk, kişinin uyruğunu temsil eder.
        public Uyruk uyruk { get; set; }

        // DogumTarihi, kişinin doğum tarihini temsil eder.
        public DateTime DogumTarihi { get; set; }

        // MedeniDurum, kişinin medeni durumunu temsil eder.
        public MedeniDurum medeniDurum { get; set; }

        // DogumYeri, kişinin doğum yerini temsil eder.
        public string DogumYeri { get; set; }

        // YabanciDil, kişinin bildiği yabancı dilleri temsil eder.
        public List<string> YabanciDil { get; set; }

        // IlgiAlanlari, kişinin ilgi alanlarını temsil eder.
        public string IlgiAlanlari { get; set; }

        // Referans, kişinin referans bilgisini temsil eder.
        public string Referans { get; set; }

        // UygunlukPuani, kişinin iş ilanına uygunluk puanını temsil eder.
        public double UygunlukPuani { get; set; }

        // Deneyimler, kişinin iş deneyim bilgilerini içeren linked list nesnesidir.
        public LinkedListIsDeneyimi Deneyimler;

        // EgitimBilgisi, kişinin eğitim bilgilerini içeren linked list nesnesidir.
        public LinkedListEgitim EgitimBilgisi;
    }
}

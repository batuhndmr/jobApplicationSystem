using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariBilgiSistemi
{
    // HeapBasvuru sınıfı, başvuruları temsil eden bir heap (kuyruk) yapısını yönetir.
    public class HeapBasvuru
    {
        private HeapDugumu[] heapBasvuru; // Heap (kuyruk) için kullanılan dizi
        private int maksBoyut; // Heap'in maksimum boyutu
        private int gecerliBoyut; // Heap'in mevcut boyutu

        // HeapBasvuru sınıfının constructor'ı. Maksimum heap boyutunu belirler ve heap'i başlatır.
        public HeapBasvuru(int maksHeapBoyutu)
        {
            maksBoyut = maksHeapBoyutu;
            gecerliBoyut = 0;
            heapBasvuru = new HeapDugumu[maksBoyut];
        }

        // Heap'in boş olup olmadığını kontrol eden metod.
        public bool IsEmpty()
        {
            return gecerliBoyut == 0;
        }

        // Heap'e yeni bir başvuru ekleyen metod.
        public bool Insert(Kisi deger)
        {
            // Heap dolu ise ekleme işlemi gerçekleştirilmez.
            if (gecerliBoyut == maksBoyut)
                return false;

            // Başvuru yapan kişi nesnesi heap'in son boş düğümüne eklenir.
            HeapDugumu yeniHeapDugumu = new HeapDugumu(deger);
            heapBasvuru[gecerliBoyut] = yeniHeapDugumu;

            // Son düğüme eklenen kişi adına göre heap'de yerini alması için MoveToUp() metodu kullanılır.
            MoveToUp(gecerliBoyut++);
            return true;
        }

        // Yeni eklenen düğümü uygun konuma taşımak için kullanılan metot.
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugumu bottom = heapBasvuru[index];

            // Yeni eklenen kişi adının (ilk harfinin) ASCII karşılığı, Heap'de o an bulunduğu parentının adının (ilk harfinin) ASCII karşılığından büyük olduğu sürece yer değiştirme işlemi gerçekleştirilir.
            while (index > 0 && Convert.ToInt32(((Kisi)heapBasvuru[parent].Deger).Ad[0]) < Convert.ToInt32(((Kisi)bottom.Deger).Ad[0]))
            {
                heapBasvuru[index] = heapBasvuru[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapBasvuru[index] = bottom;
        }

        // Heap'teki başvuruları listelemek için kullanılan metod.
        public string BasvuruListele(HeapBasvuru temp)
        {
            int i = 0;
            string liste = "";
            while (((HeapDugumu)temp.heapBasvuru[i]) != null)
            {
                // Heap'teki (ilana başvurmuş olan kişiler) kişi isimlerinin listelenmesi işlemi gerçekleştirilir.
                liste += ((Kisi)((HeapDugumu)temp.heapBasvuru[i]).Deger).Ad + Environment.NewLine;
                i++;
            }
            return liste;
        }

        // Bir kişinin daha önce başvuru yapmış olup olmadığını kontrol eden metod.
        public bool Ara(HeapBasvuru temp, Kisi k)
        {
            // Bu metod daha önce bir ilana başvuran kişinin tekrar başvuru yapmaması için oluşturulmuştur.
            // İlandaki başvuruların hepsi kontrol edilerek başvurunun ilanda kayıtlı olması durumunda true, aksi halde false döndürülerek kontrol işlemi gerçekleştirilir.
            int i = 0;
            bool bulundu = false;
            while (((HeapDugumu)temp.heapBasvuru[i]) != null)
            {
                if (((Kisi)((HeapDugumu)temp.heapBasvuru[i]).Deger) == k)
                {
                    bulundu = true;
                    break;
                }
                i++;
            }
            return bulundu;
        }

        // Uygun adayı bulan metod.
        public HeapDugumu UygunAdayBul()
        {
            int i = 0;
            double puan = 0;
            int birinciOncelik = -1;

            // Önceliğin ilk değeri -1 verilir ve -1'in değişmesi veya değişmemesi durumuna göre uygun adayın bulunup bulunmadığı kontrol edilir.
            while (heapBasvuru[i] != null)
            {
                // Öncelikteki ilk kriter uygunluk puanı kontrol edilir ve uygunluk puanı daha yüksek aday bulunursa, birinciOncelik değişkeni bunu belirten indis olarak kullanılır.
                if (((Kisi)heapBasvuru[i].Deger).UygunlukPuani > puan)
                {
                    birinciOncelik = i;
                    puan = ((Kisi)heapBasvuru[i].Deger).UygunlukPuani;
                }
                else if (((Kisi)heapBasvuru[i].Deger).UygunlukPuani == puan)
                {
                    // Uygunluk puanı eşit olduğu durumda adayın İngilizce ve not bilgileri kontrol edilir.
                    if (((Kisi)heapBasvuru[i].Deger).EgitimBilgisi.DoksanUzeriNot() == true && ((Kisi)heapBasvuru[i].Deger).YabanciDil.Find(stringX => stringX == "İngilizce") == "İngilizce")
                        birinciOncelik = i;
                }
                i++;
            }

            // birinciOncelik değişkeni -1 ise uygun aday bulunmamıştır, aksi halde uygun adayın HeapDugumu nesnesi döndürülür.
            if (birinciOncelik == -1)
                return null;
            else
                return heapBasvuru[birinciOncelik];
        }
    }
}

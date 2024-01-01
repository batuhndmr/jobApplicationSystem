using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariBilgiSistemi
{
    // HashTable sınıfı, hash tablosunu temsil eder ve ilan ekleme ve silme işlemlerini gerçekleştirir.
    public class HashTable
    {
        // Hash tablosunun boyutu. Başlangıçta 100 olarak ayarlanmıştır.
        int tabloBoyutu = 100;

        // Hash tablosunu temsil eden dizi.
        HashDugumu[] hashTablosu;

        // HashTable sınıfının constructor'ı. Hash tablosunu başlatır ve başlangıç değerlerini atar.
        public HashTable()
        {
            hashTablosu = new HashDugumu[tabloBoyutu];
            for (int i = 0; i < tabloBoyutu; i++)
                hashTablosu[i] = null; // ilk değerler null atandı
        }

        // IlanEkle metodu, hash tablosuna yeni bir ilan ekler.
        public void IlanEkle(int anahtar, object deger)
        {
            int indis = (anahtar % tabloBoyutu); // Anahtar'ın tablo boyutuna göre modu alındı ve eklenecek indis bulundu.
            if (hashTablosu[indis] == null) // indis null ise direk ekleme işlemi gerçekleşti
                hashTablosu[indis] = new HashDugumu(anahtar, deger);
            else
            {
                HashDugumu hashDugumu = hashTablosu[indis];
                while (hashDugumu.Next != null && hashDugumu.Anahtar != anahtar) // indis null değil ise null olan indise kadar ilerlendi ve eklendi
                    hashDugumu = hashDugumu.Next;
                if (hashDugumu.Anahtar == anahtar)
                    hashDugumu.Deger = deger;
                else
                    hashDugumu.Next = new HashDugumu(anahtar, deger);
            }
        }

        // IlanSil metodu, hash tablosundan bir ilanı siler.
        public void IlanSil(int anahtar)
        {
            int indis = (anahtar % tabloBoyutu); // Anahtar ve tablo boyutu kullanılarak silinecek indis bulundu
            if (hashTablosu[indis] != null)
            {
                HashDugumu oncekiHashDugumu = null;
                HashDugumu hashDugumu = hashTablosu[indis];
                while (hashDugumu.Next != null && hashDugumu.Anahtar != anahtar)
                {
                    oncekiHashDugumu = hashDugumu;
                    hashDugumu = hashDugumu.Next;
                }
                if (hashDugumu.Anahtar == anahtar) // Silinecek düğüm bulunup silme işlemi gerçekleştirildi
                {
                    if (oncekiHashDugumu == null)
                        hashTablosu[indis] = hashDugumu.Next;
                    else
                        oncekiHashDugumu.Next = hashDugumu.Next;
                }
            }
        }
    }
}

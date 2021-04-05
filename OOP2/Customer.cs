using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Customer
    {
        //TcNo vs de string kullanabiliriz. Eğer değişkenle dört işlem matematiksel işlemler yapılmayacaksa string kullanmak daha güzel olur.
        // Eğer class da bu nesnelerden birisini kullanmıyorsan. Sürekli ihtiyacın yoksa o zaman soyutlama hatası yapıyorsun demektir.

        public int Id { get; set; }
        public string MusteriNo { get; set; }
    }
}

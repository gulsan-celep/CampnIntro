using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class Urun
    {
        // class isimlerinde pascal case de ilk harfleri büyük yazılır c# da"
        // snipet -> prop
        // property -> Özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Detay { get; set; }

        public int StokAdedi { get; set; }

    }
}

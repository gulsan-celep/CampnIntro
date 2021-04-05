using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class Personel
    {
        // veritabanında not null boş geçemezsin demek o yüzden classa eklemeyi unutma.
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category //internal : acces modifier
    {
        //public : erişim sağlanır her yerden.
        //private : bulunduğu classtan.
        //internal : bulunduğu katmandan.
        //protected : bir sınıf ve o sınıfı miras alan yerlerden erişim sağlanır.

        //Code First Yaklaşımı için birincil anahtar olduğunu belirtmek ve otomatik artan yapmak için sınıf ismini yazıp ardından Id yazmak gerekiyor.

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }

        public List<Product> Products { get; set; } 

    }
}

/* 
Field - Variable - Property 


int x;  ----> direk olarak sınıfın içinde tanımlanırsa bu bir Field dır.

int x; ------> değişken yapısı sonuna get ve set olarak iki tane değer alırsa Property dir.

int x; -------> metot içinde tanımlıysa Variable dır.
 
 SOLID prensipleri
-------------------------------
S : Single Responsibility : Tek Sorumluluk ilkesi -----> Bir metot, bir değişken vs. sadece tek işlem yapılabilir demek.
 
 
 
 
 */

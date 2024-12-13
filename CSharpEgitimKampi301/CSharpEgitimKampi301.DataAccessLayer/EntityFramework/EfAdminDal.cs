using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal: GenericRepository<Admin>, IAdminDal
    {

    }
}
//Entity Özgü olmayan metodlar:
//    ekle
//    sil
//    güncelle
//    listele
//    Id ye göre getir
//mesela içinde a harfi olan kullanıcıları listele dediğimiz zaman bu entity özgü olan bir metod
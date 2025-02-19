﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class // doşardan bir T değeri Alacaksın
    {

        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll(); // bütün verileri getirecek olan getAll isimli bir liste
        T GetById(int id);

    }
}

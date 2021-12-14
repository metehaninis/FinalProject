using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //T yerine ne gönderirsek onu alır(product,category)
    //generic constraint     T yi sınırlandırıyoruz   class: referans tip olabilir demek
    //herhangibir class da yazamasın  - T bir referans tip olmalı ya IEntity olmalı ya da ondan implemente olan birşey olabilir
    //new lenebilir olamalı yani artık interface olan IEntity de girilemez
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //linq yazdığımız kısım expression getall içerisinde kullanabilmemizi sağlar - filtre vermeyebilirsin demek yani mantıken tüm datayı istiyor
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);          //interface metotları default public tir ancak kendisi değil
        void Update(T entity);
        void Delete(T entity);
    }
}

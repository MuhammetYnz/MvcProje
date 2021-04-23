using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface ICategoryDal:IRepository<Category>
    {
        //Bu tarz kullanım  her sınıf tek tek interface oluşturulmasına neden olacağından büyük projelerde çok fazla bunun gibi gereksiz interface olmasına neden olacaktır.Bu yüzden bir tane IRepository üzerinden bu sorundan kurtulabiliriz.Bu sınıf örnek olarak tutulacak kullanılmayacaktır !!!!!

        //CRUD
        //Type Name();
        //List<Category> List();

        //void Insert(Category c);

        //void Update(Category c);

        //void Delete(Category c);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CurrencyExchange.Models
{
    public class Office
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int pcode { get; set; }
        public int region {get; set;}
        public string city { get; set; }
        public string adress { get; set; }
}
    public class OfficeContext : DbContext
    {
        
        //Контекст данных представляет собой класс, производный от класса DbContext. Контекст данных содержит одно или несколько свойств типа DbSet<T>, где T представляет тип объекта, хранящегося в базе данных.
        public DbSet<Office> offices { get; set; } //свойство оffices
    }

}
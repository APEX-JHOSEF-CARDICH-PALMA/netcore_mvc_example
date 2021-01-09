using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_mvc_example.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CatergoryName { get; set; }
        /**
         * Relationship: Category One-to-Many Products
         * Osea: Un producto tiene una categoria, pero una caterogoria tiene  un producto
         * en este caso, tenemos que poner un par de propiedades
         * 1 -  create the foreing key
         * 2 -  create a list that represent the products that one category can contain
         */
        public ICollection<Product> Products { get; set; }

    }
}

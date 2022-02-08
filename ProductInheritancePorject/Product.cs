using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritancePorject {
    public class Product {

        private bool Flag { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }

        public virtual string ToPrint() {
            return $"{GetType().ToString()} | {Code} | {Price:c}";
        }
        public Product(string code, decimal price) {
            Flag = true;
            Code = code;
            Price = price;

        }
        public Product() {

        }
    }
}

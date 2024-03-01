using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerancaPolimorfismo2.Entities
{
    public class ImportedProduct : Product {

        public double CustomsFee { get; set; }

        public override string priceTag()
        {
            return base.priceTag() + $"(Customs fee: $ {CustomsFee}";
        }
    }
    
    
}

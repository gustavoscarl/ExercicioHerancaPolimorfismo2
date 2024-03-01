using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerancaPolimorfismo2.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public override string priceTag()
        {
            return base.priceTag() + $"(Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}

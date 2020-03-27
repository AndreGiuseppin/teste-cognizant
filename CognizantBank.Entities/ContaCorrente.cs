using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CognizantBank.Entities
{
    public class ContaCorrente
    {
        [Display(Name = "ID da Conta")]
        public int Id { get; set; }

        [Display(Name = "Valor Atual")]
        public decimal CurrentValue { get; set; }

        [Display(Name = "Limite Maximo")]
        public decimal MaximumLimit { get; set; }        
    }
}

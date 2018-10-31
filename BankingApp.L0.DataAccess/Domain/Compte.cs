using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L0.DataAccess.Domain
{
    [Table("Compte")]
    public class Compte
    {
        [Key]
        public String Numero { get; set; }

        public String Proprietaire { get; set; }

        public decimal Solde { get; set; }

        public void Débiter(decimal montant)
        {
            Solde += montant;
        }

        public void Créditer(decimal montant)
        {
            Solde -= montant;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Compte converti = obj as Compte;

            return this.Numero.Equals(converti.Numero);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return this.Numero.GetHashCode();
        }
    }
}

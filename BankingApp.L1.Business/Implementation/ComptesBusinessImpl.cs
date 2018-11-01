using BankingApp.L0.DataAccess.Domain;
using BankingApp.L0.DataAccess.Facade;
using BankingApp.L0.DataAccess.Implementations;
using BankingApp.L1.Business.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L1.Business.Implementation
{
    public class ComptesBusinessImpl : IComptesBusiness
    {
        private IComptesRepository repository;//= new ComptesRepositoryImpl_EF();

        // Injection par constructeur
        public ComptesBusinessImpl(IComptesRepository repository)
        {
            this.repository = repository;
        }
        public decimal? ConsulterSolde(string numero)
        {
            var result =  repository.FindById(numero);
            return result?.Solde;
        }

        public IEnumerable<Compte> TousLesComptes()
        {
            return repository.FindAll();
        }

    }
}

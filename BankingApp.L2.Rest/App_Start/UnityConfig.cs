using System;
using System.Collections.Generic;
using BankingApp.L0.DataAccess.Domain;
using BankingApp.L0.DataAccess.Facade;
using BankingApp.L0.DataAccess.Implementations;

using BankingApp.L1.Business.Facade;
using BankingApp.L1.Business.Implementation;
using Moq;
using Unity;

namespace BankingApp.L2.Rest
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();
            //var myMockRepository = new Mock<IComptesRepository>();
            //myMockRepository.Setup(o => o.FindAll()).Returns(
           //     new List<Compte>()
            //    {
            //        new Compte{ Numero="F1000",Proprietaire="OLALALAA",Solde=100m },
            //        new Compte{ Numero="F2000",Proprietaire="OLALALAA",Solde=200m },
            //        new Compte{ Numero="F3000",Proprietaire="OLALALAA",Solde=300m },
            //    }
            //    );
            //container.RegisterInstance<IComptesRepository>(myMockRepository.Object);

            container.RegisterType<IComptesRepository, ComptesRepositoryImpl_EF>();
            container.RegisterType<IComptesBusiness, ComptesBusinessImpl>();
        }
    }
}
using System;
using System.Collections.Generic;
using BankingApp.L0.DataAccess.Domain;
using BankingApp.L0.DataAccess.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.L0.DataAccess.Tests
{
    [TestClass]
    public class UnitTestComptesRepositoryImpl_EF
    {
        [TestMethod]
        public void TestCreate()
        {
            // Arrange
            var nouveau = new Compte { Numero="C4000",Proprietaire="Blabla",Solde=4000M};
            var underTest = new ComptesRepositoryImpl_EF();
            // Acte
            underTest.Create(nouveau);
            // Assert
        }

        [TestMethod]
        public void TestFindAll()
        {
            // Arrange
            var underTest = new ComptesRepositoryImpl_EF();
            // Acte
            var actual = (List<Compte>)underTest.FindAll();

            // Assert
            Assert.AreEqual(actual.Count, 4);
        }
    }
}

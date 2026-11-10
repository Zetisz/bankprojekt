using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace bankprojekt.Tests
{
    [TestFixture]
    internal class BankTest
    {
        Bank b;

        [SetUp]
        public void Setup()
        {
            b = new Bank();
            b.NewAccount("1234");
        }

        [TearDown]
        public void Teardown()
        {
            Console.WriteLine("Minden teszt véget ért.");
        }

        [Test]
        public void InitialBalanceIsZero()
        {
            /*
            // Előkészítő lépés
            var b = new Bank();

            // A művelet, amit tesztelünk
            b.NewAccount("1234");

            // Eredmény:
            Assert.That(b.GetBalance("1234"), Is.Zero);
            */
        }

        [Test]
        public void Deposit()
        {
            b.Deposit("1234", 50000);

            Assert.That(b.GetBalance("1234"), Is.EqualTo(50000));
        }

        [Test]
        public void MultipleDeposits()
        {
            b.Deposit("1234", 50000);
            b.Deposit("1234", 50000);

            Assert.That(b.GetBalance("1234"), Is.EqualTo(100000));
        }

        [Test]
        public void NegativeDeposit()
        {
            Assert.Throws<Exception>(() =>
            {
                b.Deposit("1234", -10000);
            });
        }
    }
}

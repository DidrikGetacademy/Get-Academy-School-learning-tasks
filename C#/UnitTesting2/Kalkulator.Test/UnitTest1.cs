using NUnit.Framework;

namespace Kalkulator.Test
{
    public class Tests
    {

        [Test]
        public void Leggsammen2Tall()
        {
          var kalkulator = new Kalkulator();
          int resultat = kalkulator.LeggSammen(2, 3);
          Assert.AreEqual(5,resultat);

        }

        [Test]
        public void Trekkfra2Tall()
        {
            var kalkulator = new Kalkulator();
            int resultat = kalkulator.LeggSammen(-10, 20);
            Assert.AreEqual(10, resultat);

        }



        [Test]
        public void multipliser()
        {
            var kalkulator = new Kalkulator();
            int a = 10;
            int b = 20;
             int resultat = a * b;
             Assert.AreEqual(200, resultat);

        }


        [Test]
        public void Divider()
        {
        var Kalkulator = new Kalkulator();
        Assert.Throws<ArgumentException>(() => Kalkulator.Divider(10, 0))
        }


    }

}



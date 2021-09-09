using System;
using Week7.EquazioneGrado2.Core;
using Xunit;

namespace Week7.EquazioneGrado2.Test
{
    public class EquazioneTest
    {
        [Fact]
        public void Test1()
        {
            //ARRANGE : predisposizione del test
            Equation equazione = new Equation();

            //ACT : chiamata alla funzionalità da testare
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, -3, 2);

            //ASSERT : verifica del risultato
            Assert.True(risultato.Length == 2);
            Assert.Equal(1, risultato[0]); //alternativa => Assert.True(risultato[0] == 1);
            Assert.Equal(2, risultato[1]);
        }

        [Fact]
        public void Test2()
        {
            //ARRANGE : predisposizione del test
            Equation equazione = new Equation();

            //ACT : chiamata alla funzionalità da testare
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, -5, 6);

            //ASSERT : verifica del risultato
            Assert.True(risultato.Length == 2);
            Assert.Equal(2, risultato[0]); 
            Assert.Equal(3, risultato[1]);
        }

        [Fact]
        public void Test3()
        {
            //ARRANGE : predisposizione del test
            Equation equazione = new Equation();

            //ACT : chiamata alla funzionalità da testare
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, 2, 1);

            //ASSERT : verifica del risultato
            Assert.True(risultato.Length == 1);
            Assert.Equal(-1, risultato[0]);
        }

        [Fact]
        public void Test4()
        {
            //ARRANGE : predisposizione del test
            Equation equazione = new Equation();

            //ACT : chiamata alla funzionalità da testare
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, -3, 10);

            //ASSERT : verifica del risultato
            Assert.True(risultato == null);
        }
    }
}

using _01_esempio.Models;  

namespace _01_Test.Models
{
    public class NumeroShould
    {
        [Theory]
        [InlineData(2, "pari")]
        [InlineData(4, "pari")]
        [InlineData(7, "dispari")]
        [InlineData(10, "pari")]
        public void _1_Return_ifPari(int numero, string atteso)
        {
            //Arrange 
            Numero n = new Numero();

            //act 
            string attuale = n.VerificaPari(numero); 

            //Assert 
            Assert.Equal(attuale, atteso);  
        }
    }
}
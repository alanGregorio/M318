using _05equazione.Models;
namespace test

{
    public class UnitTest1
    {
        [Theory]
        [InlineData()]
        [InlineData()]
        [InlineData()]
        [InlineData()]
        public void Test1()
        {
            //Arrange 
            Equation n = new Equation(a,b,c);

            //act 
            string attuale = n.VerificaPari(numero);

            //Assert 
            Assert.Equal(attuale, atteso);

        }
    }
}
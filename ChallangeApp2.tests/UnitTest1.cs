
namespace ChallangeApp2.tests
{
    public class Tests
    {
        [Test]
        public void WhenNumbersAreAdd()
        {
            //arrange
            var Employee = new Employee("Kuba", "Kowalczyk", 25);
            Employee.AddScore(6);
            Employee.AddScore(-7);
            Employee.AddScore(-3);

            //act

            //assert
            Assert.AreEqual(-4, Employee.Result);
        }
        [Test]
        public void WhenNumbersAreAddAndSum()
        {
            //arrange
            var Employee = new Employee("Monika", "Nowak", 30);
            Employee.AddScore(5);
            Employee.AddScore(-7);
            Employee.AddScore(-9);

            //act
            var result = Employee.Result;

            //assert
            Assert.AreEqual(-11, result);
        }
        [Test]
        public void WhenNumbersAreAddAndSumAll()
        {
            //arrange
            var Employee = new Employee("Zuzia", "Grzech", 35);
            Employee.AddScore(8);
            Employee.AddScore(-3);
            Employee.AddScore(-6);

            //act
            var result = Employee.Result;

            //assert
            Assert.AreEqual(-1, result);
        }
    }
}

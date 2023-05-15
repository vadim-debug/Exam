using Popov;
namespace TestProject1
 
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Class1 test = new Class1();
            int x = 2;int y = 3; int expected = 5;
            int actual = test.GetSum(x, y);
            Assert.Equal(expected, actual);
        }
    }
}
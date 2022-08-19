using simpleIntrest;

namespace SimpleTest
{
    public class SimpleInterestTest
    {
        [Fact]
        public void Addition()
        {
            var check = new SimpleInterest();
            check.add(1, 2);
            Assert.Equal(3, 3);


        }

        [Fact]
        public void Substraction()
        {
            var check = new SimpleInterest();
            check.subtract(1, 2);
            Assert.Equal(-1, -1);
        }
        [Fact]
        public void Multiplication()
        {
            var check = new SimpleInterest();
            check.mulitply(1, 2);
            Assert.Equal(2, 2);
        }

        [Fact]
        public void MultiplicationThreeParamaters()
        {
            var check = new SimpleInterest();
            check.mulitply(1, 2,3);
            Assert.Equal(6, 6);
        }

        [Fact]
        public void Division()
        {
            var check = new SimpleInterest();
            check.division(6, 3);
            Assert.Equal(2, 2);
        }

        [Fact]
        public void SimpleInterest()
        {
            var check = new SimpleInterest();
            double multi = check.mulitply(1200, 5, 5);
            double denominator = 100;
            double intrest = check.division(Convert.ToInt32(multi), denominator);
            Assert.Equal(intrest, 300);
        }

        [Fact]
        public void CompoundInterest()
        {
            var check = new SimpleInterest();

            double denominator = 100;
            double divide = check.division(5, denominator);
            double sum = 1;
            double addsum = check.add(sum, divide);
            double ci = 1;
            for (int i = 1; i <= 5; i++)
            {
                ci = check.mulitply(ci, addsum);

            }
            double intrest = check.mulitply(ci, 1200);
            Assert.Equal(1531.5378750000004, 1531.5378750000004);

        }



    }
}
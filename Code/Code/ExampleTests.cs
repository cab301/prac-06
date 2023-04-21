using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class ExampleTests
    {
        public class SubExampleTests
        {
            [Test("Test if 2 + 2 = 4")]
            public TestResult ExampleTest2()
            {
                string input = "2 + 2";
                string expected = "4";
                string actual = (2 + 2).ToString();
                return new TestResult(input, expected, actual, 2 + 2 == 4);
            }

            [Test("Test throw exception")]
            public TestResult ExampleTest3()
            {
                string input = null;
                return Assertions.AssertThrows(() =>
                    {
                        Console.WriteLine(input.Length);
                    }, "Getting length from null input",
                    typeof(NullReferenceException)
                );
            }
        }

        // Test if 1 + 1 = 2
        [Test("Test if 1 + 1 = 2")]
        public TestResult ExampleTest()
        {
            string input = "1 + 1";
            string expected = "2";
            string actual = (1 + 1).ToString();
            return new TestResult(input, expected, actual, 1 + 1 == 2);
        }
    }
}

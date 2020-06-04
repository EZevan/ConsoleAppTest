using System.Text;

namespace ConsoleApp1
{
    partial class TestStringBuilder
    {
        public void TestMethod()
        {
            string s = "Hello World";
            StringBuilder sb = new StringBuilder(s);

            sb.Append(" evan");
        }
    }
}
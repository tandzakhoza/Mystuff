using NUnit.Framework;
using Problems;


namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
           Program p= new Program();
           string result= p.prefix("hello");

           Assert.AreEqual("5,1:hello",result);

        
        }
    }
}
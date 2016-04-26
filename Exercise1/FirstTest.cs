using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace Exercise1
{
    public class FirstTest
    {
        [Test]
        public void fake_test()
        {
            var result = false;
            Check.That(result).IsTrue();
        }
    }
}

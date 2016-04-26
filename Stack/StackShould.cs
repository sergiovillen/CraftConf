using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace StackProject
{
    public class StackShould
    {
        [Test]
        public void throw_exception_if_popped_when_empty()
        {
            var stack = new Stack();

            Assert.Throws<Exception>(() =>
            {                
                stack.Pop();
            });
        }
    }

    internal class Stack
    {
        public void Pop()
        {
            throw new Exception();
        }
    }
}

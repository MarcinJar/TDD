using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test
{
    [TestFixture(typeof(ArrayList))]
    [TestFixture(typeof(List<int>))]
    [TestFixture(typeof(Collection<int>))]
    public class GenericListsTests<T> where T : IList, new()
    {
        [Test]
        public void CountTest()
        {
            var list = new T { 2, 3 };

            Assert.That(list, Has.Count.EqualTo(2));
        }
             
    }
}

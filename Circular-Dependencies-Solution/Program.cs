using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Dependencies_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        #region ********** first solution - interface **********
        /********** first solution - interface **********/
        public class A
        {
            IB classB { get; set; }

            public A()
            {
                classB.MakeCoffe();
            }

            public void CallFriends() { }
        }

        public class B : IB
        {
            A classA { get; set; }

            public void MakeCoffe()
            {
                classA.CallFriends();
            }
        }

        public interface IB
        {
            void MakeCoffe();
        }
        #endregion

        #region ********** second solution - factory pattern **********
        /********** second solution - factory pattern **********/
        /*public class A
        {
            private IB classB;

            public A()
            {
                Factory factory = new Factory();
                classB = factory.GetBObject();
            }

            public void CallFriends() { }
        }

        public class B : IB
        {
            A classA { get; set; }

            public void MakeCoffe()
            {
                classA.CallFriends();
            }
        }

        public interface IB
        {
            void MakeCoffe();
        }

        public class Factory
        {
            public B GetBObject()
            {
                return new B();
            }
        }*/
        #endregion

    }
}

using System;

namespace SomeProject
{
    public class Class1
    {

        public void SomeMethod()
        {
            var class2 = new Class2();
            class2.AnotherMethod();
        }

        public void AnotherMethod()
        {
            var class3 = new Class3();
            class3.SomeMethod();
        }
    }
}

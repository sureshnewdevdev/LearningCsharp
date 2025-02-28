using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class IamInternal
    {
    }

    
    public class IamPublicClass
    {

        protected int IamProerties { get; set; }

        protected class MyProtectedClass
        {
            public MyProtectedClass() { }
        }
        private class IamPrivate
        {

        }

        public IamPublicClass()
        {
            MyProtectedClass myProtectedClass = new MyProtectedClass(); 
            IamPrivate iamPrivate = new IamPrivate();
        }
    }

    public class ChildClass : IamPublicClass
    {

        public ChildClass()
        {
            
        }
        public void Display()
        {
            base.IamProerties = 990;
            MyProtectedClass myProtectedClass = new MyProtectedClass();
        }
    }

    public class GeneralClass
    {
        public GeneralClass()
        {
            IamPublicClass iamPublicClass = new IamPublicClass();
            //MyProtectedClass myProtectedClass = new MyProtectedClass(); // Only Same family members
            //can Access other members cant access these protect

            iamPublicClass.IamProerties = 1;

        }
    }



}

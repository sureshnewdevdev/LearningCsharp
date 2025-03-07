using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{


    public class MyCollection<T>
    {

        private List<T> collectionValues;

        public List<T> CollectionValues
        {
            get
            {
                return collectionValues;
            }

            set
            {
                
                collectionValues = value;
            }
        }
        public void AddItems(T t)
        {
            if (collectionValues.Count > 5)
            {
                throw new Exception("Max values allowed is 5");
            }
            collectionValues.Add(t);
        }
        private T myProperty { get; set; }

        public T MyProperty
        {
            get
            {
                return myProperty;
            }
            set
            {
                if (value == null)
                    throw new Exception("My property should not me null");
                myProperty = value;
            }
        }


    }
    public class GernericsCreateExample
    {
        public static void Main(string[] args)
        {
            MyCollection<int> myCollection = new MyCollection<int>();
            myCollection.MyProperty = 10;
            Console.WriteLine(myCollection.MyProperty);

            MyCollection<string> names = new MyCollection<string>();
            names.MyProperty = "Raju";
            Console.WriteLine(names.MyProperty);
        }
    }
}


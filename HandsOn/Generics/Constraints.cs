using System;

namespace HandsOn.Generics
{
    public class GenericConstraints
    {
        public static void Main(string[] args)
        {
            var number = new Nullable<int>(5);
            Console.WriteLine("Has value? " + number.HasValue);
            Console.WriteLine("Value : " + number.GetValueOrDefault());
        }
        //where T: IComparable      
        //where T: struct
        //where T: class
        //where T: new()
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
        public class Constraints
        {
            public int Max(int a, int b)
            {
                return a > b ? a : b;
            }

            //Generic
            public T Max<T>(T a, T b) where T : IComparable
            {
                return a.CompareTo(b) > 0 ? a : b;
            }
           
        }

        public class Constraints2<T> where T : IComparable, new()
        {

            //Generic
            public T Max(T a, T b)
            {
                return a.CompareTo(b) > 0 ? a : b;
            }
            public void DoSomething(T value)
            {
                var obj = new T();
            }
        }
        public class Nullable<T> where T : struct
        {
            private object _value;
            public Nullable()
            {

            }
            public Nullable(T value)
            {
                _value = value;
            }
            public bool HasValue
            {
                get { return _value != null; }
            }

            public T GetValueOrDefault()
            {
                if (HasValue)
                    return (T)_value;
                return default(T);
            }
        }

        public class DiscountCalculator<TProduct> where TProduct : Product
        {
            public float CalculateDiscount(TProduct product)
            {
                return product.Price;
            }

        }

        public class Product
        {
            public string Title { get; set; }
            public float Price { get; set; }
        }

        public class Book : Product
        {
            public string Isbn { get; set; }
        }
    }
}

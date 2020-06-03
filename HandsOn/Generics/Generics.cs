using System;

namespace HandsOn.Generics
{
    //Generics are  for reusability and to remove the performance penality.There's no casting or boxing 
    // In C#, value types cann't be NULL, like an integer will have 0 value if null.
    //Constraints are to limit what we can pass to a class or method
    public class Generics
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            //Classic way
            var numbers = new List();
            numbers.Add(10);

            var books = new BookList();
            books.Add(book);
            //Generic
            var numberList = new GenericList<int>();
            numberList.Add(10);

            var bookList = new GenericList<Book>();
            bookList.Add(book);

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());
        }
        public class Book
        {
            public string Isbn { get; set; }
            public string Title { get; set; }
        }
        //Like the Add() and Indexer, if we want these two features in multiple classes then we need to add it in all the classes.
        // The other thing is boxing for value type like intergers.
        // It has to be casted to other objects in case of reference type. Like a Book to an object and vice versa.
        public class BookList
        {
            public void Add(Book book)
            {
                Console.WriteLine("Book: {0}", book);
            }
            public int this[int Index]
            {
                get { throw new NotImplementedException(); }
            }
        }
        public class List
        {
            public void Add(int number)
            {
                Console.WriteLine("number: {0}", number);
            }
            public int this[int Index]
            {
                get { throw new NotImplementedException(); }
            }
        }
        //////////////Generic////////////////////
        public class GenericList<T>
        {
            public void Add(T t)
            {

            }
            public T this[int index]
            {
                get { throw new NotImplementedException(); }
            }
        }
        public class GenericDictionary<TKey, TValue>
        {
            public void Add(TKey key, TValue value)
            {

            }
        }


    }
}

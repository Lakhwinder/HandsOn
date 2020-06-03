using System;

namespace HandsOn.DesignPatterns.SOLID
{
    //SRP: The Single Responsibility Principle: — a class should have one, and only one, reason to change, meaning that a class should have only one job.

    public class SingleResponsibility
    {
        class Customer
        {
            public void Add()
            {
                try
                {
                    // Database code goes here
                }
                catch (Exception ex)
                {
                    //This class has more than one responsibility. Apart from adding to the DB, it is writting the Logs to the file as well. 
                    // To make this class have single responsibility. We have to move it to a separate class.
                    System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
                }
            }
        }
        ///////################//////////////
        class CustomerSRP
        {
            private FileLogger obj = new FileLogger();
            public virtual void Add()
            {
                try
                {
                    // Database code goes here
                }
                catch (Exception ex)
                {
                    obj.Handle(ex.ToString());
                }
            }
        }
        class FileLogger
        {
            public void Handle(string error)
            {
                System.IO.File.WriteAllText(@"c:\Error.txt", error);
            }
        }
    }
}

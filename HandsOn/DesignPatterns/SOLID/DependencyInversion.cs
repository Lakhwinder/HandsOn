using System;

namespace HandsOn.DesignPatterns.SOLID
{
    //DIP:The Dependency Inversion Principle — depend on abstractions not on concrete implementations.Entities must depend on abstractions not on concretions. It states that the high level module must not depend on the low level module, but they should depend on abstractions.Abstractions should not depend on details. Details should depend on abstractions
    class Customer
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
    interface ILogger
    {
        void Handle(string error);
    }
    // Below are three logger flavors and more can be added down the line.


    class FileLogger : ILogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
        }
    }

    class EverViewerLogger : ILogger
    {
        public void Handle(string error)
        {
            // log errors to event viewer
        }
    }
    class CustomerA //: IDiscount, IDatabase
    {
        private ILogger obj;

        public virtual void Add(int Exhandle)
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                if (Exhandle == 1)
                {
                    obj = new FileLogger();
                }
                else
                {
                    obj = new EmailLogger();
                }
                obj.Handle(ex.Message.ToString());
            }
        }

        class EmailLogger : ILogger
        {
            public void Handle(string error)
            {
                // send errors in email
            }
        }
        public class DependencyInversion
        {
            class CustomerDIP //: IDiscount, IDatabase
            {
                private ILogger obj;
                public CustomerDIP(ILogger i)
                {
                    obj = i;
                }
            }
        }
    }
}

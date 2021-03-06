﻿namespace HandsOn.DesignPatterns.SOLID
{
    //ISP: The Interface Segregation Principle: — This principle states that any client should not be forced to use an interface which is irrelevant to it.
    public class InterfaceSegregation
    {
        public interface IEmployee
        {
            bool AddEmployeeDetails();
        }
        //And all types of employee class will inherit this interface for saving data.This is fine right? Now suppose that company one day told to you that they want to read only data of permanent employees.What you will do, just add one method to this interface?

        public interface IEmployeeDatabase
        {
            bool AddEmployeeDetails();
            bool ShowEmployeeDetails(int employeeId);
        }
        //But now we are breaking something. We are forcing non-permanent employee class to show their details from database. So, the solution is to give this responsibility to another interface.
        public interface IAddOperation
        {
            bool AddEmployeeDetails();
        }
        public interface IGetOperation
        {
            bool ShowEmployeeDetails(int employeeId);
        }
    }
}

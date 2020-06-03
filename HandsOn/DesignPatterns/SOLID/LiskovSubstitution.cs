using System;

namespace HandsOn.DesignPatterns.SOLID
{
    //LSP: The Liskov Substitution Principle: — If any module is using a Base class then the reference to that Base class can be replaced with a Derived class without affecting the functionality of the module.
    // Child class should not break parent class’s type definition and behavior.

    public abstract class EmployeeA
    {
        public virtual string GetProjectDetails(int employeeId)
        {
            return "Base Project";
        }
        public virtual string GetEmployeeDetails(int employeeId)
        {
            return "Base Employee";
        }
    }
    public class CasualEmployee : EmployeeA
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }
        // May be for contractual employee we do not need to store the details into database.
        public override string GetEmployeeDetails(int employeeId)
        {
            return "Child Employee";
        }
    }
    public class ContractualEmployee : EmployeeA
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }
        // May be for contractual employee we do not need to store the details into database.
        public override string GetEmployeeDetails(int employeeId)
        {
            throw new NotImplementedException();//This will through an error
        }
    }
    public class LiskovSubstitution
    {

        public interface IEmployee
        {
            string GetEmployeeDetails(int employeeId);
        }

        public interface IProject
        {
            string GetProjectDetails(int employeeId);
        }

        public class CasualEmployee : IEmployee, IProject
        {
            public string GetProjectDetails(int employeeId)
            {
                return "Child Project";
            }
            // May be for contractual employee we do not need to store the details into database.
            public string GetEmployeeDetails(int employeeId)
            {
                return "Child Employee";
            }
        }
        public class ContractualEmployee : IProject
        {
            public string GetProjectDetails(int employeeId)
            {
                return "Child Project";
            }
            // May be for contractual employee we do not need to store the details into database.

        }
    }
}

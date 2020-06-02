using System;

namespace HandsOn
{
    public class Variance
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Car();
            //Vehicle v2 = new Car();
            //Vehicle v3 = new Aircraft();
            Func<Vehicle> func = GetVehicle; //#1
            Vehicle v4 = func();// For Func, input param is covariant and output param is conbtra.
            v4.getVehicle();//Only the Vehicle class properties and methods will be accessiable. Not of Car class.It will peel of anything related to Cars while assigning the object to Vehicle.
            Action<Car> action = ParkVehicle;
            action(new Car()); //#2 This is called contravariance, because we assigning more derived class to less derived class.
            //Action type parameters are IN, means all are contravariant.
            ICovariant<Vehicle> covariant = (ICovariant<Car>)null;//#1 Covariant - Assigning more derived class to less derived class.
            IContravariance<Car> contravariance = (IContravariance<Vehicle>)null;
        }

        //static Vehicle GetVehicle()
        //{ }
        static Car GetVehicle()
        {
            return new Car();//#1: This method is returning Car but Func<Vehicle> func = GetVehicle; is accepting Vehicle. This is called Co-variance. Assigning the Derived class to Parrent class. Car is covarient with Vehicle.
        }
        static void ParkVehicle(Vehicle vehicle)
        {
        }
        public class Vehicle
        {
            public void getVehicle() { }
        }

        class Car : Vehicle
        {
            void getsCars()
            { }
        }

        class Aircraft : Vehicle
        {

        }

        interface ICovariant<out T> //Need more understanding
        {
            T Name { get; }
            T Get();
        }
        interface IContravariance<in T>//Need more understanding
        {
            T Name { set; }
            void Set(T t);
        }
    }
}

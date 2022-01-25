using System.Globalization;
using System;

namespace C_OO2
{
    public abstract class Employee
    {
         public static int TotalNumberOfEmployee{get;private set;}
         public string Name {get; set;}
         public string Doccument {get; protected set;}
         public double Salary {get; protected set;}
         public Employee (string _name, string _doccument, double _salary)
         {
            TotalNumberOfEmployee++; 
            Salary = _salary;
            Doccument = _doccument;
            Name = _name;
         }

         
         public abstract double GetBonus();

         public abstract void Raise();
    }
}
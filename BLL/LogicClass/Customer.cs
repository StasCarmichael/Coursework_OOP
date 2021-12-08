using System;

using BLL.Interface;
using BLL.MyExceptions;
using BLL.RegEx;


namespace BLL.LogicClass
{
    [Serializable]
    public class Customer : ICustomer
    {
        #region Data

        string name;
        string surname;
        int age;
        string numberOfPassport;

        #endregion


        //ctor
        public Customer()
        { }
        public Customer(string name, string surname, int age, string numberOfPassport)
        {
            Name = name;
            Surname = surname;
            Age = age;
            NumberOfPassport = numberOfPassport;
        }


        #region Propertis

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (RegExpressions.Name.IsMatch(value))
                {
                    name = value;
                }
                else { throw new RegException("Prop Name Error"); }
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (RegExpressions.Surname.IsMatch(value))
                {
                    surname = value;
                }
                else { throw new RegException("Prop Surnane Error"); }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (RegExpressions.Age(value))
                {
                    age = value;
                }
                else { throw new RegException("Prop Age Error"); }
            }
        }
        public string NumberOfPassport
        {
            get
            {
                return numberOfPassport;
            }
            set
            {
                if (RegExpressions.NumberOfPassport.IsMatch(value))
                {
                    numberOfPassport = value;
                }
                else { throw new RegException("Prop NumberOfPassport Error"); }
            }
        }


        #endregion
    }
}

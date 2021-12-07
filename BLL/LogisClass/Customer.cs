using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Interface;

namespace BLL.LogisClass
{
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
        {        }
        public Customer(string name , string surname , int age , string numberOfPassport)
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

            }
        }
        public string Surname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NumberOfPassport { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        #endregion
    }
}

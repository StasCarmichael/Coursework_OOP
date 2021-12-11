using System;
using Xunit;

using BLL.LogicClass;

namespace Test_BLL
{
    public class Test_Customer
    {
        [Fact]
        public void Test_Name()
        {
            string data = "Stas";
            Customer customer = new Customer();
            customer.Name = data;

            Assert.Equal(data, customer.Name);
        }
        [Fact]
        public void Test_Surname()
        {
            string data = "Stas";
            Customer customer = new Customer();
            customer.Surname = data;

            Assert.Equal(data, customer.Surname);
        }
        [Fact]
        public void Test_Age()
        {
            var data = 18;
            Customer customer = new Customer();
            customer.Age = data;

            Assert.Equal(data, customer.Age);
        }
        [Fact]
        public void Test_PassportNumber()
        {
            var data = "239432344";
            Customer customer = new Customer();
            customer.NumberOfPassport = data;

            Assert.Equal(data, customer.NumberOfPassport);
        }
        [Fact]
        public void Test_Copy_Ctor()
        {
            var data = "239432344";
            Customer customer = new Customer();
            customer.NumberOfPassport = data;

            Customer customer1 = new Customer(customer);

            Assert.Equal(customer1.NumberOfPassport, customer.NumberOfPassport);
        }
        [Fact]
        public void Test_Error()
        {
            var grated = false;
            var data = "334235";
            Customer customer = new Customer();

            try
            {
                customer.Name = data;
            }
            catch (Exception)
            { grated = true; }

            try
            {
                customer.Surname = data;
            }
            catch (Exception)
            { grated = true; }

            try
            {
                customer.Age = 345435;
            }
            catch (Exception)
            { grated = true; }

            try
            {
                customer.NumberOfPassport = data;
            }
            catch (Exception)
            { grated = true; }

            Assert.True(grated);
        }

    }
}

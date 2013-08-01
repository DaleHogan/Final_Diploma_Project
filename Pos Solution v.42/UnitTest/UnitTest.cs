using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void uniqueAreaNameTest()
        {
            Restaurant r = new Restaurant { Name = "BeanScene" };
            try
            {
                Area a1 = r.AddArea("MainFloor");
                Area a2 = r.AddArea("MainFloor");

            }
            catch (BusinessRuleException b)
            {
                StringAssert.Contains(b.Message, r.uniqueAreaName);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        public void changeTableState()
        {
            States expectedState = States.Closed;
            Table t = new Table { TableNumber = "02", StateId = 1 };
            t.Close();
            Assert.AreEqual(expectedState, (t as ITable).State);
        }


        [TestMethod]
        public void addTableToArea()
        {
            string expectedTableNumber = "02";
            Area a = new Area { Description = "MainFloor" };
            Table t = a.AddTable("02");
            Assert.AreEqual(expectedTableNumber, t.TableNumber);
        }

        [TestMethod]
        public void addRetaurant()
        {
            string name = "Bean Scene";
            Restaurant r = new Restaurant { Name = name };
            Assert.AreEqual(name, r.Name);
        }

        [TestMethod]
        public void addRegister()
        {
            string name = "BeanSceneRegister";
            Register r = new Register { Name = name };
            Assert.AreEqual(name, r.Name);
        }

        [TestMethod]
        public void addPayment()
        {

            decimal expectedPayment = 10;
            Sale s = new OTCSale();
            s.AddCashPayment(10);
            Assert.AreEqual(expectedPayment, s.PaymentTotal);
        }

        [TestMethod]
        public void saleChange()
        {

            decimal expectedChange = 2;
            Sale s = new OTCSale();
            MenuProduct m1 = new MenuProduct { Price = 3 };
            MenuProduct m2 = new MenuProduct { Price = 5 };
            s.AddSaleLineItem(m1);
            s.AddSaleLineItem(m2);
            s.AddCashPayment(10);
            Assert.AreEqual(expectedChange, s.Change);
        }

        [TestMethod]
        public void increseQuentity()
        {
            decimal expectedQty = 2;
            Sale s = new OTCSale();
            MenuProduct m1 = new MenuProduct { Price = 3 };
            s.AddSaleLineItem(m1);
            SaleLineItem sli = s.AddSaleLineItem(m1);
            Assert.AreEqual(expectedQty, sli.Quantity);
        }

        [TestMethod]
        public void fetchProductWithInvalidId()
        {
            Category c = new Category();
            try
            {

                c.FetchProduct(new Guid("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
            }
            catch (BusinessRuleException b)
            {
                StringAssert.Contains(b.Message, c.invalidProductId);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        public void editAccount()
        {
            int expectedPassword = 1111;
            Employee e = new Employee();
            e.CreateAccount(1234);
            e.EditAccount(expectedPassword);
            Assert.AreEqual(expectedPassword, e.UserAccount.Password);
        }

        [TestMethod]
        public void addCategory()
        {
            string expectedName = "Coffe";
            Category c = new Category { Description = expectedName };
            Assert.AreEqual(expectedName, c.Description);
        }

        [TestMethod]
        public void addEmployee()
        {
            string expectedFirstName = "Jungeun";
            string expectedLasttName = "Kim";
            string expectedPhone = "0412345678";
            string expectedMail = "abc@gmail.com";
            Restaurant r = new Restaurant();
            Person e = r.AddEmployee(expectedFirstName, expectedLasttName, expectedPhone, expectedMail);
            Assert.AreEqual(expectedFirstName, e.FirstName);
            Assert.AreEqual(expectedLasttName, e.LastName);
            Assert.AreEqual(expectedPhone, e.ContactNumber);
            Assert.AreEqual(expectedMail, e.Email);
        }

        [TestMethod]
        public void fetchPerson()
        {     
            Restaurant r = new Restaurant();
            Person expectedPerson = r.AddEmployee("Jungeun", "Kim" ,"0412345678" , "abc@gmail.com");
            Person FetchedPerson = r.FetchPerson(expectedPerson.Id);
            Assert.AreEqual(expectedPerson, FetchedPerson);
        }

        [TestMethod]
        public void saleTotal()
        {

            decimal expectedTotal = 8;
            Sale s = new OTCSale();
            MenuProduct m1 = new MenuProduct { Price = 3 };
            MenuProduct m2 = new MenuProduct { Price = 5 };
            s.AddSaleLineItem(m1);
            s.AddSaleLineItem(m2);
            Assert.AreEqual(expectedTotal, s.SaleTotal);
        }

        [TestMethod]
        public void addMenuProduct()
        {
            decimal expectedMenuProductPrice = 6;
            Product p = new Product { Description = "Latte" };
            Menu m = new Menu();
            MenuProduct mp =  m.AddMenuProduct(p, expectedMenuProductPrice);
            Assert.AreEqual(expectedMenuProductPrice, mp.Price);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal partial class Restaurant : IRestaurant
    {
        #region Menu

        public Menu FetchMenu(Guid id)
        {
            var menu = Menus.FirstOrDefault(a => a.Id.Equals(id));
            if (menu == null)
            {
                throw new BusinessRuleException("Invalid menu id supplied");
            }
            return menu;
        }


        public Menu AddMenu()
        {
            var menu = new Menu();
            this.Menus.Add(menu);
            return menu;
        }



        #endregion

        #region Area

        public Area FetchArea(Guid id)
        {
            var area = Areas.FirstOrDefault(a => a.Id.Equals(id));
            if (area == null)
            {
                throw new BusinessRuleException("Invalid area id supplied");
            }
            return area;
        }
        public string uniqueAreaName = "Area name must be unique";
        public Area AddArea(string description)
        {
            foreach (var a in Areas)
            {
                if (a.Description.Equals(description))
                {
                    throw new BusinessRuleException(uniqueAreaName);
                }
            }

            var area = new Area(this, description);
            this.Areas.Add(area);
            return area;
        }

        public Area EditArea(Guid areaId, string description)
        {
            var area = FetchArea(areaId);
            area.Description = description;
            return area;
        }
        public Area OpenArea(Guid areaId)
        {
            var area = FetchArea(areaId);
            if (area.StateId == 1)
            {
                throw new BusinessRuleException("Area is already open");
            }
            foreach (var t in area.Tables)
            {
                t.StateId = 1;
            }
            area.StateId = 1;
            return area;
        }
        public Area CloseArea(Guid areaId)
        {
            var area = FetchArea(areaId);
            if (area.StateId == 2)
            {
                throw new BusinessRuleException("Area is already closed");
            }
            foreach (var t in area.Tables)
            {
                if (t.StateId == 3)
                {
                    throw new BusinessRuleException("A table is being occupied in the area");
                }
            }
            foreach (var t in area.Tables)
            {
                t.StateId = 2;
            }
            area.StateId = 2;
            return area;
        }
        #endregion

        #region Table

        public Table AddTable(Guid areaId, string tableNumber)
        {
            var area = FetchArea(areaId);
            return area.AddTable(tableNumber);
        }

        public Table FetchTable(Guid areaId, Guid tableId)
        {
            var area = FetchArea(areaId);
            return area.FetchTable(tableId);
        }
        public Table FetchTable(Guid tableId)
        {
            var table = Areas.SelectMany(a => a.Tables).Where(t => t.Id.Equals(tableId)).FirstOrDefault();
            if (table == null)
            {
                throw new BusinessRuleException("Invalid table id supplied");
            }
            return table;
        }
        public Table OpenTable(Guid areaId, Guid tableId)
        {
            var area = FetchArea(areaId);
            return area.OpenTable(tableId);
        }

        public Table CloseTable(Guid areaId, Guid tableId)
        {
            var area = FetchArea(areaId);
            return area.CloseTable(tableId);
        }

        public Table ReserveTable(Guid areaId, Guid tableId)
        {
            var area = FetchArea(areaId);
            return area.ReserveTable(tableId);
        }

        public Table EditTable(Guid areaId, Guid tableId, string tableNumber)
        {
            var area = FetchArea(areaId);
            return area.EditTable(tableId, tableNumber);
        }
        
        #endregion

        #region Person

        public Person AddEmployee(string firstName, string lastName, string contactNumber, string email)
        {
            Person employee = new Employee(this, firstName, lastName, contactNumber, email);
            this.People.Add(employee);
            return employee;
        }

        public Person EditEmployee(Guid id, string firstName, string lastName, string contactNumber, string email)
        {
            var p = FetchPerson(id);
            p.FirstName = firstName;
            p.LastName = lastName;
            p.ContactNumber = contactNumber;
            p.Email = email;
            return p;
        }

        public Person DeleteEmployee(Guid id)
        {
            var personID = FetchPerson(id);
            this.People.Remove(personID);
            return personID;
        }

        public List<Employee> Employees
        {
            get
            {
                return People.OfType<Employee>().ToList();
            }
        }

        public List<Employee> Users
        {
            get
            {
                return Employees.Where(e => e.UserAccount != null).ToList();
            }
        }

        public Person FetchPerson(Guid id)
        {
            var person = People.FirstOrDefault(a => a.Id.Equals(id));
            if (person == null)
            {
                throw new BusinessRuleException("Invalid person id supplied");
            }
            return person;
        }

        public UserAccount FetchUser(int password)
        {
            var employee = Users.Where(e => e.UserAccount.Password.Equals(password)).FirstOrDefault();
            if (employee == null)
            {
                throw new BusinessRuleException("Invalid password supplied");
            }
            return employee.UserAccount;
        }

        public UserAccount FetchUser(Guid userId)
        {
            var employee = Users.Where(e => e.UserAccount.Id.Equals(userId)).FirstOrDefault();
            if (employee == null)
            {
                throw new BusinessRuleException("Invalid userId supplied");
            }
            return employee.UserAccount;
        }

        #endregion

        #region Account
        public UserAccount CreateAccount(Guid employeeID, int password)
        {
            var employee = (Employee)FetchPerson(employeeID);
            return employee.CreateAccount(password);
        }
        public UserAccount EditAccount(Guid employeeID, int password)
        {
            var employee = (Employee)FetchPerson(employeeID);
            return employee.EditAccount(password);
        }
        public void DeleteAccount(Guid employeeID)
        {
            var employee = (Employee)FetchPerson(employeeID);
            employee.DeleteAccount();
        }
        #endregion

        #region Register
        public Register AddRegister(Guid areaId, string name)
        {

            var area = FetchArea(areaId);
            return area.AddRegister(name);
        }

        public Register EditRegister(Guid areaId, Guid registerId, string name)
        {
            var area = FetchArea(areaId);
            return area.EditRegister(registerId, name);

        }

        public Register FetchRegister(Guid areaId, Guid registerId)
        {
            var area = FetchArea(areaId);
            return area.FetchRegister(registerId);
        }
        #endregion

        #region Sale

        public Sale CreateOTCSale(Guid areaId, Guid registerId, UserAccount userAccount)
        {
            var area = FetchArea(areaId);
            return area.CreateOTCSale(registerId, userAccount);
        }

        public Sale CreateTableSale(Guid areaId, Guid registerId, UserAccount userAccount, Table table)
        {
            var area = FetchArea(areaId);
            return area.CreateTableSale(registerId, userAccount, table);
        }

        public void FinaliseSale(Guid areaId, Guid registerId, Guid saleId)
        {
            var area = FetchArea(areaId);
            area.FinaliseSale(registerId, saleId);
        }
        
        #endregion

        #region SalelineItem
        public SaleLineItem AddSaleLineItem(Guid areaId, Guid registerId, Guid saleId, MenuProduct menuProduct)
        {
            var area = FetchArea(areaId);
            return area.AddSaleLineItem(registerId, saleId, menuProduct);
        }

        public int IncrementQuantity(Guid areaId, Guid registerId, Guid saleId, MenuProduct menuProduct)
        {
            var area = FetchArea(areaId);
            return area.IncrementQuantity(registerId, saleId, menuProduct);
        }

        public int DecrementQuantity(Guid areaId, Guid registerId, Guid saleId, MenuProduct menuProduct)
        {
            var area = FetchArea(areaId);
            return area.DecrementQuantity(registerId, saleId, menuProduct);
        }

        public void CancelSaleLineItem(Guid areaId, Guid registerId, Guid saleId, MenuProduct menuProduct)
        {
            var area = FetchArea(areaId);
            area.CancelSaleLineItem(registerId, saleId, menuProduct);
        }

        public void VoidSale(Guid areaId, Guid registerId, Guid saleId)
        {
            var area = FetchArea(areaId);
            area.VoidSale(registerId, saleId);
        }
        public ISaleLineItem CreateSLIMessage(Guid areaId, Guid registerId, Guid saleId, string message)
        {
            var area = FetchArea(areaId);
            return area.CreateSLIMessage(registerId, saleId, message);
        }
        public IEnumerable<ISaleLineItem> FetchSalelineItems(Guid areaId, Guid registerId, Guid saleId)
        {
            var area = FetchArea(areaId);
            return area.FetchSalelineItems(registerId, saleId);
        }
        
        #endregion

        #region Payment
        public Payment AddCashPayment(Guid areaId, Guid registerId, Guid saleId, decimal paymentAmount)
        {
            var area = FetchArea(areaId);
            return area.AddCashPayment(registerId, saleId, paymentAmount);
        }
        public Payment AddEFTPOSPayment(Guid areaId, Guid registerId, Guid saleId, decimal paymentAmount)
        {
            var area = FetchArea(areaId);
            return area.AddEFTPOSPayment(registerId, saleId, paymentAmount);
        }

        #endregion

        #region MenuProduct
        public MenuProduct FetchMenuProduct(Guid MenuId, Guid menuProductId)
        {
            var menu = FetchMenu(MenuId);
            return menu.FetchMenuProduct(menuProductId);
        }

        public MenuProduct FetchMenuProduct(Guid menuProductId)
        {


            var menuProduct = Menus.SelectMany(m => m.MenuProducts).Where(mp => mp.Id.Equals(menuProductId)).FirstOrDefault();

            if (menuProduct == null)
            {
                throw new BusinessRuleException("Invalid menu product id supplied");
            }
            return menuProduct;
        }

        public MenuProduct AddMenuProduct(Guid menuId, Product product, decimal price)
        {
            var menu = FetchMenu(menuId);
            return menu.AddMenuProduct(product, price);
        }

        #endregion

        #region Interface Implementation

       
        IEnumerable<IArea> IRestaurant.Areas
        {
            get { return Areas.AsEnumerable<IArea>(); }
        }

        IEnumerable<IPerson> IRestaurant.People
        {
            get { return People.AsEnumerable<IPerson>(); }
        }

        IEnumerable<IMenu> IRestaurant.Menus
        {
            get { return Menus.AsEnumerable<IMenu>(); }
        }
        #endregion
    }
}

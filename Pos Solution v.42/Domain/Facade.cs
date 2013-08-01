using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Facade : IDisposable
    {
        private POSEntities _context = new POSEntities();
        private UserAccount currentUser { get; set; }
        private static Facade _instance;

        public Facade()
        {
            var users = _context.UserAccounts.ToList();
        }

        public static Facade Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Facade();
                return _instance;
            }
        }

        #region Properties
        public IEnumerable<ITable> Tables
        {
            get
            {
                return restaurant.Areas.SelectMany(a => a.Tables);
            }
        }

        public IRestaurant Restaurant
        {
            get
            {
                return restaurant;
            }
        }

        private Restaurant restaurant
        {
            get
            {
                return _context.Restaurants
                    .Include("People")
                    .Include("Areas.Tables")
                    .Include("Areas.Registers.Sales.SaleLineItems")
                    .Include("Areas.Registers.Sales.Payments")
                    .Include("Menus.MenuProducts")
                    .First();
            }
        }

        public IEnumerable<IArea> Areas
        {
            get
            {
                return Restaurant.Areas.AsEnumerable<IArea>();
            }
        }

        public IEnumerable<IPerson> People
        {
            get
            {
                return Restaurant.People.AsEnumerable<IPerson>();
            }
        }

        public IEnumerable<ICategory> Categories
        {
            get
            {
                return _context.Categories
                    .Include("Products.MenuProducts")
                    .AsEnumerable<ICategory>();
            }
        }

        public IEnumerable<IProduct> Products
        {
            get
            {
                return _context.Products.AsEnumerable<IProduct>();
            }
        }

        #endregion

        #region Category Management

        public ICategory AddCategory(string description)
        {
            var category = new Category(description);
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public ICategory FetchCategory(Guid categoryId)
        {
            var category = Categories.FirstOrDefault(c => c.Id.Equals(categoryId));
            if (category == null)
            {
                throw new BusinessRuleException("Invalid category id supplied");
            }
            return category;
        }

        public ICategory EditCategory(Guid categoryId, string description)
        {
            var category = FetchCategory(categoryId);
            (category as Category).Description = description;
            _context.SaveChanges();
            return category;
        }
        #endregion

        #region Product Management

        public IProduct AddProduct(Guid categoryId, decimal price, string description)
        {
            var category = FetchCategory(categoryId);
            var product = (category as Category).AddProduct(price, description);
            _context.SaveChanges();
            return product;
        }

        public IProduct EditProduct(Guid categoryId, Guid productId, decimal price, string description)
        {
            var category = FetchCategory(categoryId);
            var product = (category as Category).EditProduct(productId, price, description);
            _context.SaveChanges();
            return product;
        }

        public IProduct FetchProducts(Guid productId, Guid categoryId)
        {
            var category = FetchCategory(categoryId);
            return (category as Category).FetchProduct(productId);
        }

        public IProduct this[string productName]
        {
            get
            {
                return _context.Products.Where(p => p.Description.Equals(productName)).FirstOrDefault();
            }
        }

        public void DeleteProduct(Guid categoryId, Guid productId)
        {
            var category = FetchCategory(categoryId);
            var product = (category as Category).FetchProduct(productId);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public IProduct FetchProduct(Guid productId)
        {
            var product = Products.FirstOrDefault(p => p.Id.Equals(productId));
            if (product == null)
            {
                throw new BusinessRuleException("Invalid productId id supplied");
            }
            return product;
        }
        #endregion

        #region Area Management

        public IArea FetchArea(Guid areaId)
        {
            var area = restaurant.FetchArea(areaId);
            return area;
        }
        public IArea AddArea(string description)
        {
            var area = restaurant.AddArea(description);
            _context.SaveChanges();
            return area;
        }

        public IArea EditArea(Guid areaId, string description)
        {
            var area = restaurant.FetchArea(areaId);
            _context.SaveChanges();
            return area;
        }

        public IArea OpenArea(Guid areaId)
        {
            var area = restaurant.OpenArea(areaId);
            _context.SaveChanges();
            return area;
        }
        public IArea CloseArea(Guid areaId)
        {
            var area = restaurant.CloseArea(areaId);
            _context.SaveChanges();
            return area;
        }
        #endregion

        #region Table Management

        public ITable AddTable(Guid areaId, string tableNumber)
        {
            var table = restaurant.AddTable(areaId, tableNumber);
            _context.SaveChanges();
            return table;
        }

        public ITable FetchTable(Guid areaId, Guid tableId)
        {
            return restaurant.FetchTable(areaId, tableId);
        }

        public ITable OpenTable(Guid areaId, Guid tableId)
        {
            var table = restaurant.OpenTable(areaId, tableId);
            _context.SaveChanges();
            return table;
        }

        public ITable CloseTable(Guid areaId, Guid tableId)
        {
            var table = restaurant.CloseTable(areaId, tableId);
            _context.SaveChanges();
            return table;
        }

        public ITable ReserveTable(Guid areaId, Guid tableId)
        {
            var table = restaurant.ReserveTable(areaId, tableId);
            _context.SaveChanges();
            return table;
        }

        public ITable EditTable(Guid areaId, Guid tableId, string tableNumber)
        {
            var table = restaurant.EditTable(areaId, tableId, tableNumber);
            _context.SaveChanges();
            return table;
        }
        public void DeleteTable(Guid areaId, Guid tableId)
        {
            var table = FetchTable(areaId, tableId);
            _context.Tables.Remove(table as Table);
            _context.SaveChanges();

        }

        #endregion

        #region  Employee Management
        public IPerson AddEmployee(string firstName, string lastName, string phoneNumber, string email)
        {
            Person person = restaurant.AddEmployee(firstName, lastName, phoneNumber, email);
            _context.SaveChanges();
            return person;
        }

        public IPerson EditEmployee(Guid employeeId, string firstName, string lastName, string phoneNumber, string email)
        {
            var person = restaurant.EditEmployee(employeeId, firstName, lastName, phoneNumber, email);
            _context.SaveChanges();
            return person;
        }

        public void DeletePerson(Guid employeeID)
        {
            var personID = restaurant.FetchPerson(employeeID);
            //var useraccount = restaurant.FetchUser(employeeID);
            //_context.UserAccounts.Remove(useraccount);
            _context.People.Remove(personID);
            //_context.SaveChanges();
        }

        public IPerson FetchPersonID(Guid personID)
        {
            var id = People.FirstOrDefault(p => p.Id.Equals(personID));
            if (id == null)
            {
                throw new BusinessRuleException("Invalid person ID supplied");
            }
            return id;
        }


        public IUserAccount FetchUser(int password)
        {

            return restaurant.FetchUser(password);
        }

        public IEmployee Logon(int password)
        {
            currentUser = FetchUser(password) as UserAccount;
            return currentUser.Employee;
        }


        #endregion

        #region Manage Staff ( SEARCH )

        public IEnumerable<IPerson> this[string firstName, string lastName]
        {
            get
            {
                IEnumerable<IPerson> peopleListFirstName = new LinkedList<Person>();
                foreach (Person people in People)
                {
                    if (people.FirstName.Equals(firstName) && people.LastName.Equals(lastName))
                    {
                        peopleListFirstName = People.Where(p => p.FirstName.Equals(firstName) || p.LastName.Equals(lastName)).AsEnumerable<IPerson>();
                    }
                }
                return peopleListFirstName;
            }
        }

        #endregion

        #region Account Management

        public IUserAccount CreatAccount(Guid employeeID, int password)
        {
            var account = restaurant.CreateAccount(employeeID, password);
            _context.SaveChanges();
            return account;
        }

        public IUserAccount EditAccount(Guid employeeID, int password)
        {
            var account = restaurant.EditAccount(employeeID, password);
            _context.SaveChanges();
            return account;
        }

        public void DeleteAccount(Guid employeeID)
        {
            restaurant.DeleteAccount(employeeID);
            _context.SaveChanges();
        }
        #endregion

        #region Manage Item ( ADD, EDIT, DELETE )

        public IEnumerable<IProduct> this[string description, decimal price]
        {
            get
            {
                return Products.Where(p => p.Price == price && p.Description.Equals(description)).AsEnumerable<IProduct>();
                IEnumerable<Product> productList = new LinkedList<Product>();
                foreach (Product products in Products)
                    if (products.Price == price && products.Description.Equals(description))
                    {

                    }

                return productList;
            }
        }

        #endregion

        #region Register Management
        public IRegister AddRegister(Guid areaId, string registerName)
        {
            var register = restaurant.AddRegister(areaId, registerName);
            _context.SaveChanges();
            return register;
        }
        public IRegister EditRegister(Guid areaId, Guid registerId, string registerName)
        {
            var register = restaurant.EditRegister(areaId, registerId, registerName);
            _context.SaveChanges();
            return register;
        }

        public IRegister FetchRegister(Guid areaId, Guid registerId)
        {
            return restaurant.FetchRegister(areaId, registerId);
        }


        #endregion

        #region Sale Management
        public ISale CreateOTCSale(Guid areaId, Guid registerId, Guid userId)
        {
            var userAccount = restaurant.FetchUser(userId);
            var sale = restaurant.CreateOTCSale(areaId, registerId, userAccount);
            _context.SaveChanges();
            return sale;
        }
        public ISale CreateTableSale(Guid areaId, Guid registerId, Guid userId, Guid tableId)
        {
            var userAccount = restaurant.FetchUser(userId);
            var table = restaurant.FetchTable(tableId);
            var sale = restaurant.CreateTableSale(areaId, registerId, userAccount, table);
            _context.SaveChanges();
            return sale;
        }
        public void FinaliseSale(Guid areaId, Guid registerId, Guid saleId)
        {
            restaurant.FinaliseSale(areaId, registerId, saleId);
            _context.SaveChanges();
        }

        public void DeleteSales()
        {
            var register = restaurant.Areas.SelectMany(r => r.Registers).FirstOrDefault();
            var sales = register.Sales;
            var payments = register.Sales.SelectMany(p => p.Payments);
            var saleLineItems = register.Sales.SelectMany(p => p.SaleLineItems);
            var tableSales = _context.Tables.SelectMany(t => t.TableSales);

            foreach (var p in payments.ToList())
            {
                _context.Payments.Remove(p);
            }

            foreach (var sli in saleLineItems.ToList())
            {
                _context.SaleLineItems.Remove(sli);
            }

            foreach (var s in sales.ToList())
            {
                _context.Sales.Remove(s);
            }

            foreach (var t in Tables)
            {
                if (t.StateId != 1)
                {
                    Facade.Instance.OpenTable(t.AreaId, t.Id);
                }
            }
            _context.SaveChanges();
        }
        #endregion

        #region SalelineItem Management
        public ISaleLineItem AddSaleLineItem(Guid areaId, Guid registerId, Guid saleId, Guid menuProductId)
        {
            var menuProduct = restaurant.FetchMenuProduct(menuProductId);
            var sli = restaurant.AddSaleLineItem(areaId, registerId, saleId, menuProduct);
            _context.SaveChanges();
            return sli;
        }

        public int IncrementQuantity(Guid areaId, Guid registerId, Guid saleId, Guid menuProductId)
        {
            var menuProduct = restaurant.FetchMenuProduct(menuProductId);
            int quantity = restaurant.IncrementQuantity(areaId, registerId, saleId, menuProduct);
            _context.SaveChanges();
            return quantity;
        }

        public int DecrementQuantity(Guid areaId, Guid registerId, Guid saleId, Guid menuProductId)
        {
            var menuProduct = restaurant.FetchMenuProduct(menuProductId);
            int quantity = restaurant.DecrementQuantity(areaId, registerId, saleId, menuProduct);
            _context.SaveChanges();
            return quantity;
        }

        public void CancelSaleLineItem(Guid areaId, Guid registerId, Guid saleId, Guid menuProductId)
        {
            var menuProduct = restaurant.FetchMenuProduct(menuProductId);
            restaurant.CancelSaleLineItem(areaId, registerId, saleId, menuProduct);
            _context.SaveChanges();
        }
        public void VoidSale(Guid areaId, Guid registerId, Guid saleId)
        {
            restaurant.VoidSale(areaId, registerId, saleId);
            _context.SaveChanges();
        }
        public ISaleLineItem CreateSLIMessage(Guid areaId, Guid registerId, Guid saleId, string message)
        {
            var sli = restaurant.CreateSLIMessage(areaId, registerId, saleId, message);
            _context.SaveChanges();
            return sli;
        }
        public IEnumerable<ISaleLineItem> FetchSalelineItems(Guid areaId, Guid registerId, Guid saleId)
        {
            return restaurant.FetchSalelineItems(areaId, registerId, saleId);
        }
        #endregion

        #region MenuProduct Management
        public IMenuProduct FetchMenuProduct(Guid menuId, Guid menuProductId)
        {
            var menuProduct = restaurant.FetchMenuProduct(menuId, menuProductId);
            return menuProduct;
        }

        public void DeleteMenuProduct(Guid categoryId, Guid productId)
        {
            var category = FetchCategory(categoryId);
            var product = (category as Category).FetchProduct(productId);
            foreach (var m in product.MenuProducts)
            {
                _context.MenuProducts.Remove(m);
            }
            _context.SaveChanges();

        }

        public IMenuProduct AddMenuProduct(Guid menuId, Guid productId, decimal price)
        {
            var product = FetchProduct(productId) as Product;
            var menuProduct = restaurant.AddMenuProduct(menuId, product, price);
            _context.SaveChanges();
            return null;

        }

        #endregion

        #region Payment Management
        public IPayment AddCashPayment(Guid areaId, Guid registerId, Guid saleId, decimal paymentAmount)
        {
            var payment = restaurant.AddCashPayment(areaId, registerId, saleId, paymentAmount);
            _context.SaveChanges();
            return payment;
        }
        public IPayment AddEFTPOSPayment(Guid areaId, Guid registerId, Guid saleId, decimal paymentAmount)
        {
            var payment = restaurant.AddEFTPOSPayment(areaId, registerId, saleId, paymentAmount);
            _context.SaveChanges();
            return payment;
        }
        #endregion

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

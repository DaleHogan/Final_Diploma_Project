using MVCSharp.Core.Configuration.Tasks;
using MVCSharp.Core.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace POSApplication
{
    public class MainTask : TaskBase
    {
        #region Interaction Points
        [InteractionPoint(typeof(LoginViewController), IsCommonTarget = true)]
        public const string LoginView = "Login";

        [InteractionPoint(typeof(POSViewController), IsCommonTarget = true)]
        public const string POSView = "POSView";

        [InteractionPoint(typeof(TableViewController), IsCommonTarget = true)]
        public const string TableView = "TableView";

        [InteractionPoint(typeof(PaymentViewController), IsCommonTarget = true)]
        public const string PaymentView = "PaymentView";

        [InteractionPoint(typeof(SaleViewController), IsCommonTarget = true)]
        public const string SaleView = "SaleView";

        [InteractionPoint(typeof(AreaManagementViewController), IsCommonTarget = true)]
        public const string AreaManagementView = "AreaManagementView";

        [InteractionPoint(typeof(OSKViewController), IsCommonTarget = true)]
        public const string OSKView = "OSKView";

        [InteractionPoint(typeof(SettingViewController), IsCommonTarget = true)]
        public const string SettingView = "SettingView";

        [InteractionPoint(typeof(TableManagementViewController), IsCommonTarget = true)]
        public const string TableManagementView = "TableManagementView";

        [InteractionPoint(typeof(AddTableViewController), IsCommonTarget = true)]
        public const string AddTableView = "AddTableView";

        [InteractionPoint(typeof(EditTableViewController), IsCommonTarget = true)]
        public const string EditTableView = "EditTableView";

        [InteractionPoint(typeof(PriceLevelViewController), IsCommonTarget = true)]
        public const string PriceLevelView = "PriceLevelView";

        [InteractionPoint(typeof(ItemViewController), IsCommonTarget = true)]
        public const string ManageItemView = "ManageItemView";

        [InteractionPoint(typeof(ManageStaffMemberController), IsCommonTarget = true)]
        public const string ManageStaffMemberView = "ManageStaffMemberView";

        [InteractionPoint(typeof(ReportViewController), IsCommonTarget = true)]
        public const string ReportView = "ReportView";

        #endregion

        private IUserAccount _userAccount;

        public IUserAccount UserAccount
        {
            get
            {
                return _userAccount;
            }
        }

        private ISale _sale;

        public ISale Sale
        {
            get
            {
                return _sale;
            }
        }
        private ITable _table;

        public ITable Table
        {
            get
            {
                return _table;
            }
        }
        private string priceLevel = "Nomal Price";
        public string PriceLevel
        {
            get
            {
                return priceLevel;
            }
        }
        public override void OnStart(object param)
        {
            Navigator.NavigateDirectly(LoginView);
        }

        public Facade Facade
        {
            get
            {
                return Facade.Instance;
            }
        }

        public IRegister Register
        {
            get
            {
                return Facade.Instance.Areas.SelectMany(a => a.Registers).FirstOrDefault();
            }
        }

        public IEmployee Logon(int password)
        {
            var employee = Facade.Logon(password);
            _userAccount = employee.UserAccount;
            return employee;
        }

        public ISale CreateTableSale(Guid areaId, Guid registerId, Guid userId, Guid tableId)
        {
            var sale = Facade.CreateTableSale(areaId, registerId, userId, tableId);
            _sale = sale;
            return sale;
        }

        public ISale CreateOTCSale(Guid areaId, Guid registerId, Guid userId)
        {
            var sale = Facade.CreateOTCSale(areaId, registerId, userId);
            _sale = sale;
            return sale;
        }

        public ICategory FetchCategory(ICategory Category)
        {
            return Facade.FetchCategory(Category.Id);
        }

        public IProduct FetchProduct(IProduct Product)
        {
            return Facade.FetchProducts(Product.Id, Product.CategoryId);
        }

        public ISaleLineItem AddSaleLineItem(IMenuProduct menuProduct)
        {
            return Facade.AddSaleLineItem(Register.AreaId, Register.Id, Sale.Id, menuProduct.Id);
        }

        public int IncrementQuantity(IMenuProduct menuProduct)
        {
            return Facade.IncrementQuantity(Register.AreaId, Register.Id, Sale.Id, menuProduct.Id);
        }

        public int DecrementQuantity(IMenuProduct menuProduct)
        {
            return Facade.DecrementQuantity(Register.AreaId, Register.Id, Sale.Id, menuProduct.Id);
        }

        public void CancelSaleLineItem(IMenuProduct menuProduct)
        {
            Facade.CancelSaleLineItem(Register.AreaId, Register.Id, Sale.Id, menuProduct.Id);

        }

        public void VoidSale()
        {
            Facade.VoidSale(Register.AreaId, Register.Id, Sale.Id);
        }

        public IEnumerable<ISaleLineItem> FetchSalelineItems(ISale sale)
        {
            return Facade.FetchSalelineItems(Register.AreaId, Register.Id, Sale.Id);
        }

        public void DeleteSales()
        {
            Facade.DeleteSales();
        }

        public void FetchTableSale(ITable table)
        {
            _sale = table.TableSales.Last() as ISale;
        }

        public void CloseTable(ITable table)
        {
            Facade.CloseTable(table.AreaId, table.Id);
        }

        public void OpenTable(ITable table)
        {
            Facade.OpenTable(table.AreaId, table.Id);
        }

        public void ReserveTable(ITable table)
        {
            Facade.ReserveTable(table.AreaId, table.Id);
        }

        public void CreateCashPayment(decimal amount)
        {
            Facade.AddCashPayment(Register.AreaId, Register.Id, Sale.Id, amount);
        }

        public void CreateEftposPayment(decimal amount)
        {
            Facade.AddEFTPOSPayment(Register.AreaId, Register.Id, Sale.Id, amount);
        }

        public void OpenArea(IArea area)
        {
            Facade.OpenArea(area.Id);
        }

        public void CloseArea(IArea area)
        {
            Facade.CloseArea(area.Id);
        }

        public ISaleLineItem CreateSLIMessage(ISale sale, string message)
        {
            return Facade.CreateSLIMessage(Register.AreaId, Register.Id, sale.Id, message);
        }

        public void AddTable(IArea area, string tableNumber)
        {
            Facade.AddTable(area.Id, tableNumber);
        }

        public void AssignTable(ITable table)
        {
            _table = table;
        }

        public void EditTable(string tableNumber)
        {
            Facade.EditTable(Table.AreaId, Table.Id, tableNumber);
        }
        public void DeleteTable()
        {
            Facade.DeleteTable(Table.AreaId, Table.Id);
        }

        public void ChangePricelevel1()
        {
            priceLevel = "Nomal Price";
        }

        public void ChangePricelevel2()
        {
            priceLevel = "Happy Hour";
        }
    }
}

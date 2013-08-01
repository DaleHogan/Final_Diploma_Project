using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    internal partial class Area : IArea
    {
        public Area(Restaurant restaurant, string description)
        {
            this.Restaurant = restaurant;
            this.Description = description;
            this.StateId = 1; 
        }

        public void AreaOpen()
        {
           
        }
        #region Table
        public Table FetchTable(Guid tableId)
        {
            var table = Tables.FirstOrDefault(a => a.Id.Equals(tableId));
            if (table == null)
            {
                throw new BusinessRuleException("Invalid table id supplied");
            }
            return table; 
        }
        public Table AddTable(string tableNumber)
        {
           
            foreach (var t in Tables)
            {
                if (t.TableNumber.Equals(tableNumber))
                {
                    throw new BusinessRuleException("Table number must be unique");
                }
            }
           
            var table = new Table(this, tableNumber);
            Tables.Add(table);
            return table; 
        }
        public Table OpenTable(Guid tableId)
        {
            var table = FetchTable(tableId);
            table.Open();           
            return table;
        }

        public Table CloseTable(Guid tableId)
        {
            var table = FetchTable(tableId);
            table.Close(); 
            return table;
        }

        public Table ReserveTable(Guid tableId)
        {
            var table = FetchTable(tableId);
            table.Reserve(); 
            return table;
        }
        public Table EditTable(Guid tableId, string tableNumber)
        {
            var table = FetchTable(tableId);
            foreach (var t in Tables)
            {
                if(t.TableNumber.Equals(tableNumber))
                {
                    throw new BusinessRuleException("Table number must be unique");
                }
            }
            table.TableNumber = tableNumber;
            return table;
            
        }
       
        #endregion

        #region Register
        public Register AddRegister(string name)
        {
            var register = new Register(this, name);
            Registers.Add(register);
            return register;
        }
        public Register EditRegister(Guid registerId, string name)
        {
            var register = FetchRegister(registerId);
            register.Name = name;
            return register;
        }


        public Register FetchRegister(Guid registerId)
        {
            var register = Registers.FirstOrDefault(a => a.Id.Equals(registerId));
            if (register == null)
            {
                throw new BusinessRuleException("Invalid register id supplied");
            }
            return register;
        }
        #endregion

        #region Sale
        public Sale CreateOTCSale(Guid registerId, UserAccount userAccount)
        {
            var register = FetchRegister(registerId);
            return register.CreateOTCSale(userAccount);
   
        }
        public Sale CreateTableSale(Guid registerId, UserAccount userAccount, Table table)
        {
            var register = FetchRegister(registerId);
            return register.CreateTableSale(userAccount, table);

        }
        public void FinaliseSale(Guid registerId, Guid saleId)
        {
            var register = FetchRegister(registerId);
            
            register.FinaliseSale(saleId);
        }
        

        #endregion

        #region SalelineItem
        public SaleLineItem AddSaleLineItem(Guid registerId, Guid saleId,MenuProduct menuProduct)
        {
            var register = FetchRegister(registerId);
            return register.AddSaleLineItem(saleId, menuProduct);
        }

        public int IncrementQuantity(Guid registerId, Guid saleId,MenuProduct menuProduct)
        {
            var register = FetchRegister(registerId);
            return register.IncrementQuantity(saleId, menuProduct);
        }

        public int DecrementQuantity(Guid registerId, Guid saleId,MenuProduct menuProduct)
        {
            var register = FetchRegister(registerId);
            return register.DecrementQuantity(saleId, menuProduct);
        }

        public void CancelSaleLineItem(Guid registerId,Guid saleId, MenuProduct menuProduct)
        {
            var register = FetchRegister(registerId);
            register.CancelSaleLineItem(saleId,menuProduct);
        }

        public void VoidSale(Guid registerId, Guid saleId)
        {
            var register = FetchRegister(registerId);
            register.VoidSale(saleId);
        }
        public ISaleLineItem CreateSLIMessage(Guid registerId, Guid saleId, string message)
        {
            var register = FetchRegister(registerId);
            return register.CreateSLIMessage(saleId, message);
        }
        public IEnumerable<ISaleLineItem> FetchSalelineItems(Guid registerId,Guid saleId)
        {
           var register = FetchRegister(registerId);
           return register.FetchSalelineItems(saleId);
        }

        #endregion

        #region Payment
        public Payment AddCashPayment(Guid registerId, Guid saleId, decimal paymentAmount)
        {
            var register = FetchRegister(registerId);
            return register.AddCashPayment(saleId,paymentAmount);
        }
        public Payment AddEFTPOSPayment(Guid registerId, Guid saleId, decimal paymentAmount)
        {
            var register = FetchRegister(registerId);
            return register.AddEFTPOSPayment(saleId,paymentAmount);
        }
        #endregion

        #region State Machine

        private ServiceState _stateMachine;

        partial void ObjectPropertyChanged(string propertyName)
        {
            switch (propertyName)
            {
                case "StateId":
                    setState();
                    break;
            }
        }

        private void setState()
        {
            switch (StateId)
            {
                case 1:
                    _stateMachine = new AreaOpen();
                    break;
                case 2:
                    _stateMachine = new AreaClosed();
                    break;
                
            }
        }

        #endregion

        #region Interface Implementation
        IEnumerable<IRegister> IArea.Registers
        {
            get { return Registers.AsEnumerable<IRegister>(); }
        }

        IRestaurant IArea.Restaurant
        {
            get { return Restaurant; }
        }

        IEnumerable<ITable> IArea.Tables
        {
            get { return Tables.AsEnumerable<ITable>(); }
        }

        States IArea.State
        {
            get { return _stateMachine.State; }
        }
        #endregion


        
    }
}

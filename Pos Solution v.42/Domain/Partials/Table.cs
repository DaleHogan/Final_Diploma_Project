using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    internal partial class Table : ITable
    {
        public Table(Area area, string tableNumber)
        {
            this.Area = area;
            this.TableNumber = tableNumber;
            this.StateId = 1;
            this.TableSales = new HashSet<TableSale>();
        }


       


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

        public void Open()
        {
            _stateMachine.Open(delegate() { StateId = 1; }); 
        }


        public void Close()
        {
            _stateMachine.Close(delegate() { StateId = 2; }); 
        }

        public void Reserve()
        {
            _stateMachine.Reserve(delegate() { StateId = 3; }); 
        }

        private void setState()
        {
            switch (StateId)
            {
                case 1:
                    _stateMachine = new TableOpen();
                    break;
                case 2:
                    _stateMachine = new TableClosed();
                    break;
                case 3:
                    _stateMachine = new TableOccupied();
                    break;
            }
        }

        #endregion

        #region Interface Implementation

        IArea ITable.Area
        {
            get { return Area; }
        }

        IEnumerable<ITableSale> ITable.TableSales
        {
            get { return TableSales.AsEnumerable<ITableSale>(); }
        }
        #endregion




        States ITable.State
        {
            get { return _stateMachine.State; }
        }
    }
}

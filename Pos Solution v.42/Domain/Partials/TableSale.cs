using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal partial class TableSale : Sale, ITableSale
    {
        public TableSale() { }
        public TableSale(Register register, UserAccount userAccount, Table table)
            : base(register, userAccount)
        {

            this.Table = table;
           
        }
        public override SaleType SaleType
        {
            get { return SaleType.Table; }
        }
        #region Interface Implementation
        ITable ITableSale.Table
        {
            get { return Table; }
        }
        

        
        #endregion
    }
}

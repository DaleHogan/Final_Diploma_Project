using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal partial class UserAccount : IUserAccount
    {
        
        public UserAccount(Employee employee, int password)
        {
            this.Employee = employee;
            this.Password = password;
            this.StateId = 1;
        }

        public override string ToString()
        {
            return Employee.FirstName;
        }
        #region Interface Implementation
        IEmployee IUserAccount.Employee
        {
            get { return Employee; }
        }

        IEnumerable<ISale> IUserAccount.Sales
        {
            get { return Sales.AsEnumerable<ISale>(); }
        }
        #endregion
    }
}

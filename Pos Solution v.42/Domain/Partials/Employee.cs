using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal partial class Employee : Person, IEmployee
    {
        public Employee() : base() { }

        public Employee(Restaurant restaurant, string firstName, string lastName, string phoneNumber, string email)
            : base(restaurant, firstName, lastName, phoneNumber, email)
        {
        }

    
        public  UserAccount CreateAccount(int password)
       {
           var userAccount = new UserAccount(this, password);
           if (this.UserAccount == null)
           {
               this.UserAccount = userAccount;
           }
           else
           {
               throw new BusinessRuleException("1 user account is allowed");
           }
               return userAccount;
                                    
        }
        public UserAccount EditAccount(int password)
       {
            var userAccount = new UserAccount(this,password);
            if(this.UserAccount !=null)
            {
                this.UserAccount = userAccount;
            }
            else
            {
                throw new BusinessRuleException("There is no user account yet");
            }
               return userAccount;
                                    
        }
        public void DeleteAccount()
       {
           if (this.UserAccount != null)
           {
               this.UserAccount = null;
           }
           else
           {
               throw new BusinessRuleException("There is no user account yet");
           }
           
                                    
        }


        #region Interface Implementation
        IUserAccount IEmployee.UserAccount
        {
            get { return UserAccount; }
        }
        #endregion
    }
}

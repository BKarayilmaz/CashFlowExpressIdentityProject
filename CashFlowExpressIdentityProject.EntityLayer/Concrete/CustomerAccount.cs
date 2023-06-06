using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlowExpressIdentityProject.EntityLayer.Concrete
{
    //Access Modifier
    //Public: It is accessible and usable from anywhere.
    //Private: It is only accessible and usable within the defined class.
    //Protected: It is accessible and usable within the defined class and its derived classes.
    //Internal : It is accessible and usable within the same assembly.

    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string CustomerAccounCurrency { get; set;}
        public decimal CustomerAccountBalance { get; set; }
        public string BankBranch { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_01
{
    public class FailedWithdrawalException : Exception
    {
        public FailedWithdrawalException(string message) : base(message)
        {
           
        }
    }
}

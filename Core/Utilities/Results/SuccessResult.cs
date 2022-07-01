using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    internal class SuccessResult : Result
    {
        public SuccessResult(bool status, string message) : base(true, message)
        {

        }
        public SuccessResult(bool status) : base(true)
        {

        }
    }
}

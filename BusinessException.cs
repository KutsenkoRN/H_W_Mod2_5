using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod2_5
{
        internal class BusinessException : Exception
    {
        public BusinessException(string message) : base(message)
        {
        }
    }
}
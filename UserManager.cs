using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace active_way
{
    public static class UserManager
    {
        public static SecureString UserId { get; private set; }

        public static void SetUserId(string userId)
        {
            UserId = new SecureString();
            foreach (char c in userId)
            {
                UserId.AppendChar(c);
            }
        }

        public static string GetUserId()
        {
            IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(UserId);
            try
            {
                return System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
            }
        }
    }

}

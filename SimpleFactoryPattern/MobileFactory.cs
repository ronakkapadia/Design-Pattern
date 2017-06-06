using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class MobileFactory
    {
        public static IMobile Create (Mobile mobile, params object[] args)
        {
            if (mobile == Mobile.IPhone)
            {
                return (IMobile) Activator.CreateInstance(typeof(IPhone), args);
            }
            else if (mobile == Mobile.Samsung)
            {
                return (IMobile) Activator.CreateInstance(typeof(Samsung), args);
            }
            else if (mobile == Mobile.Sony)
            {
                return (IMobile) Activator.CreateInstance(typeof(Sony), args);
            }
            else
                return null;
            
        }
    }
}

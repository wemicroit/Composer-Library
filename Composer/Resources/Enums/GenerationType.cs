using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeMicroIt.Utils.Composer.Resources.Enums
{
    /// <include file='./docs/Enums.xml' path='doc/enums[@name="GenerationType"]/enum/*'/> 
    public enum GenerationType
    {
        /// <include file='./docs/Enums.xml' path='doc/enums[@name="GenerationType"]/field[@name="Markdown"]/*'/> 
        Markdown = 0,
        /// <include file='./docs/Enums.xml' path='doc/enums[@name="GenerationType"]/field[@name="XML"]/*'/> 
        XML = 1,
        /// <include file='./docs/Enums.xml' path='doc/enums[@name="GenerationType"]/field[@name="HTML"]/*'/> 
        Html = 2,
        /// <include file='./docs/Enums.xml' path='doc/enums[@name="GenerationType"]/field[@name="JSON"]/*'/> 
        JSON = 3,
        /// <include file='./docs/Enums.xml' path='doc/enums[@name="GenerationType"]/field[@name="CSV"]/*'/> 
        CSV = 4,
        /// <include file='./docs/Enums.xml' path='doc/enums[@name="GenerationType"]/field[@name="Raw"]/*'/> 
        Raw = 5
    }
}

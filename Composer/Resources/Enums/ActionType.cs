using System;
using System.Collections.Generic;
using System.Text;

namespace WeMicroIt.Utils.Composer.Resources.Enums
{
    /// <include file='./docs/Enums.xml' path='doc/enums[@name="ActionType"]/enum/*'/> 
    public enum ActionType
    {
        /// <include file='./docs/Enums.xml' path='doc/enums[@name="ActionType"]/field[@name="Unknown"]/*'/> 
        Unknown = 0,
        /// <include file='./docs/Enums.xml' path='doc/enums[@name="ActionType"]/field[@name="Transform"]/*'/> 
        Transform = 1,
        /// <include file='./docs/Enums.xml' path='doc/enums[@name="ActionType"]/field[@name="Split"]/*'/> 
        Split = 2,
        /// <include file='./docs/Enums.xml' path='doc/enums[@name="ActionType"]/field[@name="SplitAndTransform"]/*'/> 
        SplitAndTransform = 3,
        /// <include file='./docs/Enums.xml' path='doc/enums[@name="ActionType"]/field[@name="FileRename"]/*'/> 
        FileRename = 4
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeMicroIt.Utils.Composer.Resources;

namespace WeMicroIt.Utils.Composer.Models
{
    /// <include file='./docs/Models.xml' path='doc/models[@name="ComposeData"]/model/*'/> 
    public class ComposeData
    {
        /// <include file='./docs/Models.xml' path='doc/models[@name="ComposeData"]/properties[@name="Cycles"]/*'/> 
        public List<Cycle> Cycles { get; set; }
        /// <include file='./docs/Models.xml' path='doc/models[@name="ComposeData"]/properties[@name="GenerateIndexes"]/*'/> 
        public bool GenerateIndexes { get; set; }
        /// <include file='./docs/Models.xml' path='doc/models[@name="ComposeData"]/properties[@name="JsonHierachy"]/*'/> 
        public bool JsonHierachy { get; set; }
        /// <include file='./docs/Models.xml' path='doc/models[@name="ComposeData"]/properties[@name="NodeJS"]/*'/> 
        public bool NodeJS { get; set; } = false;

        /// <include file='./docs/Models.xml' path='doc/models[@name="ComposeData"]/constructor[@name="Default"]/*'/> 
        public ComposeData()
        {
            GenerateIndexes = false;
            NodeJS = false;
        }
    }
}

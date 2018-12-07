using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeMicroIt.Utils.Composer.Models;
using WeMicroIt.Utils.Composer.Resources.Enums;
using WeMicroIt.Utils.FileConverter;

namespace WeMicroIt.Utils.Composer
{
    /// <include file='./docs/Classes.xml' path='doc/classes[@name="Compose"]/class/*'/> /// <include file='./docs/Classes.xml' path='doc/classes[@name="Compose"]/class/*'/> 
    public class Compose
    {
        /// <include file='./docs/Classes.xml' path='doc/classes[@name="Compose"]/properties[@name="Templater"]/*'/> 
        public string Templater
        {
            set
            {
                fileComms.Templater = value;
            }
        }

        /// <include file='./docs/Classes.xml' path='doc/classes[@name="Compose"]/properties[@name="Reader"]/*'/> 
        public string Reader
        {
            set
            {
                fileComms.Reader = value;
            }
        }

        /// <include file='./docs/Classes.xml' path='doc/classes[@name="Compose"]/properties[@name="Writer"]/*'/> 
        public string Writer
        {
            set
            {
                fileComms.Writer = value;
            }
        }

        private FileManager fileComms { get; set; }

        /// <include file='./docs/Classes.xml' path='doc/classes[@name="Compose"]/constructor[@name="Default"]/*'/> 
        public Compose()
        {
            fileComms = new FileManager();
        }

        /// <include file='./docs/Classes.xml' path='doc/classes[@name="Compose"]/methods[@name="Process"]/*'/> 
        public bool Process(ComposeData Data)
        {
            foreach (var cycle in Data.Cycles)
            {
                switch (cycle.InputType)
                {
                    case GenerationType.JSON:
                        break;
                    case GenerationType.CSV:
                        break;
                    case GenerationType.Raw:
                        continue;
                }
                switch (cycle.ActionType)
                {
                    case ActionType.Unknown:
                        continue;
                    case ActionType.Transform:
                        SetStreams(cycle.SourcePath, cycle.FullPath, cycle.TemplatePath);
                        fileComms.TransformXML();
                        break;
                    case ActionType.Split:
                        SetStreams(cycle.SourcePath, cycle.FullPath);
                        fileComms.SplitXML(cycle.QueryPath, cycle.NewFileName);
                        break;
                    case ActionType.SplitAndTransform:
                        SetStreams(cycle.SourcePath, cycle.FullPath, cycle.TemplatePath);
                        fileComms.SplitAndTransformXML(cycle.QueryPath, cycle.GroupPath, cycle.NewFileName);
                        break;
                    case ActionType.FileRename:
                        SetStreams(cycle.SourcePath, cycle.DestinationDir);
                        fileComms.ConvertXMLFolderToRaw(cycle.Preserve);
                        break;
                    default:
                        break;
                }
            }
            return true;
        }

        /// <include file='./docs/Classes.xml' path='doc/classes[@name="Compose"]/methods[@name="SetStreams"][@version="Both"]/*'/> 
        public bool SetStreams(string read, string write)
        {
            Reader = read;
            Writer = write;
            return true;
        }

        /// <include file='./docs/Classes.xml' path='doc/classes[@name="Compose"]/methods[@name="SetStreams"][@version="All"]/*'/> 
        public bool SetStreams(string read, string write, string template)
        {
            Reader = read;
            Writer = write;
            Templater = template;
            return true;
        }
    }
}

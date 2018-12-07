using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WeMicroIt.Utils.Composer.Resources.Enums;

namespace WeMicroIt.Utils.Composer.Models
{
    /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/model/*'/> 
    public class Cycle
    {
        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/properties[@name="ActionType"]/*'/> 
        public ActionType ActionType { get; set; }
        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/properties[@name="InputType"]/*'/> 
        public GenerationType InputType { get; set; }
        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/properties[@name="OutputType"]/*'/> 
        public GenerationType OutputType { get; set; }
        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/properties[@name="SourcePath"]/*'/> 
        public string SourcePath { get; set; }
        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/properties[@name="TemplatePath"]/*'/> 
        public string TemplatePath { get; set; }
        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/properties[@name="DestinationDir"]/*'/> 
        public string DestinationDir { get; set; }
        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/properties[@name="NewFileName"]/*'/> 
        public string NewFileName { get; set; }
        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/properties[@name="QueryPath"]/*'/> 
        public string QueryPath { get; set; }
        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/properties[@name="GroupPath"]/*'/> 
        public string GroupPath { get; set; }
        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/properties[@name="DevEnvironment"]/*'/> 
        public string DevEnvironment { get; set; }
        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/properties[@name="Version"]/*'/> 
        public string Version { get; set; }
        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/properties[@name="Preserve"]/*'/> 
        public bool Preserve { get; set; }

        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/properties[@name="FullPath"]/*'/> 
        public string FullPath
        {
            get
            {
                if (!string.IsNullOrEmpty(NewFileName))
                {
                    throw new ArgumentNullException();
                }
                return Path.Combine(FullDestination, string.Join(".", NewFileName, OutputType.ToString()));
            }
        }

        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/properties[@name="FullDestination"]/*'/> 
        public string FullDestination
        {
            get
            {
                if (!string.IsNullOrEmpty(Version))
                {
                    return Path.Combine(DestinationDir, DevEnvironment, Version);
                }
                else if (!string.IsNullOrEmpty(DevEnvironment))
                {
                    return Path.Combine(DestinationDir, DevEnvironment);
                }
                else
                {
                    return DestinationDir;
                }
            }
        }

        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/properties[@name="FullName"]/*'/> 
        public string FullName
        {
            get
            {
                return string.Join(".", NewFileName, OutputType);
            }
        }

        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/constructor[@name="Default"]/*'/> 
        public Cycle()
        {

        }

        /// <include file='./docs/Models.xml' path='doc/models[@name="Cycle"]/constructor[@name="Type"]/*'/> 
        public Cycle(ActionType type)
        {
            ActionType = type;
            SourcePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            TemplatePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "WeMicroIt", "Composer", "Templates");
            DestinationDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            NewFileName = "";
            InputType = GenerationType.XML;
            OutputType = GenerationType.XML;
            switch (type)
            {
                case ActionType.Unknown:
                    break;
                case ActionType.Transform:
                    break;
                case ActionType.Split:
                    NewFileName = "name";
                    break;
                case ActionType.SplitAndTransform:
                    NewFileName = "name";
                    QueryPath = "items/item";
                    GroupPath = "name";
                    DevEnvironment = "Debug";
                    Version = "1";
                    break;
                case ActionType.FileRename:
                    break;
                default:
                    break;
            }
        }
    }
}

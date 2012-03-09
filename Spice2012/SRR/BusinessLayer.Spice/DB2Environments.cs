using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Xml;
using Disney.iDash.Shared;

namespace Disney.iDash.BusinessLayer
{
    public class DB2Environment
    {
        public string HostName { get; set; }
        public string Domain { get; set; }
        public string EnvironmentName { get; set; }
        public string Country { get; set; }
        public string EnvironmentType { get; set; }
        public int Port {get; set;}
        public string Label {get; set;}

        public DB2Environment()
        {
            this.HostName = string.Empty;
            this.Port = 5042;
            this.Label = "DG400";
            this.EnvironmentType = "*NonProduction";              
        }
    }

    public class DB2Environments
    {
        private List<DB2Environment> _items = new List<DB2Environment>();

        public ExceptionHandler ExceptionHandler = new ExceptionHandler();

        public List<DB2Environment> List
        {
            get { return _items; }
        }

        public bool LoadXml()
        {
            return LoadXml(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Environments.xml");
        }

        public bool LoadXml(string filename)
        {
            var result = false;
            if (System.IO.File.Exists(filename))
            {
                XmlTextReader xmlReader = null;

                try
                {
                    xmlReader = new XmlTextReader(filename);
                    while (!xmlReader.EOF)
                    {
                        xmlReader.Read();
                        if (xmlReader.Name == "Environment")
                        {
                            var item = new DB2Environment();
                            foreach (var pi in item.GetType().GetProperties())
                            {
                                var value = xmlReader.GetAttribute(pi.Name);
                                if (value != null)
                                    pi.SetValue(item, value, null);
                            }
                            _items.Add(item);
                        }
                    }

                    result = true;
                }
                catch (XmlException ex)
                {
                    ExceptionHandler.RaiseException(ex, "LoadXml(" + filename + ")");
                }
                catch (Exception ex)
                {
                    ExceptionHandler.RaiseException(ex, "LoadXml(" + filename + ")");
                }
                finally
                {
                    if (xmlReader != null)
                        xmlReader.Close();
                }
            }
            return result;
        }
    }


}

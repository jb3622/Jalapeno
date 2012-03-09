using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Disney.iDash.DataLayer;
using Disney.iDash.Shared;
using System.Xml;
using System.Reflection;

namespace Disney.iDash.BusinessLayer
{
    public class User
    {
        public string UserId { get; private set; }
        public string Username { get; private set; }
        public string Initials { get; private set; }
        public bool UserEnabled { get; private set; }
        public int TimeOutMinutes { get; private set; }
        public string EmailAddress { get; private set; }
        public string DB2Environment { get; private set; }

        public List<string> Applications { get; private set; }
        public List<string> MenuOptions { get; private set; }
        public List<int> Departments { get; private set; }
        public List<string> Environments { get; private set; }
        public List<string> Markets { get; private set; }

        public ExceptionHandler ExceptionHandler = new ExceptionHandler();
        private DB2Factory _factory = new DB2Factory();

        public User()
        {

            UserId = string.Empty;
            Username = string.Empty;
            Initials = string.Empty;
            UserEnabled = false;
            TimeOutMinutes = 5;
            EmailAddress = string.Empty;
            DB2Environment = string.Empty;

            Applications = new List<string>();
            MenuOptions = new List<string>();
            Departments = new List<int>();
            Environments = new List<string>();
            Markets = new List<string>();

            _factory.ExceptionHandler.OnException += ((ex, extraInfo, terminateApplication) =>
                {
                    ExceptionHandler.RaiseException(ex, extraInfo, terminateApplication);
                });
        }

    }

    public class Users
    {
        private List<User> _items = new List<User>();

        public ExceptionHandler ExceptionHandler = new ExceptionHandler();

        public List<User> List
        {
            get { return _items; }
        }

        public bool Authenticate(string userName, string password, string db2Environmnent)
        {
            var result = true;

            return result;
        }
        
        public bool LoadXml()
        {
            return LoadXml(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Users.xml");
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
                        if (xmlReader.Name == "User")
                        {
                            var item = new User();
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

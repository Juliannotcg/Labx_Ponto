using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Xml;

namespace LabxPonto_View
{
    public class ConfigurarBanco
    {

        public void configBase(string servidor, string usuario, string senha)
        {
            StringBuilder Con = new StringBuilder("Server=");
            Con.Append(servidor);
            Con.Append(";Database=");
            Con.Append("eponto");
            Con.Append(";User ID=");
            Con.Append(usuario);
            Con.Append(";Password=");
            Con.Append(senha);
            Con.Append(";Trusted_Connection = False");
            Con.Append(";Encrypt = False;");
            string strCon = Con.ToString();
            updateConfigFile(strCon);

            SqlConnection Db = new SqlConnection();

            ConfigurationManager.RefreshSection("connectionStrings");
            Db.ConnectionString = ConfigurationManager.ConnectionStrings["ConexaoPonto"].ToString();
        }

        public void updateConfigFile(string con)
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    xElement.FirstChild.Attributes[2].Value = con;
                }
            }

            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }
    }
}

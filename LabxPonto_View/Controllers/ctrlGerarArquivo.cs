using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LabxPonto_View.Controllers
{
    public class ctrlGerarArquivo
    {
        public bool gerarXml()
        {
            // Aqui o método irá na cadama DAL pegar no banco os dados que precisa para criar o arquivo.

            //Caminho onde o arquivo será salvo, no meu caso será:
            //C:\inetpub\wwwroot\exemplos\exemplo3.xml
            //string strFilePath = Server.MapPath("~/exemplo3.xml");
            
            //Esta linha indica que o o arquivo xml sera salvo, diferente dos outros exemplos
            XmlTextWriter xtw = new XmlTextWriter("strFilePath", Encoding.UTF8);
            
            //A linha abaixo vai identar o código, se não usar isso tudo ficará em uma linha.
            xtw.Formatting = Formatting.Indented;

            //Escreve a declaração do documento <?xml version="1.0" encoding="utf-8"?>
            xtw.WriteStartDocument();

            xtw.WriteStartElement("Tag Pai");
            xtw.WriteElementString("Nome da Tag", "Valor da Tag");
            xtw.WriteEndElement();
       
            xtw.WriteEndDocument();

            //libera o XmlTextWriter
            xtw.Flush();
            //fechar o XmlTextWriter
            xtw.Close();
            //Termina aqui

            return (true);
        }
    }
}

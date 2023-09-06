using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var doc = XDocument.Load("C:\\SSIS\\Exercices\\MSBIProject\\Data\\currency1.xml");

            var query = doc.Descendants("Currency");
            int index = 0;
                foreach (var item in query)
                {
                    XNode firstnode = item.FirstNode;
                    firstnode.AddBeforeSelf(new XElement("CurrencyKey",++index));

                item.Elements("CurrencyKey").Skip(1).ToList().ForEach(x => { x.Name = "CurrencyAlternativeKey"; });
                    
                    Console.WriteLine(item.ToString());  
                }
            
            doc.Save("C:\\SSIS\\Exercices\\MSBIProject\\Data\\currency2.xml");

            Console.Read();
        }

    }

   

    
}

//delete element
/*
  var doc = XDocument.Load("C:\\SSIS\\Exercices\\MSBIProject\\Data\\currency.xml");
            var query = doc.Descendants("CurrencyKey");
            query.Remove();
            query.ToList().ForEach(x => { x.Remove(); });
            doc.Save("C:\\SSIS\\Exercices\\MSBIProject\\Data\\currency1.xml");
            
 
 */

//Rename element
/*
  var doc = XDocument.Load("C:\\SSIS\\Exercices\\MSBIProject\\Data\\currency.xml");

            var query = doc.Descendants("CurrencyKey");
            query.Remove();
            query.ToList().ForEach(x => { x.Remove(); });

            foreach (var item in doc.Descendants())
            {
                if(item.Name.LocalName.Equals("CurrencyAlternateKey"))
                {
                    item.Name = "CurrencyKey";
                }
            }
            doc.Save("C:\\SSIS\\Exercices\\MSBIProject\\Data\\currency1.xml");
 
 
 */

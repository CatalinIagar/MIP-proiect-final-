using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace XMLLibrary
{
    public class XmlHandler
    {
         bool insertXml(string directoryAndFile,int id, string fname, string lname, string descriere) {

            string basePath = Environment.CurrentDirectory;
            string relativePath = directoryAndFile;
            string fullPath = Path.Combine(basePath, relativePath);

            try {
                XDocument doc = XDocument.Load(fullPath);

                XElement root = new XElement("Candidat");
                root.Add(new XAttribute("Id", id));
                root.Add(new XElement("Nume", fname));
                root.Add(new XElement("Prenume", lname));
                root.Add(new XElement("Descriere", descriere));
                doc.Element("Candidati").Add(root);
                doc.Save(fullPath);
                
                return true;
            }
            catch (FileNotFoundException ee) {

                try {
                    XmlTextWriter wt = new XmlTextWriter(fullPath, null);
                    wt.WriteStartDocument();
                    wt.WriteWhitespace("\n");
                    wt.WriteStartElement("Candidati");
                    wt.WriteWhitespace("\n");
                    wt.WriteStartElement("Candidat");
                    wt.WriteWhitespace("\n\t");
                    wt.WriteElementString("Id",id.ToString());
                    wt.WriteWhitespace("\n\t");
                    wt.WriteElementString("Nume", fname);
                    wt.WriteWhitespace("\n\t");
                    wt.WriteElementString("Prenume", lname);
                    wt.WriteWhitespace("\n\t");
                    wt.WriteElementString("Descriere", descriere);
                    wt.WriteWhitespace("\n");
                    wt.WriteEndElement();
                    wt.WriteWhitespace("\n");
                    wt.WriteEndElement();
                    wt.Flush();
                    wt.Close();

                    return true;
                }
                catch (DirectoryNotFoundException eee) {
                    Console.WriteLine(eee.Message);
                    return false;
                }
            }
            return false;
        }


    }
}

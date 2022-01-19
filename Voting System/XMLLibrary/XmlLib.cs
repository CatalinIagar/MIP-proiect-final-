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
         public bool insertXml(string directoryAndFile,int id, string fname, string lname, string descriere, string imageName) {

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
                root.Add(new XElement("ImageSource" ,imageName));
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
                    wt.WriteAttributeString("Id", id.ToString());
                    wt.WriteWhitespace("\n\t");
                    wt.WriteElementString("Nume", fname);
                    wt.WriteWhitespace("\n\t");
                    wt.WriteElementString("Prenume", lname);
                    wt.WriteWhitespace("\n\t");
                    wt.WriteElementString("Descriere", descriere);
                    wt.WriteWhitespace("\n\t");
                    wt.WriteElementString("ImageSource", imageName);                 
                    wt.WriteWhitespace("\n");
                    wt.WriteEndElement();
                    wt.WriteWhitespace("\n");
                    wt.WriteEndElement();
                    wt.Flush();
                    wt.Close();

                    Console.WriteLine("Done");
                    return true;
                }
                catch (DirectoryNotFoundException eee) {
                    Console.WriteLine(eee.Message);
                    return false;
                }
            }
            return false;
        }

       public bool deleteCandidatXml(string directoryAndFile, int id) {

            string basePath = Environment.CurrentDirectory;
            string relativePath = directoryAndFile;
            string fullPath = Path.Combine(basePath, relativePath);

            try {

                XElement xelem = XElement.Load(fullPath);
                
                foreach (XElement element in xelem.Elements("Candidat")) {

              
                   if (element.Attribute("Id").Value == id.ToString()) {
                       element.Remove();
                        Console.WriteLine("Sters");
                        xelem.Save(fullPath);
                       
                        return true;
                   }

                }


            }
            catch (FileNotFoundException ee) {
                Console.WriteLine("Eroare: " + ee.Message);
                return false;
            }

            return false;
        }

       public string getDescription(string directoryAndFile, int id) {

            string basePath = Environment.CurrentDirectory;
            string relativePath = directoryAndFile;
            string fullPath = Path.Combine(basePath, relativePath);

            try {

                XElement xelem = XElement.Load(fullPath);
               
                foreach (XElement element in xelem.Elements("Candidat")) {

                    if (element.Attribute("Id").Value == id.ToString()) {
                        return element.Element("Descriere").Value.ToString();
                    }
                }

            }
            catch (FileNotFoundException ee) {
                Console.WriteLine("Eroare: " + ee.Message);
                return "";
            }
            return "";
        }

        public string getImageName(string directoryAndFile, int id) {

            string basePath = Environment.CurrentDirectory;
            string relativePath = directoryAndFile;
            string fullPath = Path.Combine(basePath, relativePath);

            try {

                XElement xelem = XElement.Load(fullPath);

                foreach (XElement element in xelem.Elements("Candidat")) {

                    if (element.Attribute("Id").Value == id.ToString()) {
                        return element.Element("ImageSource").Value.ToString();
                    }
                }

            }
            catch (FileNotFoundException ee) {
                Console.WriteLine("Eroare: " + ee.Message);
                return "";
            }
            return "";
        }

        public bool modifyDescription(string directoryAndFile, int id, string description) {

            string basePath = Environment.CurrentDirectory;
            string relativePath = directoryAndFile;
            string fullPath = Path.Combine(basePath, relativePath);

            try {

                XElement xelem = XElement.Load(fullPath);

                foreach (XElement element in xelem.Elements("Candidat")) {

                    if (element.Attribute("Id").Value == id.ToString()) {
                       element.Element("Descriere").SetValue(description);
                        Console.WriteLine("Modificat");
                        xelem.Save(fullPath);
                        return true;
                    }

                }


            }
            catch (FileNotFoundException ee) {
                Console.WriteLine("Eroare: " + ee.Message);
                return false;
            }

            return false;
        }
    }
}

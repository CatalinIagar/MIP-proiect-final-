using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Threading;
using System.IO;

namespace Voting_System.Controllers {
    public class XmlController {

      private static TraceController traceController = TraceController.getInstance();
      private static bool runInsertMethod(string directoryAndFile, int id, string fname, string lname, string descriere, string imageName) {

            string basePath = Environment.CurrentDirectory;
            string relativePath = @"data\XMLLibrary.dll";
            string fullPath = Path.Combine(basePath, relativePath);

            Assembly reflDLL = Assembly.LoadFile(fullPath);

            if (reflDLL == null) {
                traceController.logMessage("Assambley negasit");
                return false;
            }
            else {

                try {
                    dynamic d = reflDLL.CreateInstance("XMLLibrary.XmlHandler");
                    d.insertXml(directoryAndFile, id,fname,lname,descriere,imageName);
                   return true;
                }
                catch (System.NullReferenceException eeeee) {
                    traceController.logMessage(eeeee.Message);
                    return false;
                }
               
            }
            return false;
        }

      private static bool rundeleteMethod(string directoryAndFile, int id) {

            string basePath = Environment.CurrentDirectory;
            string relativePath = @"data\XMLLibrary.dll";
            string fullPath = Path.Combine(basePath, relativePath);

            Assembly reflDLL = Assembly.LoadFile(fullPath);

            if (reflDLL == null) {
                traceController.logMessage("Assambley negasit!");
                return false;
            }
            else {

                try {
                    dynamic d = reflDLL.CreateInstance("XMLLibrary.XmlHandler");
                    d.deleteCandidatXml(directoryAndFile, id);
                    return true;
                }
                catch (System.NullReferenceException eeeee) {
                    traceController.logMessage(eeeee.Message);
                    return false;
                }

            }
            return false;
        }

        private static string rundgetDescriptionMethod(string directoryAndFile, int id) {

            string basePath = Environment.CurrentDirectory;
            string relativePath = @"data\XMLLibrary.dll";
            string fullPath = Path.Combine(basePath, relativePath);

            Assembly reflDLL = Assembly.LoadFile(fullPath);

            if (reflDLL == null) {
                traceController.logMessage("Assambley negasit!");
                return "";
            }
            else {

                try {
                    dynamic d = reflDLL.CreateInstance("XMLLibrary.XmlHandler");
                   string description = d.getDescription(directoryAndFile,id);
                    return description;
                }
                catch (System.NullReferenceException eeeee) {
                    traceController.logMessage(eeeee.Message);
                    return "";
                }

            }
            return "";
        }

        private static bool runmodifyDescriptionMethod(string directoryAndFile, int id, string description) {

            string basePath = Environment.CurrentDirectory;
            string relativePath = @"data\XMLLibrary.dll";
            string fullPath = Path.Combine(basePath, relativePath);

            Assembly reflDLL = Assembly.LoadFile(fullPath);

            if (reflDLL == null) {

                traceController.logMessage("Assambley negasit!");
                return false;
            }
            else {

                try {
                    dynamic d = reflDLL.CreateInstance("XMLLibrary.XmlHandler");
                    d.modifyDescription(directoryAndFile, id, description);
                        return true;
                }
                catch (System.NullReferenceException eeeee) {
                    traceController.logMessage(eeeee.Message);
                    return false;
                }

            }
            return false;
        }

        public static bool InsertXml(string directoryAndFile, int id, string fname, string lname, string descriere, string imageName) {

            bool check = false;
            Thread thread = new Thread(new ThreadStart(() => {
                check = runInsertMethod( directoryAndFile, id, fname, lname,  descriere, imageName);
            }));
            thread.Start();

            try {
                thread.Join();
            }catch(ThreadInterruptedException ex) {
               traceController.logMessage(ex.Message);
            }

            return check;
        }

        public static bool deleteCandidateXml(string directoryAndFile, int id) {
            bool check = false;
            Thread thread = new Thread(new ThreadStart(() => {
                check = rundeleteMethod( directoryAndFile, id);
            }));
            thread.Start();

            try {
                thread.Join();
            }
            catch (ThreadInterruptedException ex) {
                traceController.logMessage(ex.Message);
            }

            return check;
        }

        private static string rungetImageSourceMethod(string directoryAndFile, int id) {

            string basePath = Environment.CurrentDirectory;
            string relativePath = @"data\XMLLibrary.dll";
            string fullPath = Path.Combine(basePath, relativePath);

            Assembly reflDLL = Assembly.LoadFile(fullPath);

            if (reflDLL == null) {
                traceController.logMessage("Assambley negasit!");
                return "";
            }
            else {

                try {
                    dynamic d = reflDLL.CreateInstance("XMLLibrary.XmlHandler");
                    string image = d.getImageName(directoryAndFile, id);
                    return image;
                }
                catch (System.NullReferenceException eeeee) {
                    traceController.logMessage(eeeee.Message);
                    return "";
                }

            }
            return "";
        }
        public static string getDescriptionXml(string directoryAndFile, int id) {
            string check = "";
            Thread thread = new Thread(new ThreadStart(() => {
                check = rundgetDescriptionMethod(directoryAndFile, id);
            }));
            thread.Start();

            try {
                thread.Join();
            }
            catch (ThreadInterruptedException ex) {
                traceController.logMessage(ex.Message);
            }

            return check;
        }

        public static string getImageXml(string directoryAndFile, int id) {
            string check = "";
            Thread thread = new Thread(new ThreadStart(() => {
                check = rungetImageSourceMethod(directoryAndFile, id);
            }));
            thread.Start();

            try {
                thread.Join();
            }
            catch (ThreadInterruptedException ex) {
                traceController.logMessage(ex.Message);
            }

            return check;
        }

        public static bool modifyDescriptionCandidateXml(string directoryAndFile, int id, string description) {
            bool check = false;
            Thread thread = new Thread(new ThreadStart(() => {
                check = runmodifyDescriptionMethod( directoryAndFile, id, description);
            }));
            thread.Start();

            try {
                thread.Join();
            }
            catch (ThreadInterruptedException ex) {
                traceController.logMessage(ex.Message);
            }

            return check;
        }
    }
}

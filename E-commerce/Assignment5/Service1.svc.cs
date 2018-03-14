using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Linq;


namespace Assignment5
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void SignUp(string username, string password)
        {

            //Here we take the username and password as input from the user and store it in an xml file
            //We find the path of the xml file and store it in a variable.
            var fullpath = System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/Users.xml");
            XmlDocument xdoc = new XmlDocument();
            //We load the xml document
            xdoc.Load(fullpath);
            XmlNodeList nodel = xdoc.GetElementsByTagName("Username");
            //Here we find the root node and from there we add the username and password child nodes.
            var doc = XDocument.Load(fullpath);
            var newElement = new XElement("user",
                      new XElement("Username", username),
                      new XElement("Password", password));
            doc.Element("users").Add(newElement);
            //We save the document after the xml file is updated.
            doc.Save(fullpath);


        }

        //We take input from the user to check if he already signed up 
        public bool Login(string username, string password)
        {
            XmlDocument xdoc = new System.Xml.XmlDocument();
            // xdoc.Load(@"C:\Users\Pramod Kalidindi\Documents\Visual Studio 2013\Projects\Login\Login\obj\Debug\test.xml");
            //We find the path of the xml file and load it
            xdoc.Load(System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/Users.xml"));


            //We go through every child node in user parent node to check if the user already signed up
            foreach (XmlNode node2 in xdoc.SelectNodes("//user"))
            {
                string uname = node2.SelectSingleNode("Username").InnerText;
                string pwd = node2.SelectSingleNode("Password").InnerText;



                //  string uname = node2[0].InnerText;
                // string pwd = node3[0].InnerText;

                //If we find the username and and password we return a confirmation string
                if ((username == uname) && (password == pwd))
                {
                   // string confirmation = "You are already signed up!";
                    return true;
                }


                // string confirmation = "The details you have entered are wrong";
                //return confirmation;

            }

           // string confirmation1 = "The details you have entered are wrong. Type the correct details ";
            return false;

        }
    }
}

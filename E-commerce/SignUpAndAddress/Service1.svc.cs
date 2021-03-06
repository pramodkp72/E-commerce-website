﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using EncryptAndDecrypt;

namespace SignUpAndAddress
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void SignUp(string username, string password, string address)
        {
            //Here we take the username and password as input from the user and store it in an xml file
            //We find the path of the xml file and store it in a variable.
            var fullpath = System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/Users1.xml");


            Class1 obj = new Class1();
            String encrypted = obj.Encrypt(password);

            XmlDocument xdoc = new XmlDocument();
            //We load the xml document
            xdoc.Load(fullpath);
            XmlNodeList nodel = xdoc.GetElementsByTagName("Username");
            //Here we find the root node and from there we add the username and password child nodes.
            var doc = XDocument.Load(fullpath);
            var newElement = new XElement("user",
                      new XElement("Username", username),
                      new XElement("Password", encrypted),
                    //  new XElement("Password", password),
                      new XElement("Address", address));
            doc.Element("users").Add(newElement);
            //We save the document after the xml file is updated.
            doc.Save(fullpath);
        }

        public string getAddress(string username)
        {
            XmlDocument xdoc = new System.Xml.XmlDocument();
            // xdoc.Load(@"C:\Users\Pramod Kalidindi\Documents\Visual Studio 2013\Projects\Login\Login\obj\Debug\test.xml");
            //We find the path of the xml file and load it
            xdoc.Load(System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/Users1.xml"));


            //We go through every child node in user parent node to check if the user already signed up
            foreach (XmlNode node2 in xdoc.SelectNodes("//user"))
            {
                string uname = node2.SelectSingleNode("Username").InnerText;
                string pwd = node2.SelectSingleNode("Password").InnerText;

               



                //  string uname = node2[0].InnerText;
                // string pwd = node3[0].InnerText;

                //If we find the username and and password we return a confirmation string
                if (username == uname) 
                {
                    string address = node2.SelectSingleNode("Address").InnerText;
                    // string confirmation = "You are already signed up!";
                    return address;
                }


            }

            // string confirmation1 = "The details you have entered are wrong. Type the correct details ";
            return "Address Not Found";
        }


        public bool Login(string username, string password)
        {


            Class1 obj = new Class1();


            XmlDocument xdoc = new System.Xml.XmlDocument();
            // xdoc.Load(@"C:\Users\Pramod Kalidindi\Documents\Visual Studio 2013\Projects\Login\Login\obj\Debug\test.xml");
            //We find the path of the xml file and load it
            xdoc.Load(System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/Users1.xml"));


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
                else
                {

                    string decrypt = obj.Decrypt(password);
                    XmlDocument xdoc2 = new System.Xml.XmlDocument();
                    xdoc2.Load(System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/Staff.xml"));
                    foreach (XmlNode admin_node in xdoc2.SelectNodes("//admin"))
                    {
                        string uname1 = admin_node.SelectSingleNode("Username").InnerText;
                        string pwd1 = admin_node.SelectSingleNode("Password").InnerText;

                        if ((username == uname1) && (decrypt == pwd1))
                        {
                            // string confirmation = "You are already signed up!";
                            return true;
                        }
                    }

                }

                // string confirmation = "The details you have entered are wrong";
                //return confirmation;

            }

            // string confirmation1 = "The details you have entered are wrong. Type the correct details ";
            return false;

        }

        /*
        //We take input from the user to check if he already signed up 
        public bool Login(string username, string password)
        {
            XmlDocument xdoc = new System.Xml.XmlDocument();
            // xdoc.Load(@"C:\Users\Pramod Kalidindi\Documents\Visual Studio 2013\Projects\Login\Login\obj\Debug\test.xml");
            //We find the path of the xml file and load it
            xdoc.Load(System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/Users1.xml"));


            //We go through every child node in user parent node to check if the user already signed up
            foreach (XmlNode node2 in xdoc.SelectNodes("//user"))
            {
                string uname = node2.SelectSingleNode("Username").InnerText;
                string pwd = node2.SelectSingleNode("Password").InnerText;


                Class1 obj = new Class1();
                String encrypted = obj.Encrypt(password);

                //If we find the username and and password we return a confirmation string
                if ((username == uname) && (encrypted == pwd))
                {
                    // string confirmation = "You are already signed up!";
                    return true;
                }
                else
                {
                    xdoc.Load(System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/Staff.xml"));
                    foreach (XmlNode node3 in xdoc.SelectNodes("//user"))
                    {
                    string uname1 = node3.SelectSingleNode("Username").InnerText;
                    string pwd1 = node3.SelectSingleNode("Password").InnerText;
                         if ((username == uname) && (password == pwd))
                         {
                             return true;
                         }
                
                    // string confirmation = "You are already signed up!";
                    return true;
                    }
                }
            }

                return false;
                // string confirmation = "The details you have entered are wrong";
                //return confirmation;

            }

            // string confirmation1 = "The details you have entered are wrong. Type the correct details ";
        */


        public int getNumberOfUsers()
        {
            int users = 0;

             XmlDocument xdoc = new System.Xml.XmlDocument();
            // xdoc.Load(@"C:\Users\Pramod Kalidindi\Documents\Visual Studio 2013\Projects\Login\Login\obj\Debug\test.xml");
            //We find the path of the xml file and load it
            xdoc.Load(System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/Users1.xml"));


            //We go through every child node in user parent node to check if the user already signed up
            foreach (XmlNode node2 in xdoc.SelectNodes("//user"))
            {
                users++;
            }
            return users;
        }

        public string CustomerData()
        {
            try
            {
                XmlDocument xdoc = new System.Xml.XmlDocument();
                xdoc.Load(System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/Users1.xml"));
                XmlNodeList list = xdoc.SelectNodes("//user");
                string data = null;
                foreach (XmlNode node2 in list)
                {
                    string UserName = node2.SelectSingleNode("Username").InnerText;
                    string address = node2.SelectSingleNode("Address").InnerText;
                  //  string Password = node2.SelectSingleNode("Password").InnerText;
                    data = data + ("Username : " + UserName +"  " + "Address: " + address + ";");
                }
                return data;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}

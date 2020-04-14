using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam3
{
    class personinfoBLL
    {
        //创建人员文档
        private static string _basePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"\xml\persons.xml";
        public static void CreatePersonXml()
        {
            XDocument personDoc = new XDocument();
            XDeclaration xDeclaration = new XDeclaration("1.0", "utf-8", "yes");
            personDoc.Declaration = xDeclaration;
            XElement xElement = new XElement("personcontract");
            personDoc.Add(xElement);
            personDoc.Save(_basePath);
        }
        //增加人员信息
        public static bool Addpersoninfo(personinfo param)
        {
            XElement xml = XElement.Load(_basePath);
            XElement personXml = new XElement("person");
            personXml.Add(new XAttribute("personid", param.personid));
            personXml.Add(new XElement("name", param.Name));
            personXml.Add(new XElement("age", param.Age.ToString()));
            personXml.Add(new XElement("tel", param.Tel));
            personXml.Add(new XElement("job", param.Job));
            personXml.Add(new XElement("adr", param.Adr));
            xml.Add(personXml);
            xml.Save(_basePath);
            return true;
        }
        //修改人员信息
        public static bool UpdatePersoninfo(personinfo param)
        {
            bool result = false;
            if (param.personid > 0)
            {
                XElement xml = XElement.Load(_basePath);
                XElement personxml = (from db in xml.Descendants("person")
                                       where db.Attribute("personid").Value == param.personid.ToString()
                                       select db).Single();
                personxml.SetElementValue("name", param.Name);
                personxml.SetElementValue("age", param.Age.ToString());
                personxml.SetElementValue("tel", param.Tel);
                personxml.SetElementValue("job", param.Job);
                personxml.SetElementValue("adr", param.Adr);
                xml.Save(_basePath);
                result = true;
            }
            return result;
        }
        //删除信息
        public static bool DeletePersoninfo(int personid)
        {
            bool result = false;
            if (personid > 0)
            {
                XElement xml = XElement.Load(_basePath);
                XElement personxml = (from db in xml.Descendants("person")
                                       where db.Attribute("personid").Value == personid.ToString()
                                       select db).Single();
                personxml.Remove();
                xml.Save(_basePath);
                result = true;
            }
            return result;
        }
        //查询全部
        public static List<personinfo> getallpersoninfo()
        {
            List<personinfo> personlist = new List<personinfo>();
            XElement xml = XElement.Load(_basePath);
            var personvar = xml.Descendants("person");
            personlist = (from person in personvar
                           select new personinfo
                           {
                               personid = Int32.Parse(person.Attribute("personid").Value),
                               Name = person.Element("name").Value,
                               Age = Int32.Parse(person.Element("age").Value),
                               Tel = person.Element("tel").Value,
                               Job = person.Element("job").Value,
                               Adr = person.Element("adr").Value
                           }).ToList();
            return personlist;
        }
        //根据编号查询
        public static personinfo getpersoninfo(int personid)
        {
            personinfo personinfo = new personinfo();
            XElement xml = XElement.Load(_basePath);
            personinfo = (from person in xml.Descendants("person")
                           where person.Attribute("personid").Value == personid.ToString()
                           select new personinfo
                           {
                               personid = Int32.Parse(person.Attribute("personid").Value),
                               Name = person.Element("name").Value,
                               Age = Int32.Parse(person.Element("age").Value),
                               Tel= person.Element("tel").Value,
                               Job = person.Element("job").Value,
                               Adr = person.Element("adr").Value,
                           }).Single();
            return personinfo;
        }
        //根据姓名查询
        public static personinfo getpersoninfo(string name)
        {
            personinfo personinfo = new personinfo();
            XElement xml = XElement.Load(_basePath);
            personinfo = (from person in xml.Descendants("person")
                          where person.Attribute("name").Value == name
                          select new personinfo
                          {
                              personid = Int32.Parse(person.Attribute("personid").Value),
                              Name = person.Element("name").Value,
                              Age = Int32.Parse(person.Element("age").Value),
                              Tel = person.Element("tel").Value,
                              Job = person.Element("job").Value,
                              Adr = person.Element("adr").Value,
                          }).Single();
            return personinfo;
        }
        //获取信息列表
        public static List<personinfo> getpersoninfolist(personinfo param)
        {
            List<personinfo> personlist = new List<personinfo>();
            XElement xml = XElement.Load(_basePath);
            var personvar = xml.Descendants("person");
            if (param.personid != 0)
            {
                personvar = xml.Descendants("person").Where(a => a.Attribute("personid").Value
                    == param.personid.ToString());
            }
            else if (!string.IsNullOrEmpty(param.Name))
            {
                personvar = xml.Descendants("person").Where(a => a.Element("name").Value
                    == param.Name);
            }
            personlist = (from person in personvar
                           select new personinfo
                           {
                               personid = Int32.Parse(person.Attribute("personid").Value),
                               Name = person.Element("name").Value,
                               Age = Int32.Parse(person.Element("age").Value),
                               Tel = person.Element("tel").Value,
                               Job = person.Element("job").Value,
                               Adr = person.Element("adr").Value,
                           }).ToList();
            return personlist;
        }
    }
}
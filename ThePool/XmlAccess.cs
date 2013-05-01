using System;
using System.Xml;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace ThePool
{
    public enum Cycle
    {
        undefined,
        monthly,
        seasonly,
        halfyearly,
        yearly
    }

    public enum FlowType
    {
        income,
        payout
    }

    public struct Flow
    {
        public FlowType type;
        public float volume;
        public string comment;
    }
    
    public struct Fund
    {
        public float volume;
        public float rate;
        public Cycle cycle;
        public DateTime start;
        public DateTime end;
        public string comment;
    }

    public struct Partner
    {
        public string name;
        public string telephone;
        public string comment;
        public ArrayList funds;
    }

    public struct Project
    {
        public string name;
        public string contact;
        public string telephone;
        public float volume;
        public float rate;
        public Cycle cycle;
        public DateTime start;
        public DateTime end;
        public string comment;
    }

    public struct Debt
    {
        public string name;
        public float volume;
        public Cycle cycle;
        public string comment;
        public DateTime start;
        public DateTime end;
    }

    public struct Calendar
    {
        public DateTime date;
        public ArrayList flows;
    }

    /// <summary>
    /// Xml 操作工具类
    /// </summary>
    public class Xml
    {
        private Xml() { }

        public static ArrayList LoadPartner(string file)
        {
            ArrayList partners = new ArrayList();

            XmlDocument xml = new XmlDocument();
            xml.Load(file);
            XmlNode root = xml.SelectSingleNode("Partners");

            foreach (XmlNode partner in root.ChildNodes)
            {
                Partner par = new Partner();
                par.name = partner.Attributes["name"].Value;
                par.telephone = partner.Attributes["telephone"].Value;
                par.comment = partner.Attributes["comment"].Value;
                par.funds = new ArrayList();
                foreach (XmlNode fund in partner.ChildNodes)
                {
                    Fund f = new Fund();
                    f.volume = float.Parse(fund.Attributes["volume"].Value);
                    f.rate = float.Parse(fund.Attributes["rate"].Value);
                    f.cycle = (Cycle)Enum.ToObject(typeof(Cycle), byte.Parse(fund.Attributes["cycle"].Value));
                    f.start = DateTime.Parse(fund.Attributes["start"].Value);
                    f.end = DateTime.Parse(fund.Attributes["end"].Value);
                    f.comment = fund.Attributes["comment"].Value;
                    par.funds.Add(f);
                }
                partners.Add(par);
            }

            return partners;
        }

        public static void UpdatePartner(string file, ArrayList partners)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(file);
            XmlNode root = xml.SelectSingleNode("Partners");
            root.RemoveAll();

            foreach (Partner partner in partners)
            {
                XmlNode par = AppendElement(root, "partner");
                SetAttribute(par, "name", partner.name);
                SetAttribute(par, "telephone", partner.telephone);
                SetAttribute(par, "comment", partner.comment);
                foreach (Fund fund in partner.funds)
                {
                    XmlNode f = AppendElement(par, "fund");
                    SetAttribute(f, "volume", fund.volume.ToString());
                    SetAttribute(f, "rate", fund.rate.ToString());
                    SetAttribute(f, "cycle", ((int)fund.cycle).ToString());
                    SetAttribute(f, "start", fund.start.ToShortDateString());
                    SetAttribute(f, "end", fund.end.ToShortDateString());
                    SetAttribute(f, "comment", fund.comment);
                }
            }

            xml.Save(file);
        }

        public static ArrayList LoadProject(string file)
        {
            ArrayList projects = new ArrayList();

            XmlDocument xml = new XmlDocument();
            xml.Load(file);
            XmlNode root = xml.SelectSingleNode("Projects");

            foreach (XmlNode project in root.ChildNodes)
            {
                Project proj = new Project();
                proj.name = project.Attributes["name"].Value;
                proj.contact = project.Attributes["contact"].Value;
                proj.telephone = project.Attributes["telephone"].Value;
                proj.volume = float.Parse(project.Attributes["volume"].Value);
                proj.rate = float.Parse(project.Attributes["rate"].Value);
                proj.cycle = (Cycle)(Enum.ToObject(typeof(Cycle), byte.Parse(project.Attributes["cycle"].Value)));
                proj.start = DateTime.Parse(project.Attributes["start"].Value);
                proj.end = DateTime.Parse(project.Attributes["end"].Value);
                proj.comment = project.Attributes["comment"].Value;
                projects.Add(proj);
            }

            return projects;
        }

        public static void UpdateProject(string file, ArrayList projects)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(file);
            XmlNode root = xml.SelectSingleNode("Projects");
            root.RemoveAll();

            foreach (Project project in projects)
            {
                XmlNode proj = AppendElement(root, "project");
                SetAttribute(proj, "name", project.name);
                SetAttribute(proj, "contact", project.contact);
                SetAttribute(proj, "telephone", project.telephone);
                SetAttribute(proj, "volume", project.volume.ToString());
                SetAttribute(proj, "rate", project.rate.ToString());
                SetAttribute(proj, "cycle", ((int)project.cycle).ToString());
                SetAttribute(proj, "start", project.start.ToShortDateString());
                SetAttribute(proj, "end", project.end.ToShortDateString());
                SetAttribute(proj, "comment", project.comment);
            }

            xml.Save(file);
        }

        public static ArrayList LoadDebt(string file)
        {
            ArrayList debts = new ArrayList();

            XmlDocument xml = new XmlDocument();
            xml.Load(file);
            XmlNode root = xml.SelectSingleNode("Debts");

            foreach (XmlNode debt in root.ChildNodes)
            {
                Debt d = new Debt();
                d.name = debt.Attributes["name"].Value;
                d.volume = float.Parse(debt.Attributes["volume"].Value);
                d.cycle = (Cycle)(Enum.ToObject(typeof(Cycle), byte.Parse(debt.Attributes["cycle"].Value)));
                d.start = DateTime.Parse(debt.Attributes["start"].Value);
                d.end = DateTime.Parse(debt.Attributes["end"].Value);
                d.comment = debt.Attributes["comment"].Value;
                debts.Add(d);
            }

            return debts;
        }

        public static void UpdateDebt(string file, ArrayList debts)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(file);
            XmlNode root = xml.SelectSingleNode("Debts");
            root.RemoveAll();

            foreach (Debt debt in debts)
            {
                XmlNode d = AppendElement(root, "debt");
                SetAttribute(d, "name", debt.name);
                SetAttribute(d, "volume", debt.volume.ToString());
                SetAttribute(d, "cycle", ((int)debt.cycle).ToString());
                SetAttribute(d, "start", debt.start.ToShortDateString());
                SetAttribute(d, "end", debt.end.ToShortDateString());
                SetAttribute(d, "comment", debt.comment);
            }

            xml.Save(file);
        }

        public static ArrayList LoadCalendar(string file)
        {
            ArrayList calendars = new ArrayList();

            XmlDocument xml = new XmlDocument();
            xml.Load(file);
            XmlNode root = xml.SelectSingleNode("Calendar");

            foreach (XmlNode year in root.ChildNodes)
            {
                foreach (XmlNode month in year.ChildNodes)
                {
                    foreach (XmlNode day in month.ChildNodes)
                    {
                        Calendar calendar = new Calendar();
                        calendar.date = new DateTime(int.Parse(year.Attributes["value"].Value),
                                                     int.Parse(month.Attributes["value"].Value),
                                                     int.Parse(day.Attributes["value"].Value));
                        calendar.flows = new ArrayList();
                        foreach (XmlNode flow in day.ChildNodes)
                        {
                            Flow f = new Flow();
                            f.type = (FlowType)(Enum.ToObject(typeof(FlowType), byte.Parse(flow.Attributes["type"].Value)));
                            f.volume = float.Parse(flow.Attributes["volume"].Value);
                            f.comment = flow.Attributes["comment"].Value;
                            calendar.flows.Add(f);
                        }
                        if (calendar.flows.Count > 0) calendars.Add(calendar);
                    }
                }
            }

            return calendars;
        }

        public static void UpdateCalendar(string file, ArrayList calendars)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(file);
            XmlNode root = xml.SelectSingleNode("Calendar");
            root.RemoveAll();

            foreach (Calendar calendar in calendars)
            {
                XmlNode year = null;
                foreach (XmlNode nodeYear in root.ChildNodes)
                {
                    if (nodeYear.Attributes["value"].Value == calendar.date.Year.ToString()) year = nodeYear; break;
                }
                if (year == null)
                {
                    year = AppendElement(root, "Year");
                    SetAttribute(year, "value", calendar.date.Year.ToString()); 
                }

                XmlNode month = null;
                foreach (XmlNode nodeMonth in year.ChildNodes)
                {
                    if (nodeMonth.Attributes["value"].Value == calendar.date.Month.ToString()) month = nodeMonth; break;
                }
                if (month == null)
                {
                    month = AppendElement(year, "Month");
                    SetAttribute(month, "value", calendar.date.Month.ToString());
                }

                XmlNode day = null;
                foreach (XmlNode nodeDay in month.ChildNodes)
                {
                    if (nodeDay.Attributes["value"].Value == calendar.date.Day.ToString()) day = nodeDay; break;
                }
                if (day == null)
                {
                    day = AppendElement(month, "Day");
                }

                day.RemoveAll();
                SetAttribute(day, "value", calendar.date.Day.ToString());
                foreach (Flow flow in calendar.flows)
                {
                    XmlNode flowNode = AppendElement(day, "Flow");
                    SetAttribute(flowNode, "type", ((int)flow.type).ToString());
                    SetAttribute(flowNode, "volume", flow.volume.ToString());
                    SetAttribute(flowNode, "comment", flow.comment);
                }
            }

            xml.Save(file);
        }

        /// <summary>
        /// 创建节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="newElementName"></param>
        /// <returns></returns>
        public static XmlNode AppendElement(XmlNode node, string newElementName)
        {
            return AppendElement(node, newElementName, null);
        }

        /// <summary>
        /// 创建节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="newElementName"></param>
        /// <param name="innerValue"></param>
        /// <returns></returns>
        public static XmlNode AppendElement(XmlNode node, string newElementName, string innerValue)
        {
            XmlNode oNode;
            if (node is XmlDocument)
            {
                oNode = node.AppendChild(((XmlDocument)node).CreateElement(newElementName));
            }
            else
            {
                oNode = node.AppendChild(node.OwnerDocument.CreateElement(newElementName));
            }

            if (innerValue != null)
            {
                oNode.AppendChild(node.OwnerDocument.CreateTextNode(innerValue));
            }
            return oNode;
        }

        /// <summary>
        /// 创建属性
        /// </summary>
        /// <param name="xmlDocument"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static XmlAttribute CreateAttribute(XmlDocument xmlDocument, string name, string value)
        {
            XmlAttribute oAtt = xmlDocument.CreateAttribute(name);
            oAtt.Value = value;
            return oAtt;
        }

        /// <summary>
        /// 设置属性的值
        /// </summary>
        /// <param name="node"></param>
        /// <param name="attributeName"></param>
        /// <param name="attributeValue"></param>
        public static void SetAttribute(XmlNode node, string attributeName, string attributeValue)
        {
            if (node.Attributes[attributeName] != null)
            {
                node.Attributes[attributeName].Value = attributeValue;
            }
            else
            {
                node.Attributes.Append(CreateAttribute(node.OwnerDocument, attributeName, attributeValue));
            }
        }

        /// <summary>
        /// 获取属性的值
        /// </summary>
        /// <param name="node"></param>
        /// <param name="attributeName"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string GetAttribute(XmlNode node, string attributeName, string defaultValue)
        {
            XmlAttribute att = node.Attributes[attributeName];
            if (att != null)
            {
                return att.Value;
            }
            else
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 获取节点的值
        /// </summary>
        /// <param name="parentNode"></param>
        /// <param name="nodeXPath"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string GetNodeValue(XmlNode parentNode, string nodeXPath, string defaultValue)
        {
            XmlNode node = parentNode.SelectSingleNode(nodeXPath);
            if (node.FirstChild != null)
            {
                return node.FirstChild.Value;
            }
            else if (node != null)
            {
                return node.Value;
            }
            else
            {
                return defaultValue;
            }
        }
    }
}

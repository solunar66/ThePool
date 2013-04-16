using System;
using System.Xml;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace ThePool
{
    public struct Partner
    {
        string name;
        string telephone;
        string comment;

    }

    public enum Cycle
    {
        undefined,
        monthly,
        seasonly,
        halfyearly,
        yearly
    }
    
    public struct Fund
    {
        int volume;
        float rate;
        Cycle cycle;
        DateTime start;
        DateTime end;
        string comment;
    }

    public struct Project
    {
        string name;
        string contact;
        string telephone;
        int volume;
        float rate;
        Cycle cycle;
        DateTime start;
        DateTime end;
    }

    public enum FlowType
    {
        income,
        payout
    }

    public struct Calendar
    {
        DateTime date;
        FlowType type;
        int volume;
        string partner;
        string project;
        string comment;
    }

    /// <summary>
    /// Xml 操作工具类
    /// </summary>
    public class Xml
    {
        private Xml() { }

        public static ArrayList LoadPartner()
        { return null; }

        public static ArrayList LoadProject()
        { return null; }

        public static ArrayList LoadCalendar()
        { return null; }

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

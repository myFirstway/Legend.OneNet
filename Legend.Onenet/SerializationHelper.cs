using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Legend.Onenet.Serialization
{
    public static class SerializationHelper
    {
        private static readonly JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Ignore
        };
        public static T DeserializeObject<T>(string data, FormaterType formaterType = FormaterType.Json) where T : class
        {
            if (formaterType == FormaterType.Xml)
            {
                using (StringReader sr = new StringReader(data))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    var xml = xmlSerializer.Deserialize(sr) as T;
                    return xml;
                }
            }
            else
            {
                var obj = JsonConvert.DeserializeObject<T>(data);
                return obj;
            }
        }

        public static string SerializeObject(object obj, FormaterType formaterType = FormaterType.Json)
        {
            if (formaterType == FormaterType.Xml)
            {
                XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
                xmlSerializerNamespaces.Add("", "");
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings
                {
                    OmitXmlDeclaration = true,
                    Encoding = Encoding.UTF8,
                    Indent = true
                };
                Type type = obj.GetType();
                XmlSerializer xmlSerializer = new XmlSerializer(type);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (XmlWriter xmlWriter = XmlWriter.Create(ms, xmlWriterSettings))
                    {
                        xmlSerializer.Serialize(xmlWriter, obj, xmlSerializerNamespaces);
                        var xml = Encoding.UTF8.GetString(ms.ToArray());
                        return xml;
                    }
                }

                //XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
                //xmlSerializerNamespaces.Add("", "");
                //XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
                //using (MemoryStream ms = new MemoryStream())
                //{
                //    using (XmlTextWriterEE xmlWriter = new XmlTextWriterEE(ms))
                //    {
                //        xmlWriter.Formatting = System.Xml.Formatting.Indented;
                //        xmlWriter.Settings = new XmlWriterSettings
                //        {

                //        };
                //        xmlSerializer.Serialize(xmlWriter, obj, xmlSerializerNamespaces);
                //        var xml = Encoding.UTF8.GetString(ms.ToArray());
                //        return xml;
                //    }
                //}
            }
            else
            {
                var result = JsonConvert.SerializeObject(obj, _settings);
                return result;
            }
        }
    }
    public enum FormaterType
    {
        Json,
        Xml
    }
    public class XmlTextWriterEE : XmlTextWriter
    {
        public XmlTextWriterEE(Stream stream) : base(stream, Encoding.UTF8)
        {

        }

        //public override void WriteValue(string value)
        //{
        //    base.WriteCData(value);
        //}
        public override void WriteEndElement()
        {
            base.WriteFullEndElement();
        }

    }
}

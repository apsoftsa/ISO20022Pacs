using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace Iso20022.Model
{
	public static class SerializationExtensions
	{
		public static T DeserializeXml<T>(this string toDeserialize, string namespaceName, string elementName, bool isNullable)
		{
			XmlRootAttribute xRoot = new XmlRootAttribute();

			xRoot.ElementName = elementName;
			xRoot.Namespace = namespaceName;
			xRoot.IsNullable = isNullable;

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(T), xRoot);
			using StringReader textReader = new StringReader(toDeserialize);
			return (T)xmlSerializer.Deserialize(textReader);
		}


		public static T DeserializeXml<T>(this string toDeserialize)
		{
			var xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(toDeserialize);

			var document = xmlDoc.ChildNodes.Cast<XmlNode>().SingleOrDefault(x => x.Name == "Document");
			var schemaNamespace = document?.Attributes?.Cast<XmlAttribute>().SingleOrDefault(x => x.Name == "xmlns")?.Value;
			var schemaNamespaceInstance = document?.Attributes?.Cast<XmlAttribute>().SingleOrDefault(x => x.Name == "xmlns:xsi")?.Value;

			XmlRootAttribute xRoot = new XmlRootAttribute();

			xRoot.ElementName = "Document";
			xRoot.Namespace = schemaNamespace;
			xRoot.IsNullable = string.IsNullOrWhiteSpace(schemaNamespaceInstance);

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(T), xRoot);
			using StringReader textReader = new StringReader(toDeserialize);
			return (T)xmlSerializer.Deserialize(textReader);
		}


		// 		public static T DeserializeXmlSic<T>(this string toDeserialize)
		// 		{
		// 				
		// 			XmlRootAttribute xRoot = new XmlRootAttribute();
		// 
		// 			xRoot.ElementName = "Document";
		// 			xRoot.Namespace = "http://www.six-interbank-clearing.com/de/pacs.008.001.02.ch.02";
		// 			xRoot.IsNullable = false;
		// 
		// 			XmlSerializer xmlSerializer = new XmlSerializer(typeof(T), xRoot);
		// 			using StringReader textReader = new StringReader(toDeserialize);
		// 			return (T)xmlSerializer.Deserialize(textReader);
		// 		}

		public static string SerializeToXml<T>(this T toSerialize)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

			var settings = new XmlWriterSettings();
			settings.Indent = true;
			settings.OmitXmlDeclaration = true;
			
			using var sww = new StringWriter();
			using XmlWriter writer = XmlWriter.Create(sww, settings);
			
			xmlSerializer.Serialize(writer, toSerialize);
			var xml = sww.ToString();
			
			return xml;
		}
	}
}

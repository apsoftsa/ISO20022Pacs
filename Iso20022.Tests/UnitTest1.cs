using System.IO;
using FluentAssertions;
using Iso20022.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Iso20022.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var filepath = Path.Combine(Directory.GetCurrentDirectory(), "Examples", "pacs002.001.12.xml");

			var message = File.ReadAllText(filepath);

			var pacs002 = message.DeserializeXml<Iso20022.Model.pacs_002_001_12.Document>();

			pacs002.FIToFIPmtStsRpt.Should().NotBeNull();
			pacs002.FIToFIPmtStsRpt.GrpHdr.InstgAgt.FinInstnId.BICFI.Should().Be("ABABUS23");
			pacs002.FIToFIPmtStsRpt.GrpHdr.InstdAgt.FinInstnId.BICFI.Should().Be("AAAAUS29");
			pacs002.FIToFIPmtStsRpt.TxInfAndSts[0].StsId.Should().Be("AB/8568");
		}
	}
}

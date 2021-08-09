using System;
using System.Xml;

// ReSharper disable once CheckNamespace
namespace Iso20022.Model.pacs_002_001_08
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]


    public class Document
    {
        public virtual FIToFIPaymentStatusReportV08 FIToFIPmtStsRpt { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class FIToFIPaymentStatusReportV08
    {
        public virtual GroupHeader53 GrpHdr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("OrgnlGrpInfAndSts")]
        public virtual OriginalGroupHeader7[] OrgnlGrpInfAndSts { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("TxInfAndSts")]
        public virtual PaymentTransaction80[] TxInfAndSts { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }

}

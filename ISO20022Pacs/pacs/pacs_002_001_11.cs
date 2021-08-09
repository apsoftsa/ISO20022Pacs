using System;
using System.Xml;

// ReSharper disable once CheckNamespace
namespace Iso20022.Model.pacs_002_001_11
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]


    public class Document
    {
        public virtual FIToFIPaymentStatusReportV11 FIToFIPmtStsRpt { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class FIToFIPaymentStatusReportV11
    {
        public virtual GroupHeader91 GrpHdr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("OrgnlGrpInfAndSts")]
        public virtual OriginalGroupHeader17[] OrgnlGrpInfAndSts { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("TxInfAndSts")]
        public virtual PaymentTransaction123[] TxInfAndSts { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }

}

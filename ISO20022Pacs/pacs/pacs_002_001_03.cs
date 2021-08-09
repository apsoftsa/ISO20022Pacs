using System;
using System.Xml;

// ReSharper disable once CheckNamespace
namespace Iso20022.Model.pacs_002_001_03
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]


    public class Document
    {
        public virtual FIToFIPaymentStatusReportV03 FIToFIPmtStsRpt { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class FIToFIPaymentStatusReportV03
    {
        public virtual GroupHeader37 GrpHdr { get; set; }

        public virtual OriginalGroupInformation20 OrgnlGrpInfAndSts { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("TxInfAndSts")]
        public virtual PaymentTransactionInformation26[] TxInfAndSts { get; set; }

    }

}

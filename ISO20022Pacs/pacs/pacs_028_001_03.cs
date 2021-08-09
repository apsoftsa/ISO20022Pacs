using System;
using System.Xml;

// ReSharper disable once CheckNamespace
namespace Iso20022.Model.pacs_028_001_03
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]


    public class Document
    {
        public virtual FIToFIPaymentStatusRequestV03 FIToFIPmtStsReq { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class FIToFIPaymentStatusRequestV03
    {
        public virtual GroupHeader91 GrpHdr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("OrgnlGrpInf")]
        public virtual OriginalGroupInformation27[] OrgnlGrpInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("TxInf")]
        public virtual PaymentTransaction113[] TxInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }

}

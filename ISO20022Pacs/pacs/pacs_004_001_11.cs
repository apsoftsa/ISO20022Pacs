using System;
using System.Xml;

// ReSharper disable once CheckNamespace
namespace Iso20022.Model.pacs_004_001_11
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]


    public class Document
    {
        public virtual PaymentReturnV11 PmtRtr { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentReturnV11
    {
        public virtual GroupHeader99 GrpHdr { get; set; }

        public virtual OriginalGroupHeader18 OrgnlGrpInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("TxInf")]
        public virtual PaymentTransaction133[] TxInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }

}

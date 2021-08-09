using System;
using System.Xml;

// ReSharper disable once CheckNamespace
namespace Iso20022.Model.pacs_007_001_09
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]


    public class Document
    {
        public virtual FIToFIPaymentReversalV09 FIToFIPmtRvsl { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class FIToFIPaymentReversalV09
    {
        public virtual GroupHeader89 GrpHdr { get; set; }

        public virtual OriginalGroupHeader16 OrgnlGrpInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("TxInf")]
        public virtual PaymentTransaction111[] TxInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }

}

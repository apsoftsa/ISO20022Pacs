using System;
using System.Xml;

// ReSharper disable once CheckNamespace
namespace Iso20022.Model.pacs_009_001_01
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]


    public class Document
    {
        [System.Xml.Serialization.XmlElementAttribute("pacs.009.001.01")]
        public virtual pacs00900101 pacs00900101 { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class pacs00900101
    {
        public virtual GroupHeader4 GrpHdr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("CdtTrfTxInf")]
        public virtual CreditTransferTransactionInformation3[] CdtTrfTxInf { get; set; }

    }

}

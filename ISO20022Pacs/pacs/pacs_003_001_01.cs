using System;
using System.Xml;

// ReSharper disable once CheckNamespace
namespace Iso20022.Model.pacs_003_001_01
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]


    public class Document
    {
        [System.Xml.Serialization.XmlElementAttribute("pacs.003.001.01")]
        public virtual pacs00300101 pacs00300101 { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class pacs00300101
    {
        public virtual GroupHeader3 GrpHdr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("DrctDbtTxInf")]
        public virtual DirectDebitTransactionInformation2[] DrctDbtTxInf { get; set; }

    }

}

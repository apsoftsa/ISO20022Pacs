using System;
using System.Xml;

// ReSharper disable once CheckNamespace
namespace Iso20022.Model.pacs_002_001_02
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]


    public class Document
    {
        [System.Xml.Serialization.XmlElementAttribute("pacs.002.001.02")]
        public virtual pacs00200102 pacs00200102 { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class pacs00200102
    {
        public virtual GroupHeader5 GrpHdr { get; set; }

        public virtual OriginalGroupInformation1 OrgnlGrpInfAndSts { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("TxInfAndSts")]
        public virtual PaymentTransactionInformation1[] TxInfAndSts { get; set; }

    }

}

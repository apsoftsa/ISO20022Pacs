using System;
using System.Xml;

// ReSharper disable once CheckNamespace
namespace Iso20022.Model.pacs_008_001_05
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]


    public class Document
    {
        public virtual FIToFICustomerCreditTransferV05 FIToFICstmrCdtTrf { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class FIToFICustomerCreditTransferV05
    {
        public virtual GroupHeader49 GrpHdr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("CdtTrfTxInf")]
        public virtual CreditTransferTransaction19[] CdtTrfTxInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }

}

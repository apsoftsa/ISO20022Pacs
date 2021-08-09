using System;
using System.Xml;

// ReSharper disable once CheckNamespace
namespace Iso20022.Model.pacs_003_001_02
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]


    public class Document
    {
        public virtual FIToFICustomerDirectDebitV02 FIToFICstmrDrctDbt { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class FIToFICustomerDirectDebitV02
    {
        public virtual GroupHeader34 GrpHdr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("DrctDbtTxInf")]
        public virtual DirectDebitTransactionInformation10[] DrctDbtTxInf { get; set; }

    }

}

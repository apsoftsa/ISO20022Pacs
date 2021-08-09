using System;
using System.Xml;

// ReSharper disable once CheckNamespace
namespace Iso20022.Model.pacs_010_001_05
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]


    public class Document
    {
        public virtual FinancialInstitutionDirectDebitV05 FIDrctDbt { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class FinancialInstitutionDirectDebitV05
    {
        public virtual GroupHeader92 GrpHdr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("CdtInstr")]
        public virtual CreditTransferTransaction53[] CdtInstr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }

}

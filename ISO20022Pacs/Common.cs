using System;
using System.Xml;

namespace Iso20022.Model
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class AccountIdentification3Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("IBAN", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("UPIC", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("PrtryAcct", typeof(SimpleIdentificationInformation2))]
        [System.Xml.Serialization.XmlElementAttribute("BBAN", typeof(String))]
        public virtual Object Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType3 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class AccountIdentification4Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("IBAN", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Othr", typeof(GenericAccountIdentification1))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class AccountSchemeName1Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ActiveCurrencyAndAmount
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual String Ccy { get; set; }

        [System.Xml.Serialization.XmlTextAttribute()]
        public virtual Decimal Value { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ActiveOrHistoricCurrencyAndAmount
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual String Ccy { get; set; }

        [System.Xml.Serialization.XmlTextAttribute()]
        public virtual Decimal Value { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class AddressType3Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(AddressType2Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification30))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class AmendmentInformationDetails1
    {
        public virtual String OrgnlMndtId { get; set; }

        public virtual PartyIdentification8 OrgnlCdtrSchmeId { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 OrgnlCdtrAgt { get; set; }

        public virtual CashAccount7 OrgnlCdtrAgtAcct { get; set; }

        public virtual PartyIdentification8 OrgnlDbtr { get; set; }

        public virtual CashAccount7 OrgnlDbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 OrgnlDbtrAgt { get; set; }

        public virtual CashAccount7 OrgnlDbtrAgtAcct { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime OrgnlFnlColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlFnlColltnDtSpecified { get; set; }

        public virtual Frequency1Code OrgnlFrqcy { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlFrqcySpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class AmendmentInformationDetails10
    {
        public virtual String OrgnlMndtId { get; set; }

        public virtual PartyIdentification43 OrgnlCdtrSchmeId { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 OrgnlCdtrAgt { get; set; }

        public virtual CashAccount24 OrgnlCdtrAgtAcct { get; set; }

        public virtual PartyIdentification43 OrgnlDbtr { get; set; }

        public virtual CashAccount24 OrgnlDbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 OrgnlDbtrAgt { get; set; }

        public virtual CashAccount24 OrgnlDbtrAgtAcct { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime OrgnlFnlColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlFnlColltnDtSpecified { get; set; }

        public virtual Frequency21Choice OrgnlFrqcy { get; set; }

        public virtual MandateSetupReason1Choice OrgnlRsn { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class AmendmentInformationDetails11
    {
        public virtual String OrgnlMndtId { get; set; }

        public virtual PartyIdentification43 OrgnlCdtrSchmeId { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 OrgnlCdtrAgt { get; set; }

        public virtual CashAccount24 OrgnlCdtrAgtAcct { get; set; }

        public virtual PartyIdentification43 OrgnlDbtr { get; set; }

        public virtual CashAccount24 OrgnlDbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 OrgnlDbtrAgt { get; set; }

        public virtual CashAccount24 OrgnlDbtrAgtAcct { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime OrgnlFnlColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlFnlColltnDtSpecified { get; set; }

        public virtual Frequency36Choice OrgnlFrqcy { get; set; }

        public virtual MandateSetupReason1Choice OrgnlRsn { get; set; }

        public virtual String OrgnlTrckgDays { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class AmendmentInformationDetails12
    {
        public virtual String OrgnlMndtId { get; set; }

        public virtual PartyIdentification125 OrgnlCdtrSchmeId { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 OrgnlCdtrAgt { get; set; }

        public virtual CashAccount24 OrgnlCdtrAgtAcct { get; set; }

        public virtual PartyIdentification125 OrgnlDbtr { get; set; }

        public virtual CashAccount24 OrgnlDbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 OrgnlDbtrAgt { get; set; }

        public virtual CashAccount24 OrgnlDbtrAgtAcct { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime OrgnlFnlColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlFnlColltnDtSpecified { get; set; }

        public virtual Frequency36Choice OrgnlFrqcy { get; set; }

        public virtual MandateSetupReason1Choice OrgnlRsn { get; set; }

        public virtual String OrgnlTrckgDays { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class AmendmentInformationDetails13
    {
        public virtual String OrgnlMndtId { get; set; }

        public virtual PartyIdentification135 OrgnlCdtrSchmeId { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 OrgnlCdtrAgt { get; set; }

        public virtual CashAccount38 OrgnlCdtrAgtAcct { get; set; }

        public virtual PartyIdentification135 OrgnlDbtr { get; set; }

        public virtual CashAccount38 OrgnlDbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 OrgnlDbtrAgt { get; set; }

        public virtual CashAccount38 OrgnlDbtrAgtAcct { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime OrgnlFnlColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlFnlColltnDtSpecified { get; set; }

        public virtual Frequency36Choice OrgnlFrqcy { get; set; }

        public virtual MandateSetupReason1Choice OrgnlRsn { get; set; }

        public virtual String OrgnlTrckgDays { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class AmendmentInformationDetails14
    {
        public virtual String OrgnlMndtId { get; set; }

        public virtual PartyIdentification135 OrgnlCdtrSchmeId { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 OrgnlCdtrAgt { get; set; }

        public virtual CashAccount40 OrgnlCdtrAgtAcct { get; set; }

        public virtual PartyIdentification135 OrgnlDbtr { get; set; }

        public virtual CashAccount40 OrgnlDbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 OrgnlDbtrAgt { get; set; }

        public virtual CashAccount40 OrgnlDbtrAgtAcct { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime OrgnlFnlColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlFnlColltnDtSpecified { get; set; }

        public virtual Frequency36Choice OrgnlFrqcy { get; set; }

        public virtual MandateSetupReason1Choice OrgnlRsn { get; set; }

        public virtual String OrgnlTrckgDays { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class AmendmentInformationDetails6
    {
        public virtual String OrgnlMndtId { get; set; }

        public virtual PartyIdentification32 OrgnlCdtrSchmeId { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 OrgnlCdtrAgt { get; set; }

        public virtual CashAccount16 OrgnlCdtrAgtAcct { get; set; }

        public virtual PartyIdentification32 OrgnlDbtr { get; set; }

        public virtual CashAccount16 OrgnlDbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 OrgnlDbtrAgt { get; set; }

        public virtual CashAccount16 OrgnlDbtrAgtAcct { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime OrgnlFnlColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlFnlColltnDtSpecified { get; set; }

        public virtual Frequency1Code OrgnlFrqcy { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlFrqcySpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class AmountType2Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("InstdAmt", typeof(CurrencyAndAmount))]
        [System.Xml.Serialization.XmlElementAttribute("EqvtAmt", typeof(EquivalentAmount))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class AmountType3Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("EqvtAmt", typeof(EquivalentAmount2))]
        [System.Xml.Serialization.XmlElementAttribute("InstdAmt", typeof(ActiveOrHistoricCurrencyAndAmount))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class AmountType4Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("EqvtAmt", typeof(EquivalentAmount2))]
        [System.Xml.Serialization.XmlElementAttribute("InstdAmt", typeof(ActiveOrHistoricCurrencyAndAmount))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Authorisation1Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(Authorisation1Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class BranchAndFinancialInstitutionIdentification3
    {
        public virtual FinancialInstitutionIdentification5Choice FinInstnId { get; set; }

        public virtual BranchData BrnchId { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class BranchAndFinancialInstitutionIdentification4
    {
        public virtual FinancialInstitutionIdentification7 FinInstnId { get; set; }

        public virtual BranchData2 BrnchId { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class BranchAndFinancialInstitutionIdentification5
    {
        public virtual FinancialInstitutionIdentification8 FinInstnId { get; set; }

        public virtual BranchData2 BrnchId { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class BranchAndFinancialInstitutionIdentification6
    {
        public virtual FinancialInstitutionIdentification18 FinInstnId { get; set; }

        public virtual BranchData3 BrnchId { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class BranchData
    {
        public virtual String Id { get; set; }

        public virtual String Nm { get; set; }

        public virtual PostalAddress1 PstlAdr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class BranchData2
    {
        public virtual String Id { get; set; }

        public virtual String Nm { get; set; }

        public virtual PostalAddress6 PstlAdr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class BranchData3
    {
        public virtual String Id { get; set; }

        public virtual String LEI { get; set; }

        public virtual String Nm { get; set; }

        public virtual PostalAddress24 PstlAdr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CancellationReason1Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(CancellationReason2Code))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CancellationReasonInformation1
    {
        public virtual PartyIdentification8 CxlOrgtr { get; set; }

        public virtual CancellationReason1Choice CxlRsn { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlCxlRsnInf")]
        public virtual String[] AddtlCxlRsnInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CashAccount16
    {
        public virtual AccountIdentification4Choice Id { get; set; }

        public virtual CashAccountType2 Tp { get; set; }

        public virtual String Ccy { get; set; }

        public virtual String Nm { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CashAccount24
    {
        public virtual AccountIdentification4Choice Id { get; set; }

        public virtual CashAccountType2Choice Tp { get; set; }

        public virtual String Ccy { get; set; }

        public virtual String Nm { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CashAccount38
    {
        public virtual AccountIdentification4Choice Id { get; set; }

        public virtual CashAccountType2Choice Tp { get; set; }

        public virtual String Ccy { get; set; }

        public virtual String Nm { get; set; }

        public virtual ProxyAccountIdentification1 Prxy { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CashAccount40
    {
        public virtual AccountIdentification4Choice Id { get; set; }

        public virtual CashAccountType2Choice Tp { get; set; }

        public virtual String Ccy { get; set; }

        public virtual String Nm { get; set; }

        public virtual ProxyAccountIdentification1 Prxy { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CashAccount7
    {
        public virtual AccountIdentification3Choice Id { get; set; }

        public virtual CashAccountType2 Tp { get; set; }

        public virtual String Ccy { get; set; }

        public virtual String Nm { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CashAccountType2
    {
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(CashAccountType4Code))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CashAccountType2Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CategoryPurpose1Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Charges2
    {
        public virtual ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 Agt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Charges7
    {
        public virtual ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 Agt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ChargesInformation1
    {
        public virtual CurrencyAndAmount ChrgsAmt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 ChrgsPty { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ChargesInformation5
    {
        public virtual ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 Pty { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ClearingSystemIdentification1Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("ClrSysId", typeof(CashClearingSystem3Code))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ClearingSystemIdentification2Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ClearingSystemIdentification3Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ClearingSystemMemberIdentification2
    {
        public virtual ClearingSystemIdentification2Choice ClrSysId { get; set; }

        public virtual String MmbId { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ClearingSystemMemberIdentification3Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Id", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType2 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Contact4
    {
        public virtual NamePrefix2Code NmPrfx { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean NmPrfxSpecified { get; set; }

        public virtual String Nm { get; set; }

        public virtual String PhneNb { get; set; }

        public virtual String MobNb { get; set; }

        public virtual String FaxNb { get; set; }

        public virtual String EmailAdr { get; set; }

        public virtual String EmailPurp { get; set; }

        public virtual String JobTitl { get; set; }

        public virtual String Rspnsblty { get; set; }

        public virtual String Dept { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Othr")]
        public virtual OtherContact1[] Othr { get; set; }

        public virtual PreferredContactMethod1Code PrefrdMtd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PrefrdMtdSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ContactDetails2
    {
        public virtual NamePrefix1Code NmPrfx { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean NmPrfxSpecified { get; set; }

        public virtual String Nm { get; set; }

        public virtual String PhneNb { get; set; }

        public virtual String MobNb { get; set; }

        public virtual String FaxNb { get; set; }

        public virtual String EmailAdr { get; set; }

        public virtual String Othr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditorReferenceInformation1
    {
        public virtual CreditorReferenceType1 CdtrRefTp { get; set; }

        public virtual String CdtrRef { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditorReferenceInformation2
    {
        public virtual CreditorReferenceType2 Tp { get; set; }

        public virtual String Ref { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditorReferenceType1
    {
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(DocumentType3Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual Object Item { get; set; }

        public virtual String Issr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditorReferenceType1Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(DocumentType3Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditorReferenceType2
    {
        public virtual CreditorReferenceType1Choice CdOrPrtry { get; set; }

        public virtual String Issr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferMandateData1
    {
        public virtual String MndtId { get; set; }

        public virtual MandateTypeInformation2 Tp { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime DtOfSgntr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtOfSgntrSpecified { get; set; }

        public virtual DateTime DtOfVrfctn { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtOfVrfctnSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public virtual Byte[] ElctrncSgntr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FrstPmtDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FrstPmtDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FnlPmtDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FnlPmtDtSpecified { get; set; }

        public virtual Frequency36Choice Frqcy { get; set; }

        public virtual MandateSetupReason1Choice Rsn { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction19
    {
        public virtual PaymentIdentification3 PmtId { get; set; }

        public virtual PaymentTypeInformation21 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime PoolgAdjstmntDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PoolgAdjstmntDtSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges2[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 PrvsInstgAgt { get; set; }

        public virtual CashAccount24 PrvsInstgAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt1 { get; set; }

        public virtual CashAccount24 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt2 { get; set; }

        public virtual CashAccount24 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt3 { get; set; }

        public virtual CashAccount24 IntrmyAgt3Acct { get; set; }

        public virtual PartyIdentification43 UltmtDbtr { get; set; }

        public virtual PartyIdentification43 InitgPty { get; set; }

        public virtual PartyIdentification43 Dbtr { get; set; }

        public virtual CashAccount24 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 DbtrAgt { get; set; }

        public virtual CashAccount24 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 CdtrAgt { get; set; }

        public virtual CashAccount24 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification43 Cdtr { get; set; }

        public virtual CashAccount24 CdtrAcct { get; set; }

        public virtual PartyIdentification43 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent1[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
        public virtual RegulatoryReporting3[] RgltryRptg { get; set; }

        public virtual TaxInformation3 Tax { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
        public virtual RemittanceLocation4[] RltdRmtInf { get; set; }

        public virtual RemittanceInformation10 RmtInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction23
    {
        public virtual PaymentIdentification3 PmtId { get; set; }

        public virtual PaymentTypeInformation21 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 PrvsInstgAgt { get; set; }

        public virtual CashAccount24 PrvsInstgAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt1 { get; set; }

        public virtual CashAccount24 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt2 { get; set; }

        public virtual CashAccount24 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt3 { get; set; }

        public virtual CashAccount24 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 UltmtDbtr { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 Dbtr { get; set; }

        public virtual CashAccount24 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 DbtrAgt { get; set; }

        public virtual CashAccount24 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 CdtrAgt { get; set; }

        public virtual CashAccount24 CdtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 Cdtr { get; set; }

        public virtual CashAccount24 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent2[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("Ustrd", IsNullable = false)]
        public virtual String[] RmtInf { get; set; }

        public virtual CreditTransferTransaction24 UndrlygCstmrCdtTrf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction24
    {
        public virtual PartyIdentification43 UltmtDbtr { get; set; }

        public virtual PartyIdentification43 InitgPty { get; set; }

        public virtual PartyIdentification43 Dbtr { get; set; }

        public virtual CashAccount24 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 DbtrAgt { get; set; }

        public virtual CashAccount24 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 PrvsInstgAgt { get; set; }

        public virtual CashAccount24 PrvsInstgAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt1 { get; set; }

        public virtual CashAccount24 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt2 { get; set; }

        public virtual CashAccount24 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt3 { get; set; }

        public virtual CashAccount24 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 CdtrAgt { get; set; }

        public virtual CashAccount24 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification43 Cdtr { get; set; }

        public virtual CashAccount24 CdtrAcct { get; set; }

        public virtual PartyIdentification43 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent1[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        public virtual TaxInformation3 Tax { get; set; }

        public virtual RemittanceInformation11 RmtInf { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction25
    {
        public virtual PaymentIdentification3 PmtId { get; set; }

        public virtual PaymentTypeInformation21 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime PoolgAdjstmntDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PoolgAdjstmntDtSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges2[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 PrvsInstgAgt { get; set; }

        public virtual CashAccount24 PrvsInstgAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt1 { get; set; }

        public virtual CashAccount24 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt2 { get; set; }

        public virtual CashAccount24 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt3 { get; set; }

        public virtual CashAccount24 IntrmyAgt3Acct { get; set; }

        public virtual PartyIdentification43 UltmtDbtr { get; set; }

        public virtual PartyIdentification43 InitgPty { get; set; }

        public virtual PartyIdentification43 Dbtr { get; set; }

        public virtual CashAccount24 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 DbtrAgt { get; set; }

        public virtual CashAccount24 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 CdtrAgt { get; set; }

        public virtual CashAccount24 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification43 Cdtr { get; set; }

        public virtual CashAccount24 CdtrAcct { get; set; }

        public virtual PartyIdentification43 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent1[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
        public virtual RegulatoryReporting3[] RgltryRptg { get; set; }

        public virtual TaxInformation3 Tax { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
        public virtual RemittanceLocation4[] RltdRmtInf { get; set; }

        public virtual RemittanceInformation11 RmtInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction30
    {
        public virtual PaymentIdentification3 PmtId { get; set; }

        public virtual PaymentTypeInformation21 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime PoolgAdjstmntDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PoolgAdjstmntDtSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges2[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 PrvsInstgAgt1 { get; set; }

        public virtual CashAccount24 PrvsInstgAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 PrvsInstgAgt2 { get; set; }

        public virtual CashAccount24 PrvsInstgAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 PrvsInstgAgt3 { get; set; }

        public virtual CashAccount24 PrvsInstgAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt1 { get; set; }

        public virtual CashAccount24 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt2 { get; set; }

        public virtual CashAccount24 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt3 { get; set; }

        public virtual CashAccount24 IntrmyAgt3Acct { get; set; }

        public virtual PartyIdentification125 UltmtDbtr { get; set; }

        public virtual PartyIdentification125 InitgPty { get; set; }

        public virtual PartyIdentification125 Dbtr { get; set; }

        public virtual CashAccount24 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 DbtrAgt { get; set; }

        public virtual CashAccount24 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 CdtrAgt { get; set; }

        public virtual CashAccount24 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification125 Cdtr { get; set; }

        public virtual CashAccount24 CdtrAcct { get; set; }

        public virtual PartyIdentification125 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent1[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
        public virtual RegulatoryReporting3[] RgltryRptg { get; set; }

        public virtual TaxInformation6 Tax { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
        public virtual RemittanceLocation4[] RltdRmtInf { get; set; }

        public virtual RemittanceInformation15 RmtInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction31
    {
        public virtual PaymentIdentification3 PmtId { get; set; }

        public virtual PaymentTypeInformation21 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 PrvsInstgAgt1 { get; set; }

        public virtual CashAccount24 PrvsInstgAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 PrvsInstgAgt2 { get; set; }

        public virtual CashAccount24 PrvsInstgAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 PrvsInstgAgt3 { get; set; }

        public virtual CashAccount24 PrvsInstgAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt1 { get; set; }

        public virtual CashAccount24 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt2 { get; set; }

        public virtual CashAccount24 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt3 { get; set; }

        public virtual CashAccount24 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 UltmtDbtr { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 Dbtr { get; set; }

        public virtual CashAccount24 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 DbtrAgt { get; set; }

        public virtual CashAccount24 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 CdtrAgt { get; set; }

        public virtual CashAccount24 CdtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 Cdtr { get; set; }

        public virtual CashAccount24 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent2[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("Ustrd", IsNullable = false)]
        public virtual String[] RmtInf { get; set; }

        public virtual CreditTransferTransaction32 UndrlygCstmrCdtTrf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction32
    {
        public virtual PartyIdentification125 UltmtDbtr { get; set; }

        public virtual PartyIdentification125 InitgPty { get; set; }

        public virtual PartyIdentification125 Dbtr { get; set; }

        public virtual CashAccount24 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 DbtrAgt { get; set; }

        public virtual CashAccount24 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 PrvsInstgAgt1 { get; set; }

        public virtual CashAccount24 PrvsInstgAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 PrvsInstgAgt2 { get; set; }

        public virtual CashAccount24 PrvsInstgAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 PrvsInstgAgt3 { get; set; }

        public virtual CashAccount24 PrvsInstgAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt1 { get; set; }

        public virtual CashAccount24 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt2 { get; set; }

        public virtual CashAccount24 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt3 { get; set; }

        public virtual CashAccount24 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 CdtrAgt { get; set; }

        public virtual CashAccount24 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification125 Cdtr { get; set; }

        public virtual CashAccount24 CdtrAcct { get; set; }

        public virtual PartyIdentification125 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent1[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        public virtual TaxInformation6 Tax { get; set; }

        public virtual RemittanceInformation15 RmtInf { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction36
    {
        public virtual PaymentIdentification7 PmtId { get; set; }

        public virtual PaymentTypeInformation28 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt1 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt2 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt3 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual CashAccount38 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual CashAccount38 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual CashAccount38 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 UltmtDbtr { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 Dbtr { get; set; }

        public virtual CashAccount38 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount38 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount38 CdtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 Cdtr { get; set; }

        public virtual CashAccount38 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent2[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("Ustrd", IsNullable = false)]
        public virtual String[] RmtInf { get; set; }

        public virtual CreditTransferTransaction37 UndrlygCstmrCdtTrf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction37
    {
        public virtual PartyIdentification135 UltmtDbtr { get; set; }

        public virtual PartyIdentification135 InitgPty { get; set; }

        public virtual PartyIdentification135 Dbtr { get; set; }

        public virtual CashAccount38 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount38 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt1 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt2 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt3 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual CashAccount38 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual CashAccount38 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual CashAccount38 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount38 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification135 Cdtr { get; set; }

        public virtual CashAccount38 CdtrAcct { get; set; }

        public virtual PartyIdentification135 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent1[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        public virtual TaxInformation8 Tax { get; set; }

        public virtual RemittanceInformation16 RmtInf { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction38
    {
        public virtual String CdtId { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual PaymentTypeInformation28 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual CashAccount38 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual CashAccount38 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual CashAccount38 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount38 CdtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 Cdtr { get; set; }

        public virtual CashAccount38 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent2[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("DrctDbtTxInf")]
        public virtual DirectDebitTransactionInformation25[] DrctDbtTxInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction39
    {
        public virtual PaymentIdentification7 PmtId { get; set; }

        public virtual PaymentTypeInformation28 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime PoolgAdjstmntDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PoolgAdjstmntDtSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges7[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt1 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt2 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt3 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual CashAccount38 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual CashAccount38 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual CashAccount38 IntrmyAgt3Acct { get; set; }

        public virtual PartyIdentification135 UltmtDbtr { get; set; }

        public virtual PartyIdentification135 InitgPty { get; set; }

        public virtual PartyIdentification135 Dbtr { get; set; }

        public virtual CashAccount38 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount38 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount38 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification135 Cdtr { get; set; }

        public virtual CashAccount38 CdtrAcct { get; set; }

        public virtual PartyIdentification135 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent1[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
        public virtual RegulatoryReporting3[] RgltryRptg { get; set; }

        public virtual TaxInformation8 Tax { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
        public virtual RemittanceLocation7[] RltdRmtInf { get; set; }

        public virtual RemittanceInformation16 RmtInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction43
    {
        public virtual PaymentIdentification13 PmtId { get; set; }

        public virtual PaymentTypeInformation28 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime PoolgAdjstmntDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PoolgAdjstmntDtSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges7[] ChrgsInf { get; set; }

        public virtual CreditTransferMandateData1 MndtRltdInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt1 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt2 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt3 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual CashAccount38 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual CashAccount38 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual CashAccount38 IntrmyAgt3Acct { get; set; }

        public virtual PartyIdentification135 UltmtDbtr { get; set; }

        public virtual PartyIdentification135 InitgPty { get; set; }

        public virtual PartyIdentification135 Dbtr { get; set; }

        public virtual CashAccount38 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount38 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount38 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification135 Cdtr { get; set; }

        public virtual CashAccount38 CdtrAcct { get; set; }

        public virtual PartyIdentification135 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent3[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
        public virtual RegulatoryReporting3[] RgltryRptg { get; set; }

        public virtual TaxInformation8 Tax { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
        public virtual RemittanceLocation7[] RltdRmtInf { get; set; }

        public virtual RemittanceInformation16 RmtInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction44
    {
        public virtual PaymentIdentification13 PmtId { get; set; }

        public virtual PaymentTypeInformation28 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt1 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt2 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt3 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual CashAccount38 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual CashAccount38 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual CashAccount38 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 UltmtDbtr { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 Dbtr { get; set; }

        public virtual CashAccount38 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount38 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount38 CdtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 Cdtr { get; set; }

        public virtual CashAccount38 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent3[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("Ustrd", IsNullable = false)]
        public virtual String[] RmtInf { get; set; }

        public virtual CreditTransferTransaction45 UndrlygCstmrCdtTrf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction45
    {
        public virtual PartyIdentification135 UltmtDbtr { get; set; }

        public virtual PartyIdentification135 InitgPty { get; set; }

        public virtual PartyIdentification135 Dbtr { get; set; }

        public virtual CashAccount38 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount38 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt1 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt2 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt3 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual CashAccount38 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual CashAccount38 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual CashAccount38 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount38 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification135 Cdtr { get; set; }

        public virtual CashAccount38 CdtrAcct { get; set; }

        public virtual PartyIdentification135 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent3[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        public virtual TaxInformation8 Tax { get; set; }

        public virtual RemittanceInformation16 RmtInf { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction47
    {
        public virtual String CdtId { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual PaymentTypeInformation28 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual CashAccount38 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual CashAccount38 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual CashAccount38 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount38 CdtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 Cdtr { get; set; }

        public virtual CashAccount38 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent3[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("DrctDbtTxInf")]
        public virtual DirectDebitTransactionInformation26[] DrctDbtTxInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction50
    {
        public virtual PaymentIdentification13 PmtId { get; set; }

        public virtual PaymentTypeInformation28 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime PoolgAdjstmntDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PoolgAdjstmntDtSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges7[] ChrgsInf { get; set; }

        public virtual CreditTransferMandateData1 MndtRltdInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt1 { get; set; }

        public virtual CashAccount40 PrvsInstgAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt2 { get; set; }

        public virtual CashAccount40 PrvsInstgAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt3 { get; set; }

        public virtual CashAccount40 PrvsInstgAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual CashAccount40 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual CashAccount40 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual CashAccount40 IntrmyAgt3Acct { get; set; }

        public virtual PartyIdentification135 UltmtDbtr { get; set; }

        public virtual PartyIdentification135 InitgPty { get; set; }

        public virtual PartyIdentification135 Dbtr { get; set; }

        public virtual CashAccount40 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount40 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount40 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification135 Cdtr { get; set; }

        public virtual CashAccount40 CdtrAcct { get; set; }

        public virtual PartyIdentification135 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent3[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
        public virtual RegulatoryReporting3[] RgltryRptg { get; set; }

        public virtual TaxInformation10 Tax { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
        public virtual RemittanceLocation7[] RltdRmtInf { get; set; }

        public virtual RemittanceInformation21 RmtInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction52
    {
        public virtual PartyIdentification135 UltmtDbtr { get; set; }

        public virtual PartyIdentification135 InitgPty { get; set; }

        public virtual PartyIdentification135 Dbtr { get; set; }

        public virtual CashAccount40 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount40 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt1 { get; set; }

        public virtual CashAccount40 PrvsInstgAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt2 { get; set; }

        public virtual CashAccount40 PrvsInstgAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt3 { get; set; }

        public virtual CashAccount40 PrvsInstgAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual CashAccount40 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual CashAccount40 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual CashAccount40 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount40 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification135 Cdtr { get; set; }

        public virtual CashAccount40 CdtrAcct { get; set; }

        public virtual PartyIdentification135 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent3[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        public virtual TaxInformation10 Tax { get; set; }

        public virtual RemittanceInformation21 RmtInf { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction53
    {
        public virtual String CdtId { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual PaymentTypeInformation28 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual CashAccount40 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual CashAccount40 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual CashAccount40 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount40 CdtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 Cdtr { get; set; }

        public virtual CashAccount40 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent3[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("DrctDbtTxInf")]
        public virtual DirectDebitTransactionInformation27[] DrctDbtTxInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction56
    {
        public virtual PaymentIdentification13 PmtId { get; set; }

        public virtual PaymentTypeInformation28 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt1 { get; set; }

        public virtual CashAccount40 PrvsInstgAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt2 { get; set; }

        public virtual CashAccount40 PrvsInstgAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt3 { get; set; }

        public virtual CashAccount40 PrvsInstgAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual CashAccount40 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual CashAccount40 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual CashAccount40 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 UltmtDbtr { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 Dbtr { get; set; }

        public virtual CashAccount40 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount40 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount40 CdtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 Cdtr { get; set; }

        public virtual CashAccount40 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent3[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("Ustrd", IsNullable = false)]
        public virtual String[] RmtInf { get; set; }

        public virtual CreditTransferTransaction52 UndrlygCstmrCdtTrf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransaction9
    {
        public virtual String CdtId { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual PaymentTypeInformation21 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt1 { get; set; }

        public virtual CashAccount24 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt2 { get; set; }

        public virtual CashAccount24 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt3 { get; set; }

        public virtual CashAccount24 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 CdtrAgt { get; set; }

        public virtual CashAccount24 CdtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 Cdtr { get; set; }

        public virtual CashAccount24 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent2[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("DrctDbtTxInf")]
        public virtual DirectDebitTransactionInformation15[] DrctDbtTxInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransactionInformation11
    {
        public virtual PaymentIdentification3 PmtId { get; set; }

        public virtual PaymentTypeInformation21 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime PoolgAdjstmntDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PoolgAdjstmntDtSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual ChargesInformation5[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 PrvsInstgAgt { get; set; }

        public virtual CashAccount16 PrvsInstgAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 IntrmyAgt1 { get; set; }

        public virtual CashAccount16 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 IntrmyAgt2 { get; set; }

        public virtual CashAccount16 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 IntrmyAgt3 { get; set; }

        public virtual CashAccount16 IntrmyAgt3Acct { get; set; }

        public virtual PartyIdentification32 UltmtDbtr { get; set; }

        public virtual PartyIdentification32 InitgPty { get; set; }

        public virtual PartyIdentification32 Dbtr { get; set; }

        public virtual CashAccount16 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 DbtrAgt { get; set; }

        public virtual CashAccount16 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 CdtrAgt { get; set; }

        public virtual CashAccount16 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification32 Cdtr { get; set; }

        public virtual CashAccount16 CdtrAcct { get; set; }

        public virtual PartyIdentification32 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent1[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
        public virtual RegulatoryReporting3[] RgltryRptg { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
        public virtual RemittanceLocation2[] RltdRmtInf { get; set; }

        public virtual RemittanceInformation5 RmtInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransactionInformation12
    {
        public virtual PartyIdentification32 UltmtDbtr { get; set; }

        public virtual PartyIdentification32 InitgPty { get; set; }

        public virtual PartyIdentification32 Dbtr { get; set; }

        public virtual CashAccount16 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 DbtrAgt { get; set; }

        public virtual CashAccount16 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 PrvsInstgAgt { get; set; }

        public virtual CashAccount16 PrvsInstgAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 IntrmyAgt1 { get; set; }

        public virtual CashAccount16 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 IntrmyAgt2 { get; set; }

        public virtual CashAccount16 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 IntrmyAgt3 { get; set; }

        public virtual CashAccount16 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 CdtrAgt { get; set; }

        public virtual CashAccount16 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification32 Cdtr { get; set; }

        public virtual CashAccount16 CdtrAcct { get; set; }

        public virtual PartyIdentification32 UltmtCdtr { get; set; }

        public virtual RemittanceInformation5 RmtInf { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransactionInformation13
    {
        public virtual PaymentIdentification3 PmtId { get; set; }

        public virtual PaymentTypeInformation23 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 PrvsInstgAgt { get; set; }

        public virtual CashAccount16 PrvsInstgAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 IntrmyAgt1 { get; set; }

        public virtual CashAccount16 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 IntrmyAgt2 { get; set; }

        public virtual CashAccount16 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 IntrmyAgt3 { get; set; }

        public virtual CashAccount16 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 UltmtDbtr { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 Dbtr { get; set; }

        public virtual CashAccount16 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 DbtrAgt { get; set; }

        public virtual CashAccount16 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 CdtrAgt { get; set; }

        public virtual CashAccount16 CdtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 Cdtr { get; set; }

        public virtual CashAccount16 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent2[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("Ustrd", IsNullable = false)]
        public virtual String[] RmtInf { get; set; }

        public virtual CreditTransferTransactionInformation12 UndrlygCstmrCdtTrf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransactionInformation2
    {
        public virtual PaymentIdentification2 PmtId { get; set; }

        public virtual PaymentTypeInformation3 PmtTpInf { get; set; }

        public virtual CurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest1 SttlmTmReq { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime PoolgAdjstmntDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PoolgAdjstmntDtSpecified { get; set; }

        public virtual CurrencyAndAmount InstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual ChargesInformation1[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 PrvsInstgAgt { get; set; }

        public virtual CashAccount7 PrvsInstgAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 IntrmyAgt1 { get; set; }

        public virtual CashAccount7 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 IntrmyAgt2 { get; set; }

        public virtual CashAccount7 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 IntrmyAgt3 { get; set; }

        public virtual CashAccount7 IntrmyAgt3Acct { get; set; }

        public virtual PartyIdentification8 UltmtDbtr { get; set; }

        public virtual PartyIdentification8 InitgPty { get; set; }

        public virtual PartyIdentification8 Dbtr { get; set; }

        public virtual CashAccount7 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 DbtrAgt { get; set; }

        public virtual CashAccount7 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 CdtrAgt { get; set; }

        public virtual CashAccount7 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification8 Cdtr { get; set; }

        public virtual CashAccount7 CdtrAcct { get; set; }

        public virtual PartyIdentification8 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent1[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        public virtual Purpose1Choice Purp { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
        public virtual RegulatoryReporting2[] RgltryRptg { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
        public virtual RemittanceLocation1[] RltdRmtInf { get; set; }

        public virtual RemittanceInformation1 RmtInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CreditTransferTransactionInformation3
    {
        public virtual PaymentIdentification2 PmtId { get; set; }

        public virtual PaymentTypeInformation5 PmtTpInf { get; set; }

        public virtual CurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest1 SttlmTmReq { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 PrvsInstgAgt { get; set; }

        public virtual CashAccount7 PrvsInstgAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 IntrmyAgt1 { get; set; }

        public virtual CashAccount7 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 IntrmyAgt2 { get; set; }

        public virtual CashAccount7 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 IntrmyAgt3 { get; set; }

        public virtual CashAccount7 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 UltmtDbtr { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 Dbtr { get; set; }

        public virtual CashAccount7 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 DbtrAgt { get; set; }

        public virtual CashAccount7 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 CdtrAgt { get; set; }

        public virtual CashAccount7 CdtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 Cdtr { get; set; }

        public virtual CashAccount7 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 UltmtCdtr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public virtual InstructionForCreditorAgent2[] InstrForCdtrAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("InstrForNxtAgt")]
        public virtual InstructionForNextAgent1[] InstrForNxtAgt { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("Ustrd", IsNullable = false)]
        public virtual String[] RmtInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class CurrencyAndAmount
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual String Ccy { get; set; }

        [System.Xml.Serialization.XmlTextAttribute()]
        public virtual Decimal Value { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DateAndDateTime2Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("DtTm", typeof(DateTime))]
        [System.Xml.Serialization.XmlElementAttribute("Dt", typeof(DateTime), DataType="date")]
        public virtual DateTime Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType8 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DateAndDateTimeChoice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("DtTm", typeof(DateTime))]
        [System.Xml.Serialization.XmlElementAttribute("Dt", typeof(DateTime), DataType="date")]
        public virtual DateTime Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType8 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DateAndPlaceOfBirth
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime BirthDt { get; set; }

        public virtual String PrvcOfBirth { get; set; }

        public virtual String CityOfBirth { get; set; }

        public virtual String CtryOfBirth { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DateAndPlaceOfBirth1
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime BirthDt { get; set; }

        public virtual String PrvcOfBirth { get; set; }

        public virtual String CityOfBirth { get; set; }

        public virtual String CtryOfBirth { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DatePeriod2
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FrDt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ToDt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DatePeriodDetails
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FrDt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ToDt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DirectDebitTransaction1
    {
        public virtual MandateRelatedInformation1 MndtRltdInf { get; set; }

        public virtual PartyIdentification8 CdtrSchmeId { get; set; }

        public virtual String PreNtfctnId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime PreNtfctnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PreNtfctnDtSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DirectDebitTransaction10
    {
        public virtual MandateRelatedInformation14 MndtRltdInf { get; set; }

        public virtual PartyIdentification135 CdtrSchmeId { get; set; }

        public virtual String PreNtfctnId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime PreNtfctnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PreNtfctnDtSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DirectDebitTransaction11
    {
        public virtual MandateRelatedInformation15 MndtRltdInf { get; set; }

        public virtual PartyIdentification135 CdtrSchmeId { get; set; }

        public virtual String PreNtfctnId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime PreNtfctnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PreNtfctnDtSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DirectDebitTransaction6
    {
        public virtual MandateRelatedInformation6 MndtRltdInf { get; set; }

        public virtual PartyIdentification32 CdtrSchmeId { get; set; }

        public virtual String PreNtfctnId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime PreNtfctnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PreNtfctnDtSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DirectDebitTransaction8
    {
        public virtual MandateRelatedInformation10 MndtRltdInf { get; set; }

        public virtual PartyIdentification43 CdtrSchmeId { get; set; }

        public virtual String PreNtfctnId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime PreNtfctnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PreNtfctnDtSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DirectDebitTransaction9
    {
        public virtual MandateRelatedInformation11 MndtRltdInf { get; set; }

        public virtual PartyIdentification43 CdtrSchmeId { get; set; }

        public virtual String PreNtfctnId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime PreNtfctnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PreNtfctnDtSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DirectDebitTransactionInformation10
    {
        public virtual PaymentIdentification3 PmtId { get; set; }

        public virtual PaymentTypeInformation22 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual ChargesInformation5[] ChrgsInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdColltnDtSpecified { get; set; }

        public virtual DirectDebitTransaction6 DrctDbtTx { get; set; }

        public virtual PartyIdentification32 Cdtr { get; set; }

        public virtual CashAccount16 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 CdtrAgt { get; set; }

        public virtual CashAccount16 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification32 UltmtCdtr { get; set; }

        public virtual PartyIdentification32 InitgPty { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 IntrmyAgt1 { get; set; }

        public virtual CashAccount16 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 IntrmyAgt2 { get; set; }

        public virtual CashAccount16 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 IntrmyAgt3 { get; set; }

        public virtual CashAccount16 IntrmyAgt3Acct { get; set; }

        public virtual PartyIdentification32 Dbtr { get; set; }

        public virtual CashAccount16 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 DbtrAgt { get; set; }

        public virtual CashAccount16 DbtrAgtAcct { get; set; }

        public virtual PartyIdentification32 UltmtDbtr { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
        public virtual RegulatoryReporting3[] RgltryRptg { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
        public virtual RemittanceLocation2[] RltdRmtInf { get; set; }

        public virtual RemittanceInformation5 RmtInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DirectDebitTransactionInformation15
    {
        public virtual PaymentIdentification3 PmtId { get; set; }

        public virtual PaymentTypeInformation21 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 UltmtDbtr { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 Dbtr { get; set; }

        public virtual CashAccount24 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 DbtrAgt { get; set; }

        public virtual CashAccount24 DbtrAgtAcct { get; set; }

        public virtual String InstrForDbtrAgt { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("Ustrd", IsNullable = false)]
        public virtual String[] RmtInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DirectDebitTransactionInformation2
    {
        public virtual PaymentIdentification2 PmtId { get; set; }

        public virtual PaymentTypeInformation4 PmtTpInf { get; set; }

        public virtual CurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual CurrencyAndAmount InstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual ChargesInformation1[] ChrgsInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdColltnDtSpecified { get; set; }

        public virtual DirectDebitTransaction1 DrctDbtTx { get; set; }

        public virtual PartyIdentification8 Cdtr { get; set; }

        public virtual CashAccount7 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 CdtrAgt { get; set; }

        public virtual CashAccount7 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification8 UltmtCdtr { get; set; }

        public virtual PartyIdentification8 InitgPty { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 IntrmyAgt1 { get; set; }

        public virtual CashAccount7 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 IntrmyAgt2 { get; set; }

        public virtual CashAccount7 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 IntrmyAgt3 { get; set; }

        public virtual CashAccount7 IntrmyAgt3Acct { get; set; }

        public virtual PartyIdentification8 Dbtr { get; set; }

        public virtual CashAccount7 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 DbtrAgt { get; set; }

        public virtual CashAccount7 DbtrAgtAcct { get; set; }

        public virtual PartyIdentification8 UltmtDbtr { get; set; }

        public virtual Purpose1Choice Purp { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
        public virtual RegulatoryReporting2[] RgltryRptg { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
        public virtual RemittanceLocation1[] RltdRmtInf { get; set; }

        public virtual RemittanceInformation1 RmtInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DirectDebitTransactionInformation20
    {
        public virtual PaymentIdentification3 PmtId { get; set; }

        public virtual PaymentTypeInformation25 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges2[] ChrgsInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdColltnDtSpecified { get; set; }

        public virtual DirectDebitTransaction8 DrctDbtTx { get; set; }

        public virtual PartyIdentification43 Cdtr { get; set; }

        public virtual CashAccount24 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 CdtrAgt { get; set; }

        public virtual CashAccount24 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification43 UltmtCdtr { get; set; }

        public virtual PartyIdentification43 InitgPty { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt1 { get; set; }

        public virtual CashAccount24 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt2 { get; set; }

        public virtual CashAccount24 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt3 { get; set; }

        public virtual CashAccount24 IntrmyAgt3Acct { get; set; }

        public virtual PartyIdentification43 Dbtr { get; set; }

        public virtual CashAccount24 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 DbtrAgt { get; set; }

        public virtual CashAccount24 DbtrAgtAcct { get; set; }

        public virtual PartyIdentification43 UltmtDbtr { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
        public virtual RegulatoryReporting3[] RgltryRptg { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
        public virtual RemittanceLocation4[] RltdRmtInf { get; set; }

        public virtual RemittanceInformation11 RmtInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DirectDebitTransactionInformation21
    {
        public virtual PaymentIdentification3 PmtId { get; set; }

        public virtual PaymentTypeInformation25 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges2[] ChrgsInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdColltnDtSpecified { get; set; }

        public virtual DirectDebitTransaction9 DrctDbtTx { get; set; }

        public virtual PartyIdentification43 Cdtr { get; set; }

        public virtual CashAccount24 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 CdtrAgt { get; set; }

        public virtual CashAccount24 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification43 UltmtCdtr { get; set; }

        public virtual PartyIdentification43 InitgPty { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt1 { get; set; }

        public virtual CashAccount24 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt2 { get; set; }

        public virtual CashAccount24 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt3 { get; set; }

        public virtual CashAccount24 IntrmyAgt3Acct { get; set; }

        public virtual PartyIdentification43 Dbtr { get; set; }

        public virtual CashAccount24 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 DbtrAgt { get; set; }

        public virtual CashAccount24 DbtrAgtAcct { get; set; }

        public virtual PartyIdentification43 UltmtDbtr { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
        public virtual RegulatoryReporting3[] RgltryRptg { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
        public virtual RemittanceLocation4[] RltdRmtInf { get; set; }

        public virtual RemittanceInformation11 RmtInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DirectDebitTransactionInformation24
    {
        public virtual PaymentIdentification7 PmtId { get; set; }

        public virtual PaymentTypeInformation27 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges7[] ChrgsInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdColltnDtSpecified { get; set; }

        public virtual DirectDebitTransaction10 DrctDbtTx { get; set; }

        public virtual PartyIdentification135 Cdtr { get; set; }

        public virtual CashAccount38 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount38 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification135 UltmtCdtr { get; set; }

        public virtual PartyIdentification135 InitgPty { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual CashAccount38 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual CashAccount38 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual CashAccount38 IntrmyAgt3Acct { get; set; }

        public virtual PartyIdentification135 Dbtr { get; set; }

        public virtual CashAccount38 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount38 DbtrAgtAcct { get; set; }

        public virtual PartyIdentification135 UltmtDbtr { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
        public virtual RegulatoryReporting3[] RgltryRptg { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
        public virtual RemittanceLocation7[] RltdRmtInf { get; set; }

        public virtual RemittanceInformation16 RmtInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DirectDebitTransactionInformation25
    {
        public virtual PaymentIdentification7 PmtId { get; set; }

        public virtual PaymentTypeInformation28 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 UltmtDbtr { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 Dbtr { get; set; }

        public virtual CashAccount38 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount38 DbtrAgtAcct { get; set; }

        public virtual String InstrForDbtrAgt { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("Ustrd", IsNullable = false)]
        public virtual String[] RmtInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DirectDebitTransactionInformation26
    {
        public virtual PaymentIdentification13 PmtId { get; set; }

        public virtual PaymentTypeInformation28 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 UltmtDbtr { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 Dbtr { get; set; }

        public virtual CashAccount38 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount38 DbtrAgtAcct { get; set; }

        public virtual String InstrForDbtrAgt { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("Ustrd", IsNullable = false)]
        public virtual String[] RmtInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DirectDebitTransactionInformation27
    {
        public virtual PaymentIdentification13 PmtId { get; set; }

        public virtual PaymentTypeInformation28 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 UltmtDbtr { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 Dbtr { get; set; }

        public virtual CashAccount40 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount40 DbtrAgtAcct { get; set; }

        public virtual String InstrForDbtrAgt { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("Ustrd", IsNullable = false)]
        public virtual String[] RmtInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DirectDebitTransactionInformation29
    {
        public virtual PaymentIdentification13 PmtId { get; set; }

        public virtual PaymentTypeInformation27 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges7[] ChrgsInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdColltnDtSpecified { get; set; }

        public virtual DirectDebitTransaction11 DrctDbtTx { get; set; }

        public virtual PartyIdentification135 Cdtr { get; set; }

        public virtual CashAccount40 CdtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount40 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification135 UltmtCdtr { get; set; }

        public virtual PartyIdentification135 InitgPty { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual CashAccount40 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual CashAccount40 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual CashAccount40 IntrmyAgt3Acct { get; set; }

        public virtual PartyIdentification135 Dbtr { get; set; }

        public virtual CashAccount40 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount40 DbtrAgtAcct { get; set; }

        public virtual PartyIdentification135 UltmtDbtr { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
        public virtual RegulatoryReporting3[] RgltryRptg { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
        public virtual RemittanceLocation7[] RltdRmtInf { get; set; }

        public virtual RemittanceInformation21 RmtInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DiscountAmountAndType1
    {
        public virtual DiscountAmountType1Choice Tp { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DiscountAmountType1Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DocumentAdjustment1
    {
        public virtual ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

        public virtual CreditDebitCode CdtDbtInd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CdtDbtIndSpecified { get; set; }

        public virtual String Rsn { get; set; }

        public virtual String AddtlInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DocumentLineIdentification1
    {
        public virtual DocumentLineType1 Tp { get; set; }

        public virtual String Nb { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime RltdDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean RltdDtSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DocumentLineInformation1
    {
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public virtual DocumentLineIdentification1[] Id { get; set; }

        public virtual String Desc { get; set; }

        public virtual RemittanceAmount3 Amt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DocumentLineType1
    {
        public virtual DocumentLineType1Choice CdOrPrtry { get; set; }

        public virtual String Issr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class DocumentLineType1Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class EquivalentAmount
    {
        public virtual CurrencyAndAmount Amt { get; set; }

        public virtual String CcyOfTrf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class EquivalentAmount2
    {
        public virtual ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

        public virtual String CcyOfTrf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class FinancialIdentificationSchemeName1Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class FinancialInstitutionIdentification18
    {
        public virtual String BICFI { get; set; }

        public virtual ClearingSystemMemberIdentification2 ClrSysMmbId { get; set; }

        public virtual String LEI { get; set; }

        public virtual String Nm { get; set; }

        public virtual PostalAddress24 PstlAdr { get; set; }

        public virtual GenericFinancialIdentification1 Othr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class FinancialInstitutionIdentification3
    {
        public virtual String BIC { get; set; }

        public virtual ClearingSystemMemberIdentification3Choice ClrSysMmbId { get; set; }

        public virtual String Nm { get; set; }

        public virtual PostalAddress1 PstlAdr { get; set; }

        public virtual GenericIdentification3 PrtryId { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class FinancialInstitutionIdentification5Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("ClrSysMmbId", typeof(ClearingSystemMemberIdentification3Choice))]
        [System.Xml.Serialization.XmlElementAttribute("CmbndId", typeof(FinancialInstitutionIdentification3))]
        [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress7))]
        [System.Xml.Serialization.XmlElementAttribute("BIC", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification3))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class FinancialInstitutionIdentification7
    {
        public virtual String BIC { get; set; }

        public virtual ClearingSystemMemberIdentification2 ClrSysMmbId { get; set; }

        public virtual String Nm { get; set; }

        public virtual PostalAddress6 PstlAdr { get; set; }

        public virtual GenericFinancialIdentification1 Othr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class FinancialInstitutionIdentification8
    {
        public virtual String BICFI { get; set; }

        public virtual ClearingSystemMemberIdentification2 ClrSysMmbId { get; set; }

        public virtual String Nm { get; set; }

        public virtual PostalAddress6 PstlAdr { get; set; }

        public virtual GenericFinancialIdentification1 Othr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Frequency21Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Tp", typeof(Frequency6Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prd", typeof(FrequencyPeriod1))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Frequency36Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Tp", typeof(Frequency6Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prd", typeof(FrequencyPeriod1))]
        [System.Xml.Serialization.XmlElementAttribute("PtInTm", typeof(FrequencyAndMoment1))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class FrequencyAndMoment1
    {
        public virtual Frequency6Code Tp { get; set; }

        public virtual String PtInTm { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class FrequencyPeriod1
    {
        public virtual Frequency6Code Tp { get; set; }

        public virtual Decimal CntPerPrd { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Garnishment1
    {
        public virtual GarnishmentType1 Tp { get; set; }

        public virtual PartyIdentification43 Grnshee { get; set; }

        public virtual PartyIdentification43 GrnshmtAdmstr { get; set; }

        public virtual String RefNb { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime Dt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RmtdAmt { get; set; }

        public virtual Boolean FmlyMdclInsrncInd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FmlyMdclInsrncIndSpecified { get; set; }

        public virtual Boolean MplyeeTermntnInd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean MplyeeTermntnIndSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Garnishment2
    {
        public virtual GarnishmentType1 Tp { get; set; }

        public virtual PartyIdentification125 Grnshee { get; set; }

        public virtual PartyIdentification125 GrnshmtAdmstr { get; set; }

        public virtual String RefNb { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime Dt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RmtdAmt { get; set; }

        public virtual Boolean FmlyMdclInsrncInd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FmlyMdclInsrncIndSpecified { get; set; }

        public virtual Boolean MplyeeTermntnInd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean MplyeeTermntnIndSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Garnishment3
    {
        public virtual GarnishmentType1 Tp { get; set; }

        public virtual PartyIdentification135 Grnshee { get; set; }

        public virtual PartyIdentification135 GrnshmtAdmstr { get; set; }

        public virtual String RefNb { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime Dt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RmtdAmt { get; set; }

        public virtual Boolean FmlyMdclInsrncInd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FmlyMdclInsrncIndSpecified { get; set; }

        public virtual Boolean MplyeeTermntnInd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean MplyeeTermntnIndSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GarnishmentType1
    {
        public virtual GarnishmentType1Choice CdOrPrtry { get; set; }

        public virtual String Issr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GarnishmentType1Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GenericAccountIdentification1
    {
        public virtual String Id { get; set; }

        public virtual AccountSchemeName1Choice SchmeNm { get; set; }

        public virtual String Issr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GenericFinancialIdentification1
    {
        public virtual String Id { get; set; }

        public virtual FinancialIdentificationSchemeName1Choice SchmeNm { get; set; }

        public virtual String Issr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GenericIdentification3
    {
        public virtual String Id { get; set; }

        public virtual String Issr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GenericIdentification30
    {
        public virtual String Id { get; set; }

        public virtual String Issr { get; set; }

        public virtual String SchmeNm { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GenericIdentification4
    {
        public virtual String Id { get; set; }

        public virtual String IdTp { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GenericOrganisationIdentification1
    {
        public virtual String Id { get; set; }

        public virtual OrganisationIdentificationSchemeName1Choice SchmeNm { get; set; }

        public virtual String Issr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GenericPersonIdentification1
    {
        public virtual String Id { get; set; }

        public virtual PersonIdentificationSchemeName1Choice SchmeNm { get; set; }

        public virtual String Issr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader101
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual OriginalBusinessQuery1 OrgnlBizQry { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader2
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual CurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInformation1 SttlmInf { get; set; }

        public virtual PaymentTypeInformation3 PmtTpInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader3
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Authstn")]
        public virtual String[] Authstn { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual CurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInformation2 SttlmInf { get; set; }

        public virtual PaymentTypeInformation4 PmtTpInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader33
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInformation13 SttlmInf { get; set; }

        public virtual PaymentTypeInformation21 PmtTpInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader34
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Authstn")]
        public virtual Authorisation1Choice[] Authstn { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInformation14 SttlmInf { get; set; }

        public virtual PaymentTypeInformation22 PmtTpInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader35
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInformation13 SttlmInf { get; set; }

        public virtual PaymentTypeInformation23 PmtTpInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader37
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader38
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Authstn")]
        public virtual Authorisation1Choice[] Authstn { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual Boolean GrpRtr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean GrpRtrSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlRtrdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInformation13 SttlmInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader4
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual CurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInformation1 SttlmInf { get; set; }

        public virtual PaymentTypeInformation5 PmtTpInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader41
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Authstn")]
        public virtual Authorisation1Choice[] Authstn { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual Boolean GrpRvsl { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean GrpRvslSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlRvsdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInformation13 SttlmInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader49
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInstruction1 SttlmInf { get; set; }

        public virtual PaymentTypeInformation21 PmtTpInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader5
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        public virtual PartyIdentification8 InitgPty { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 FwdgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 DbtrAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 CdtrAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader50
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Authstn")]
        public virtual Authorisation1Choice[] Authstn { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInstruction2 SttlmInf { get; set; }

        public virtual PaymentTypeInformation25 PmtTpInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader53
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader6
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Authstn")]
        public virtual String[] Authstn { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual Boolean GrpRtr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean GrpRtrSpecified { get; set; }

        public virtual CurrencyAndAmount TtlRtrdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInformation1 SttlmInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader63
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader7
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual Boolean GrpCxl { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean GrpCxlSpecified { get; set; }

        public virtual PartyIdentification8 InitgPty { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 FwdgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 DbtrAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 CdtrAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader70
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInstruction4 SttlmInf { get; set; }

        public virtual PaymentTypeInformation21 PmtTpInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader71
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Authstn")]
        public virtual Authorisation1Choice[] Authstn { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual Boolean GrpRvsl { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean GrpRvslSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlRvsdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInstruction4 SttlmInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader72
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Authstn")]
        public virtual Authorisation1Choice[] Authstn { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual Boolean GrpRtr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean GrpRtrSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlRtrdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInstruction4 SttlmInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader89
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Authstn")]
        public virtual Authorisation1Choice[] Authstn { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual Boolean GrpRvsl { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean GrpRvslSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlRvsdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInstruction7 SttlmInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader9
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Authstn")]
        public virtual String[] Authstn { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual Boolean GrpRvsl { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean GrpRvslSpecified { get; set; }

        public virtual CurrencyAndAmount TtlRvsdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInformation1 SttlmInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader90
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Authstn")]
        public virtual Authorisation1Choice[] Authstn { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual Boolean GrpRtr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean GrpRtrSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlRtrdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInstruction7 SttlmInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader91
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader92
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader93
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInstruction7 SttlmInf { get; set; }

        public virtual PaymentTypeInformation28 PmtTpInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader94
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Authstn")]
        public virtual Authorisation1Choice[] Authstn { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInstruction8 SttlmInf { get; set; }

        public virtual PaymentTypeInformation27 PmtTpInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader96
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInstruction11 SttlmInf { get; set; }

        public virtual PaymentTypeInformation28 PmtTpInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader97
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Authstn")]
        public virtual Authorisation1Choice[] Authstn { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual Boolean GrpRvsl { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean GrpRvslSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlRvsdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInstruction11 SttlmInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader98
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Authstn")]
        public virtual Authorisation1Choice[] Authstn { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInstruction14 SttlmInf { get; set; }

        public virtual PaymentTypeInformation27 PmtTpInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class GroupHeader99
    {
        public virtual String MsgId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Authstn")]
        public virtual Authorisation1Choice[] Authstn { get; set; }

        public virtual Boolean BtchBookg { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean BtchBookgSpecified { get; set; }

        public virtual String NbOfTxs { get; set; }

        public virtual Decimal CtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtrlSumSpecified { get; set; }

        public virtual Boolean GrpRtr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean GrpRtrSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount TtlRtrdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual SettlementInstruction11 SttlmInf { get; set; }

        public virtual PaymentTypeInformation28 PmtTpInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class InstructionForCreditorAgent1
    {
        public virtual Instruction3Code Cd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CdSpecified { get; set; }

        public virtual String InstrInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class InstructionForCreditorAgent2
    {
        public virtual Instruction5Code Cd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CdSpecified { get; set; }

        public virtual String InstrInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class InstructionForCreditorAgent3
    {
        public virtual String Cd { get; set; }

        public virtual String InstrInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class InstructionForNextAgent1
    {
        public virtual Instruction4Code Cd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CdSpecified { get; set; }

        public virtual String InstrInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class LocalInstrument1Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class LocalInstrument2Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class MandateClassification1Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(MandateClassification1Code))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class MandateRelatedData1Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("DrctDbtMndt", typeof(MandateRelatedInformation14))]
        [System.Xml.Serialization.XmlElementAttribute("CdtTrfMndt", typeof(CreditTransferMandateData1))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class MandateRelatedData2Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("CdtTrfMndt", typeof(CreditTransferMandateData1))]
        [System.Xml.Serialization.XmlElementAttribute("DrctDbtMndt", typeof(MandateRelatedInformation15))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class MandateRelatedInformation1
    {
        public virtual String MndtId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime DtOfSgntr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtOfSgntrSpecified { get; set; }

        public virtual Boolean AmdmntInd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AmdmntIndSpecified { get; set; }

        public virtual AmendmentInformationDetails1 AmdmntInfDtls { get; set; }

        public virtual String ElctrncSgntr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FrstColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FrstColltnDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FnlColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FnlColltnDtSpecified { get; set; }

        public virtual Frequency1Code Frqcy { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FrqcySpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class MandateRelatedInformation10
    {
        public virtual String MndtId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime DtOfSgntr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtOfSgntrSpecified { get; set; }

        public virtual Boolean AmdmntInd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AmdmntIndSpecified { get; set; }

        public virtual AmendmentInformationDetails10 AmdmntInfDtls { get; set; }

        public virtual String ElctrncSgntr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FrstColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FrstColltnDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FnlColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FnlColltnDtSpecified { get; set; }

        public virtual Frequency21Choice Frqcy { get; set; }

        public virtual MandateSetupReason1Choice Rsn { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class MandateRelatedInformation11
    {
        public virtual String MndtId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime DtOfSgntr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtOfSgntrSpecified { get; set; }

        public virtual Boolean AmdmntInd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AmdmntIndSpecified { get; set; }

        public virtual AmendmentInformationDetails11 AmdmntInfDtls { get; set; }

        public virtual String ElctrncSgntr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FrstColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FrstColltnDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FnlColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FnlColltnDtSpecified { get; set; }

        public virtual Frequency36Choice Frqcy { get; set; }

        public virtual MandateSetupReason1Choice Rsn { get; set; }

        public virtual String TrckgDays { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class MandateRelatedInformation12
    {
        public virtual String MndtId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime DtOfSgntr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtOfSgntrSpecified { get; set; }

        public virtual Boolean AmdmntInd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AmdmntIndSpecified { get; set; }

        public virtual AmendmentInformationDetails12 AmdmntInfDtls { get; set; }

        public virtual String ElctrncSgntr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FrstColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FrstColltnDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FnlColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FnlColltnDtSpecified { get; set; }

        public virtual Frequency36Choice Frqcy { get; set; }

        public virtual MandateSetupReason1Choice Rsn { get; set; }

        public virtual String TrckgDays { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class MandateRelatedInformation14
    {
        public virtual String MndtId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime DtOfSgntr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtOfSgntrSpecified { get; set; }

        public virtual Boolean AmdmntInd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AmdmntIndSpecified { get; set; }

        public virtual AmendmentInformationDetails13 AmdmntInfDtls { get; set; }

        public virtual String ElctrncSgntr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FrstColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FrstColltnDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FnlColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FnlColltnDtSpecified { get; set; }

        public virtual Frequency36Choice Frqcy { get; set; }

        public virtual MandateSetupReason1Choice Rsn { get; set; }

        public virtual String TrckgDays { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class MandateRelatedInformation15
    {
        public virtual String MndtId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime DtOfSgntr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtOfSgntrSpecified { get; set; }

        public virtual Boolean AmdmntInd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AmdmntIndSpecified { get; set; }

        public virtual AmendmentInformationDetails14 AmdmntInfDtls { get; set; }

        public virtual String ElctrncSgntr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FrstColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FrstColltnDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FnlColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FnlColltnDtSpecified { get; set; }

        public virtual Frequency36Choice Frqcy { get; set; }

        public virtual MandateSetupReason1Choice Rsn { get; set; }

        public virtual String TrckgDays { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class MandateRelatedInformation6
    {
        public virtual String MndtId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime DtOfSgntr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtOfSgntrSpecified { get; set; }

        public virtual Boolean AmdmntInd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AmdmntIndSpecified { get; set; }

        public virtual AmendmentInformationDetails6 AmdmntInfDtls { get; set; }

        public virtual String ElctrncSgntr { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FrstColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FrstColltnDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime FnlColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FnlColltnDtSpecified { get; set; }

        public virtual Frequency1Code Frqcy { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FrqcySpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class MandateSetupReason1Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class MandateTypeInformation2
    {
        public virtual ServiceLevel8Choice SvcLvl { get; set; }

        public virtual LocalInstrument2Choice LclInstrm { get; set; }

        public virtual CategoryPurpose1Choice CtgyPurp { get; set; }

        public virtual MandateClassification1Choice Clssfctn { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class NameAndAddress10
    {
        public virtual String Nm { get; set; }

        public virtual PostalAddress6 Adr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class NameAndAddress16
    {
        public virtual String Nm { get; set; }

        public virtual PostalAddress24 Adr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class NameAndAddress3
    {
        public virtual String Nm { get; set; }

        public virtual PostalAddress1 Adr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class NameAndAddress7
    {
        public virtual String Nm { get; set; }

        public virtual PostalAddress1 PstlAdr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class NumberOfTransactionsPerStatus1
    {
        public virtual String DtldNbOfTxs { get; set; }

        public virtual TransactionIndividualStatus1Code DtldSts { get; set; }

        public virtual Decimal DtldCtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtldCtrlSumSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class NumberOfTransactionsPerStatus3
    {
        public virtual String DtldNbOfTxs { get; set; }

        public virtual TransactionIndividualStatus3Code DtldSts { get; set; }

        public virtual Decimal DtldCtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtldCtrlSumSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class NumberOfTransactionsPerStatus5
    {
        public virtual String DtldNbOfTxs { get; set; }

        public virtual String DtldSts { get; set; }

        public virtual Decimal DtldCtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtldCtrlSumSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OrganisationIdentification2
    {
        public virtual String BIC { get; set; }

        public virtual String IBEI { get; set; }

        public virtual String BEI { get; set; }

        public virtual String EANGLN { get; set; }

        public virtual String USCHU { get; set; }

        public virtual String DUNS { get; set; }

        public virtual String BkPtyId { get; set; }

        public virtual String TaxIdNb { get; set; }

        public virtual GenericIdentification3 PrtryId { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OrganisationIdentification29
    {
        public virtual String AnyBIC { get; set; }

        public virtual String LEI { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Othr")]
        public virtual GenericOrganisationIdentification1[] Othr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OrganisationIdentification4
    {
        public virtual String BICOrBEI { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Othr")]
        public virtual GenericOrganisationIdentification1[] Othr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OrganisationIdentification8
    {
        public virtual String AnyBIC { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Othr")]
        public virtual GenericOrganisationIdentification1[] Othr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OrganisationIdentificationSchemeName1Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalBusinessQuery1
    {
        public virtual String MsgId { get; set; }

        public virtual String MsgNmId { get; set; }

        public virtual DateTime CreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CreDtTmSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupHeader1
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        public virtual String OrgnlNbOfTxs { get; set; }

        public virtual Decimal OrgnlCtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCtrlSumSpecified { get; set; }

        public virtual TransactionGroupStatus3Code GrpSts { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean GrpStsSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("StsRsnInf")]
        public virtual StatusReasonInformation9[] StsRsnInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("NbOfTxsPerSts")]
        public virtual NumberOfTransactionsPerStatus3[] NbOfTxsPerSts { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupHeader11
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RvslRsnInf")]
        public virtual PaymentReversalReason8[] RvslRsnInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupHeader12
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RtrRsnInf")]
        public virtual PaymentReturnReason4[] RtrRsnInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupHeader13
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        public virtual String OrgnlNbOfTxs { get; set; }

        public virtual Decimal OrgnlCtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCtrlSumSpecified { get; set; }

        public virtual String GrpSts { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("StsRsnInf")]
        public virtual StatusReasonInformation11[] StsRsnInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("NbOfTxsPerSts")]
        public virtual NumberOfTransactionsPerStatus5[] NbOfTxsPerSts { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupHeader16
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RvslRsnInf")]
        public virtual PaymentReversalReason9[] RvslRsnInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupHeader17
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        public virtual String OrgnlNbOfTxs { get; set; }

        public virtual Decimal OrgnlCtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCtrlSumSpecified { get; set; }

        public virtual String GrpSts { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("StsRsnInf")]
        public virtual StatusReasonInformation12[] StsRsnInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("NbOfTxsPerSts")]
        public virtual NumberOfTransactionsPerStatus5[] NbOfTxsPerSts { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupHeader18
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RtrRsnInf")]
        public virtual PaymentReturnReason6[] RtrRsnInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupHeader2
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RtrRsnInf")]
        public virtual PaymentReturnReason1[] RtrRsnInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupHeader3
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RvslRsnInf")]
        public virtual PaymentReversalReason7[] RvslRsnInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupHeader7
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        public virtual String OrgnlNbOfTxs { get; set; }

        public virtual Decimal OrgnlCtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCtrlSumSpecified { get; set; }

        public virtual String GrpSts { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("StsRsnInf")]
        public virtual StatusReasonInformation9[] StsRsnInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("NbOfTxsPerSts")]
        public virtual NumberOfTransactionsPerStatus5[] NbOfTxsPerSts { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupInformation1
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("OrgnlMsgId", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("NtwkFileNm", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType6 ItemElementName { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        public virtual String FileOrgtr { get; set; }

        public virtual String OrgnlNbOfTxs { get; set; }

        public virtual Decimal OrgnlCtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCtrlSumSpecified { get; set; }

        public virtual TransactionGroupStatus1Code GrpSts { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean GrpStsSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("StsRsnInf")]
        public virtual StatusReasonInformation1[] StsRsnInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("NbOfTxsPerSts")]
        public virtual NumberOfTransactionsPerStatus1[] NbOfTxsPerSts { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupInformation2
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RtrRsnInf")]
        public virtual ReturnReasonInformation1[] RtrRsnInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupInformation20
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        public virtual String OrgnlNbOfTxs { get; set; }

        public virtual Decimal OrgnlCtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCtrlSumSpecified { get; set; }

        public virtual TransactionGroupStatus3Code GrpSts { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean GrpStsSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("StsRsnInf")]
        public virtual StatusReasonInformation8[] StsRsnInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("NbOfTxsPerSts")]
        public virtual NumberOfTransactionsPerStatus3[] NbOfTxsPerSts { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupInformation21
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RtrRsnInf")]
        public virtual ReturnReasonInformation9[] RtrRsnInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupInformation22
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RvslRsnInf")]
        public virtual ReversalReasonInformation6[] RvslRsnInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupInformation27
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        public virtual String OrgnlNbOfTxs { get; set; }

        public virtual Decimal OrgnlCtrlSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCtrlSumSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupInformation29
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupInformation3
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupInformation4
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("CxlRsnInf")]
        public virtual CancellationReasonInformation1[] CxlRsnInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalGroupInformation5
    {
        public virtual String OrgnlMsgId { get; set; }

        public virtual String OrgnlMsgNmId { get; set; }

        public virtual DateTime OrgnlCreDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlCreDtTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RvslRsnInf")]
        public virtual ReversalReasonInformation1[] RvslRsnInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalTransactionReference1
    {
        public virtual CurrencyAndAmount IntrBkSttlmAmt { get; set; }

        public virtual AmountType2Choice Amt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("ReqdExctnDt", typeof(DateTime), DataType="date")]
        [System.Xml.Serialization.XmlElementAttribute("ReqdColltnDt", typeof(DateTime), DataType="date")]
        public virtual DateTime Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType5 ItemElementName { get; set; }

        public virtual PartyIdentification8 CdtrSchmeId { get; set; }

        public virtual SettlementInformation3 SttlmInf { get; set; }

        public virtual PaymentTypeInformation6 PmtTpInf { get; set; }

        public virtual PaymentMethod4Code PmtMtd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PmtMtdSpecified { get; set; }

        public virtual MandateRelatedInformation1 MndtRltdInf { get; set; }

        public virtual RemittanceInformation1 RmtInf { get; set; }

        public virtual PartyIdentification8 UltmtDbtr { get; set; }

        public virtual PartyIdentification8 Dbtr { get; set; }

        public virtual CashAccount7 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 DbtrAgt { get; set; }

        public virtual CashAccount7 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 CdtrAgt { get; set; }

        public virtual CashAccount7 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification8 Cdtr { get; set; }

        public virtual CashAccount7 CdtrAcct { get; set; }

        public virtual PartyIdentification8 UltmtCdtr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalTransactionReference13
    {
        public virtual ActiveOrHistoricCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        public virtual AmountType3Choice Amt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdColltnDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdExctnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdExctnDtSpecified { get; set; }

        public virtual PartyIdentification32 CdtrSchmeId { get; set; }

        public virtual SettlementInformation13 SttlmInf { get; set; }

        public virtual PaymentTypeInformation22 PmtTpInf { get; set; }

        public virtual PaymentMethod4Code PmtMtd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PmtMtdSpecified { get; set; }

        public virtual MandateRelatedInformation6 MndtRltdInf { get; set; }

        public virtual RemittanceInformation5 RmtInf { get; set; }

        public virtual PartyIdentification32 UltmtDbtr { get; set; }

        public virtual PartyIdentification32 Dbtr { get; set; }

        public virtual CashAccount16 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 DbtrAgt { get; set; }

        public virtual CashAccount16 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 CdtrAgt { get; set; }

        public virtual CashAccount16 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification32 Cdtr { get; set; }

        public virtual CashAccount16 CdtrAcct { get; set; }

        public virtual PartyIdentification32 UltmtCdtr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalTransactionReference22
    {
        public virtual ActiveOrHistoricCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        public virtual AmountType4Choice Amt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdColltnDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdExctnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdExctnDtSpecified { get; set; }

        public virtual PartyIdentification43 CdtrSchmeId { get; set; }

        public virtual SettlementInstruction4 SttlmInf { get; set; }

        public virtual PaymentTypeInformation25 PmtTpInf { get; set; }

        public virtual PaymentMethod4Code PmtMtd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PmtMtdSpecified { get; set; }

        public virtual MandateRelatedInformation10 MndtRltdInf { get; set; }

        public virtual RemittanceInformation11 RmtInf { get; set; }

        public virtual PartyIdentification43 UltmtDbtr { get; set; }

        public virtual PartyIdentification43 Dbtr { get; set; }

        public virtual CashAccount24 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 DbtrAgt { get; set; }

        public virtual CashAccount24 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 CdtrAgt { get; set; }

        public virtual CashAccount24 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification43 Cdtr { get; set; }

        public virtual CashAccount24 CdtrAcct { get; set; }

        public virtual PartyIdentification43 UltmtCdtr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalTransactionReference24
    {
        public virtual ActiveOrHistoricCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        public virtual AmountType4Choice Amt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdColltnDtSpecified { get; set; }

        public virtual DateAndDateTimeChoice ReqdExctnDt { get; set; }

        public virtual PartyIdentification43 CdtrSchmeId { get; set; }

        public virtual SettlementInstruction4 SttlmInf { get; set; }

        public virtual PaymentTypeInformation25 PmtTpInf { get; set; }

        public virtual PaymentMethod4Code PmtMtd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PmtMtdSpecified { get; set; }

        public virtual MandateRelatedInformation11 MndtRltdInf { get; set; }

        public virtual RemittanceInformation11 RmtInf { get; set; }

        public virtual PartyIdentification43 UltmtDbtr { get; set; }

        public virtual PartyIdentification43 Dbtr { get; set; }

        public virtual CashAccount24 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 DbtrAgt { get; set; }

        public virtual CashAccount24 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 CdtrAgt { get; set; }

        public virtual CashAccount24 CdtrAgtAcct { get; set; }

        public virtual PartyIdentification43 Cdtr { get; set; }

        public virtual CashAccount24 CdtrAcct { get; set; }

        public virtual PartyIdentification43 UltmtCdtr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalTransactionReference27
    {
        public virtual ActiveOrHistoricCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        public virtual AmountType4Choice Amt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdColltnDtSpecified { get; set; }

        public virtual DateAndDateTime2Choice ReqdExctnDt { get; set; }

        public virtual PartyIdentification125 CdtrSchmeId { get; set; }

        public virtual SettlementInstruction4 SttlmInf { get; set; }

        public virtual PaymentTypeInformation25 PmtTpInf { get; set; }

        public virtual PaymentMethod4Code PmtMtd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PmtMtdSpecified { get; set; }

        public virtual MandateRelatedInformation12 MndtRltdInf { get; set; }

        public virtual RemittanceInformation15 RmtInf { get; set; }

        public virtual Party35Choice UltmtDbtr { get; set; }

        public virtual Party35Choice Dbtr { get; set; }

        public virtual CashAccount24 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 DbtrAgt { get; set; }

        public virtual CashAccount24 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 CdtrAgt { get; set; }

        public virtual CashAccount24 CdtrAgtAcct { get; set; }

        public virtual Party35Choice Cdtr { get; set; }

        public virtual CashAccount24 CdtrAcct { get; set; }

        public virtual Party35Choice UltmtCdtr { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalTransactionReference28
    {
        public virtual ActiveOrHistoricCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        public virtual AmountType4Choice Amt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdColltnDtSpecified { get; set; }

        public virtual DateAndDateTime2Choice ReqdExctnDt { get; set; }

        public virtual PartyIdentification135 CdtrSchmeId { get; set; }

        public virtual SettlementInstruction7 SttlmInf { get; set; }

        public virtual PaymentTypeInformation27 PmtTpInf { get; set; }

        public virtual PaymentMethod4Code PmtMtd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PmtMtdSpecified { get; set; }

        public virtual MandateRelatedInformation14 MndtRltdInf { get; set; }

        public virtual RemittanceInformation16 RmtInf { get; set; }

        public virtual Party40Choice UltmtDbtr { get; set; }

        public virtual Party40Choice Dbtr { get; set; }

        public virtual CashAccount38 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount38 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount38 CdtrAgtAcct { get; set; }

        public virtual Party40Choice Cdtr { get; set; }

        public virtual CashAccount38 CdtrAcct { get; set; }

        public virtual Party40Choice UltmtCdtr { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalTransactionReference31
    {
        public virtual ActiveOrHistoricCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        public virtual AmountType4Choice Amt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdColltnDtSpecified { get; set; }

        public virtual DateAndDateTime2Choice ReqdExctnDt { get; set; }

        public virtual PartyIdentification135 CdtrSchmeId { get; set; }

        public virtual SettlementInstruction7 SttlmInf { get; set; }

        public virtual PaymentTypeInformation27 PmtTpInf { get; set; }

        public virtual PaymentMethod4Code PmtMtd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PmtMtdSpecified { get; set; }

        public virtual MandateRelatedData1Choice MndtRltdInf { get; set; }

        public virtual RemittanceInformation16 RmtInf { get; set; }

        public virtual Party40Choice UltmtDbtr { get; set; }

        public virtual Party40Choice Dbtr { get; set; }

        public virtual CashAccount38 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount38 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount38 CdtrAgtAcct { get; set; }

        public virtual Party40Choice Cdtr { get; set; }

        public virtual CashAccount38 CdtrAcct { get; set; }

        public virtual Party40Choice UltmtCdtr { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalTransactionReference32
    {
        public virtual ActiveOrHistoricCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        public virtual AmountType4Choice Amt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdColltnDtSpecified { get; set; }

        public virtual DateAndDateTime2Choice ReqdExctnDt { get; set; }

        public virtual PartyIdentification135 CdtrSchmeId { get; set; }

        public virtual SettlementInstruction7 SttlmInf { get; set; }

        public virtual PaymentTypeInformation27 PmtTpInf { get; set; }

        public virtual PaymentMethod4Code PmtMtd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PmtMtdSpecified { get; set; }

        public virtual MandateRelatedData1Choice MndtRltdInf { get; set; }

        public virtual RemittanceInformation16 RmtInf { get; set; }

        public virtual Party40Choice UltmtDbtr { get; set; }

        public virtual Party40Choice Dbtr { get; set; }

        public virtual CashAccount38 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount38 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount38 CdtrAgtAcct { get; set; }

        public virtual Party40Choice Cdtr { get; set; }

        public virtual CashAccount38 CdtrAcct { get; set; }

        public virtual Party40Choice UltmtCdtr { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        public virtual CreditTransferTransaction45 UndrlygCstmrCdtTrf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalTransactionReference35
    {
        public virtual ActiveOrHistoricCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        public virtual AmountType4Choice Amt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdColltnDtSpecified { get; set; }

        public virtual DateAndDateTime2Choice ReqdExctnDt { get; set; }

        public virtual PartyIdentification135 CdtrSchmeId { get; set; }

        public virtual SettlementInstruction11 SttlmInf { get; set; }

        public virtual PaymentTypeInformation27 PmtTpInf { get; set; }

        public virtual PaymentMethod4Code PmtMtd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PmtMtdSpecified { get; set; }

        public virtual MandateRelatedData2Choice MndtRltdInf { get; set; }

        public virtual RemittanceInformation21 RmtInf { get; set; }

        public virtual Party40Choice UltmtDbtr { get; set; }

        public virtual Party40Choice Dbtr { get; set; }

        public virtual CashAccount40 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount40 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount40 CdtrAgtAcct { get; set; }

        public virtual Party40Choice Cdtr { get; set; }

        public virtual CashAccount40 CdtrAcct { get; set; }

        public virtual Party40Choice UltmtCdtr { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OriginalTransactionReference36
    {
        public virtual ActiveOrHistoricCurrencyAndAmount IntrBkSttlmAmt { get; set; }

        public virtual AmountType4Choice Amt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime ReqdColltnDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ReqdColltnDtSpecified { get; set; }

        public virtual DateAndDateTime2Choice ReqdExctnDt { get; set; }

        public virtual PartyIdentification135 CdtrSchmeId { get; set; }

        public virtual SettlementInstruction11 SttlmInf { get; set; }

        public virtual PaymentTypeInformation27 PmtTpInf { get; set; }

        public virtual PaymentMethod4Code PmtMtd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean PmtMtdSpecified { get; set; }

        public virtual MandateRelatedData2Choice MndtRltdInf { get; set; }

        public virtual RemittanceInformation21 RmtInf { get; set; }

        public virtual Party40Choice UltmtDbtr { get; set; }

        public virtual Party40Choice Dbtr { get; set; }

        public virtual CashAccount40 DbtrAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount40 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount40 CdtrAgtAcct { get; set; }

        public virtual Party40Choice Cdtr { get; set; }

        public virtual CashAccount40 CdtrAcct { get; set; }

        public virtual Party40Choice UltmtCdtr { get; set; }

        public virtual Purpose2Choice Purp { get; set; }

        public virtual CreditTransferTransaction52 UndrlygCstmrCdtTrf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class OtherContact1
    {
        public virtual String ChanlTp { get; set; }

        public virtual String Id { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Party11Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("OrgId", typeof(OrganisationIdentification8))]
        [System.Xml.Serialization.XmlElementAttribute("PrvtId", typeof(PersonIdentification5))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Party2Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("OrgId", typeof(OrganisationIdentification2))]
        [System.Xml.Serialization.XmlElementAttribute("PrvtId", typeof(PersonIdentification3))]
        public virtual Object[] Items { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Party34Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("OrgId", typeof(OrganisationIdentification8))]
        [System.Xml.Serialization.XmlElementAttribute("PrvtId", typeof(PersonIdentification13))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Party35Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Pty", typeof(PartyIdentification125))]
        [System.Xml.Serialization.XmlElementAttribute("Agt", typeof(BranchAndFinancialInstitutionIdentification5))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Party38Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("PrvtId", typeof(PersonIdentification13))]
        [System.Xml.Serialization.XmlElementAttribute("OrgId", typeof(OrganisationIdentification29))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Party40Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Pty", typeof(PartyIdentification135))]
        [System.Xml.Serialization.XmlElementAttribute("Agt", typeof(BranchAndFinancialInstitutionIdentification6))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Party6Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("PrvtId", typeof(PersonIdentification5))]
        [System.Xml.Serialization.XmlElementAttribute("OrgId", typeof(OrganisationIdentification4))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PartyIdentification125
    {
        public virtual String Nm { get; set; }

        public virtual PostalAddress6 PstlAdr { get; set; }

        public virtual Party34Choice Id { get; set; }

        public virtual String CtryOfRes { get; set; }

        public virtual ContactDetails2 CtctDtls { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PartyIdentification135
    {
        public virtual String Nm { get; set; }

        public virtual PostalAddress24 PstlAdr { get; set; }

        public virtual Party38Choice Id { get; set; }

        public virtual String CtryOfRes { get; set; }

        public virtual Contact4 CtctDtls { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PartyIdentification32
    {
        public virtual String Nm { get; set; }

        public virtual PostalAddress6 PstlAdr { get; set; }

        public virtual Party6Choice Id { get; set; }

        public virtual String CtryOfRes { get; set; }

        public virtual ContactDetails2 CtctDtls { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PartyIdentification43
    {
        public virtual String Nm { get; set; }

        public virtual PostalAddress6 PstlAdr { get; set; }

        public virtual Party11Choice Id { get; set; }

        public virtual String CtryOfRes { get; set; }

        public virtual ContactDetails2 CtctDtls { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PartyIdentification8
    {
        public virtual String Nm { get; set; }

        public virtual PostalAddress1 PstlAdr { get; set; }

        public virtual Party2Choice Id { get; set; }

        public virtual String CtryOfRes { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentIdentification13
    {
        public virtual String InstrId { get; set; }

        public virtual String EndToEndId { get; set; }

        public virtual String TxId { get; set; }

        public virtual String UETR { get; set; }

        public virtual String ClrSysRef { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentIdentification2
    {
        public virtual String InstrId { get; set; }

        public virtual String EndToEndId { get; set; }

        public virtual String TxId { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentIdentification3
    {
        public virtual String InstrId { get; set; }

        public virtual String EndToEndId { get; set; }

        public virtual String TxId { get; set; }

        public virtual String ClrSysRef { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentIdentification7
    {
        public virtual String InstrId { get; set; }

        public virtual String EndToEndId { get; set; }

        public virtual String TxId { get; set; }

        public virtual String UETR { get; set; }

        public virtual String ClrSysRef { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentReturnReason1
    {
        public virtual PartyIdentification43 Orgtr { get; set; }

        public virtual ReturnReason5Choice Rsn { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlInf")]
        public virtual String[] AddtlInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentReturnReason4
    {
        public virtual PartyIdentification125 Orgtr { get; set; }

        public virtual ReturnReason5Choice Rsn { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlInf")]
        public virtual String[] AddtlInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentReturnReason6
    {
        public virtual PartyIdentification135 Orgtr { get; set; }

        public virtual ReturnReason5Choice Rsn { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlInf")]
        public virtual String[] AddtlInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentReversalReason7
    {
        public virtual PartyIdentification43 Orgtr { get; set; }

        public virtual ReversalReason4Choice Rsn { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlInf")]
        public virtual String[] AddtlInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentReversalReason8
    {
        public virtual PartyIdentification125 Orgtr { get; set; }

        public virtual ReversalReason4Choice Rsn { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlInf")]
        public virtual String[] AddtlInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentReversalReason9
    {
        public virtual PartyIdentification135 Orgtr { get; set; }

        public virtual ReversalReason4Choice Rsn { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlInf")]
        public virtual String[] AddtlInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction110
    {
        public virtual String StsId { get; set; }

        public virtual OriginalGroupInformation29 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlUETR { get; set; }

        public virtual String TxSts { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("StsRsnInf")]
        public virtual StatusReasonInformation12[] StsRsnInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges7[] ChrgsInf { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        public virtual DateAndDateTime2Choice FctvIntrBkSttlmDt { get; set; }

        public virtual String AcctSvcrRef { get; set; }

        public virtual String ClrSysRef { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual OriginalTransactionReference28 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction111
    {
        public virtual String RvslId { get; set; }

        public virtual OriginalGroupInformation29 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlUETR { get; set; }

        public virtual String OrgnlClrSysRef { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        public virtual ActiveCurrencyAndAmount RvsdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RvsdInstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CompstnAmt { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ChrgBrSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges7[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RvslRsnInf")]
        public virtual PaymentReversalReason9[] RvslRsnInf { get; set; }

        public virtual OriginalTransactionReference28 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction112
    {
        public virtual String RtrId { get; set; }

        public virtual OriginalGroupInformation29 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlUETR { get; set; }

        public virtual String OrgnlClrSysRef { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime OrgnlIntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlIntrBkSttlmDtSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount RtrdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RtrdInstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CompstnAmt { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ChrgBrSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges7[] ChrgsInf { get; set; }

        public virtual String ClrSysRef { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual TransactionParties7 RtrChain { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RtrRsnInf")]
        public virtual PaymentReturnReason6[] RtrRsnInf { get; set; }

        public virtual OriginalTransactionReference28 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction113
    {
        public virtual String StsReqId { get; set; }

        public virtual OriginalGroupInformation29 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlUETR { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        public virtual String ClrSysRef { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual OriginalTransactionReference28 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction118
    {
        public virtual String RtrId { get; set; }

        public virtual OriginalGroupInformation29 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlUETR { get; set; }

        public virtual String OrgnlClrSysRef { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime OrgnlIntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlIntrBkSttlmDtSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount RtrdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RtrdInstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CompstnAmt { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ChrgBrSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges7[] ChrgsInf { get; set; }

        public virtual String ClrSysRef { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual TransactionParties8 RtrChain { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RtrRsnInf")]
        public virtual PaymentReturnReason6[] RtrRsnInf { get; set; }

        public virtual OriginalTransactionReference32 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction119
    {
        public virtual String RvslId { get; set; }

        public virtual OriginalGroupInformation29 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlUETR { get; set; }

        public virtual String OrgnlClrSysRef { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        public virtual ActiveCurrencyAndAmount RvsdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RvsdInstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CompstnAmt { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ChrgBrSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges7[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RvslRsnInf")]
        public virtual PaymentReversalReason9[] RvslRsnInf { get; set; }

        public virtual OriginalTransactionReference31 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction121
    {
        public virtual String StsReqId { get; set; }

        public virtual OriginalGroupInformation29 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlUETR { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        public virtual String ClrSysRef { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual OriginalTransactionReference31 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction123
    {
        public virtual String StsId { get; set; }

        public virtual OriginalGroupInformation29 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlUETR { get; set; }

        public virtual String TxSts { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("StsRsnInf")]
        public virtual StatusReasonInformation12[] StsRsnInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges7[] ChrgsInf { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        public virtual DateAndDateTime2Choice FctvIntrBkSttlmDt { get; set; }

        public virtual String AcctSvcrRef { get; set; }

        public virtual String ClrSysRef { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual OriginalTransactionReference31 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction130
    {
        public virtual String StsId { get; set; }

        public virtual OriginalGroupInformation29 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlUETR { get; set; }

        public virtual String TxSts { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("StsRsnInf")]
        public virtual StatusReasonInformation12[] StsRsnInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges7[] ChrgsInf { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        public virtual DateAndDateTime2Choice FctvIntrBkSttlmDt { get; set; }

        public virtual String AcctSvcrRef { get; set; }

        public virtual String ClrSysRef { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual OriginalTransactionReference35 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction131
    {
        public virtual String StsReqId { get; set; }

        public virtual OriginalGroupInformation29 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlUETR { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        public virtual String ClrSysRef { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual OriginalTransactionReference35 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction133
    {
        public virtual String RtrId { get; set; }

        public virtual OriginalGroupInformation29 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlUETR { get; set; }

        public virtual String OrgnlClrSysRef { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime OrgnlIntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlIntrBkSttlmDtSpecified { get; set; }

        public virtual PaymentTypeInformation28 PmtTpInf { get; set; }

        public virtual ActiveCurrencyAndAmount RtrdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual SettlementTimeRequest2 SttlmTmReq { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RtrdInstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CompstnAmt { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ChrgBrSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges7[] ChrgsInf { get; set; }

        public virtual String ClrSysRef { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        public virtual TransactionParties10 RtrChain { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RtrRsnInf")]
        public virtual PaymentReturnReason6[] RtrRsnInf { get; set; }

        public virtual OriginalTransactionReference36 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction135
    {
        public virtual String RvslId { get; set; }

        public virtual OriginalGroupInformation29 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlUETR { get; set; }

        public virtual String OrgnlClrSysRef { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        public virtual ActiveCurrencyAndAmount RvsdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual SettlementDateTimeIndication1 SttlmTmIndctn { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RvsdInstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CompstnAmt { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ChrgBrSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges7[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RvslRsnInf")]
        public virtual PaymentReversalReason9[] RvslRsnInf { get; set; }

        public virtual OriginalTransactionReference35 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction60
    {
        public virtual String RvslId { get; set; }

        public virtual OriginalGroupInformation3 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlClrSysRef { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        public virtual ActiveCurrencyAndAmount RvsdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RvsdInstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CompstnAmt { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ChrgBrSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges2[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RvslRsnInf")]
        public virtual PaymentReversalReason7[] RvslRsnInf { get; set; }

        public virtual OriginalTransactionReference22 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction63
    {
        public virtual String StsId { get; set; }

        public virtual OriginalGroupInformation3 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual TransactionIndividualStatus3Code TxSts { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean TxStsSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("StsRsnInf")]
        public virtual StatusReasonInformation9[] StsRsnInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges2[] ChrgsInf { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        public virtual String AcctSvcrRef { get; set; }

        public virtual String ClrSysRef { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        public virtual OriginalTransactionReference22 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction65
    {
        public virtual String RtrId { get; set; }

        public virtual OriginalGroupInformation3 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlClrSysRef { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        public virtual ActiveCurrencyAndAmount RtrdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RtrdInstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CompstnAmt { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ChrgBrSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges2[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RtrRsnInf")]
        public virtual PaymentReturnReason1[] RtrRsnInf { get; set; }

        public virtual OriginalTransactionReference22 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction73
    {
        public virtual String StsReqId { get; set; }

        public virtual OriginalGroupInformation3 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        public virtual String ClrSysRef { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        public virtual OriginalTransactionReference24 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction76
    {
        public virtual String RtrId { get; set; }

        public virtual OriginalGroupInformation3 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlClrSysRef { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        public virtual ActiveCurrencyAndAmount RtrdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RtrdInstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CompstnAmt { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ChrgBrSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges2[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RtrRsnInf")]
        public virtual PaymentReturnReason1[] RtrRsnInf { get; set; }

        public virtual OriginalTransactionReference24 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction80
    {
        public virtual String StsId { get; set; }

        public virtual OriginalGroupInformation3 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String TxSts { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("StsRsnInf")]
        public virtual StatusReasonInformation9[] StsRsnInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges2[] ChrgsInf { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        public virtual String AcctSvcrRef { get; set; }

        public virtual String ClrSysRef { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        public virtual OriginalTransactionReference24 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction81
    {
        public virtual String RvslId { get; set; }

        public virtual OriginalGroupInformation3 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlClrSysRef { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        public virtual ActiveCurrencyAndAmount RvsdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RvsdInstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CompstnAmt { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ChrgBrSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges2[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RvslRsnInf")]
        public virtual PaymentReversalReason7[] RvslRsnInf { get; set; }

        public virtual OriginalTransactionReference24 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction87
    {
        public virtual String RtrId { get; set; }

        public virtual OriginalGroupInformation29 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlClrSysRef { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime OrgnlIntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean OrgnlIntrBkSttlmDtSpecified { get; set; }

        public virtual ActiveCurrencyAndAmount RtrdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RtrdInstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CompstnAmt { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ChrgBrSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges2[] ChrgsInf { get; set; }

        public virtual String ClrSysRef { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        public virtual TransactionParties5 RtrChain { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RtrRsnInf")]
        public virtual PaymentReturnReason4[] RtrRsnInf { get; set; }

        public virtual OriginalTransactionReference27 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction88
    {
        public virtual String RvslId { get; set; }

        public virtual OriginalGroupInformation29 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlClrSysRef { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        public virtual ActiveCurrencyAndAmount RvsdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual Priority3Code SttlmPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SttlmPrtySpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RvsdInstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CompstnAmt { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ChrgBrSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges2[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RvslRsnInf")]
        public virtual PaymentReversalReason8[] RvslRsnInf { get; set; }

        public virtual OriginalTransactionReference27 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction91
    {
        public virtual String StsId { get; set; }

        public virtual OriginalGroupInformation29 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String TxSts { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("StsRsnInf")]
        public virtual StatusReasonInformation11[] StsRsnInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual Charges2[] ChrgsInf { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        public virtual String AcctSvcrRef { get; set; }

        public virtual String ClrSysRef { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        public virtual OriginalTransactionReference27 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransaction94
    {
        public virtual String StsReqId { get; set; }

        public virtual OriginalGroupInformation29 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        public virtual String ClrSysRef { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdAgt { get; set; }

        public virtual OriginalTransactionReference27 OrgnlTxRef { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public virtual SupplementaryData1[] SplmtryData { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransactionInformation1
    {
        public virtual String StsId { get; set; }

        public virtual String OrgnlPmtInfId { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual TransactionIndividualStatus1Code TxSts { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean TxStsSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("StsRsnInf")]
        public virtual StatusReasonInformation1[] StsRsnInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual ChargesInformation1[] ChrgsInf { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstdAgt { get; set; }

        public virtual OriginalTransactionReference1 OrgnlTxRef { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransactionInformation2
    {
        public virtual String RtrId { get; set; }

        public virtual OriginalGroupInformation3 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual CurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        public virtual CurrencyAndAmount RtrdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual CurrencyAndAmount RtrdInstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual CurrencyAndAmount CompstnAmt { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ChrgBrSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual ChargesInformation1[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstdAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RtrRsnInf")]
        public virtual ReturnReasonInformation1[] RtrRsnInf { get; set; }

        public virtual OriginalTransactionReference1 OrgnlTxRef { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransactionInformation26
    {
        public virtual String StsId { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual TransactionIndividualStatus3Code TxSts { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean TxStsSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("StsRsnInf")]
        public virtual StatusReasonInformation8[] StsRsnInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual ChargesInformation5[] ChrgsInf { get; set; }

        public virtual DateTime AccptncDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AccptncDtTmSpecified { get; set; }

        public virtual String AcctSvcrRef { get; set; }

        public virtual String ClrSysRef { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstdAgt { get; set; }

        public virtual OriginalTransactionReference13 OrgnlTxRef { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransactionInformation27
    {
        public virtual String RtrId { get; set; }

        public virtual OriginalGroupInformation3 OrgnlGrpInf { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlClrSysRef { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        public virtual ActiveCurrencyAndAmount RtrdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RtrdInstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CompstnAmt { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ChrgBrSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual ChargesInformation5[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstdAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RtrRsnInf")]
        public virtual ReturnReasonInformation9[] RtrRsnInf { get; set; }

        public virtual OriginalTransactionReference13 OrgnlTxRef { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransactionInformation29
    {
        public virtual String RvslId { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual String OrgnlClrSysRef { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        public virtual ActiveCurrencyAndAmount RvsdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RvsdInstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CompstnAmt { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ChrgBrSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual ChargesInformation5[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstdAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RvslRsnInf")]
        public virtual ReversalReasonInformation6[] RvslRsnInf { get; set; }

        public virtual OriginalTransactionReference13 OrgnlTxRef { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransactionInformation3
    {
        public virtual String CxlId { get; set; }

        public virtual String OrgnlPmtInfId { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual CurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        public virtual CurrencyAndAmount OrgnlInstdAmt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstdAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("CxlRsnInf")]
        public virtual CancellationReasonInformation1[] CxlRsnInf { get; set; }

        public virtual OriginalTransactionReference1 OrgnlTxRef { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTransactionInformation5
    {
        public virtual String RvslId { get; set; }

        public virtual String OrgnlPmtInfId { get; set; }

        public virtual String OrgnlInstrId { get; set; }

        public virtual String OrgnlEndToEndId { get; set; }

        public virtual String OrgnlTxId { get; set; }

        public virtual CurrencyAndAmount OrgnlIntrBkSttlmAmt { get; set; }

        public virtual CurrencyAndAmount RvsdIntrBkSttlmAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime IntrBkSttlmDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean IntrBkSttlmDtSpecified { get; set; }

        public virtual CurrencyAndAmount RvsdInstdAmt { get; set; }

        public virtual Decimal XchgRate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean XchgRateSpecified { get; set; }

        public virtual CurrencyAndAmount CompstnAmt { get; set; }

        public virtual ChargeBearerType1Code ChrgBr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ChrgBrSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChrgsInf")]
        public virtual ChargesInformation1[] ChrgsInf { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstgAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstdAgt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RvslRsnInf")]
        public virtual ReversalReasonInformation1[] RvslRsnInf { get; set; }

        public virtual OriginalTransactionReference1 OrgnlTxRef { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTypeInformation21
    {
        public virtual Priority2Code InstrPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean InstrPrtySpecified { get; set; }

        public virtual ClearingChannel2Code ClrChanl { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ClrChanlSpecified { get; set; }

        public virtual ServiceLevel8Choice SvcLvl { get; set; }

        public virtual LocalInstrument2Choice LclInstrm { get; set; }

        public virtual CategoryPurpose1Choice CtgyPurp { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTypeInformation22
    {
        public virtual Priority2Code InstrPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean InstrPrtySpecified { get; set; }

        public virtual ClearingChannel2Code ClrChanl { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ClrChanlSpecified { get; set; }

        public virtual ServiceLevel8Choice SvcLvl { get; set; }

        public virtual LocalInstrument2Choice LclInstrm { get; set; }

        public virtual SequenceType1Code SeqTp { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SeqTpSpecified { get; set; }

        public virtual CategoryPurpose1Choice CtgyPurp { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTypeInformation23
    {
        public virtual Priority2Code InstrPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean InstrPrtySpecified { get; set; }

        public virtual ClearingChannel2Code ClrChanl { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ClrChanlSpecified { get; set; }

        public virtual ServiceLevel8Choice SvcLvl { get; set; }

        public virtual LocalInstrument2Choice LclInstrm { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTypeInformation25
    {
        public virtual Priority2Code InstrPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean InstrPrtySpecified { get; set; }

        public virtual ClearingChannel2Code ClrChanl { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ClrChanlSpecified { get; set; }

        public virtual ServiceLevel8Choice SvcLvl { get; set; }

        public virtual LocalInstrument2Choice LclInstrm { get; set; }

        public virtual SequenceType3Code SeqTp { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SeqTpSpecified { get; set; }

        public virtual CategoryPurpose1Choice CtgyPurp { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTypeInformation27
    {
        public virtual Priority2Code InstrPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean InstrPrtySpecified { get; set; }

        public virtual ClearingChannel2Code ClrChanl { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ClrChanlSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SvcLvl")]
        public virtual ServiceLevel8Choice[] SvcLvl { get; set; }

        public virtual LocalInstrument2Choice LclInstrm { get; set; }

        public virtual SequenceType3Code SeqTp { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SeqTpSpecified { get; set; }

        public virtual CategoryPurpose1Choice CtgyPurp { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTypeInformation28
    {
        public virtual Priority2Code InstrPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean InstrPrtySpecified { get; set; }

        public virtual ClearingChannel2Code ClrChanl { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean ClrChanlSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SvcLvl")]
        public virtual ServiceLevel8Choice[] SvcLvl { get; set; }

        public virtual LocalInstrument2Choice LclInstrm { get; set; }

        public virtual CategoryPurpose1Choice CtgyPurp { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTypeInformation3
    {
        public virtual Priority2Code InstrPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean InstrPrtySpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ClrChanl", typeof(ClearingChannel2Code))]
        [System.Xml.Serialization.XmlElementAttribute("SvcLvl", typeof(ServiceLevel2Choice))]
        public virtual Object Item { get; set; }

        public virtual LocalInstrument1Choice LclInstrm { get; set; }

        public virtual PaymentCategoryPurpose1Code CtgyPurp { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtgyPurpSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTypeInformation4
    {
        public virtual Priority2Code InstrPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean InstrPrtySpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SvcLvl", typeof(ServiceLevel3Choice))]
        [System.Xml.Serialization.XmlElementAttribute("ClrChanl", typeof(ClearingChannel2Code))]
        public virtual Object Item { get; set; }

        public virtual LocalInstrument1Choice LclInstrm { get; set; }

        public virtual SequenceType1Code SeqTp { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SeqTpSpecified { get; set; }

        public virtual PaymentCategoryPurpose1Code CtgyPurp { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtgyPurpSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTypeInformation5
    {
        public virtual Priority2Code InstrPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean InstrPrtySpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("SvcLvl", typeof(RestrictedProprietaryChoice))]
        [System.Xml.Serialization.XmlElementAttribute("ClrChanl", typeof(ClearingChannel2Code))]
        public virtual Object Item { get; set; }

        public virtual RestrictedProprietaryChoice LclInstrm { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PaymentTypeInformation6
    {
        public virtual Priority2Code InstrPrty { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean InstrPrtySpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ClrChanl", typeof(ClearingChannel2Code))]
        [System.Xml.Serialization.XmlElementAttribute("SvcLvl", typeof(ServiceLevel2Choice))]
        public virtual Object Item { get; set; }

        public virtual LocalInstrument1Choice LclInstrm { get; set; }

        public virtual SequenceType1Code SeqTp { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SeqTpSpecified { get; set; }

        public virtual PaymentCategoryPurpose1Code CtgyPurp { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CtgyPurpSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PersonIdentification13
    {
        public virtual DateAndPlaceOfBirth1 DtAndPlcOfBirth { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Othr")]
        public virtual GenericPersonIdentification1[] Othr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PersonIdentification3
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("MplyrIdNb", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("DrvrsLicNb", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("DtAndPlcOfBirth", typeof(DateAndPlaceOfBirth))]
        [System.Xml.Serialization.XmlElementAttribute("IdntyCardNb", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("AlnRegnNb", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("OthrId", typeof(GenericIdentification4))]
        [System.Xml.Serialization.XmlElementAttribute("PsptNb", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("CstmrNb", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("TaxIdNb", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("SclSctyNb", typeof(String))]
        public virtual Object Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType7 ItemElementName { get; set; }

        public virtual String Issr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PersonIdentification5
    {
        public virtual DateAndPlaceOfBirth DtAndPlcOfBirth { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Othr")]
        public virtual GenericPersonIdentification1[] Othr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PersonIdentificationSchemeName1Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PostalAddress1
    {
        public virtual AddressType2Code AdrTp { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AdrTpSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AdrLine")]
        public virtual String[] AdrLine { get; set; }

        public virtual String StrtNm { get; set; }

        public virtual String BldgNb { get; set; }

        public virtual String PstCd { get; set; }

        public virtual String TwnNm { get; set; }

        public virtual String CtrySubDvsn { get; set; }

        public virtual String Ctry { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PostalAddress24
    {
        public virtual AddressType3Choice AdrTp { get; set; }

        public virtual String Dept { get; set; }

        public virtual String SubDept { get; set; }

        public virtual String StrtNm { get; set; }

        public virtual String BldgNb { get; set; }

        public virtual String BldgNm { get; set; }

        public virtual String Flr { get; set; }

        public virtual String PstBx { get; set; }

        public virtual String Room { get; set; }

        public virtual String PstCd { get; set; }

        public virtual String TwnNm { get; set; }

        public virtual String TwnLctnNm { get; set; }

        public virtual String DstrctNm { get; set; }

        public virtual String CtrySubDvsn { get; set; }

        public virtual String Ctry { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AdrLine")]
        public virtual String[] AdrLine { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class PostalAddress6
    {
        public virtual AddressType2Code AdrTp { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean AdrTpSpecified { get; set; }

        public virtual String Dept { get; set; }

        public virtual String SubDept { get; set; }

        public virtual String StrtNm { get; set; }

        public virtual String BldgNb { get; set; }

        public virtual String PstCd { get; set; }

        public virtual String TwnNm { get; set; }

        public virtual String CtrySubDvsn { get; set; }

        public virtual String Ctry { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AdrLine")]
        public virtual String[] AdrLine { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ProxyAccountIdentification1
    {
        public virtual ProxyAccountType1Choice Tp { get; set; }

        public virtual String Id { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ProxyAccountType1Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Purpose1Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class Purpose2Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReferredDocumentAmount1Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("TaxAmt", typeof(CurrencyAndAmount))]
        [System.Xml.Serialization.XmlElementAttribute("DscntApldAmt", typeof(CurrencyAndAmount))]
        [System.Xml.Serialization.XmlElementAttribute("DuePyblAmt", typeof(CurrencyAndAmount))]
        [System.Xml.Serialization.XmlElementAttribute("RmtdAmt", typeof(CurrencyAndAmount))]
        [System.Xml.Serialization.XmlElementAttribute("CdtNoteAmt", typeof(CurrencyAndAmount))]
        public virtual CurrencyAndAmount Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType1 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReferredDocumentInformation1
    {
        public virtual ReferredDocumentType1 RfrdDocTp { get; set; }

        public virtual String RfrdDocNb { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReferredDocumentInformation3
    {
        public virtual ReferredDocumentType2 Tp { get; set; }

        public virtual String Nb { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime RltdDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean RltdDtSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReferredDocumentInformation6
    {
        public virtual ReferredDocumentType4 Tp { get; set; }

        public virtual String Nb { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime RltdDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean RltdDtSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReferredDocumentInformation7
    {
        public virtual ReferredDocumentType4 Tp { get; set; }

        public virtual String Nb { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime RltdDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean RltdDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("LineDtls")]
        public virtual DocumentLineInformation1[] LineDtls { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReferredDocumentType1
    {
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(DocumentType2Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual Object Item { get; set; }

        public virtual String Issr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReferredDocumentType1Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(DocumentType5Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReferredDocumentType2
    {
        public virtual ReferredDocumentType1Choice CdOrPrtry { get; set; }

        public virtual String Issr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReferredDocumentType3Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(DocumentType6Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReferredDocumentType4
    {
        public virtual ReferredDocumentType3Choice CdOrPrtry { get; set; }

        public virtual String Issr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RegulatoryAuthority
    {
        public virtual String AuthrtyNm { get; set; }

        public virtual String AuthrtyCtry { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RegulatoryAuthority2
    {
        public virtual String Nm { get; set; }

        public virtual String Ctry { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RegulatoryReporting2
    {
        public virtual RegulatoryReportingType1Code DbtCdtRptgInd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DbtCdtRptgIndSpecified { get; set; }

        public virtual RegulatoryAuthority Authrty { get; set; }

        public virtual StructuredRegulatoryReporting2 RgltryDtls { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RegulatoryReporting3
    {
        public virtual RegulatoryReportingType1Code DbtCdtRptgInd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DbtCdtRptgIndSpecified { get; set; }

        public virtual RegulatoryAuthority2 Authrty { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Dtls")]
        public virtual StructuredRegulatoryReporting3[] Dtls { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RemittanceAmount1
    {
        public virtual ActiveOrHistoricCurrencyAndAmount DuePyblAmt { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount DscntApldAmt { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CdtNoteAmt { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TaxAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AdjstmntAmtAndRsn")]
        public virtual DocumentAdjustment1[] AdjstmntAmtAndRsn { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RmtdAmt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RemittanceAmount2
    {
        public virtual ActiveOrHistoricCurrencyAndAmount DuePyblAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("DscntApldAmt")]
        public virtual DiscountAmountAndType1[] DscntApldAmt { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CdtNoteAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("TaxAmt")]
        public virtual TaxAmountAndType1[] TaxAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AdjstmntAmtAndRsn")]
        public virtual DocumentAdjustment1[] AdjstmntAmtAndRsn { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RmtdAmt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RemittanceAmount3
    {
        public virtual ActiveOrHistoricCurrencyAndAmount DuePyblAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("DscntApldAmt")]
        public virtual DiscountAmountAndType1[] DscntApldAmt { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount CdtNoteAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("TaxAmt")]
        public virtual TaxAmountAndType1[] TaxAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AdjstmntAmtAndRsn")]
        public virtual DocumentAdjustment1[] AdjstmntAmtAndRsn { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount RmtdAmt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RemittanceInformation1
    {
        [System.Xml.Serialization.XmlElementAttribute("Ustrd")]
        public virtual String[] Ustrd { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Strd")]
        public virtual StructuredRemittanceInformation6[] Strd { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RemittanceInformation10
    {
        [System.Xml.Serialization.XmlElementAttribute("Ustrd")]
        public virtual String[] Ustrd { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Strd")]
        public virtual StructuredRemittanceInformation12[] Strd { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RemittanceInformation11
    {
        [System.Xml.Serialization.XmlElementAttribute("Ustrd")]
        public virtual String[] Ustrd { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Strd")]
        public virtual StructuredRemittanceInformation13[] Strd { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RemittanceInformation15
    {
        [System.Xml.Serialization.XmlElementAttribute("Ustrd")]
        public virtual String[] Ustrd { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Strd")]
        public virtual StructuredRemittanceInformation15[] Strd { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RemittanceInformation16
    {
        [System.Xml.Serialization.XmlElementAttribute("Ustrd")]
        public virtual String[] Ustrd { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Strd")]
        public virtual StructuredRemittanceInformation16[] Strd { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RemittanceInformation21
    {
        [System.Xml.Serialization.XmlElementAttribute("Ustrd")]
        public virtual String[] Ustrd { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Strd")]
        public virtual StructuredRemittanceInformation17[] Strd { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RemittanceInformation5
    {
        [System.Xml.Serialization.XmlElementAttribute("Ustrd")]
        public virtual String[] Ustrd { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Strd")]
        public virtual StructuredRemittanceInformation7[] Strd { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RemittanceLocation1
    {
        public virtual String RmtId { get; set; }

        public virtual RemittanceLocationMethod1Code RmtLctnMtd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean RmtLctnMtdSpecified { get; set; }

        public virtual String RmtLctnElctrncAdr { get; set; }

        public virtual NameAndAddress3 RmtLctnPstlAdr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RemittanceLocation2
    {
        public virtual String RmtId { get; set; }

        public virtual RemittanceLocationMethod2Code RmtLctnMtd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean RmtLctnMtdSpecified { get; set; }

        public virtual String RmtLctnElctrncAdr { get; set; }

        public virtual NameAndAddress10 RmtLctnPstlAdr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RemittanceLocation4
    {
        public virtual String RmtId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RmtLctnDtls")]
        public virtual RemittanceLocationDetails1[] RmtLctnDtls { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RemittanceLocation7
    {
        public virtual String RmtId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RmtLctnDtls")]
        public virtual RemittanceLocationData1[] RmtLctnDtls { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RemittanceLocationData1
    {
        public virtual RemittanceLocationMethod2Code Mtd { get; set; }

        public virtual String ElctrncAdr { get; set; }

        public virtual NameAndAddress16 PstlAdr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RemittanceLocationDetails1
    {
        public virtual RemittanceLocationMethod2Code Mtd { get; set; }

        public virtual String ElctrncAdr { get; set; }

        public virtual NameAndAddress10 PstlAdr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class RestrictedProprietaryChoice
    {
        [System.Xml.Serialization.XmlElementAttribute("Prtry")]
        public virtual String Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReturnReason1Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(TransactionRejectReason2Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReturnReason5Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReturnReasonInformation1
    {
        public virtual PartyIdentification8 RtrOrgtr { get; set; }

        public virtual ReturnReason1Choice RtrRsn { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlRtrRsnInf")]
        public virtual String[] AddtlRtrRsnInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReturnReasonInformation9
    {
        public virtual PartyIdentification32 Orgtr { get; set; }

        public virtual ReturnReason5Choice Rsn { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlInf")]
        public virtual String[] AddtlInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReversalReason1Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(TransactionReversalReason1Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReversalReason4Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReversalReasonInformation1
    {
        public virtual PartyIdentification8 RvslOrgtr { get; set; }

        public virtual ReversalReason1Choice RvslRsn { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlRvslRsnInf")]
        public virtual String[] AddtlRvslRsnInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ReversalReasonInformation6
    {
        public virtual PartyIdentification32 Orgtr { get; set; }

        public virtual ReversalReason4Choice Rsn { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlInf")]
        public virtual String[] AddtlInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ServiceLevel2Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(ServiceLevel1Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ServiceLevel3Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(ServiceLevel2Code))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class ServiceLevel8Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SettlementDateTimeIndication1
    {
        public virtual DateTime DbtDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DbtDtTmSpecified { get; set; }

        public virtual DateTime CdtDtTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CdtDtTmSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SettlementInformation1
    {
        public virtual SettlementMethod1Code SttlmMtd { get; set; }

        public virtual CashAccount7 SttlmAcct { get; set; }

        public virtual ClearingSystemIdentification1Choice ClrSys { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstgRmbrsmntAgt { get; set; }

        public virtual CashAccount7 InstgRmbrsmntAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstdRmbrsmntAgt { get; set; }

        public virtual CashAccount7 InstdRmbrsmntAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 ThrdRmbrsmntAgt { get; set; }

        public virtual CashAccount7 ThrdRmbrsmntAgtAcct { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SettlementInformation13
    {
        public virtual SettlementMethod1Code SttlmMtd { get; set; }

        public virtual CashAccount16 SttlmAcct { get; set; }

        public virtual ClearingSystemIdentification3Choice ClrSys { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstgRmbrsmntAgt { get; set; }

        public virtual CashAccount16 InstgRmbrsmntAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 InstdRmbrsmntAgt { get; set; }

        public virtual CashAccount16 InstdRmbrsmntAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification4 ThrdRmbrsmntAgt { get; set; }

        public virtual CashAccount16 ThrdRmbrsmntAgtAcct { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SettlementInformation14
    {
        public virtual SettlementMethod2Code SttlmMtd { get; set; }

        public virtual CashAccount16 SttlmAcct { get; set; }

        public virtual ClearingSystemIdentification3Choice ClrSys { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SettlementInformation2
    {
        public virtual SettlementMethod2Code SttlmMtd { get; set; }

        public virtual CashAccount7 SttlmAcct { get; set; }

        public virtual ClearingSystemIdentification1Choice ClrSys { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SettlementInformation3
    {
        public virtual SettlementMethod1Code SttlmMtd { get; set; }

        public virtual CashAccount7 SttlmAcct { get; set; }

        public virtual ClearingSystemIdentification1Choice ClrSys { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstgRmbrsmntAgt { get; set; }

        public virtual CashAccount7 InstgRmbrsmntAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 InstdRmbrsmntAgt { get; set; }

        public virtual CashAccount7 InstdRmbrsmntAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification3 ThrdRmbrsmntAgt { get; set; }

        public virtual CashAccount7 ThrdRmbrsmntAgtAcct { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SettlementInstruction1
    {
        public virtual SettlementMethod1Code SttlmMtd { get; set; }

        public virtual CashAccount24 SttlmAcct { get; set; }

        public virtual ClearingSystemIdentification3Choice ClrSys { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgRmbrsmntAgt { get; set; }

        public virtual CashAccount24 InstgRmbrsmntAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdRmbrsmntAgt { get; set; }

        public virtual CashAccount24 InstdRmbrsmntAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 ThrdRmbrsmntAgt { get; set; }

        public virtual CashAccount24 ThrdRmbrsmntAgtAcct { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SettlementInstruction11
    {
        public virtual SettlementMethod1Code SttlmMtd { get; set; }

        public virtual CashAccount40 SttlmAcct { get; set; }

        public virtual ClearingSystemIdentification3Choice ClrSys { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgRmbrsmntAgt { get; set; }

        public virtual CashAccount40 InstgRmbrsmntAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdRmbrsmntAgt { get; set; }

        public virtual CashAccount40 InstdRmbrsmntAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 ThrdRmbrsmntAgt { get; set; }

        public virtual CashAccount40 ThrdRmbrsmntAgtAcct { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SettlementInstruction14
    {
        public virtual SettlementMethod2Code SttlmMtd { get; set; }

        public virtual CashAccount40 SttlmAcct { get; set; }

        public virtual ClearingSystemIdentification3Choice ClrSys { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SettlementInstruction2
    {
        public virtual SettlementMethod2Code SttlmMtd { get; set; }

        public virtual CashAccount24 SttlmAcct { get; set; }

        public virtual ClearingSystemIdentification3Choice ClrSys { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SettlementInstruction4
    {
        public virtual SettlementMethod1Code SttlmMtd { get; set; }

        public virtual CashAccount24 SttlmAcct { get; set; }

        public virtual ClearingSystemIdentification3Choice ClrSys { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstgRmbrsmntAgt { get; set; }

        public virtual CashAccount24 InstgRmbrsmntAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 InstdRmbrsmntAgt { get; set; }

        public virtual CashAccount24 InstdRmbrsmntAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 ThrdRmbrsmntAgt { get; set; }

        public virtual CashAccount24 ThrdRmbrsmntAgtAcct { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SettlementInstruction7
    {
        public virtual SettlementMethod1Code SttlmMtd { get; set; }

        public virtual CashAccount38 SttlmAcct { get; set; }

        public virtual ClearingSystemIdentification3Choice ClrSys { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstgRmbrsmntAgt { get; set; }

        public virtual CashAccount38 InstgRmbrsmntAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 InstdRmbrsmntAgt { get; set; }

        public virtual CashAccount38 InstdRmbrsmntAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 ThrdRmbrsmntAgt { get; set; }

        public virtual CashAccount38 ThrdRmbrsmntAgtAcct { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SettlementInstruction8
    {
        public virtual SettlementMethod2Code SttlmMtd { get; set; }

        public virtual CashAccount38 SttlmAcct { get; set; }

        public virtual ClearingSystemIdentification3Choice ClrSys { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SettlementTimeRequest1
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public virtual DateTime CLSTm { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SettlementTimeRequest2
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public virtual DateTime CLSTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean CLSTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public virtual DateTime TillTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean TillTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public virtual DateTime FrTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean FrTmSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public virtual DateTime RjctTm { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean RjctTmSpecified { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SimpleIdentificationInformation2
    {
        public virtual String Id { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class StatusReason1Choice
    {
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(TransactionRejectReason2Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual Object Item { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class StatusReason6Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class StatusReasonInformation1
    {
        public virtual PartyIdentification8 StsOrgtr { get; set; }

        public virtual StatusReason1Choice StsRsn { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlStsRsnInf")]
        public virtual String[] AddtlStsRsnInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class StatusReasonInformation11
    {
        public virtual PartyIdentification125 Orgtr { get; set; }

        public virtual StatusReason6Choice Rsn { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlInf")]
        public virtual String[] AddtlInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class StatusReasonInformation12
    {
        public virtual PartyIdentification135 Orgtr { get; set; }

        public virtual StatusReason6Choice Rsn { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlInf")]
        public virtual String[] AddtlInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class StatusReasonInformation8
    {
        public virtual PartyIdentification32 Orgtr { get; set; }

        public virtual StatusReason6Choice Rsn { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlInf")]
        public virtual String[] AddtlInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class StatusReasonInformation9
    {
        public virtual PartyIdentification43 Orgtr { get; set; }

        public virtual StatusReason6Choice Rsn { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlInf")]
        public virtual String[] AddtlInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class StructuredRegulatoryReporting2
    {
        public virtual String Cd { get; set; }

        public virtual CurrencyAndAmount Amt { get; set; }

        public virtual String Inf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class StructuredRegulatoryReporting3
    {
        public virtual String Tp { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime Dt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtSpecified { get; set; }

        public virtual String Ctry { get; set; }

        public virtual String Cd { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Inf")]
        public virtual String[] Inf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class StructuredRemittanceInformation12
    {
        [System.Xml.Serialization.XmlElementAttribute("RfrdDocInf")]
        public virtual ReferredDocumentInformation6[] RfrdDocInf { get; set; }

        public virtual RemittanceAmount2 RfrdDocAmt { get; set; }

        public virtual CreditorReferenceInformation2 CdtrRefInf { get; set; }

        public virtual PartyIdentification43 Invcr { get; set; }

        public virtual PartyIdentification43 Invcee { get; set; }

        public virtual TaxInformation4 TaxRmt { get; set; }

        public virtual Garnishment1 GrnshmtRmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlRmtInf")]
        public virtual String[] AddtlRmtInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class StructuredRemittanceInformation13
    {
        [System.Xml.Serialization.XmlElementAttribute("RfrdDocInf")]
        public virtual ReferredDocumentInformation7[] RfrdDocInf { get; set; }

        public virtual RemittanceAmount2 RfrdDocAmt { get; set; }

        public virtual CreditorReferenceInformation2 CdtrRefInf { get; set; }

        public virtual PartyIdentification43 Invcr { get; set; }

        public virtual PartyIdentification43 Invcee { get; set; }

        public virtual TaxInformation4 TaxRmt { get; set; }

        public virtual Garnishment1 GrnshmtRmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlRmtInf")]
        public virtual String[] AddtlRmtInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class StructuredRemittanceInformation15
    {
        [System.Xml.Serialization.XmlElementAttribute("RfrdDocInf")]
        public virtual ReferredDocumentInformation7[] RfrdDocInf { get; set; }

        public virtual RemittanceAmount2 RfrdDocAmt { get; set; }

        public virtual CreditorReferenceInformation2 CdtrRefInf { get; set; }

        public virtual PartyIdentification125 Invcr { get; set; }

        public virtual PartyIdentification125 Invcee { get; set; }

        public virtual TaxInformation7 TaxRmt { get; set; }

        public virtual Garnishment2 GrnshmtRmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlRmtInf")]
        public virtual String[] AddtlRmtInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class StructuredRemittanceInformation16
    {
        [System.Xml.Serialization.XmlElementAttribute("RfrdDocInf")]
        public virtual ReferredDocumentInformation7[] RfrdDocInf { get; set; }

        public virtual RemittanceAmount2 RfrdDocAmt { get; set; }

        public virtual CreditorReferenceInformation2 CdtrRefInf { get; set; }

        public virtual PartyIdentification135 Invcr { get; set; }

        public virtual PartyIdentification135 Invcee { get; set; }

        public virtual TaxInformation7 TaxRmt { get; set; }

        public virtual Garnishment3 GrnshmtRmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlRmtInf")]
        public virtual String[] AddtlRmtInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class StructuredRemittanceInformation17
    {
        [System.Xml.Serialization.XmlElementAttribute("RfrdDocInf")]
        public virtual ReferredDocumentInformation7[] RfrdDocInf { get; set; }

        public virtual RemittanceAmount2 RfrdDocAmt { get; set; }

        public virtual CreditorReferenceInformation2 CdtrRefInf { get; set; }

        public virtual PartyIdentification135 Invcr { get; set; }

        public virtual PartyIdentification135 Invcee { get; set; }

        public virtual TaxData1 TaxRmt { get; set; }

        public virtual Garnishment3 GrnshmtRmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlRmtInf")]
        public virtual String[] AddtlRmtInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class StructuredRemittanceInformation6
    {
        public virtual ReferredDocumentInformation1 RfrdDocInf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime RfrdDocRltdDt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean RfrdDocRltdDtSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RfrdDocAmt")]
        public virtual ReferredDocumentAmount1Choice[] RfrdDocAmt { get; set; }

        public virtual CreditorReferenceInformation1 CdtrRefInf { get; set; }

        public virtual PartyIdentification8 Invcr { get; set; }

        public virtual PartyIdentification8 Invcee { get; set; }

        public virtual String AddtlRmtInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class StructuredRemittanceInformation7
    {
        [System.Xml.Serialization.XmlElementAttribute("RfrdDocInf")]
        public virtual ReferredDocumentInformation3[] RfrdDocInf { get; set; }

        public virtual RemittanceAmount1 RfrdDocAmt { get; set; }

        public virtual CreditorReferenceInformation2 CdtrRefInf { get; set; }

        public virtual PartyIdentification32 Invcr { get; set; }

        public virtual PartyIdentification32 Invcee { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("AddtlRmtInf")]
        public virtual String[] AddtlRmtInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class SupplementaryData1
    {
        public virtual String PlcAndNm { get; set; }

        public virtual XmlElement Envlp { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxAmount1
    {
        public virtual Decimal Rate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean RateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TaxblBaseAmt { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Dtls")]
        public virtual TaxRecordDetails1[] Dtls { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxAmount2
    {
        public virtual Decimal Rate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean RateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TaxblBaseAmt { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Dtls")]
        public virtual TaxRecordDetails2[] Dtls { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxAmount3
    {
        public virtual Decimal Rate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean RateSpecified { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TaxblBaseAmt { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Dtls")]
        public virtual TaxRecordDetails3[] Dtls { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxAmountAndType1
    {
        public virtual TaxAmountType1Choice Tp { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxAmountType1Choice
    {
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(String))]
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(String))]
        public virtual String Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemChoiceType4 ItemElementName { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxAuthorisation1
    {
        public virtual String Titl { get; set; }

        public virtual String Nm { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxData1
    {
        public virtual TaxParty1 Cdtr { get; set; }

        public virtual TaxParty2 Dbtr { get; set; }

        public virtual TaxParty2 UltmtDbtr { get; set; }

        public virtual String AdmstnZone { get; set; }

        public virtual String RefNb { get; set; }

        public virtual String Mtd { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlTaxblBaseAmt { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlTaxAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime Dt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtSpecified { get; set; }

        public virtual Decimal SeqNb { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SeqNbSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Rcrd")]
        public virtual TaxRecord3[] Rcrd { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxInformation10
    {
        public virtual TaxParty1 Cdtr { get; set; }

        public virtual TaxParty2 Dbtr { get; set; }

        public virtual String AdmstnZone { get; set; }

        public virtual String RefNb { get; set; }

        public virtual String Mtd { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlTaxblBaseAmt { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlTaxAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime Dt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtSpecified { get; set; }

        public virtual Decimal SeqNb { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SeqNbSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Rcrd")]
        public virtual TaxRecord3[] Rcrd { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxInformation3
    {
        public virtual TaxParty1 Cdtr { get; set; }

        public virtual TaxParty2 Dbtr { get; set; }

        public virtual String AdmstnZn { get; set; }

        public virtual String RefNb { get; set; }

        public virtual String Mtd { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlTaxblBaseAmt { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlTaxAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime Dt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtSpecified { get; set; }

        public virtual Decimal SeqNb { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SeqNbSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Rcrd")]
        public virtual TaxRecord1[] Rcrd { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxInformation4
    {
        public virtual TaxParty1 Cdtr { get; set; }

        public virtual TaxParty2 Dbtr { get; set; }

        public virtual TaxParty2 UltmtDbtr { get; set; }

        public virtual String AdmstnZone { get; set; }

        public virtual String RefNb { get; set; }

        public virtual String Mtd { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlTaxblBaseAmt { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlTaxAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime Dt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtSpecified { get; set; }

        public virtual Decimal SeqNb { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SeqNbSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Rcrd")]
        public virtual TaxRecord1[] Rcrd { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxInformation6
    {
        public virtual TaxParty1 Cdtr { get; set; }

        public virtual TaxParty2 Dbtr { get; set; }

        public virtual String AdmstnZn { get; set; }

        public virtual String RefNb { get; set; }

        public virtual String Mtd { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlTaxblBaseAmt { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlTaxAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime Dt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtSpecified { get; set; }

        public virtual Decimal SeqNb { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SeqNbSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Rcrd")]
        public virtual TaxRecord2[] Rcrd { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxInformation7
    {
        public virtual TaxParty1 Cdtr { get; set; }

        public virtual TaxParty2 Dbtr { get; set; }

        public virtual TaxParty2 UltmtDbtr { get; set; }

        public virtual String AdmstnZone { get; set; }

        public virtual String RefNb { get; set; }

        public virtual String Mtd { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlTaxblBaseAmt { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlTaxAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime Dt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtSpecified { get; set; }

        public virtual Decimal SeqNb { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SeqNbSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Rcrd")]
        public virtual TaxRecord2[] Rcrd { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxInformation8
    {
        public virtual TaxParty1 Cdtr { get; set; }

        public virtual TaxParty2 Dbtr { get; set; }

        public virtual String AdmstnZone { get; set; }

        public virtual String RefNb { get; set; }

        public virtual String Mtd { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlTaxblBaseAmt { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount TtlTaxAmt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime Dt { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean DtSpecified { get; set; }

        public virtual Decimal SeqNb { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean SeqNbSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Rcrd")]
        public virtual TaxRecord2[] Rcrd { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxParty1
    {
        public virtual String TaxId { get; set; }

        public virtual String RegnId { get; set; }

        public virtual String TaxTp { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxParty2
    {
        public virtual String TaxId { get; set; }

        public virtual String RegnId { get; set; }

        public virtual String TaxTp { get; set; }

        public virtual TaxAuthorisation1 Authstn { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxPeriod1
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime Yr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean YrSpecified { get; set; }

        public virtual TaxRecordPeriod1Code Tp { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean TpSpecified { get; set; }

        public virtual DatePeriodDetails FrToDt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxPeriod2
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public virtual DateTime Yr { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean YrSpecified { get; set; }

        public virtual TaxRecordPeriod1Code Tp { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean TpSpecified { get; set; }

        public virtual DatePeriod2 FrToDt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxPeriod3
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType="gYear")]
        public virtual String Yr { get; set; }

        public virtual TaxRecordPeriod1Code Tp { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual Boolean TpSpecified { get; set; }

        public virtual DatePeriod2 FrToDt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxRecord1
    {
        public virtual String Tp { get; set; }

        public virtual String Ctgy { get; set; }

        public virtual String CtgyDtls { get; set; }

        public virtual String DbtrSts { get; set; }

        public virtual String CertId { get; set; }

        public virtual String FrmsCd { get; set; }

        public virtual TaxPeriod1 Prd { get; set; }

        public virtual TaxAmount1 TaxAmt { get; set; }

        public virtual String AddtlInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxRecord2
    {
        public virtual String Tp { get; set; }

        public virtual String Ctgy { get; set; }

        public virtual String CtgyDtls { get; set; }

        public virtual String DbtrSts { get; set; }

        public virtual String CertId { get; set; }

        public virtual String FrmsCd { get; set; }

        public virtual TaxPeriod2 Prd { get; set; }

        public virtual TaxAmount2 TaxAmt { get; set; }

        public virtual String AddtlInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxRecord3
    {
        public virtual String Tp { get; set; }

        public virtual String Ctgy { get; set; }

        public virtual String CtgyDtls { get; set; }

        public virtual String DbtrSts { get; set; }

        public virtual String CertId { get; set; }

        public virtual String FrmsCd { get; set; }

        public virtual TaxPeriod3 Prd { get; set; }

        public virtual TaxAmount3 TaxAmt { get; set; }

        public virtual String AddtlInf { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxRecordDetails1
    {
        public virtual TaxPeriod1 Prd { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxRecordDetails2
    {
        public virtual TaxPeriod2 Prd { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TaxRecordDetails3
    {
        public virtual TaxPeriod3 Prd { get; set; }

        public virtual ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TransactionParties10
    {
        public virtual Party40Choice UltmtDbtr { get; set; }

        public virtual Party40Choice Dbtr { get; set; }

        public virtual CashAccount40 DbtrAcct { get; set; }

        public virtual Party40Choice InitgPty { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount40 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt1 { get; set; }

        public virtual CashAccount40 PrvsInstgAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt2 { get; set; }

        public virtual CashAccount40 PrvsInstgAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt3 { get; set; }

        public virtual CashAccount40 PrvsInstgAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual CashAccount40 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual CashAccount40 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual CashAccount40 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount40 CdtrAgtAcct { get; set; }

        public virtual Party40Choice Cdtr { get; set; }

        public virtual CashAccount40 CdtrAcct { get; set; }

        public virtual Party40Choice UltmtCdtr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TransactionParties5
    {
        public virtual Party35Choice UltmtDbtr { get; set; }

        public virtual Party35Choice Dbtr { get; set; }

        public virtual Party35Choice InitgPty { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 DbtrAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 PrvsInstgAgt1 { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 PrvsInstgAgt2 { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 PrvsInstgAgt3 { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt1 { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt2 { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 IntrmyAgt3 { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification5 CdtrAgt { get; set; }

        public virtual Party35Choice Cdtr { get; set; }

        public virtual Party35Choice UltmtCdtr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TransactionParties7
    {
        public virtual Party40Choice UltmtDbtr { get; set; }

        public virtual Party40Choice Dbtr { get; set; }

        public virtual Party40Choice InitgPty { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt1 { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt2 { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt3 { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual Party40Choice Cdtr { get; set; }

        public virtual Party40Choice UltmtCdtr { get; set; }

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "1.0.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.SerializableAttribute()]

    public class TransactionParties8
    {
        public virtual Party40Choice UltmtDbtr { get; set; }

        public virtual Party40Choice Dbtr { get; set; }

        public virtual CashAccount38 DbtrAcct { get; set; }

        public virtual Party40Choice InitgPty { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 DbtrAgt { get; set; }

        public virtual CashAccount38 DbtrAgtAcct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt1 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt2 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 PrvsInstgAgt3 { get; set; }

        public virtual CashAccount38 PrvsInstgAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt1 { get; set; }

        public virtual CashAccount38 IntrmyAgt1Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt2 { get; set; }

        public virtual CashAccount38 IntrmyAgt2Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 IntrmyAgt3 { get; set; }

        public virtual CashAccount38 IntrmyAgt3Acct { get; set; }

        public virtual BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public virtual CashAccount38 CdtrAgtAcct { get; set; }

        public virtual Party40Choice Cdtr { get; set; }

        public virtual CashAccount38 CdtrAcct { get; set; }

        public virtual Party40Choice UltmtCdtr { get; set; }

    }
    
}

namespace Iso20022.Model
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType1
    {
        CdtNoteAmt,
        DscntApldAmt,
        DuePyblAmt,
        RmtdAmt,
        TaxAmt,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType2
    {
        Id,
        Prtry,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType3
    {
        BBAN,
        IBAN,
        PrtryAcct,
        UPIC,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType4
    {
        Cd,
        Prtry,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType5
    {
        ReqdColltnDt,
        ReqdExctnDt,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType6
    {
        NtwkFileNm,
        OrgnlMsgId,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType7
    {
        AlnRegnNb,
        CstmrNb,
        DrvrsLicNb,
        DtAndPlcOfBirth,
        IdntyCardNb,
        MplyrIdNb,
        OthrId,
        PsptNb,
        SclSctyNb,
        TaxIdNb,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType8
    {
        Dt,
        DtTm,
    }

}

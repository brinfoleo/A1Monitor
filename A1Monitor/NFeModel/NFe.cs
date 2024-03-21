namespace A1Monitor.NFeModel
{
    public class NFe
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        [System.Xml.Serialization.XmlRoot(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
        public partial class nfeProc
        {

            private nfeProcNFe nFeField;

            private nfeProcProtNFe protNFeField;

            private decimal versaoField;

            /// <remarks/>
            public nfeProcNFe NFe
            {
                get
                {
                    return nFeField;
                }
                set
                {
                    nFeField = value;
                }
            }

            /// <remarks/>
            public nfeProcProtNFe protNFe
            {
                get
                {
                    return protNFeField;
                }
                set
                {
                    protNFeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public decimal versao
            {
                get
                {
                    return versaoField;
                }
                set
                {
                    versaoField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFe
        {

            private nfeProcNFeInfNFe infNFeField;

            private Signature signatureField;

            /// <remarks/>
            public nfeProcNFeInfNFe infNFe
            {
                get
                {
                    return infNFeField;
                }
                set
                {
                    infNFeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public Signature Signature
            {
                get
                {
                    return signatureField;
                }
                set
                {
                    signatureField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFe
        {

            private nfeProcNFeInfNFeIde ideField;

            private nfeProcNFeInfNFeEmit emitField;

            private nfeProcNFeInfNFeDest destField;

            private nfeProcNFeInfNFeDet detField;

            private nfeProcNFeInfNFeTotal totalField;

            private nfeProcNFeInfNFeTransp transpField;

            private nfeProcNFeInfNFeCobr cobrField;

            private nfeProcNFeInfNFePag pagField;

            private nfeProcNFeInfNFeInfAdic infAdicField;

            private nfeProcNFeInfNFeInfRespTec infRespTecField;

            private decimal versaoField;

            private string idField;

            /// <remarks/>
            public nfeProcNFeInfNFeIde ide
            {
                get
                {
                    return ideField;
                }
                set
                {
                    ideField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeEmit emit
            {
                get
                {
                    return emitField;
                }
                set
                {
                    emitField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeDest dest
            {
                get
                {
                    return destField;
                }
                set
                {
                    destField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeDet det
            {
                get
                {
                    return detField;
                }
                set
                {
                    detField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeTotal total
            {
                get
                {
                    return totalField;
                }
                set
                {
                    totalField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeTransp transp
            {
                get
                {
                    return transpField;
                }
                set
                {
                    transpField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeCobr cobr
            {
                get
                {
                    return cobrField;
                }
                set
                {
                    cobrField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFePag pag
            {
                get
                {
                    return pagField;
                }
                set
                {
                    pagField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeInfAdic infAdic
            {
                get
                {
                    return infAdicField;
                }
                set
                {
                    infAdicField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeInfRespTec infRespTec
            {
                get
                {
                    return infRespTecField;
                }
                set
                {
                    infRespTecField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public decimal versao
            {
                get
                {
                    return versaoField;
                }
                set
                {
                    versaoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string Id
            {
                get
                {
                    return idField;
                }
                set
                {
                    idField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeIde
        {

            private byte cUFField;

            private uint cNFField;

            private string natOpField;

            private byte modField;

            private byte serieField;

            private uint nNFField;

            private DateTime dhEmiField;

            private DateTime dhSaiEntField;

            private byte tpNFField;

            private byte idDestField;

            private uint cMunFGField;

            private byte tpImpField;

            private byte tpEmisField;

            private byte cDVField;

            private byte tpAmbField;

            private byte finNFeField;

            private byte indFinalField;

            private byte indPresField;

            private byte indIntermedField;

            private byte procEmiField;

            private uint verProcField;

            /// <remarks/>
            public byte cUF
            {
                get
                {
                    return cUFField;
                }
                set
                {
                    cUFField = value;
                }
            }

            /// <remarks/>
            public uint cNF
            {
                get
                {
                    return cNFField;
                }
                set
                {
                    cNFField = value;
                }
            }

            /// <remarks/>
            public string natOp
            {
                get
                {
                    return natOpField;
                }
                set
                {
                    natOpField = value;
                }
            }

            /// <remarks/>
            public byte mod
            {
                get
                {
                    return modField;
                }
                set
                {
                    modField = value;
                }
            }

            /// <remarks/>
            public byte serie
            {
                get
                {
                    return serieField;
                }
                set
                {
                    serieField = value;
                }
            }

            /// <remarks/>
            public uint nNF
            {
                get
                {
                    return nNFField;
                }
                set
                {
                    nNFField = value;
                }
            }

            /// <remarks/>
            public DateTime dhEmi
            {
                get
                {
                    return dhEmiField;
                }
                set
                {
                    dhEmiField = value;
                }
            }

            /// <remarks/>
            public DateTime dhSaiEnt
            {
                get
                {
                    return dhSaiEntField;
                }
                set
                {
                    dhSaiEntField = value;
                }
            }

            /// <remarks/>
            public byte tpNF
            {
                get
                {
                    return tpNFField;
                }
                set
                {
                    tpNFField = value;
                }
            }

            /// <remarks/>
            public byte idDest
            {
                get
                {
                    return idDestField;
                }
                set
                {
                    idDestField = value;
                }
            }

            /// <remarks/>
            public uint cMunFG
            {
                get
                {
                    return cMunFGField;
                }
                set
                {
                    cMunFGField = value;
                }
            }

            /// <remarks/>
            public byte tpImp
            {
                get
                {
                    return tpImpField;
                }
                set
                {
                    tpImpField = value;
                }
            }

            /// <remarks/>
            public byte tpEmis
            {
                get
                {
                    return tpEmisField;
                }
                set
                {
                    tpEmisField = value;
                }
            }

            /// <remarks/>
            public byte cDV
            {
                get
                {
                    return cDVField;
                }
                set
                {
                    cDVField = value;
                }
            }

            /// <remarks/>
            public byte tpAmb
            {
                get
                {
                    return tpAmbField;
                }
                set
                {
                    tpAmbField = value;
                }
            }

            /// <remarks/>
            public byte finNFe
            {
                get
                {
                    return finNFeField;
                }
                set
                {
                    finNFeField = value;
                }
            }

            /// <remarks/>
            public byte indFinal
            {
                get
                {
                    return indFinalField;
                }
                set
                {
                    indFinalField = value;
                }
            }

            /// <remarks/>
            public byte indPres
            {
                get
                {
                    return indPresField;
                }
                set
                {
                    indPresField = value;
                }
            }

            /// <remarks/>
            public byte indIntermed
            {
                get
                {
                    return indIntermedField;
                }
                set
                {
                    indIntermedField = value;
                }
            }

            /// <remarks/>
            public byte procEmi
            {
                get
                {
                    return procEmiField;
                }
                set
                {
                    procEmiField = value;
                }
            }

            /// <remarks/>
            public uint verProc
            {
                get
                {
                    return verProcField;
                }
                set
                {
                    verProcField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeEmit
        {

            private ulong cNPJField;

            private string xNomeField;

            private string xFantField;

            private nfeProcNFeInfNFeEmitEnderEmit enderEmitField;

            private ulong ieField;

            private uint imField;

            private uint cNAEField;

            private byte cRTField;

            /// <remarks/>
            public ulong CNPJ
            {
                get
                {
                    return cNPJField;
                }
                set
                {
                    cNPJField = value;
                }
            }

            /// <remarks/>
            public string xNome
            {
                get
                {
                    return xNomeField;
                }
                set
                {
                    xNomeField = value;
                }
            }

            /// <remarks/>
            public string xFant
            {
                get
                {
                    return xFantField;
                }
                set
                {
                    xFantField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeEmitEnderEmit enderEmit
            {
                get
                {
                    return enderEmitField;
                }
                set
                {
                    enderEmitField = value;
                }
            }

            /// <remarks/>
            public ulong IE
            {
                get
                {
                    return ieField;
                }
                set
                {
                    ieField = value;
                }
            }

            /// <remarks/>
            public uint IM
            {
                get
                {
                    return imField;
                }
                set
                {
                    imField = value;
                }
            }

            /// <remarks/>
            public uint CNAE
            {
                get
                {
                    return cNAEField;
                }
                set
                {
                    cNAEField = value;
                }
            }

            /// <remarks/>
            public byte CRT
            {
                get
                {
                    return cRTField;
                }
                set
                {
                    cRTField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeEmitEnderEmit
        {

            private string xLgrField;

            private byte nroField;

            private string xBairroField;

            private uint cMunField;

            private string xMunField;

            private string ufField;

            private uint cEPField;

            private ushort cPaisField;

            private string xPaisField;

            private uint foneField;

            /// <remarks/>
            public string xLgr
            {
                get
                {
                    return xLgrField;
                }
                set
                {
                    xLgrField = value;
                }
            }

            /// <remarks/>
            public byte nro
            {
                get
                {
                    return nroField;
                }
                set
                {
                    nroField = value;
                }
            }

            /// <remarks/>
            public string xBairro
            {
                get
                {
                    return xBairroField;
                }
                set
                {
                    xBairroField = value;
                }
            }

            /// <remarks/>
            public uint cMun
            {
                get
                {
                    return cMunField;
                }
                set
                {
                    cMunField = value;
                }
            }

            /// <remarks/>
            public string xMun
            {
                get
                {
                    return xMunField;
                }
                set
                {
                    xMunField = value;
                }
            }

            /// <remarks/>
            public string UF
            {
                get
                {
                    return ufField;
                }
                set
                {
                    ufField = value;
                }
            }

            /// <remarks/>
            public uint CEP
            {
                get
                {
                    return cEPField;
                }
                set
                {
                    cEPField = value;
                }
            }

            /// <remarks/>
            public ushort cPais
            {
                get
                {
                    return cPaisField;
                }
                set
                {
                    cPaisField = value;
                }
            }

            /// <remarks/>
            public string xPais
            {
                get
                {
                    return xPaisField;
                }
                set
                {
                    xPaisField = value;
                }
            }

            /// <remarks/>
            public uint fone
            {
                get
                {
                    return foneField;
                }
                set
                {
                    foneField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeDest
        {

            private ulong cNPJField;

            private string xNomeField;

            private nfeProcNFeInfNFeDestEnderDest enderDestField;

            private byte indIEDestField;

            private uint ieField;

            private string emailField;

            /// <remarks/>
            public ulong CNPJ
            {
                get
                {
                    return cNPJField;
                }
                set
                {
                    cNPJField = value;
                }
            }

            /// <remarks/>
            public string xNome
            {
                get
                {
                    return xNomeField;
                }
                set
                {
                    xNomeField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeDestEnderDest enderDest
            {
                get
                {
                    return enderDestField;
                }
                set
                {
                    enderDestField = value;
                }
            }

            /// <remarks/>
            public byte indIEDest
            {
                get
                {
                    return indIEDestField;
                }
                set
                {
                    indIEDestField = value;
                }
            }

            /// <remarks/>
            public uint IE
            {
                get
                {
                    return ieField;
                }
                set
                {
                    ieField = value;
                }
            }

            /// <remarks/>
            public string email
            {
                get
                {
                    return emailField;
                }
                set
                {
                    emailField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeDestEnderDest
        {

            private string xLgrField;

            private byte nroField;

            private string xBairroField;

            private uint cMunField;

            private string xMunField;

            private string ufField;

            private uint cEPField;

            private ushort cPaisField;

            private string xPaisField;

            private ulong foneField;

            /// <remarks/>
            public string xLgr
            {
                get
                {
                    return xLgrField;
                }
                set
                {
                    xLgrField = value;
                }
            }

            /// <remarks/>
            public byte nro
            {
                get
                {
                    return nroField;
                }
                set
                {
                    nroField = value;
                }
            }

            /// <remarks/>
            public string xBairro
            {
                get
                {
                    return xBairroField;
                }
                set
                {
                    xBairroField = value;
                }
            }

            /// <remarks/>
            public uint cMun
            {
                get
                {
                    return cMunField;
                }
                set
                {
                    cMunField = value;
                }
            }

            /// <remarks/>
            public string xMun
            {
                get
                {
                    return xMunField;
                }
                set
                {
                    xMunField = value;
                }
            }

            /// <remarks/>
            public string UF
            {
                get
                {
                    return ufField;
                }
                set
                {
                    ufField = value;
                }
            }

            /// <remarks/>
            public uint CEP
            {
                get
                {
                    return cEPField;
                }
                set
                {
                    cEPField = value;
                }
            }

            /// <remarks/>
            public ushort cPais
            {
                get
                {
                    return cPaisField;
                }
                set
                {
                    cPaisField = value;
                }
            }

            /// <remarks/>
            public string xPais
            {
                get
                {
                    return xPaisField;
                }
                set
                {
                    xPaisField = value;
                }
            }

            /// <remarks/>
            public ulong fone
            {
                get
                {
                    return foneField;
                }
                set
                {
                    foneField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeDet
        {

            private nfeProcNFeInfNFeDetProd prodField;

            private nfeProcNFeInfNFeDetImposto impostoField;

            private byte nItemField;

            /// <remarks/>
            public nfeProcNFeInfNFeDetProd prod
            {
                get
                {
                    return prodField;
                }
                set
                {
                    prodField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeDetImposto imposto
            {
                get
                {
                    return impostoField;
                }
                set
                {
                    impostoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public byte nItem
            {
                get
                {
                    return nItemField;
                }
                set
                {
                    nItemField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeDetProd
        {

            private string cProdField;

            private string cEANField;

            private string xProdField;

            private uint nCMField;

            private ushort cFOPField;

            private string uComField;

            private decimal qComField;

            private decimal vUnComField;

            private decimal vProdField;

            private string cEANTribField;

            private string uTribField;

            private decimal qTribField;

            private decimal vUnTribField;

            private byte indTotField;

            private nfeProcNFeInfNFeDetProdRastro rastroField;

            /// <remarks/>
            public string cProd
            {
                get
                {
                    return cProdField;
                }
                set
                {
                    cProdField = value;
                }
            }

            /// <remarks/>
            public string cEAN
            {
                get
                {
                    return cEANField;
                }
                set
                {
                    cEANField = value;
                }
            }

            /// <remarks/>
            public string xProd
            {
                get
                {
                    return xProdField;
                }
                set
                {
                    xProdField = value;
                }
            }

            /// <remarks/>
            public uint NCM
            {
                get
                {
                    return nCMField;
                }
                set
                {
                    nCMField = value;
                }
            }

            /// <remarks/>
            public ushort CFOP
            {
                get
                {
                    return cFOPField;
                }
                set
                {
                    cFOPField = value;
                }
            }

            /// <remarks/>
            public string uCom
            {
                get
                {
                    return uComField;
                }
                set
                {
                    uComField = value;
                }
            }

            /// <remarks/>
            public decimal qCom
            {
                get
                {
                    return qComField;
                }
                set
                {
                    qComField = value;
                }
            }

            /// <remarks/>
            public decimal vUnCom
            {
                get
                {
                    return vUnComField;
                }
                set
                {
                    vUnComField = value;
                }
            }

            /// <remarks/>
            public decimal vProd
            {
                get
                {
                    return vProdField;
                }
                set
                {
                    vProdField = value;
                }
            }

            /// <remarks/>
            public string cEANTrib
            {
                get
                {
                    return cEANTribField;
                }
                set
                {
                    cEANTribField = value;
                }
            }

            /// <remarks/>
            public string uTrib
            {
                get
                {
                    return uTribField;
                }
                set
                {
                    uTribField = value;
                }
            }

            /// <remarks/>
            public decimal qTrib
            {
                get
                {
                    return qTribField;
                }
                set
                {
                    qTribField = value;
                }
            }

            /// <remarks/>
            public decimal vUnTrib
            {
                get
                {
                    return vUnTribField;
                }
                set
                {
                    vUnTribField = value;
                }
            }

            /// <remarks/>
            public byte indTot
            {
                get
                {
                    return indTotField;
                }
                set
                {
                    indTotField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeDetProdRastro rastro
            {
                get
                {
                    return rastroField;
                }
                set
                {
                    rastroField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeDetProdRastro
        {

            private uint nLoteField;

            private decimal qLoteField;

            private DateTime dFabField;

            private DateTime dValField;

            /// <remarks/>
            public uint nLote
            {
                get
                {
                    return nLoteField;
                }
                set
                {
                    nLoteField = value;
                }
            }

            /// <remarks/>
            public decimal qLote
            {
                get
                {
                    return qLoteField;
                }
                set
                {
                    qLoteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(DataType = "date")]
            public DateTime dFab
            {
                get
                {
                    return dFabField;
                }
                set
                {
                    dFabField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(DataType = "date")]
            public DateTime dVal
            {
                get
                {
                    return dValField;
                }
                set
                {
                    dValField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeDetImposto
        {

            private decimal vTotTribField;

            private nfeProcNFeInfNFeDetImpostoICMS iCMSField;

            private nfeProcNFeInfNFeDetImpostoIPI iPIField;

            private nfeProcNFeInfNFeDetImpostoPIS pISField;

            private nfeProcNFeInfNFeDetImpostoCOFINS cOFINSField;

            /// <remarks/>
            public decimal vTotTrib
            {
                get
                {
                    return vTotTribField;
                }
                set
                {
                    vTotTribField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeDetImpostoICMS ICMS
            {
                get
                {
                    return iCMSField;
                }
                set
                {
                    iCMSField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeDetImpostoIPI IPI
            {
                get
                {
                    return iPIField;
                }
                set
                {
                    iPIField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeDetImpostoPIS PIS
            {
                get
                {
                    return pISField;
                }
                set
                {
                    pISField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeDetImpostoCOFINS COFINS
            {
                get
                {
                    return cOFINSField;
                }
                set
                {
                    cOFINSField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeDetImpostoICMS
        {

            private nfeProcNFeInfNFeDetImpostoICMSICMS00 iCMS00Field;

            /// <remarks/>
            public nfeProcNFeInfNFeDetImpostoICMSICMS00 ICMS00
            {
                get
                {
                    return iCMS00Field;
                }
                set
                {
                    iCMS00Field = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeDetImpostoICMSICMS00
        {

            private byte origField;

            private byte cSTField;

            private byte modBCField;

            private decimal vBCField;

            private decimal pICMSField;

            private decimal vICMSField;

            /// <remarks/>
            public byte orig
            {
                get
                {
                    return origField;
                }
                set
                {
                    origField = value;
                }
            }

            /// <remarks/>
            public byte CST
            {
                get
                {
                    return cSTField;
                }
                set
                {
                    cSTField = value;
                }
            }

            /// <remarks/>
            public byte modBC
            {
                get
                {
                    return modBCField;
                }
                set
                {
                    modBCField = value;
                }
            }

            /// <remarks/>
            public decimal vBC
            {
                get
                {
                    return vBCField;
                }
                set
                {
                    vBCField = value;
                }
            }

            /// <remarks/>
            public decimal pICMS
            {
                get
                {
                    return pICMSField;
                }
                set
                {
                    pICMSField = value;
                }
            }

            /// <remarks/>
            public decimal vICMS
            {
                get
                {
                    return vICMSField;
                }
                set
                {
                    vICMSField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeDetImpostoIPI
        {

            private ushort cEnqField;

            private nfeProcNFeInfNFeDetImpostoIPIIPINT iPINTField;

            /// <remarks/>
            public ushort cEnq
            {
                get
                {
                    return cEnqField;
                }
                set
                {
                    cEnqField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeDetImpostoIPIIPINT IPINT
            {
                get
                {
                    return iPINTField;
                }
                set
                {
                    iPINTField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeDetImpostoIPIIPINT
        {

            private byte cSTField;

            /// <remarks/>
            public byte CST
            {
                get
                {
                    return cSTField;
                }
                set
                {
                    cSTField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeDetImpostoPIS
        {

            private nfeProcNFeInfNFeDetImpostoPISPISAliq pISAliqField;

            /// <remarks/>
            public nfeProcNFeInfNFeDetImpostoPISPISAliq PISAliq
            {
                get
                {
                    return pISAliqField;
                }
                set
                {
                    pISAliqField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeDetImpostoPISPISAliq
        {

            private byte cSTField;

            private decimal vBCField;

            private decimal pPISField;

            private decimal vPISField;

            /// <remarks/>
            public byte CST
            {
                get
                {
                    return cSTField;
                }
                set
                {
                    cSTField = value;
                }
            }

            /// <remarks/>
            public decimal vBC
            {
                get
                {
                    return vBCField;
                }
                set
                {
                    vBCField = value;
                }
            }

            /// <remarks/>
            public decimal pPIS
            {
                get
                {
                    return pPISField;
                }
                set
                {
                    pPISField = value;
                }
            }

            /// <remarks/>
            public decimal vPIS
            {
                get
                {
                    return vPISField;
                }
                set
                {
                    vPISField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeDetImpostoCOFINS
        {

            private nfeProcNFeInfNFeDetImpostoCOFINSCOFINSAliq cOFINSAliqField;

            /// <remarks/>
            public nfeProcNFeInfNFeDetImpostoCOFINSCOFINSAliq COFINSAliq
            {
                get
                {
                    return cOFINSAliqField;
                }
                set
                {
                    cOFINSAliqField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeDetImpostoCOFINSCOFINSAliq
        {

            private byte cSTField;

            private decimal vBCField;

            private decimal pCOFINSField;

            private decimal vCOFINSField;

            /// <remarks/>
            public byte CST
            {
                get
                {
                    return cSTField;
                }
                set
                {
                    cSTField = value;
                }
            }

            /// <remarks/>
            public decimal vBC
            {
                get
                {
                    return vBCField;
                }
                set
                {
                    vBCField = value;
                }
            }

            /// <remarks/>
            public decimal pCOFINS
            {
                get
                {
                    return pCOFINSField;
                }
                set
                {
                    pCOFINSField = value;
                }
            }

            /// <remarks/>
            public decimal vCOFINS
            {
                get
                {
                    return vCOFINSField;
                }
                set
                {
                    vCOFINSField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeTotal
        {

            private nfeProcNFeInfNFeTotalICMSTot iCMSTotField;

            /// <remarks/>
            public nfeProcNFeInfNFeTotalICMSTot ICMSTot
            {
                get
                {
                    return iCMSTotField;
                }
                set
                {
                    iCMSTotField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeTotalICMSTot
        {

            private decimal vBCField;

            private decimal vICMSField;

            private decimal vICMSDesonField;

            private decimal vFCPField;

            private decimal vBCSTField;

            private decimal vSTField;

            private decimal vFCPSTField;

            private decimal vFCPSTRetField;

            private decimal vProdField;

            private decimal vFreteField;

            private decimal vSegField;

            private decimal vDescField;

            private decimal vIIField;

            private decimal vIPIField;

            private decimal vIPIDevolField;

            private decimal vPISField;

            private decimal vCOFINSField;

            private decimal vOutroField;

            private decimal vNFField;

            private decimal vTotTribField;

            /// <remarks/>
            public decimal vBC
            {
                get
                {
                    return vBCField;
                }
                set
                {
                    vBCField = value;
                }
            }

            /// <remarks/>
            public decimal vICMS
            {
                get
                {
                    return vICMSField;
                }
                set
                {
                    vICMSField = value;
                }
            }

            /// <remarks/>
            public decimal vICMSDeson
            {
                get
                {
                    return vICMSDesonField;
                }
                set
                {
                    vICMSDesonField = value;
                }
            }

            /// <remarks/>
            public decimal vFCP
            {
                get
                {
                    return vFCPField;
                }
                set
                {
                    vFCPField = value;
                }
            }

            /// <remarks/>
            public decimal vBCST
            {
                get
                {
                    return vBCSTField;
                }
                set
                {
                    vBCSTField = value;
                }
            }

            /// <remarks/>
            public decimal vST
            {
                get
                {
                    return vSTField;
                }
                set
                {
                    vSTField = value;
                }
            }

            /// <remarks/>
            public decimal vFCPST
            {
                get
                {
                    return vFCPSTField;
                }
                set
                {
                    vFCPSTField = value;
                }
            }

            /// <remarks/>
            public decimal vFCPSTRet
            {
                get
                {
                    return vFCPSTRetField;
                }
                set
                {
                    vFCPSTRetField = value;
                }
            }

            /// <remarks/>
            public decimal vProd
            {
                get
                {
                    return vProdField;
                }
                set
                {
                    vProdField = value;
                }
            }

            /// <remarks/>
            public decimal vFrete
            {
                get
                {
                    return vFreteField;
                }
                set
                {
                    vFreteField = value;
                }
            }

            /// <remarks/>
            public decimal vSeg
            {
                get
                {
                    return vSegField;
                }
                set
                {
                    vSegField = value;
                }
            }

            /// <remarks/>
            public decimal vDesc
            {
                get
                {
                    return vDescField;
                }
                set
                {
                    vDescField = value;
                }
            }

            /// <remarks/>
            public decimal vII
            {
                get
                {
                    return vIIField;
                }
                set
                {
                    vIIField = value;
                }
            }

            /// <remarks/>
            public decimal vIPI
            {
                get
                {
                    return vIPIField;
                }
                set
                {
                    vIPIField = value;
                }
            }

            /// <remarks/>
            public decimal vIPIDevol
            {
                get
                {
                    return vIPIDevolField;
                }
                set
                {
                    vIPIDevolField = value;
                }
            }

            /// <remarks/>
            public decimal vPIS
            {
                get
                {
                    return vPISField;
                }
                set
                {
                    vPISField = value;
                }
            }

            /// <remarks/>
            public decimal vCOFINS
            {
                get
                {
                    return vCOFINSField;
                }
                set
                {
                    vCOFINSField = value;
                }
            }

            /// <remarks/>
            public decimal vOutro
            {
                get
                {
                    return vOutroField;
                }
                set
                {
                    vOutroField = value;
                }
            }

            /// <remarks/>
            public decimal vNF
            {
                get
                {
                    return vNFField;
                }
                set
                {
                    vNFField = value;
                }
            }

            /// <remarks/>
            public decimal vTotTrib
            {
                get
                {
                    return vTotTribField;
                }
                set
                {
                    vTotTribField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeTransp
        {

            private byte modFreteField;

            private nfeProcNFeInfNFeTranspTransporta transportaField;

            private nfeProcNFeInfNFeTranspVol volField;

            /// <remarks/>
            public byte modFrete
            {
                get
                {
                    return modFreteField;
                }
                set
                {
                    modFreteField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeTranspTransporta transporta
            {
                get
                {
                    return transportaField;
                }
                set
                {
                    transportaField = value;
                }
            }

            /// <remarks/>
            public nfeProcNFeInfNFeTranspVol vol
            {
                get
                {
                    return volField;
                }
                set
                {
                    volField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeTranspTransporta
        {

            private ulong cNPJField;

            private string xNomeField;

            private ulong ieField;

            private string xEnderField;

            private string xMunField;

            private string ufField;

            /// <remarks/>
            public ulong CNPJ
            {
                get
                {
                    return cNPJField;
                }
                set
                {
                    cNPJField = value;
                }
            }

            /// <remarks/>
            public string xNome
            {
                get
                {
                    return xNomeField;
                }
                set
                {
                    xNomeField = value;
                }
            }

            /// <remarks/>
            public ulong IE
            {
                get
                {
                    return ieField;
                }
                set
                {
                    ieField = value;
                }
            }

            /// <remarks/>
            public string xEnder
            {
                get
                {
                    return xEnderField;
                }
                set
                {
                    xEnderField = value;
                }
            }

            /// <remarks/>
            public string xMun
            {
                get
                {
                    return xMunField;
                }
                set
                {
                    xMunField = value;
                }
            }

            /// <remarks/>
            public string UF
            {
                get
                {
                    return ufField;
                }
                set
                {
                    ufField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeTranspVol
        {

            private byte qVolField;

            private string espField;

            private decimal pesoLField;

            private decimal pesoBField;

            /// <remarks/>
            public byte qVol
            {
                get
                {
                    return qVolField;
                }
                set
                {
                    qVolField = value;
                }
            }

            /// <remarks/>
            public string esp
            {
                get
                {
                    return espField;
                }
                set
                {
                    espField = value;
                }
            }

            /// <remarks/>
            public decimal pesoL
            {
                get
                {
                    return pesoLField;
                }
                set
                {
                    pesoLField = value;
                }
            }

            /// <remarks/>
            public decimal pesoB
            {
                get
                {
                    return pesoBField;
                }
                set
                {
                    pesoBField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeCobr
        {

            private nfeProcNFeInfNFeCobrFat fatField;

            private nfeProcNFeInfNFeCobrDup[] dupField;

            /// <remarks/>
            public nfeProcNFeInfNFeCobrFat fat
            {
                get
                {
                    return fatField;
                }
                set
                {
                    fatField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("dup")]
            public nfeProcNFeInfNFeCobrDup[] dup
            {
                get
                {
                    return dupField;
                }
                set
                {
                    dupField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeCobrFat
        {

            private uint nFatField;

            private decimal vOrigField;

            private decimal vDescField;

            private decimal vLiqField;

            /// <remarks/>
            public uint nFat
            {
                get
                {
                    return nFatField;
                }
                set
                {
                    nFatField = value;
                }
            }

            /// <remarks/>
            public decimal vOrig
            {
                get
                {
                    return vOrigField;
                }
                set
                {
                    vOrigField = value;
                }
            }

            /// <remarks/>
            public decimal vDesc
            {
                get
                {
                    return vDescField;
                }
                set
                {
                    vDescField = value;
                }
            }

            /// <remarks/>
            public decimal vLiq
            {
                get
                {
                    return vLiqField;
                }
                set
                {
                    vLiqField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeCobrDup
        {

            private byte nDupField;

            private DateTime dVencField;

            private decimal vDupField;

            /// <remarks/>
            public byte nDup
            {
                get
                {
                    return nDupField;
                }
                set
                {
                    nDupField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(DataType = "date")]
            public DateTime dVenc
            {
                get
                {
                    return dVencField;
                }
                set
                {
                    dVencField = value;
                }
            }

            /// <remarks/>
            public decimal vDup
            {
                get
                {
                    return vDupField;
                }
                set
                {
                    vDupField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFePag
        {

            private nfeProcNFeInfNFePagDetPag detPagField;

            /// <remarks/>
            public nfeProcNFeInfNFePagDetPag detPag
            {
                get
                {
                    return detPagField;
                }
                set
                {
                    detPagField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFePagDetPag
        {

            private byte indPagField;

            private byte tPagField;

            private decimal vPagField;

            /// <remarks/>
            public byte indPag
            {
                get
                {
                    return indPagField;
                }
                set
                {
                    indPagField = value;
                }
            }

            /// <remarks/>
            public byte tPag
            {
                get
                {
                    return tPagField;
                }
                set
                {
                    tPagField = value;
                }
            }

            /// <remarks/>
            public decimal vPag
            {
                get
                {
                    return vPagField;
                }
                set
                {
                    vPagField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeInfAdic
        {

            private string infCplField;

            /// <remarks/>
            public string infCpl
            {
                get
                {
                    return infCplField;
                }
                set
                {
                    infCplField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcNFeInfNFeInfRespTec
        {

            private ulong cNPJField;

            private string xContatoField;

            private string emailField;

            private uint foneField;

            /// <remarks/>
            public ulong CNPJ
            {
                get
                {
                    return cNPJField;
                }
                set
                {
                    cNPJField = value;
                }
            }

            /// <remarks/>
            public string xContato
            {
                get
                {
                    return xContatoField;
                }
                set
                {
                    xContatoField = value;
                }
            }

            /// <remarks/>
            public string email
            {
                get
                {
                    return emailField;
                }
                set
                {
                    emailField = value;
                }
            }

            /// <remarks/>
            public uint fone
            {
                get
                {
                    return foneField;
                }
                set
                {
                    foneField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        [System.Xml.Serialization.XmlRoot(Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
        public partial class Signature
        {

            private SignatureSignedInfo signedInfoField;

            private string signatureValueField;

            private SignatureKeyInfo keyInfoField;

            /// <remarks/>
            public SignatureSignedInfo SignedInfo
            {
                get
                {
                    return signedInfoField;
                }
                set
                {
                    signedInfoField = value;
                }
            }

            /// <remarks/>
            public string SignatureValue
            {
                get
                {
                    return signatureValueField;
                }
                set
                {
                    signatureValueField = value;
                }
            }

            /// <remarks/>
            public SignatureKeyInfo KeyInfo
            {
                get
                {
                    return keyInfoField;
                }
                set
                {
                    keyInfoField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public partial class SignatureSignedInfo
        {

            private SignatureSignedInfoCanonicalizationMethod canonicalizationMethodField;

            private SignatureSignedInfoSignatureMethod signatureMethodField;

            private SignatureSignedInfoReference referenceField;

            /// <remarks/>
            public SignatureSignedInfoCanonicalizationMethod CanonicalizationMethod
            {
                get
                {
                    return canonicalizationMethodField;
                }
                set
                {
                    canonicalizationMethodField = value;
                }
            }

            /// <remarks/>
            public SignatureSignedInfoSignatureMethod SignatureMethod
            {
                get
                {
                    return signatureMethodField;
                }
                set
                {
                    signatureMethodField = value;
                }
            }

            /// <remarks/>
            public SignatureSignedInfoReference Reference
            {
                get
                {
                    return referenceField;
                }
                set
                {
                    referenceField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public partial class SignatureSignedInfoCanonicalizationMethod
        {

            private string algorithmField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string Algorithm
            {
                get
                {
                    return algorithmField;
                }
                set
                {
                    algorithmField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public partial class SignatureSignedInfoSignatureMethod
        {

            private string algorithmField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string Algorithm
            {
                get
                {
                    return algorithmField;
                }
                set
                {
                    algorithmField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public partial class SignatureSignedInfoReference
        {

            private SignatureSignedInfoReferenceTransform[] transformsField;

            private SignatureSignedInfoReferenceDigestMethod digestMethodField;

            private string digestValueField;

            private string uRIField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItem("Transform", IsNullable = false)]
            public SignatureSignedInfoReferenceTransform[] Transforms
            {
                get
                {
                    return transformsField;
                }
                set
                {
                    transformsField = value;
                }
            }

            /// <remarks/>
            public SignatureSignedInfoReferenceDigestMethod DigestMethod
            {
                get
                {
                    return digestMethodField;
                }
                set
                {
                    digestMethodField = value;
                }
            }

            /// <remarks/>
            public string DigestValue
            {
                get
                {
                    return digestValueField;
                }
                set
                {
                    digestValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string URI
            {
                get
                {
                    return uRIField;
                }
                set
                {
                    uRIField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public partial class SignatureSignedInfoReferenceTransform
        {

            private string algorithmField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string Algorithm
            {
                get
                {
                    return algorithmField;
                }
                set
                {
                    algorithmField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public partial class SignatureSignedInfoReferenceDigestMethod
        {

            private string algorithmField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string Algorithm
            {
                get
                {
                    return algorithmField;
                }
                set
                {
                    algorithmField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public partial class SignatureKeyInfo
        {

            private SignatureKeyInfoX509Data x509DataField;

            /// <remarks/>
            public SignatureKeyInfoX509Data X509Data
            {
                get
                {
                    return x509DataField;
                }
                set
                {
                    x509DataField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public partial class SignatureKeyInfoX509Data
        {

            private string x509CertificateField;

            /// <remarks/>
            public string X509Certificate
            {
                get
                {
                    return x509CertificateField;
                }
                set
                {
                    x509CertificateField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcProtNFe
        {

            private nfeProcProtNFeInfProt infProtField;

            private decimal versaoField;

            /// <remarks/>
            public nfeProcProtNFeInfProt infProt
            {
                get
                {
                    return infProtField;
                }
                set
                {
                    infProtField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public decimal versao
            {
                get
                {
                    return versaoField;
                }
                set
                {
                    versaoField = value;
                }
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class nfeProcProtNFeInfProt
        {

            private byte tpAmbField;

            private string verAplicField;

            private string chNFeField;

            private DateTime dhRecbtoField;

            private ulong nProtField;

            private string digValField;

            private byte cStatField;

            private string xMotivoField;

            private string idField;

            /// <remarks/>
            public byte tpAmb
            {
                get
                {
                    return tpAmbField;
                }
                set
                {
                    tpAmbField = value;
                }
            }

            /// <remarks/>
            public string verAplic
            {
                get
                {
                    return verAplicField;
                }
                set
                {
                    verAplicField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(DataType = "integer")]
            public string chNFe
            {
                get
                {
                    return chNFeField;
                }
                set
                {
                    chNFeField = value;
                }
            }

            /// <remarks/>
            public DateTime dhRecbto
            {
                get
                {
                    return dhRecbtoField;
                }
                set
                {
                    dhRecbtoField = value;
                }
            }

            /// <remarks/>
            public ulong nProt
            {
                get
                {
                    return nProtField;
                }
                set
                {
                    nProtField = value;
                }
            }

            /// <remarks/>
            public string digVal
            {
                get
                {
                    return digValField;
                }
                set
                {
                    digValField = value;
                }
            }

            /// <remarks/>
            public byte cStat
            {
                get
                {
                    return cStatField;
                }
                set
                {
                    cStatField = value;
                }
            }

            /// <remarks/>
            public string xMotivo
            {
                get
                {
                    return xMotivoField;
                }
                set
                {
                    xMotivoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string Id
            {
                get
                {
                    return idField;
                }
                set
                {
                    idField = value;
                }
            }
        }


    }
}

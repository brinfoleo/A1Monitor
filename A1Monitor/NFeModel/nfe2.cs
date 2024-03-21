namespace A1Monitor.NFeModel
{
    using System.Xml.Serialization;

    // Raiz do XML da NF-e
    [XmlRoot("nfeProc", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class NfeProc
    {
        [XmlElement("NFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public NFe2 NFe { get; set; }
    }

    // Estrutura do elemento NFe do XML da NF-e
    public class NFe2
    {
        [XmlElement("infNFe")]
        public InfNFe InfNFe { get; set; }
    }

    // Informações da NF-e
    public class InfNFe
    {
        [XmlElement("ide")]
        public Ide Ide { get; set; }

        // Outros elementos que você deseja extrair da NF-e
        // Exemplo: emit, dest, total, etc.
    }

    // Dados da Identificação da NF-e
    public class Ide
    {
        [XmlElement("cNF")]
        public string CNF { get; set; }

        [XmlElement("natOp")]
        public string NatOp { get; set; }

        // Outros elementos de identificação
        // Exemplo: nNF, dhEmi, etc.
    }

}

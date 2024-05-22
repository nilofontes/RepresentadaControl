namespace RepresentadaControl.Data
{
    public class Fornecedor : BaseModel
    {

        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo {  get; set; }
        public IEnumerable<Produto> Produtos { get; set; }

    }
}

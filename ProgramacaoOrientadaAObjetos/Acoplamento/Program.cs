using HerancaComposicao;

Console.WriteLine("## Herança com Composição\n");

ComportamentoNadar nadar = new ComportamentoNadar();
ComportamentoAndar andar = new ComportamentoAndar();

var humano = new Humano(andar);
humano.Locomocao();

var macaco = new Macaco(andar);
macaco.Locomocao();

var sardinha = new Sardinha(nadar);
sardinha.Locomocao();

Console.ReadKey();

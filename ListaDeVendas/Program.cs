using ListaDeVendas;

List<Produto> listaProdutos = new List<Produto>();
Produto p1 = new Produto(10.00M, "Pão", 1);
Produto p2 = new Produto(5.50M, "Leite", 2);
Produto p3 = new Produto(2.20M, "Café", 3);
Produto p4 = new Produto(15.00M, "Queijo", 4);
Produto p5 = new Produto(7.80M, "Presunto", 5);
Produto p6 = new Produto(3.50M, "Bolacha", 6);
Produto p7 = new Produto(6.90M, "Refrigerante", 7);
Produto p8 = new Produto(8.75M, "Suco", 8);
Produto p9 = new Produto(1.20M, "Água", 9);
Produto p10 = new Produto(4.25M, "Chocolate", 10);

listaProdutos.Add(p1); listaProdutos.Add(p2); listaProdutos.Add(p3); listaProdutos.Add(p4); listaProdutos.Add(p5);
listaProdutos.Add(p6); listaProdutos.Add(p7); listaProdutos.Add(p8); listaProdutos.Add(p9); listaProdutos.Add(p10);

List<Produto> produtosComprados = new List<Produto>();
produtosComprados.Add(listaProdutos[5]);  
produtosComprados.Add(listaProdutos[3]);  
produtosComprados.Add(listaProdutos[7]);
produtosComprados.Add(listaProdutos[1]);
produtosComprados.Add(listaProdutos[2]);

Venda venda = new Venda(1, DateTime.Now, produtosComprados);
venda.ImprimirVenda();

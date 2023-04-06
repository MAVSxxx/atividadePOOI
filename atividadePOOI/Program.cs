
using atividadePOOI.Model;

Cliente cliente1 = new Cliente("Beija Flor", "202-2", "10-180-210");
Base base1 = new Base("Roger", cliente1, "toalha", 15, 0101, 25.60m, 3);
Base base2 = new Base("Roger", cliente1, "cortina", 20, 0102, 120.80m, 2);

Console.WriteLine($"Vendedor: {base1.Vendedor}; produtos: {base1.Produtos}; Empresa: {cliente1.NomeEmp}; quantidade: {base1.Quantidade}, código: {base1.Codigo}, valor: {base1.Valor}, vendidos: {base1.Venda}, saldo:{base1.Saldo}");
Console.WriteLine($"Produto: {base2.Produtos}, Vendas: {base2.Venda}, valor: {base2.Valor}, valor total de venda; {base1.SaldoTotal}");
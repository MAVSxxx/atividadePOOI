using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadePOOI.Model
{
    public class Base
    {
        private string _produtos;
        private int _quantidade;
        private int _codigo;
        private string _vendedor;
        private decimal _valor;
        private decimal _venda;
        private static decimal _vendaTotal;
        private decimal _saldo;
        private static decimal _saldoTotal;

        public Base(string vendedor, Cliente titular, decimal saldo = 0, decimal saldoTotal = 0)
        {
            _vendedor = vendedor;
            Titular = titular;
            Saldo = saldo;
            SaldoTotal = saldoTotal;
        }

        public Base(string vendedor, Cliente titular, string produtos, int quantidade, int codigo, decimal valor, decimal venda) {
            _produtos = produtos;
            _quantidade = quantidade;
            _codigo = codigo;
            _vendedor = vendedor;
            _valor = valor;
            _venda = quantidade - venda;
            Titular = titular;
            _vendaTotal += _venda;  
            _saldo = valor * venda;
            _saldoTotal += _saldo;
        }

        public string Produtos {
            get => _produtos;
            set => _produtos = value;
        }
        public int Quantidade
        {
            get => _quantidade;
            set => _quantidade = value;
        }
        public int Codigo
        {
            get => _codigo;
            set => _codigo = value;
        }
        public string Vendedor
        {
            get => _vendedor;
            set => _vendedor = value;
        }
        public decimal Valor
        {
            get => _valor;
            set => _valor = value;
        }
        public decimal Venda
        {
            get => _venda;
            set => _venda = value;
        }
        public decimal VendaTotal
        {
            get => _vendaTotal;
            set => _vendaTotal = value;
        }
        public decimal Saldo
        {
            get => _saldo;
            set => _saldo = value;
        }
        public decimal SaldoTotal
        {
            get => _saldoTotal;
            set => _saldoTotal = value;
        }

        public Cliente Titular { get; set;}

    }
}

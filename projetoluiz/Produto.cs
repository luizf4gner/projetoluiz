using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoluiz
{
    public class Produto
    {
        public int Id { get; set; }
        [DisplayName("Produto")]
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        [DisplayName("Preço de compra")]
        public float precoCompra { get; set; }
        [DisplayName("Preço de venda")]
        public float precoVenda { get; set; }
    }

}

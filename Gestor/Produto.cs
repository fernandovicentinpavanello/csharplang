using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor
{
    [System.Serializable]
    abstract class Produto
    {
        public string? nome;
        public float preco; 
    }
}
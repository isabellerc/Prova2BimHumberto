using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Providers.MongoDB.Collections
{
    [BsonCollection("Jogos")]
    public class JogosCollection : Document
    {

        //[MinLength(3, ErrorMessage = "Minimo 3 Caracteres.")]
        //[MaxLength(255, ErrorMessage = "Maximo 255 Caracteres.")]
        //[Required(ErrorMessage = "Nome Obrigatorio.")]
        public int primeiroNumero { get; private set; }

        public int segundoNumero { get; private set; }

        public int terceiroNumero { get; private set; }

        public int quartoNumero { get; private set; }
        public int quintoNumero { get; private set; }
        public int sextoNumero { get; private set; }
    }
}

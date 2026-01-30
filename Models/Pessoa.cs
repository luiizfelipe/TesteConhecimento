using System;
using System.Collections.Generic;
using System.Text;

namespace TesteConhecimento.Models
{
    public class Pessoa
    {
        public int Id { get; set; } // Recomendo Guid invés de ID com auto incremento para evitar colisões em sistemas distribuídos.
        public string Nome { get ; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
    }
}

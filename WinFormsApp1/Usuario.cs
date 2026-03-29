using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Usuario
    {
        [JsonPropertyName("usuario")]
        public string Email {  get; set; }

        [JsonPropertyName("senha")]
        public string Senha { get; set; }

    }
}

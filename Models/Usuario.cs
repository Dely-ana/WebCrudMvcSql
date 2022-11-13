using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Text.Json.Serialization;

namespace WebCrudMvcSql.Models
{


    [Table("usuario")]
    public class Usuario
    {
    
            [Column("id")]
            public int Id { get; set; }

            [Column("nome")]
            public string Nome { get; set; } = string.Empty;

            [Column("cpf")]
            public int Cpf { get; set; }

            [Column("telefone")]
            public int Telefone { get; set; }

            [Column("email")]
            public string Email { get; set; } = string.Empty;

            [Column("pais")]
            public string Pais { get; set; } = string.Empty;

            [Column("sexo")]
            public string Sexo { get; set; } = string.Empty;

            [Column("destino")]
            public string Destino { get; set; } = string.Empty;


   

        }

    }
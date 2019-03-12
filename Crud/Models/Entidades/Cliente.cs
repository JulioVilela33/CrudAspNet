using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Models.Entidades
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public Guid ClienteId { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Required]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime Data { get; set; }

        [Required]
        [MaxLength(15)]
        [Display(Name = "CPF/CNPJ")]
        public String Documento { get; set; }

        [Required]
        public String Telefone { get; set; }

        [Required]
        [Display(Name = "Tipo Do Telefone")]
        public TipoTelefone TelTipo { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Endereço")]
        public String Endereco { get; set; }

        [Required]
        [Display(Name = "Tipo Endereço")]
        public TipoEndereco EndeTipo {get; set; }

        [Required]
        [Display(Name = "Tipo Cliente")]
        public TipoCliente TipoCliente { get; set; }

    }

    public enum TipoTelefone
    {
        Celular = 1,
        Residencial = 2,
        Comercial = 3
    }

    public enum TipoEndereco
    {
        Residencial = 1,
        Comercial = 2,
        Entrega = 3,
        Correnspondencia = 4
    }
    public enum TipoCliente
    {
        Fisica = 1,
        Juridica = 2
    }
}

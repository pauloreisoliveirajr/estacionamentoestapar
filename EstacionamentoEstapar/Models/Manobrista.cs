//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstacionamentoEstapar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Manobrista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Manobrista()
        {
            this.Manobras = new HashSet<Manobra>();
        }
    
        public int IdManobrista { get; set; }

        [Required(ErrorMessage = "Informe o nome do manobrista.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no m�ximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o CPF do manobrista.")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "O CPF deve ter 11 caracteres(14 com a pontua��o).")]
        public string CPF { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Informe a data de nascimento do manobrista.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data de nascimento em formato inv�lido")]
        public System.DateTime DtNascimento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Manobra> Manobras { get; set; }
    }
}

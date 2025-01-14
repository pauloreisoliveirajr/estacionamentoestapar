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

    public partial class Modelo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Modelo()
        {
            this.Manobras = new HashSet<Manobra>();
        }
    
        public int IdModelo { get; set; }

        public int IdMarca { get; set; }

        [Display(Name = "Modelo")]
        [Required(ErrorMessage = "Informe o modelo.")]
        [StringLength(100, ErrorMessage = "O modelo deve ter no m�ximo 100 caracteres.")]
        public string DscModelo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Manobra> Manobras { get; set; }
        public virtual Marca Marca { get; set; }
    }
}

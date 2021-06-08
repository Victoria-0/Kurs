namespace Kurs.ModelBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Library")]
    public partial class Library
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Avtor { get; set; }

        [StringLength(50)]
        public string Book { get; set; }

        [StringLength(50)]
        public string God { get; set; }

        [StringLength(50)]
        public string Style { get; set; }
    }
}

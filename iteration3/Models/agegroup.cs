namespace iteration3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("agegroup")]
    public partial class agegroup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Column("ageGroup")]
        [Required]
        [StringLength(5)]
        public string ageGroup1 { get; set; }
    }
}

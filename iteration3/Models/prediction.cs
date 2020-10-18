namespace iteration3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("prediction")]
    public partial class prediction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int gender { get; set; }

        public int age_group_10y { get; set; }

        public int english_proficiency { get; set; }

        public int highest_education { get; set; }

        public int field_of_study { get; set; }

        [Required]
        [StringLength(52)]
        public string pred_1 { get; set; }

        [Required]
        [StringLength(52)]
        public string pred_2 { get; set; }

        [Required]
        [StringLength(52)]
        public string pred_3 { get; set; }
    }
}

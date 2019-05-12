namespace WebAppWald
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History")]
    public partial class History
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int History_Id { get; set; }

        public int Patient_Id { get; set; }

        public int Billing { get; set; }

        public int Medical_Record { get; set; }

        public virtual Patient Patient { get; set; }
    }
}

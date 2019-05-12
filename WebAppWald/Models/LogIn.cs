namespace WebAppWald
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogIn")]
    public partial class LogIn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int User_Id { get; set; }

        [Required]
        [StringLength(80)]
        public string UserName { get; set; }

        [Required]
        [StringLength(60)]
        public string Password { get; set; }
    }
}

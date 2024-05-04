namespace FindiJobs.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User
    {
        [Key]
        [Column("user_id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(100)]
        public required string Name { get; set; }
        [Column("email")]
        [StringLength(255)]
        public required string Email { get; set; }
        [Column("password")]
        [StringLength(255)]
        public required string Password { get; set; }
        [Column("registration_date", TypeName = "date")]
        public DateTime RegisDate { get; set; }
    }
}

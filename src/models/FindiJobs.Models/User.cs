namespace FindiJobs.Models
{
    using System;

    public class User
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }

        public DateTime RegisterDate { get; set; }
    }
}

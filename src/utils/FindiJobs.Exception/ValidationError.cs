namespace FindiJobs.Exception
{
    public class ValidationError : BaseError
    {
        public ValidationError()
        {
            this.Errors = new List<Error>();
        }

        public List<Error> Errors { get; set; }
    }
}

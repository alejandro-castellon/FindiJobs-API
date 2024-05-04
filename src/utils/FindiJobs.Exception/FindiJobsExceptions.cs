using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace FindiJobs.Exception
{
    using System;
    public class FindiJobsExceptions : Exception
    {
        public FindiJobsExceptions(FindiJobsErrors code)
        {
            this.BaseError = new BaseError();
            this.BaseError.Message = "The resource couldn't be found";
            this.Error = new ObjectResult(this.BaseError);
            this.Error.StatusCode = (int)FindiJobsErrors.NotFound;
        }
        public FindiJobsExceptions(FindiJobsErrors code, Exception exception)
        {
            this.BaseError = new BaseError();
            this.ValidationError = new ValidationError();

            switch (code)
            {
                case FindiJobsErrors.BadRequest:
                    var validationException = (ValidationException)exception;
                    this.ValidationError.Message = "Please review the errors, inconsistent data.";

                    foreach (var error in validationException.Errors)
                    {
                        var myError = new Error();
                        myError.PropertyName = error.PropertyName;
                        myError.ErrorMessage = error.ErrorMessage;
                        myError.AttemptedValue = error.AttemptedValue;
                        this.ValidationError.Errors.Add(myError);
                    }

                    this.Error = new ObjectResult(this.ValidationError);
                    this.Error.StatusCode = (int)FindiJobsErrors.BadRequest;
                    break;
                case FindiJobsErrors.InternalServerError:
                    this.BaseError.Message = "Something went wrong, please contact the FindiJobs administrator.";
                    this.Error = new ObjectResult(this.BaseError);
                    this.Error.StatusCode = (int)FindiJobsErrors.InternalServerError;
                    break;
                default:
                    break;
            }
        }

        public BaseError BaseError { get; set; }

        public ValidationError ValidationError { get; set; }

        public ObjectResult Error { get; set; }
    }
}

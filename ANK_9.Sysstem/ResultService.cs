using System;
using System.Collections.Generic;
using System.Linq;

namespace ANK_9.Sysstem
{
    public class ResultService<T>
    {
        public bool HasError { get { return Errors.Count > 0; } }

        public T Data { get; set; }

        public List<T> ListData { get; set; }

        public ResultService()
        {
            Errors = new List<ErrorItem>();
        }

        public ICollection<ErrorItem> Errors { get; set; }

        public void AddError(string errorType, string errorMessage)
        {
            Errors.Add(
                new ErrorItem
                {
                    ErrorType = errorType,
                    ErrorMessage = errorMessage
                });
        }
    }
}

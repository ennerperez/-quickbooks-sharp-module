using System;

namespace QuickBooks.Abstractions.Models
{
    public class ProcessEntity<T>
    {
        public Exception Error { get; set; }
        public T Data { get; set; }

    }
}
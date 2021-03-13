using System;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-02-dylinw-dykstra1] - 
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Presentation.Models
{
    public class ErrorViewModel
    {

        [Required]
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

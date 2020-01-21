using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LibraryManagement.Presentation.Infrastructure
{
    public class BorrowDateValidationAttribute : ValidationAttribute
    {
    
     public override bool IsValid(object value){
         DateTime submitDate = (DateTime)value;
         DateTime presentDay = DateTime.Now;
         DateTime lastDay = submitDate.AddDays(15);
         if((submitDate > presentDay) && (submitDate <lastDay) )
                 return true;
          return false;
     }
    }
}
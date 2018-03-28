using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yoyo.ViewModels
{
    public class RequiredTestViewModel
    {
        [Required]
        [Display(Name = "Mon champ required")]
        public string MonChampRequired { get; set; }
    }
}
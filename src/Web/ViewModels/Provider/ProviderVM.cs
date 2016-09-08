using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels.Provider
{
    public class ProviderVM
    {
        public int Id { get; set; }
        [Display(Name = "Поставщик услуги"), Required(ErrorMessage = "{0} - обязательное поле")]
        [StringLength(256, MinimumLength = 5, ErrorMessage = "Строка должна быть не менее 5 символов и не более 256.")]
        public string ProviderName { get; set; }
    }
}

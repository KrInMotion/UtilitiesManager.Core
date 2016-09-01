
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels.Invoice
{
    public class InvoiceFormVM
    {
        public int Id { get; set; }
        [Display(Name ="Номер документа")]
        public string InvoiceNum { get; set; }
        [Display(Name = "Лицевой счет"), MaxLength(100)]
        public string Account { get; set; }
        [Display(Name = "Тип документа"), Required(ErrorMessage = "{0} - обязательное поле")]
        public int InvoiceTypeId { get; set; }
        [Display(Name = "Поставщик услуги"), Required(ErrorMessage = "{0} - обязательное поле")]
        public int InvoiceProviderId { get; set; }
        [Display(Name = "Расчетный месяц"), Required(ErrorMessage = "{0} - обязательное поле")]
        public int MonthId { get; set; }
        public List<SelectListItem> InvoiceTypeList { get; set; }
        public List<SelectListItem> InvoiceProviderList { get; set; }
        public List<SelectListItem> MonthList { get; set; }
    }
}

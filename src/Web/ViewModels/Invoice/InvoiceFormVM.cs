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
        public InvoiceFormVM()
        {
            InvoiceTypeList = new List<SelectListItem>();
            InvoiceProviderList = new List<SelectListItem>();
            MonthList = new List<SelectListItem>();
        }
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
        [Display(Name = "Расчетный год"), Required(ErrorMessage = "{0} - обязательное поле")] 
        [Range(1980, 2100, ErrorMessage = "Расчетный год должет быть в диапазоне {1} - {2}")]
        public int Year { get; set; }
        public List<SelectListItem> InvoiceTypeList { get; set; }
        public List<SelectListItem> InvoiceProviderList { get; set; }
        public List<SelectListItem> MonthList { get; set; }
    }
}

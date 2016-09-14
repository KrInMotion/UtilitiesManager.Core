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
            KindList = new List<SelectListItem>();
            ProviderList = new List<SelectListItem>();
            MonthList = new List<SelectListItem>();
        }
        public int DocumentId { get; set; }
        [Display(Name ="Номер документа"), StringLength(256, ErrorMessage = "Размер строки не более 256 символов")]
        public string Number { get; set; }
        [Display(Name = "Лицевой счет"), StringLength(256, ErrorMessage ="Размер строки не более 256 символов")]
        public string Account { get; set; }
        [Display(Name = "Тип документа"), Required(ErrorMessage = "{0} - обязательное поле")]
        public int KindId { get; set; }
        [Display(Name = "Поставщик услуги"), Required(ErrorMessage = "{0} - обязательное поле")]
        public int ProviderId { get; set; }
        [Display(Name = "Расчетный месяц"), Required(ErrorMessage = "{0} - обязательное поле")]
        public int MonthId { get; set; }
        [Display(Name = "Расчетный год"), Required(ErrorMessage = "{0} - обязательное поле")] 
        [Range(1980, 2100, ErrorMessage = "Расчетный год должет быть в диапазоне {1} - {2}")]
        public int Year { get; set; }
        [Display(Name = "Сумма к оплате"), Required(ErrorMessage = "{0} - обязательное поле")]
        [DataType(DataType.Currency, ErrorMessage ="Значение должно быть числом")]
        public double Sum { get; set; }
        [Display(Name = "Сумма задолженности")]
        [DataType(DataType.Currency, ErrorMessage = "Значение должно быть числом")]
        public decimal Debt { get; set; }
        [Display(Name = "Пеня")]
        [DataType(DataType.Currency, ErrorMessage = "Значение должно быть числом")]
        public decimal Penalty { get; set; }
        [Display(Name = "Сумма оплаты")]
        [DataType(DataType.Currency, ErrorMessage = "Значение должно быть числом")]
        public double? PaymentSum { get; set; }
        [Display(Name = "Дата оплаты")]
        public DateTime? PaymentDate { get; set; }
        [Display(Name = "Примечание"), DataType(DataType.MultilineText)]
        [StringLength(10, ErrorMessage ="Размер сообщения не более 4000 символов")]
        public string Note { get; set; }

        public List<SelectListItem> KindList { get; set; }
        public List<SelectListItem> ProviderList { get; set; }
        public List<SelectListItem> MonthList { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels.Invoice
{
    public class InvoiceListVM
    {
        public int Id { get; set; }
        [Display(Name ="№ квитанции")]
        public string InvoiceNum { get; set; }
        [Display(Name = "Тип квитанции")]
        public string InvoiceTypeName { get; set; }
        [Display(Name = "Поставщик")]
        public string InvoiceProviderName { get; set; }
        [Display(Name = "За период")]
        public string InvoiceDate { get; set; }
        [Display(Name = "Сумма к оплате")]
        public double InvoiceSum { get; set; }
        [Display(Name = "Оплачено")]
        public double? PaymentSum { get; set; }
    }
}

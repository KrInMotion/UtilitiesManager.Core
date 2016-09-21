using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels.Invoice
{
    public class InvoiceDetailVM
    {
        public int Id { get; set; }
        [Display(Name ="№ квитанции")]
        public string Number { get; set; }
        [Display(Name = "Тип квитанции")]
        public string KindName { get; set; }
        [Display(Name = "Поставщик")]
        public string ProviderName { get; set; }
        [Display(Name = "За период")]
        public string InvoiceDate { get; set; }
        [Display(Name = "Сумма к оплате"), DataType(DataType.Currency)]
        public decimal Sum { get; set; }
        [Display(Name = "Оплачено"), DataType(DataType.Currency)]
        public decimal? PaymentSum { get; set; }
        [Display(Name = "Дата оплаты")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString ="{0:d}")]
        public DateTime? PaymentDate { get; set; }
        [Display(Name = "Дата создания")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime CreatedAt { get; set; }
    }
}

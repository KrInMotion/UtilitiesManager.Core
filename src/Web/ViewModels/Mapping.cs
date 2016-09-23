using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data.Entities;
using Web.ViewModels.Provider;
using Web.ViewModels.Invoice;

namespace Web.ViewModels
{
    public static class Mapping
    {
        public static void Initialize()
        {
            Mapper.Initialize(config =>
            {
                //InvoiceProvider
                config.CreateMap<ProviderVM, Web.Data.Entities.Provider>();
                config.CreateMap<Web.Data.Entities.Provider, ProviderVM>();
                //Invoice -> InvoiceListVM
                config.CreateMap<Web.Data.Entities.Invoice, InvoiceListVM>()
                    .ForMember(dest => dest.KindName, opt=>opt.MapFrom(src=>src.Kind.KindName))
                    .ForMember(dest => dest.ProviderName, opt => opt.MapFrom(src => src.Provider.ProviderName))
                    .ForMember(dest => dest.InvoiceDate, opt => opt.MapFrom(src => $"{src.Month.MonthName} {src.Year.ToString()}"))
                    .ForMember(dest => dest.RowStyle, opt => opt.MapFrom(src => SetRowColor(src.Sum, src.PaymentSum, src.Debt, src.Penalty)))
                    .ForMember(dest => dest.Finance, opt => opt.MapFrom(src => CalcFinance(src.Sum, src.PaymentSum, src. Debt, src.Penalty)));
                //InvoiceFormVM -> Invoice
                config.CreateMap<InvoiceFormVM, Web.Data.Entities.Invoice>();
                //Invoice -> InvoiceFormVM
                config.CreateMap<Web.Data.Entities.Invoice, InvoiceFormVM>()
                    .ForMember(dest => dest.DocumentId, opt => opt.MapFrom(src => src.Id));
                //Invoice -> InvoiceDetailVM
                config.CreateMap<Web.Data.Entities.Invoice, InvoiceDetailVM>()
                    .ForMember(dest => dest.KindName, opt => opt.MapFrom(src => src.Kind.KindName))
                    .ForMember(dest => dest.ProviderName, opt => opt.MapFrom(src => src.Provider.ProviderName))
                    .ForMember(dest => dest.InvoiceDate, opt => opt.MapFrom(src => $"{src.Month.MonthName} {src.Year.ToString()}"));
            });
        }

        private static string SetRowColor(decimal sum, decimal paymentSum, decimal debt, decimal penalty)
        {
            if (sum == paymentSum && debt==0 && penalty==0 )
            {
                return "success";
            }
            if (debt > 0) return "danger";
            if (penalty > 0) return "warning";

            return "info";
        }

        private static string CalcFinance(decimal sum, decimal paymentSum, decimal debt, decimal penalty)
        {
            return $"{sum.ToString()}/{paymentSum.ToString()}/{debt}/{penalty}";
        }
    }
}

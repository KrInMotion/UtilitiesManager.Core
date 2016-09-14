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
                //Invoice
                config.CreateMap<Web.Data.Entities.Invoice, InvoiceListVM>()
                    .ForMember(dest => dest.KindName, opt=>opt.MapFrom(src=>src.Kind.KindName))
                    .ForMember(dest => dest.ProviderName, opt => opt.MapFrom(src => src.Provider.ProviderName))
                    .ForMember(dest => dest.InvoiceDate, opt => opt.MapFrom(src => $"{src.Month.MonthName} {src.Year.ToString()}"))
                    .ForMember(dest=>dest.RowStyle, opt => opt.MapFrom(src => (src.PaymentSum != 0) ? "success": string.Empty));
                config.CreateMap<InvoiceFormVM, Web.Data.Entities.Invoice>();
                config.CreateMap<Web.Data.Entities.Invoice, InvoiceFormVM>();
            });
        }
    }
}

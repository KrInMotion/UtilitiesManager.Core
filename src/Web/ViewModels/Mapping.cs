using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data.Entities;
using Web.ViewModels.InvoiceProvider;
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
                config.CreateMap<InvoiceProviderVM, Web.Data.Entities.InvoiceProvider>();
                config.CreateMap<Web.Data.Entities.InvoiceProvider, InvoiceProviderVM>();
                //Invoice
                config.CreateMap<Web.Data.Entities.Invoice, InvoiceListVM>()
                    .ForMember(dest=>dest.InvoiceTypeName, opt=>opt.MapFrom(src=>src.InvoiceType.InvoiceTypeName))
                    .ForMember(dest => dest.InvoiceProviderName, opt => opt.MapFrom(src => src.InvoiceProvider.InvoiceProviderName))
                    .ForMember(dest => dest.InvoiceDate, opt => opt.MapFrom(src => $"{src.Month.MonthName} {src.InvoiceYear.ToString()}"));
                config.CreateMap<InvoiceFormVM, Web.Data.Entities.Invoice>()
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.Now));
            });
        }
    }
}

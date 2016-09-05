using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewModels.InvoiceProvider;
using Web.Data.Entities;

namespace Web.ViewModels
{
    public static class Mapping
    {
        public static void Initialize()
        {
            Mapper.Initialize(config =>
            {
                //InvoiceProvider
                config.CreateMap<InvoiceProviderVM, Web.Data.Entities.InvoiceProvider>().ReverseMap();
            });
        }
    }
}

using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        //IOC Container'da her bir IProductService isteğine karşılık olarak bir tane ProductService nesnesi üretecek. Buradaki extention metodu yazılmalıdır. Bu extention metodu IoC Container'a gönderilecek.
        //Extention Metod
        public static void AddPersistenceServices( this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}

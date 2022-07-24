using Autofac;
using Autofac.Extensions.DependencyInjection;
using Mobiliva.Business.Abstract;
using Mobiliva.Business.Concrete;
using Mobiliva.DataAccess.Abstract;
using Mobiliva.DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Services.AddControllersWithViews();
builder.Services.AddControllers();

builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterType<ProductManager>().As<IProductService>());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterType<EfProductDal>().As<IProductDal>());

builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterType<OrderManager>().As<IOrderService>());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterType<EfOrderDal>().As<IOrderDal>());

builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterType<OrderDetailManager>().As<IOrderDetailService>());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterType<EfOrderDetailDal>().As<IOrderDetailDal>());

builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterType<ProductDetailManager>().As<IProductDetailService>());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterType<EfProductDetailDal>().As<IProductDetailDal>());

builder.Services.AddMemoryCache();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

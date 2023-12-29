using Microsoft.AspNetCore.Http.Features;
using BLL;
using BOL;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/pranav", () => {
    CatalogManager mgr=new CatalogManager();
    List<Product> products=mgr.GetAllProducts();
    return products;
});

app.MapPost("/postt",()=>{
    CatalogManager mgr=new CatalogManager();
    List<Product> products=mgr.GetAllProducts();
    return products;
});

app.MapDelete("/del",()=>{
     CatalogManager mgr=new CatalogManager();
    List<Product> products=mgr.GetAllProducts();
    return products;
});

app.MapPut("/put",()=>{
     CatalogManager mgr=new CatalogManager();
    List<Product> products=mgr.GetAllProducts();
    return products;
});

app.Run();

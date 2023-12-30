using BOL;
using DAL;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.MapGet("/", () => "Hello World!");

app.MapGet("/somesh/product", () => {
    List<Product> plist=DBManager.GetAllProducts();
    return plist;
});
app.MapPost("/somesh/product/post/{index}", (int index) => {
    Console.WriteLine("Data post successfully");
    Console.WriteLine("Index "+index);
    List<Product> plist=DBManager.GetAllProducts();
    Product p=plist.Find((a)=>a.Id==index);
    return p;
});
app.MapDelete("/somesh/product/delete", () => {
   Console.WriteLine("Deleted!!!");
});

app.Run();

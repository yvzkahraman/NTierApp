// See https://aka.ms/new-console-template for more information
using NTierApp.Business.Managers;

var productManager = new ProductManager();

var list =  productManager.GetProducts();

foreach (var item in list)
{
    Console.WriteLine("item :"+item.Name);
}

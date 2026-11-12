using AddisEats.Api.Models;

MenuItem item1 = new MenuItem(1, "Burger", "food", 10.5m);
// Console.WriteLine(item1.Id);
// Console.WriteLine("Test");

List<MenuItem> myMenuItems = new List<MenuItem>
{
    new MenuItem(1, "Burger", "Food", 10.5m),
    new MenuItem(2, "Pizza", "Food", 15.0m),
    new MenuItem(3, "Coke", "Drink", 2.5m),
    new MenuItem(4, "Water", "Drink", 1.0m),
    new MenuItem(5, "Salad", "Food", 8.0m),
    new MenuItem(6, "Fries", "Food", 3.5m),
    new MenuItem(7, "Ice Cream", "Dessert", 4.0m)
};

//! -------------- LinQ-------------

var foodgreaterThan5 = myMenuItems.Where(i => i.Price > 2m).OrderBy(i => i.Name);

foreach(var i in foodgreaterThan5)
{
    Console.WriteLine(i.Name);
} 
//          myMenuItems = [
//      {Id:1, Name:"Burger", Category:"Food", Price:10.5m},
//      {Id:2, Name:"Pizza", Category:"Food", Price:15.0m},
// ]

// myMenuItem[1].Name


// Console.WriteLine(myMenuItems[1].Name);


// using AddisEats.Api.Services.MenuItemServices;
// using AddisEats.Api.Services.RestaurantServices;

// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container

// builder.Services.AddControllers();
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();
// builder.Services.AddScoped<IMenuItemService, MenuItemService>()
// builder.Services.AddScoped<IRestaurantService, RestaurantService>();

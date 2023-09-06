using Microsoft.EntityFrameworkCore;
using ParkView.Models;
using Microsoft.AspNetCore.Identity;
using System.Composition;
using System.Text.Json.Serialization;

namespace ParkView
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IRoom, RoomDbRepo>();
            builder.Services.AddScoped<IRoomCategory, RoomCategoryDbRepo>();
            builder.Services.AddScoped<IHotel, HotelDbRepo>();
            builder.Services.AddScoped<IBookingRoom, BookinRoomDbRepo>();
            // Add services to the container.
            builder.Services.AddControllersWithViews()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<HotelDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<HotelDbContext>();

            builder.Services.AddAuthentication().AddGoogle(
                googleoptions =>
                {
                    googleoptions.ClientId = builder.Configuration["Authentication:Google:ClientId"];
                    googleoptions.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"];
                });

            builder.Services.AddScoped<BookingCart>(sp => BookingCart.GetCart(sp));
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddSession();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }



            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();

            app.Run();
        }
    }
}
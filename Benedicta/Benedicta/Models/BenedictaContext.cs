using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Benedicta.Models
{
    public class BenedictaContext:DbContext
    {
        public BenedictaContext():base ("BenedictaContext")
        {

        }
        DbSet<About> Abouts { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<ContactForm> ContactForms { get; set; }
        DbSet<Menu> Menus { get; set; }
        DbSet<MenuUpdate> MenuUpdates { get; set; }
        DbSet<News> News { get; set; }
        DbSet<Property> Propertys { get; set; }
        DbSet<Reservation> Reservations { get; set; }
        DbSet<ReserveTable> ReserveTables { get; set; }
        DbSet<Service> Services { get; set; }
        DbSet<Setting> Settings { get; set; }
        DbSet<Slider> Sliders { get; set; }
        DbSet<Tea> Teas { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Welcome> Welcomes { get; set; }

    }

}
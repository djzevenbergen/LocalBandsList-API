using Microsoft.EntityFrameworkCore;

namespace LocalBandsList.Models
{
  public class LocalBandsListContext : DbContext
  {
    public LocalBandsListContext(DbContextOptions<LocalBandsListContext> options)
        : base(options)
    {
    }

    public DbSet<Band> Bands { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Band>()
      .HasData(
      new Band { BandId = 10, Name = "Jeff's Burritos", Description = "A bold, bland take on the popular California burrito", PhoneNumber = "4355552221", Type = "restaurant", WebSite = "https://www.google.com/", UserId = 1 },
      new Band { BandId = 11, Name = "Juan's Pizza Palace", Description = "Pizza with an inexplicably spicy twist.", PhoneNumber = "8468618684", Type = "restaurant", WebSite = "castor oil", UserId = 2 },
      new Band { BandId = 2, Name = "Joly Jands Joliday Joopla", Description = "Holiday specialities from your favorite Latinx nuns!", PhoneNumber = "7878799456", Type = "restaurant", WebSite = "https://www.google.com/", UserId = 2 },
      new Band { BandId = 3, Name = "Don't Eat Anywhere Else", Description = "The only place you're allowed to eat... Ever...", PhoneNumber = "3743453457", Type = "restaurant", WebSite = "https://www.google.com/", UserId = 1 },
      new Band { BandId = 4, Name = "Mycelium and Moss", Description = "Your local purveyor of creeping slimes and fuzzy foilage.", PhoneNumber = "9757567677", Type = "shop", WebSite = "https://www.google.com/", UserId = 2 },
      new Band { BandId = 5, Name = "The Soap Shop", Description = "Get clean and smell great.", PhoneNumber = "3684568654", Type = "shop", WebSite = "https://www.google.com/", UserId = 1 },
      new Band { BandId = 6, Name = "Get Wellness!", Description = "We got all the healthy stuff here", PhoneNumber = "8141465465", Type = "shop", WebSite = "https://www.google.com/", UserId = 2 },
      new Band { BandId = 7, Name = "I Need", Description = "For whatever you need.", PhoneNumber = "6565656565", Type = "shop", WebSite = "lemon", UserId = 1 },
      new Band { BandId = 8, Name = "Good Times Clock Shop", Description = "We have clocks in all the timezones.", PhoneNumber = "9876543212", Type = "shop", WebSite = "https://www.google.com/", UserId = 2 },
      new Band { BandId = 9, Name = "Zebra Print Bread", Description = "We make bread that's partially toasted", PhoneNumber = "0212121212", Type = "restaurant", WebSite = "https://www.google.com/", UserId = 1 }
      );

      builder.Entity<User>()
      .HasData(
        new User { Id = 1, FirstName = "David", LastName = "Zevenbergen", Username = "DJTest", Password = "test" }
      );
    }
  }
}
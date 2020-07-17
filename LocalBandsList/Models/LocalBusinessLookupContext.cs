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
      new Band { BandId = 10, Name = "Your Friend Deej", Genre = "indie", Bio = "Just me, bein' Deej.", YearFormed = "2015", VideoLink = "https://www.youtube.com/watch?v=zRmL4tVbs6Y", MusicLink = "https://soundcloud.com/yourfrienddeej/i-fell-in-love-with-a-postcard", ZipCode = "98020", Gigging = false, Together = true, UserId = 1 },
      new Band { BandId = 9, Name = "Jammy Jr.", Genre = "synth pop", Bio = "Jammy Jr. is an odd blend of chiptunes and whispery-soul", YearFormed = "2017", VideoLink = "https://vimeo.com/286650646", MusicLink = "https://soundcloud.com/jammyjr/5-computer-time-house", ZipCode = "98020", Gigging = false, Together = true, UserId = 1 },
      new Band { BandId = 8, Name = "Dad Friendly", Genre = "indie pop", Bio = "Hopeful Mac Demarco-lookin asses trying to make something fun", YearFormed = "2019", VideoLink = "", MusicLink = "", ZipCode = "98109", Gigging = false, Together = true, UserId = 1 },
      new Band { BandId = 7, Name = "CON", Genre = "rock", Bio = "A group of jabronies that liked to rock", YearFormed = "2013", VideoLink = "", MusicLink = "https://soundcloud.com/wearecon/allison", Gigging = false, Together = false, UserId = 1 },
      new Band { BandId = 6, Name = "Smooth Richard", Genre = "psychedelic rock", Bio = "A well-oiled rock machine, pumping out tunes for early-morning smoke sessions", YearFormed = "2017", VideoLink = "", MusicLink = "https://soundcloud.com/smoothrichard/lintfire", ZipCode = "98125", Gigging = true, Together = true, UserId = 1 },
      new Band { BandId = 5, Name = "bad gravity", Genre = "IDM", Bio = "Vibe out with this understated electronic duo", YearFormed = "2018", VideoLink = "", MusicLink = "https://soundcloud.com/crystalssquad/hover-board", ZipCode = "98109", Gigging = true, Together = true, UserId = 1 }

      );

      builder.Entity<User>()
      .HasData(
        new User { Id = 1, FirstName = "David", LastName = "Zevenbergen", Username = "DJTest", Password = "test" }
      );
    }
  }
}
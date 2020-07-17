using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace LocalBandsList.Models
{
  public class Band : IValidatableObject
  {
    public int BandId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    public string Genre { get; set; }
    [StringLength(300)]
    public string Bio { get; set; }
    public string Email { get; set; }
    public int YearFormed { get; set; }
    public string VideoLink { get; set; }
    public string MusicLink { get; set; }
    public string ZipCode { get; set; }
    public int UserId { get; set; }
    public bool Gigging { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      List<string> genre = new List<string> { "restaurant", "shop" };

      if (!genre.Contains(Genre))
      {
        yield return new ValidationResult(
            $"Please either use {types[0]} or {types[1]}",
            new[] { "Type" });
      }
    }

  }
}
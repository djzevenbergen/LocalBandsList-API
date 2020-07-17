
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LocalBandsList.Models;
using Microsoft.AspNetCore.Authorization;
using LocalBandsList.Services;
using Microsoft.EntityFrameworkCore;


namespace LocalBandsList.Controllers
{
  [ApiVersion("1.0")]
  [Route("api/bands")]
  [ApiController]
  public class BandesController : ControllerBase
  {
    private LocalBandsListContext _db;

    private IUserService _userService;

    public BandesController(LocalBandsListContext db, IUserService userService)
    {
      _db = db;
      _userService = userService;
    }

    // POST api/Bands
    [Authorize]
    [HttpPost]
    public void Post([FromBody] Band band)
    {
      _db.Bands.Add(band);
      _db.SaveChanges();
    }

    // GET api/Bands/#
    [HttpGet("{id}")]
    public ActionResult<Band> Get(int id)
    {
      return _db.Bands.FirstOrDefault(entry => entry.BandId == id);
    }

    //PUT api/Bands/userId/BandId
    [Authorize]
    [HttpPut("{userId}/{id}")]
    public void Put(int userId, int id, [FromBody] Band band)
    {
      band.BandId = id;
      if (band.UserId == userId)
      {
        _db.Entry(band).State = EntityState.Modified;
        _db.SaveChanges();
      }
    }

    //http://localhost:5000/api/Bands/1/9
    [Authorize]
    [HttpDelete("{userId}/{id}")]
    public void Delete(int id, int userId)
    {
      var bandToDelete = _db.Bands.FirstOrDefault(entry => entry.BandId == id);
      if (bandToDelete.UserId == userId)
      {
        _db.Bands.Remove(bandToDelete);
        _db.SaveChanges();
      }
    }

    [HttpGet("random")]
    public ActionResult<Band> Random()
    {
      var query = _db.Bands.AsQueryable().ToList();
      List<int> idList = new List<int>();


      foreach (Band b in query)
      {
        idList.Add(b.BandId);
      }

      Random rand = new Random();
      int r = rand.Next(0, idList.Count);
      Console.WriteLine(r);
      return query[r];

    }


    // GET api/Bands
    [HttpGet]
    // public ActionResult<IEnumerable<Remedy>> Get(string name, string details, string ailment, string category, string ingredients, int userId)
    public ActionResult<Dictionary<string, object>> Get(string name, string type, string description, string phoneNumber, string webSite, int userId)
    {
      var query = _db.Bands.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name.ToLower().Contains(name.ToLower()));
      }

      if (type != null)
      {
        query = query.Where(entry => entry.Type.ToLower().Contains(type.ToLower()));
      }

      if (description != null)
      {
        query = query.Where(entry => entry.Description.ToLower().Contains(description.ToLower()));
      }

      if (phoneNumber != null)
      {
        query = query.Where(entry => entry.PhoneNumber == phoneNumber);
      }

      if (webSite != null)
      {
        query = query.Where(entry => entry.WebSite == webSite);
      }

      if (userId != 0)
      {
        query = query.Where(entry => entry.UserId == userId);
      }
      Dictionary<string, object> response = new Dictionary<string, object>();
      List<string> version = new List<string> { "version 1" };
      List<string> types = new List<string> { "restaurant", "shop" };
      response.Add("version", version);
      response.Add("types", types);
      response.Add("bands", query);
      return response;
    }
  }

  // [ApiVersion("2.0")]
  // [Route("api/bands")]
  // [ApiController]
  // public class BandesV2Controller : ControllerBase
  // {
  //   private LocalBandsListContext _db;

  //   private IUserService _userService;

  //   public BandesV2Controller(LocalBandsListContext db, IUserService userService)
  //   {
  //     _db = db;
  //     _userService = userService;
  //   }

  //   // POST api/Bands
  //   [Authorize]
  //   [HttpPost]
  //   public void Post([FromBody] Band band)
  //   {
  //     _db.Bands.Add(band);
  //     _db.SaveChanges();
  //   }

  //   // GET api/Bands/#
  //   [HttpGet("{id}")]
  //   public ActionResult<Band> Get(int id)
  //   {
  //     return _db.Bands.FirstOrDefault(entry => entry.BandId == id);
  //   }

  //   //PUT api/Bands/userId/BandId
  //   [Authorize]
  //   [HttpPut("{userId}/{id}")]
  //   public void Put(int userId, int id, [FromBody] Band band)
  //   {
  //     band.BandId = id;
  //     if (band.UserId == userId)
  //     {
  //       _db.Entry(band).State = EntityState.Modified;
  //       _db.SaveChanges();
  //     }
  //   }

  //   //http://localhost:5000/api/Bands/1/9
  //   [Authorize]
  //   [HttpDelete("{userId}/{id}")]
  //   public void Delete(int id, int userId)
  //   {
  //     var bandToDelete = _db.Bands.FirstOrDefault(entry => entry.BandId == id);
  //     if (bandToDelete.UserId == userId)
  //     {
  //       _db.Bands.Remove(bandToDelete);
  //       _db.SaveChanges();
  //     }
  //   }

  //   [HttpGet("random")]
  //   public ActionResult<Band> Random()
  //   {
  //     var query = _db.Bands.AsQueryable().ToList();
  //     List<int> idList = new List<int>();


  //     foreach (Band b in query)
  //     {
  //       idList.Add(b.BandId);
  //     }

  //     Random rand = new Random();
  //     int r = rand.Next(0, idList.Count);
  //     Console.WriteLine(r);
  //     return query[r];

  //   }


  //   // GET api/Bands
  //   [HttpGet]
  //   // public ActionResult<IEnumerable<Remedy>> Get(string name, string details, string ailment, string category, string ingredients, int userId)
  //   public ActionResult<Dictionary<string, object>> Get(string name, string type, string description, string phoneNumber, string webSite, int userId)
  //   {
  //     var query = _db.Bands.AsQueryable();

  //     if (name != null)
  //     {
  //       query = query.Where(entry => entry.Name.ToLower().Contains(name.ToLower()));
  //     }

  //     if (type != null)
  //     {
  //       query = query.Where(entry => entry.Type.ToLower().Contains(type.ToLower()));
  //     }

  //     if (description != null)
  //     {
  //       query = query.Where(entry => entry.Description.ToLower().Contains(description.ToLower()));
  //     }

  //     if (phoneNumber != null)
  //     {
  //       query = query.Where(entry => entry.PhoneNumber == phoneNumber);
  //     }

  //     if (webSite != null)
  //     {
  //       query = query.Where(entry => entry.WebSite == webSite);
  //     }

  //     if (userId != 0)
  //     {
  //       query = query.Where(entry => entry.UserId == userId);
  //     }
  //     Dictionary<string, object> response = new Dictionary<string, object>();
  //     List<string> version = new List<string> { "version 2" };
  //     List<string> types = new List<string> { "restaurant", "shop" };
  //     response.Add("version", version);
  //     response.Add("types", types);
  //     response.Add("bands", query);
  //     return response;
  //   }
  // }
}
using Microsoft.AspNetCore.Mvc;
using Catalogue.Models;
using System.Collections.Generic;

namespace Catalogue.Controllers
{
  public class SongsController : Controller
  {

    [HttpGet("/albums/{albumId}/songs/new")]
    public ActionResult New(int albumId)
    {
      Album album = Album.Find(albumId);
      return View(album);
    }

    [HttpGet("/albums/{albumId}/songs/{songId}")]
    public ActionResult Show(int albumId, int songId)
    {
      Song song = Song.Find(songId);
      Album album = Album.Find(albumId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("song", song);
      model.Add("album", album);
      return View(model);
    }
  }
}
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Catalogue.Models;

namespace Catalogue.Controllers
{
  public class AlbumsController : Controller
  {
    [HttpGet("/albums")]
    public ActionResult Index()
    {
      List<Album> allAlbum = Album.GetAll();
      return View(allAlbum);
    }

    [HttpGet("/albums/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/albums")]
    public ActionResult Create(string albumName)
    {
      Album newAlbum = new Album(albumName);
      return RedirectToAction("Index");
    }

    [HttpGet("/albums/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Album selectedAlbum = Album.Find(id);
      List<Song> albumSongs = selectedAlbum.Songs;
      model.Add("album", selectedAlbum);
      model.Add("songs", albumSongs);
      return View(model);
    }
    // this one creates new songs within a given album, not new albums;
    [HttpPost("/albums/{albumId}/songs")]
    public ActionResult New(int albumId, string songDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Album foundAlbum = Album.Find(albumId);
      Song newSong = new Song(songDescription);
      foundAlbum.AddSong(newSong);
      List<Song> albumSongs = foundAlbum.Songs;
      model.Add("songs", albumSongs);
      model.Add("album", foundAlbum);
      return View("Show", model);
    }


  }
}
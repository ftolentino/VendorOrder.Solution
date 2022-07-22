using System.Collections.Generic;

namespace Catalogue.Models
{
  public class Album
  {
    private static List<Album> _instances = new List<Album> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Song> Songs { get; set; }
  

  public Album(string albumName)
  {
    Name = albumName;
    _instances.Add(this);
    Id = _instances.Count;
    Songs = new List<Song>{};
  }

  public static void ClearAll()
  {
    _instances.Clear();
  }

  public static List<Album> GetAll()
  {
    return _instances;
  }

  public static Album Find(int searchId)
  {
    return _instances[searchId-1];
  }

  public void AddSong(Song song)
  {
    Songs.Add(song);
  }

}
}
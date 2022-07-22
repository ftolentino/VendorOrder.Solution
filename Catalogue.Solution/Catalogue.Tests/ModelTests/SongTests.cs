using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Catalogue.Models;
using System;

namespace Catalogue.Tests
{
  [TestClass]
  public class SongTests : IDisposable
  {

    public void Dispose()
    {
      Song.ClearAll();
    }

    [TestMethod]
    public void SongConstructor_CreatesInstanceOfSong_Song()
    {
      Song newSong = new Song("test");
      Assert.AreEqual(typeof(Song), newSong.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";

      //Act
      Song newSong = new Song(description);
      string result = newSong.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Song newSong = new Song(description);

      //Act
      string updatedDescription = "Do the dishes";
      newSong.Description = updatedDescription;
      string result = newSong.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_SongList()
    {
      // Arrange
      List<Song> newList = new List<Song> { };

      // Act
      List<Song> result = Song.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsSongs_SongList()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Song newSong1 = new Song(description01);
      Song newSong2 = new Song(description02);
      List<Song> newList = new List<Song> { newSong1, newSong2 };

      //Act
      List<Song> result = Song.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_SongsInstantiateWithAnIdAndGetterReturn_Int()
    {
      string description = "walk the dog.";
      Song newSong = new Song(description);
      int result = newSong.Id;
      Assert.AreEqual(1,result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectItem_Song()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Song newSong1 = new Song(description01);
      Song newSong2 = new Song(description02);

      //Act
      Song result = Song.Find(2);

      //Assert
      Assert.AreEqual(newSong2, result);
    }
  }
}
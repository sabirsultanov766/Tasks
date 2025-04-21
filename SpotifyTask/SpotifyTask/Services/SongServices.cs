using SpotifyTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace SpotifyTask.Services
{
    public class SongServices
    {

       public  void CreateSong()
        {
            Song song = new Song();
            Playlist.songs.Add(song);
        }
        public void UpdateSong(int id, Song song)
        {
            foreach (var s in Playlist.songs)
            {
                if (s.ID == id)
                {
                    s.SongName = song.SongName;
                    s.ArtistName = song.ArtistName;
                    s.Genre = song.Genre;
                    s.Duration = song.Duration;
                }
            }
        }
        public Song Read(int id)
        {
            foreach(var song in Playlist.songs)
            {
                if(song.ID == id)
                {
                    return song;
                }
                
            }
            throw new Exception($"{id}-li Mahnı yoxdur");
        }
        public  void Delete(int id)
        {
            foreach(var playlist in Playlist.playlists)
            {   
                if(playlist.Playlistİd== id)
                {
                    Playlist.playlists.Remove(playlist);
                }
            }
        }




    }
}

using SpotifyTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace SpotifyTask.Models
{
    public class Playlist
    {   
        
        private int _playlistId = 1;
        public int Playlistİd { get;}
        public string playlistName;
        public static List<Song> songs = new List<Song>();
        public static List<Playlist> playlists = new List<Playlist>();

       
     public List<Song> FilterByArtistName(string ArtistName)
        {
            List<Song> Songs = new List<Song>();
            foreach(Song s in Playlist.songs)
            {
                if (s.ArtistName.Contains(ArtistName))
                {
                    Songs.Add(s);
                }
            }
            return Songs;
        }
    public List<Song> FilterBySongName(string Name)
        {
            List<Song> Songs = new List<Song>();
            foreach (Song s in Playlist.songs)
            {
                if (s.SongName == Name)
                {
                    Songs.Add(s);
                }
            }
            return Songs;
        }
    public List<Song> FilterByGenre(Genre genre)
        {
            List<Song> Songs = new List<Song>();
            foreach (Song s in Playlist.songs)
            {
                if (s.Genre == genre)
                {
                    Songs.Add(s);
                }
            }
            return Songs;

        }


    }
}

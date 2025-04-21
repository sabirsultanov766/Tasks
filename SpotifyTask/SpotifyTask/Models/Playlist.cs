using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpotifyTask.Models
{
    public class Playlist
    {   
        
        private int _playlistId = 1;
        public int Playlistİd { get;}
        public string playlistName;
        public static List<Song> songs = new List<Song>();
        public static List<Playlist> playlists = new List<Playlist>();

        

    }
}

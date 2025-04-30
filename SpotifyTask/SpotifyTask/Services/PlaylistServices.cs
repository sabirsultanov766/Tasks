using SpotifyTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyTask.Services
{
    public class PlaylistServices
    {
        public void CreatePlaylist()
        {
            Playlist playlist = new Playlist();
            Playlist.playlists.Add(playlist);
        }
        public void UpdateSong(int id, Playlist playlist)
        {
            foreach (var s in Playlist.playlists)
            {
                if (s.Playlistİd == id)
                {
                    s.playlistName = playlist.playlistName;
                }
            }
        }
        public Song Read(int id)
        {
            foreach (var song in Playlist.songs)
            {
                if (song.ID == id)
                {
                    return song;
                }

            }
            throw new Exception($"{id}-li Mahnı yoxdur");
        }
        public void Delete(int id)
        {
            foreach (var playlist in Playlist.playlists)
            {
                if (playlist.Playlistİd == id)
                {
                    Playlist.playlists.Remove(playlist);
                }
            }
        }


    }
}

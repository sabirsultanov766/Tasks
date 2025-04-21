using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyTask.Enums;
namespace SpotifyTask.Models;

public class Song //internal qeyd etmeyimizin sebebi eyni proyekt daxilinde el catan olmagidir
{
    private static int _songId = 1;
    public int ID { get; }
    public string SongName;
    public List<string> ArtistName;
    public int Duration; //Saniye Ile
    public Genre Genre;
}



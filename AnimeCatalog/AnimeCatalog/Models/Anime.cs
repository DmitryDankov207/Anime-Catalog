using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace AnimeCatalog.Models
{
    public class Anime
    {
        public string ImageSource { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ObservableCollection<string> Types { get; set; }
        public bool IsJapanish { get; set; }
        public bool IsOngoing { get; set; }
        public DateTime ReleaseDate { get; set; }
        public float Rated { get; set; }
        public int ViewCount { get; set; }
        public ObservableCollection<string> Series { get; set; }
        public int SeriesCount { get; set; }
    }
}

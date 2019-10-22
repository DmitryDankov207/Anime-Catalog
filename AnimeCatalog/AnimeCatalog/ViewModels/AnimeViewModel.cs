using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using AnimeCatalog.Models;

namespace AnimeCatalog.ViewModels
{
    public class AnimeViewModel : INotifyPropertyChanged
    {
        private Anime _anime;

        AnimeListViewModel _lvm;

        public AnimeViewModel()
        {
            ListViewModel = new AnimeListViewModel();
            _anime = new Anime()
            {
                Types = new ObservableCollection<string>(),
                Series = new ObservableCollection<string>()
            };
        }

        public AnimeListViewModel ListViewModel
        {
            get => _lvm;
            set
            {
                if(_lvm != value)
                {
                    _lvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }

        public string Name 
        { 
            get => _anime.Name;
            set
            {
                if(_anime.Name != value)
                {
                    _anime.Name = value; 
                    OnPropertyChanged("Name");
                } 
            }
        }

        public string Description
        {
            get => _anime.Description;
            set
            {
                if (_anime.Description != value)
                {
                    _anime.Description = value;
                    OnPropertyChanged("Description");
                }

            }
        }

        public ObservableCollection<string> Types
        {
            get => _anime.Types;
            set
            {
                if (_anime.Types != value)
                {
                    _anime.Types = value;
                    OnPropertyChanged("Types");
                }

            }
        }

        public bool IsJapanish
        {
            get => _anime.IsJapanish;
            set
            {
                if (_anime.IsJapanish != value)
                {
                    _anime.IsJapanish = value;
                    OnPropertyChanged("IsJapanish");
                }

            }
        }

        public bool IsOngoing
        {
            get => _anime.IsOngoing;
            set
            {
                if (_anime.IsOngoing != value)
                {
                    _anime.IsOngoing = value;
                    OnPropertyChanged("IsOngoing");
                }

            }
        }

        public DateTime ReleaseDate
        {
            get => _anime.ReleaseDate;
            set
            {
                if (_anime.ReleaseDate != value)
                {
                    _anime.ReleaseDate = value;
                    OnPropertyChanged("ReleaseDate");
                }

            }
        }

        public float Rated
        {
            get => _anime.Rated;
            set
            {
                if (_anime.Rated != value)
                {
                    _anime.Rated = value;
                    OnPropertyChanged("Rated");
                }

            }
        }

        public int ViewCount
        {
            get => _anime.ViewCount;
            set
            {
                if (_anime.ViewCount != value)
                {
                    _anime.ViewCount = value;
                    OnPropertyChanged("ViewCount");
                }

            }
        }

        public ObservableCollection<string> Series
        {
            get => _anime.Series;
            set
            {
                if (_anime.Series != value)
                {
                    _anime.Series = value;
                    OnPropertyChanged("Series");
                }

            }
        }

        public int SeriesCount
        {
            get => _anime.SeriesCount;
            set
            {
                if (_anime.SeriesCount != value)
                {
                    _anime.SeriesCount = value;
                    OnPropertyChanged("SeriesCount");
                }

            }
        }

        public string ImageSource
        { get => _anime.ImageSource; 
            set
            {
                if (_anime.ImageSource != value)
                {
                    _anime.ImageSource = value;
                    OnPropertyChanged("ImageSource");
                }

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

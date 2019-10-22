using AnimeCatalog.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AnimeCatalog.Models
{
    public class AnimeCollection : ObservableCollection<AnimeViewModel>, IEnumerable<AnimeViewModel>
    {

    }

    /*public class AnimeCollection : KeyedCollection<string, Anime>, IEnumerable<Anime>
    {
        protected override string GetKeyForItem(Anime item)
        {
            string key = this.GetKeyForItem(item);
            if (key == null) throw new ArgumentNullException("invalid key!");

            return key;
        }

    }*/
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPworkshop.Domain.Media
{
    public class MediaCollection
    {
        Dictionary<int, Media> library;
        public MediaCollection() { library = new Dictionary<int, Media>(); }
        Media GetMedia(int ID)
        {
            if (library.TryGetValue(ID, out var media))
                return media;
            else
                return null;

        }
        public bool IsAvalible(int ID) { return GetMedia(ID).IsAvailable(); }
        public void AddMedia(int ID, Media media) { library.Add(ID,media); }
        public void RemoveMedia(int ID) 
        {
            library.Remove(ID);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAPIExample.Track
{
    public class Track
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ComposerId { get; set; }
        public string Genre { get; set; }
        public string ComposerName { get; set; }

        public override bool Equals(Object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
                return false;

            var p = (Track)obj;
            return
                Id == p.Id
                && Title == p.Title
                && ComposerId == p.ComposerId
                && Genre == p.Genre
                && ComposerName == p.ComposerName;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

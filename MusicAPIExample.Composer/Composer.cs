using System;

namespace MusicAPIExample.Composer
{
    public class Composer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Award { get; set; }

        public override bool Equals(Object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
                return false;

            var p = (Composer)obj;
            return
                Id == p.Id
                && FirstName == p.FirstName
                && LastName == p.LastName
                && Title == p.Title
                && Award == p.Award;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

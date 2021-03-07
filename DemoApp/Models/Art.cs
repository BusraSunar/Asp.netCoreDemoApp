using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    public class Art
    {

        public int Id { get; set; }

        public String ArtName { get; set; }

        public String ArtistName { get; set; }

        public byte[] Image { get; set; }

        public Art()
        {

        }

    }
}

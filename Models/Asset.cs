using System;
using System.Collections.Generic;

namespace AssetsAPI_AdrianMorales.Models
{
    public partial class Asset
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public decimal Cost { get; set; }
    }
}

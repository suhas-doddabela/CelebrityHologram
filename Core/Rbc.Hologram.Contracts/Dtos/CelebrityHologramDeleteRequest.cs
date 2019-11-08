using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rbc.Hologram.Contracts.Dtos
{
    public class CelebrityHologramDeleteRequest
    {
        [Required]
        public string CelebrityHologramRefrence { get; set; }
    }
}

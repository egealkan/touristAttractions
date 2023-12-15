using Contentful.Core.Models;
using System.Collections.Generic;

namespace touristAttractions.Models;

public class touristAttraction
{
    public string? Name { get; set; }

    public Asset? Image { get; set; } 

    public string? Rating { get; set; }

    public string? Description { get; set; }

    public string? AdmissionFee { get; set; }

    public string? Category { get; set; }

    public string? Location { get; set; }

}

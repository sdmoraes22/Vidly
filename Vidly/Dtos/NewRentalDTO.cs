using System.Collections.Generic;

namespace Vidly.Controllers.Api
{
    public class NewRentalDTO
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}
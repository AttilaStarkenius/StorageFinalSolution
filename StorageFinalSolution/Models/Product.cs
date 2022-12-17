using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace StorageFinalSolution.Models
{
    //[Keyless]
    [PrimaryKey(nameof(Id))]

    public class Product
    {
        int Id { get; set; }
        string Name { get; set; }
        int Price { get; set; }
        DateTime Orderdate { get; set; }
        string Category { get; set; }
        string Shelf { get; set; }
        int Count { get; set; }
        string Description { get; set; }
    }
}




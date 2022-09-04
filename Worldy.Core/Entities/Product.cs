using System.ComponentModel.DataAnnotations;
using Worldy.Core.Entities.Base;

namespace Worldy.Core.Entities
{
    public class Product : IEntityIdentity<int>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
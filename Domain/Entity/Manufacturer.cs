namespace Domain.Entities
{
    public class Manufacturer : BaseEntity
    {
        public string Name { get; set; }
        public string CountryOfProduction { get; set; }
    }
}
namespace AspNetCorePokedex.Domain.Entities
{
    public partial class Move
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Accuracy { get; set; }
        public string Category { get; set; }
        public string Power { get; set; }
        public string Pp { get; set; }
        public int TypeId { get; set; }

        public virtual Type Type { get; set; }
    }
}

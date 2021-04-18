 
namespace AspNetCorePokedex.Domain.Entities
{
    public partial class Base
    {
        public int Id { get; set; }
        public byte Hp { get; set; }
        public byte Attack { get; set; }
        public byte Defense { get; set; }
        public byte SpAttack { get; set; }
        public byte SpDefense { get; set; }
        public byte Speed { get; set; }
        public int PokemonId { get; set; }

        public virtual Pokemon Pokemon { get; set; }
    }
}

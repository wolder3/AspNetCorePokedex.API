using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCorePokedex.Application.DTO
{
    public class BaseDTO
    {
        public byte Hp { get; set; }
        public byte Attack { get; set; }
        public byte Defense { get; set; }
        public byte SpAttack { get; set; }
        public byte SpDefense { get; set; }
        public byte Speed { get; set; }
      
    }
}

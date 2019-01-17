using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSamurai.Domain
{
    public class SecretIdentity
    {
        public int Id { get; set; }
        public int  SamuraiId { get; set; }
        public string SecretName { get; set; }
    }
}

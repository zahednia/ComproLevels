using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Personals
    {
        public int Id { get; set; }

        public int Code { get; set; }

        public string? FullNameE { get; set; }
    }
}

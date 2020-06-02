using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_ef
{
    public class Data
    {
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(20)")]
        public string Address { get; set; }
    }
}

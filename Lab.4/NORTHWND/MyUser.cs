namespace Lab._4.NORTHWND
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MyUser
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime RegistrationDate { get; set; }
    }
}

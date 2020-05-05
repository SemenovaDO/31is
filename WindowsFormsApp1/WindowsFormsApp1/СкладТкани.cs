namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class СкладТкани
    {
        [Key]
        [Column(Order = 0)]
        public Guid Рулон { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string АртикулТкани { get; set; }

        public double Ширина { get; set; }

        public double Длина { get; set; }

        public virtual Ткань Ткань { get; set; }
    }
}

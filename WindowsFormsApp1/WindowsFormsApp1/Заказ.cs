namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заказ
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Номер { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Дата { get; set; }

        [Required]
        [StringLength(50)]
        public string ЭтапВыполнения { get; set; }

        [Required]
        [StringLength(50)]
        public string Заказчик { get; set; }

        [StringLength(50)]
        public string Менеджер { get; set; }

        public decimal? Стоимость { get; set; }

        public virtual Пользователь Пользователь { get; set; }

        public virtual Пользователь Пользователь1 { get; set; }

        public virtual ЗаказанныеИзделия ЗаказанныеИзделия { get; set; }
    }
}

namespace _1061109_FirstNetMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ComGroup")]
    public partial class ComGroup
    {
        [Key]
        [StringLength(8)]
        [Required(ErrorMessage = "�п�J�s��")]
        [RegularExpression("[0-9]*", ErrorMessage = "�榡����,�ȥi��J�Ʀr")]
        public string GroupID { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "�п�J�W��")]
        public string GroupName { get; set; }

        [StringLength(20)]
        [Required]
        public string GroupNameEn { get; set; }

        [StringLength(68)]
        
        public string Explain { get; set; }

        [StringLength(4000)]
        public string Memo { get; set; }

        [StringLength(4000)]
        public string AppxPath { get; set; }
    }
}

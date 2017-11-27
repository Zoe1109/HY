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
        [Required(ErrorMessage = "請輸入編號")]
        [RegularExpression("[0-9]*", ErrorMessage = "格式不符,僅可輸入數字")]
        public string GroupID { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "請輸入名稱")]
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

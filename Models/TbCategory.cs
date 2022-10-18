using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LapShop.Models
{
    public partial class TbCategory
    {
        public TbCategory()
        {
            TbItems = new HashSet<TbItem>();
        }
       
        [ValidateNever]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Enter Category Name")]
        public string CategoryName { get; set; }
        [ValidateNever]
        public string? CreatedBy { get; set; }=null;    
        [ValidateNever]
        public DateTime CreatedDate { get; set; }
        public int CurrentState { get; set; }
        [ValidateNever]
        public string ImageName { get; set; }
        [ValidateNever]
        public bool? ShowInHomePage { get; set; }
        [ValidateNever]
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [ValidateNever]
        public virtual ICollection<TbItem> TbItems { get; set; }
    }
}

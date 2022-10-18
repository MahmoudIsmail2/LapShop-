using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LapShop.Models
{
    public partial class TbItem
    {
        public TbItem()
        {
            TbItemDiscounts = new HashSet<TbItemDiscount>();
            TbItemImages = new HashSet<TbItemImage>();
            TbPurchaseInvoiceItems = new HashSet<TbPurchaseInvoiceItem>();
            TbSalesInvoiceItems = new HashSet<TbSalesInvoiceItem>();
            Customers = new HashSet<TbCustomer>();
        }
        [Key]
        [ValidateNever]    
        public int? ItemId { get; set; }
        [Required(ErrorMessage ="Plese Enter Item Name")]
      
        public string ItemName { get; set; } = null!;
        [Required(ErrorMessage ="Plese Enter Sales Price")]
     
        public decimal SalesPrice { get; set; }
        [Required(ErrorMessage = "Plese Enter Purchase Price ")]

        public decimal PurchasePrice { get; set; }
        [Required(ErrorMessage = "Plese Enter Category Name")]
        [ValidateNever]
        public int? CategoryId { get; set; } = 1;
        public string? ImageName { get; set; }
        [ValidateNever]
        public DateTime CreatedDate { get; set; }
        [ValidateNever]
        public string CreatedBy { get; set; } = null!;
        [ValidateNever]
        public int CurrentState { get; set; }
        [ValidateNever]
        public string? UpdatedBy { get; set; }
        [ValidateNever]
        public DateTime? UpdatedDate { get; set; }
        [ValidateNever]
        public string? Description { get; set; }
        [Required(ErrorMessage ="Enter The Gpu")]
        public string? Gpu { get; set; }
        [Required(ErrorMessage = "Enter The Hard Disk")]
        public string? HardDisk { get; set; }
        public int? ItemTypeId { get; set; }
        [Required(ErrorMessage = "Enter The Processor")]
        public string? Processor { get; set; }
        [Required(ErrorMessage = "Enter The Ram Size")]

        public int? RamSize { get; set; }
        [Required(ErrorMessage = "Enter Screen Reslution")]
        public string? ScreenReslution { get; set; }
        [Required(ErrorMessage = "Enter Screen Size")]
        public string? ScreenSize { get; set; }
        [Required(ErrorMessage = "Enter Weight")]
        public string? Weight { get; set; }
        public int? OsId { get; set; }
        [ValidateNever]
        public virtual TbCategory Category { get; set; } = null!;
        public virtual TbItemType? ItemType { get; set; }
        public virtual TbO? Os { get; set; }
        public virtual ICollection<TbItemDiscount> TbItemDiscounts { get; set; }
        public virtual ICollection<TbItemImage> TbItemImages { get; set; }
        public virtual ICollection<TbPurchaseInvoiceItem> TbPurchaseInvoiceItems { get; set; }
        public virtual ICollection<TbSalesInvoiceItem> TbSalesInvoiceItems { get; set; }

        public virtual ICollection<TbCustomer> Customers { get; set; }
    }
}

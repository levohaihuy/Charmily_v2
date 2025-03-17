﻿using System;
using System.Collections.Generic;

namespace Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int StockQuantity { get; set; }

    public int CategoryId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public int? DeletedBy { get; set; }

    public string? Status { get; set; }

    public int ReviewCount { get; set; }

    public double AverageRating { get; set; }

    public bool AllowsCustomization { get; set; } = false;

    public decimal? CustomBasePrice { get; set; }

    public virtual ICollection<BannerProduct> BannerProducts { get; set; } = new List<BannerProduct>();

    public virtual ICollection<CartDetail> CartDetails { get; set; } = new List<CartDetail>();

    public virtual Category Category { get; set; } = null!;

    public virtual Admin? CreatedByNavigation { get; set; }

    public virtual ICollection<CustomProduct> CustomProducts { get; set; } = new List<CustomProduct>();

    public virtual Admin? DeletedByNavigation { get; set; }

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();

    public virtual Admin? UpdatedByNavigation { get; set; }
}

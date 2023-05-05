﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShoesStore.Models;

public partial class LoaiGiay
{
    public string MaLoai { get; set; } = null!;

    public string? TenLoai { get; set; }

    public virtual ICollection<Giay> Giays { get; } = new List<Giay>();
}

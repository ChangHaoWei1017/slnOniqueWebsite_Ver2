﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjOniqueWebsite.Models.EFModels
{
    public partial class Collect
    {
        public int CollectId { get; set; }
        public int MemberId { get; set; }
        public int ProductId { get; set; }

        public virtual Members Member { get; set; }
        public virtual Products Product { get; set; }
    }
}
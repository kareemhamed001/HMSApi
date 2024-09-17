﻿using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.Configuration
{
    public class PharmacistPharmacyConfiguration : IEntityTypeConfiguration<ParmacistPharmacy>
    {
        public void Configure(EntityTypeBuilder<ParmacistPharmacy> builder)
        {
            builder.HasKey(pp => new { pp.PharmacyId, pp.PharmasistId });
        }
    }
}

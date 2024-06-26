﻿using Pathmaker.Persistence;
using Pathmaker.Persistence.Entities.Products;

namespace Pathmaker.Tests.Shared.Seed;

public class ProductSeed : BaseSeed {
    public ProductSeed(ApplicationDbContext context) : base(context) {
    }

    public override async Task SeedAsync() {
        var product = new ProductEntity() {
            Id = Guid.NewGuid(),
            Name = Guid.NewGuid().ToString().Substring(0, 10)
        };

        Context.Products.Add(product);
        await Context.SaveChangesAsync();
    }
}
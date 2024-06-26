﻿using Pathmaker.Persistence;
using Pathmaker.UnitTests.Factories;

namespace Pathmaker.UnitTests;

public abstract class BaseRequestTest {
    protected ApplicationDbContext ApplicationDbContext { get; private set; } = null!;

    [SetUp]
    public void BaseSetup() {
        ApplicationDbContext = DbContextFactory.Create();
    }

    [TearDown]
    public virtual async Task BaseTearDown() {
        await ApplicationDbContext.DisposeAsync();
    }
}
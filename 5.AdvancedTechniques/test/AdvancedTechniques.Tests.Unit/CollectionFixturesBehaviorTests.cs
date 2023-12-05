﻿using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace AdvancedTechniques.Tests.Unit;

//Collction Fixture compartilha o contexto entre várias classe de testes.
//Neste exemplo o GUID gerado pela MyClassFixture será igual em todos os cenários que implementam a TestCollectionFixture
[Collection("My awesome collection fixture")]
public class CollectionFixturesBehaviorTests
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly MyClassFixture _fixture;

    public CollectionFixturesBehaviorTests(ITestOutputHelper testOutputHelper,
        MyClassFixture fixture)
    {
        _testOutputHelper = testOutputHelper;
        _fixture = fixture;
    }

    [Fact]
    public async Task ExampleTest1()
    {
        _testOutputHelper.WriteLine($"The Guid was: {_fixture.Id}");
        await Task.Delay(2000);
    }

    [Fact]
    public async Task ExampleTest2()
    {
        _testOutputHelper.WriteLine($"The Guid was: {_fixture.Id}");
        await Task.Delay(2000);
    }
}

[Collection("My awesome collection fixture")]
public class CollectionFixturesBehaviorTestsAgain
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly MyClassFixture _fixture;

    public CollectionFixturesBehaviorTestsAgain(ITestOutputHelper testOutputHelper,
        MyClassFixture fixture)
    {
        _testOutputHelper = testOutputHelper;
        _fixture = fixture;
    }

    [Fact]
    public async Task ExampleTest1()
    {
        _testOutputHelper.WriteLine($"The Guid was: {_fixture.Id}");
        await Task.Delay(2000);
    }

    [Fact]
    public async Task ExampleTest2()
    {
        _testOutputHelper.WriteLine($"The Guid was: {_fixture.Id}");
        await Task.Delay(2000);
    }
}
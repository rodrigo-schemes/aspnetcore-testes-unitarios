﻿using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace AdvancedTechniques.Tests.Unit;

//Default Behaviour não compartilha o contexto entre os testes.
//Neste exemplo será gerado um GUID diferente a cada teste
public class DefaultBehaviorTests
{
    private readonly Guid _id = Guid.NewGuid();
    private readonly ITestOutputHelper _testOutputHelper;

    public DefaultBehaviorTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task ExampleTest1()
    {
        _testOutputHelper.WriteLine($"The Guid was: {_id}");
        await Task.Delay(2000);
    }

    [Fact]
    public async Task ExampleTest2()
    {
        _testOutputHelper.WriteLine($"The Guid was: {_id}");
        await Task.Delay(2000);
    }
}

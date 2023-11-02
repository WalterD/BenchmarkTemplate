using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;

namespace BenchmarkTemplate;

internal class Program
{
    static void Main(string[] args)
    {
        // How to run the tests:
        // In the Solution Explorer, right click on the project name and then "Open Folder in File Explorer"
        // Click on the address bar and then press Home to go to the beginning of the line
        // Type cmd or Powershell, and a space
        // Press enter to open CMD or Power Shell window.
        // In command window execute: dotnet build -c release
        // After you get a message of a successful build, copy the path to the dll that is displayed
        // To run the benchmark, in the command window execute: dotnet [paste the path]
        // Benchmark website: https://benchmarkdotnet.org/

        BenchmarkRunner.Run<ReversingStringsBenchmarks>();
    }
}

/// <summary>
/// Test methods to reverse a string.
/// </summary>
[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class ReversingStringsBenchmarks
{
    // String used for testing.
    private const string testString = ".net core application using c#.";

    // Service containing test methods.
    private static readonly ReverseStringService stringService = new();

    /// <summary>
    /// Testing method 1.
    /// </summary>
    [Benchmark(Baseline = true)]
    public void Benchmark1()
    {
        stringService.ReverseString1(testString);
    }

    /// <summary>
    /// Testing method 2.
    /// </summary>
    [Benchmark]
    public void Benchmark2()
    {
        stringService.ReverseString2(testString);
    }

    /// <summary>
    /// Testing method 3.
    /// </summary>
    [Benchmark]
    public void Benchmark3()
    {
        stringService.ReverseString3(testString);
    }

    /// <summary>
    /// Testing method 3.
    /// </summary>
    [Benchmark]
    public void Benchmark4()
    {
        stringService.ReverseString4(testString);
    }
}
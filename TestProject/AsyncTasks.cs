using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace TestProject;
public class AsyncTasks
{
    private readonly ITestOutputHelper log;

    public AsyncTasks(ITestOutputHelper output)
    {
        this.log = output;
    }
    [Fact]
    public async void DoubleNumbersAsync()
    {
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var watch = Stopwatch.StartNew();
        var act = await DoubleAsync(numbers);
        watch.Stop();
        log.WriteLine(watch.ElapsedMilliseconds.ToString());
        Assert.Equivalent(new List<int>() { 1, 4, 6, 8, 10, 12, 14, 16, 18, 20 }, act);
    }
    [Fact]
    public void DoubleNumbersSync()
    {
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var watch = Stopwatch.StartNew();
        var act = DoubleSync(numbers);
        watch.Stop();
        log.WriteLine(watch.ElapsedMilliseconds.ToString());
        Assert.Equivalent(new List<int>() { 1, 4, 6, 8, 10, 12, 14, 16, 18, 20 }, act);
    }

    private async static Task<List<int>> DoubleAsync(List<int> numbers)
    {
        List<Task> tasks = new();
        numbers.ForEach(number =>
        {
            tasks.Add(Task.Run(() => number *= 2));
        });
        await Task.WhenAll(tasks);
        return numbers;
    }
    private static List<int> DoubleSync(List<int> numbers)
    {
        numbers.ForEach(number => number *= 2);
        return numbers;
    }
}

namespace TestProject;
public class AsyncSandbox
{
    [Fact]
    public async void Async_TasksAreAsync()
    {
        List<int> arr = new();
        arr.Add(1);
        await Wait(arr, 2, 3000);
        arr.Add(3);
        Assert.Equivalent(new List<int> { 1, 2, 3 }, arr);
    }
    [Fact]
    public async void Async_TasksAreSync()
    {
        List<int> arr = new();
        arr.Add(1);
        arr.Add(3);
        await Wait(arr, 3);
        Assert.Equivalent(new List<int> { 1, 2, 3 }, arr);
    }
    [Fact]
    public async void Async_TasksAreAsynced()
    {
        List<int> arr = new();
        arr.Add(1);
        await Wait(arr, 2, 2000);
        await Wait(arr, 3, 500);
        arr.Add(4);
        Assert.Equivalent(new List<int> { 1, 2, 3, 4 }, arr);
    }
    internal static async Task Wait(List<int> source, int value, int ms = 1000)
    {
        await Task.Delay(ms);
        source.Add(value);
    }

}

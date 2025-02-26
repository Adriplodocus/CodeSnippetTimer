using System;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class CodeSnippetTimer : IDisposable
{
    public CodeSnippetTimer(string source)
    {
        this.source = source;
        Init();
    }

    private readonly string source;
    private Stopwatch stopwatch;

    private void Init()
    {
        stopwatch = new Stopwatch();
        stopwatch.Start();
    }

    private void Display()
    {
        Debug.Log($"Codeblock <color=red>{source}</color> took {stopwatch.ElapsedMilliseconds}ms");
    }

    public void Dispose()
    {
        stopwatch.Stop();
        Display();

        stopwatch = null;
    }
}
namespace Übung_4;

internal static class StepExpansion
{
    public static Task<Step?> GetAwaiter(this Step step)
    {
        return new Task<Step?>(() => step);
    }
}

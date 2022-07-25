namespace Übung_4;

internal class Step
{
    public Step? PreviousStep { get; }
    public int StepCount { get; }
    public ChessboardField Field { get; }

    public Step(ChessboardField chessboardField)
    {
        StepCount = 1;
        Field = chessboardField;
    }

    public Step(Step previousStep, ChessboardField chessboardField)
    {
        PreviousStep = previousStep;

        if (PreviousStep != null)
            StepCount = PreviousStep.StepCount + 1;

        Field = chessboardField;
    }
}

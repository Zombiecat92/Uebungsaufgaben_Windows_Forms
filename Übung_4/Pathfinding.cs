﻿namespace Übung_4;

internal class Pathfinding
{
    private readonly Chessboard _chessboard;

    public Pathfinding(Chessboard board)
    {
        _chessboard = board;
    }

    async public Task<Step?> FindPath(Step currentStep)
    {
        if (currentStep.StepCount == (_chessboard.BoardSize * _chessboard.BoardSize))
            return currentStep;

        List<Step> possibleNextSteps = PossibleNextSteps(currentStep);

        List<Step> sortetPossibleNextSteps = SortStepsByPossibleNextSteps(possibleNextSteps);

        foreach (Step nextStep in sortetPossibleNextSteps)
        {
            currentStep.Field.panel.BackColor = Color.Red;

            await Task.Delay(500);

            Step? checkedStep = await FindPath(nextStep);

            if (checkedStep == null)
                continue;
            else
                return checkedStep;
        }

        return null;
    }

    private bool IsFieldPlayable(Step currendStep, ChessboardCoordinate targetFieldCoordinate)
    {
        if (!IsFieldOnBoard(targetFieldCoordinate))
            return false;

        Step? step = currendStep;

        while(step != null)
        {
            if (step.Field.Coordinate.Equals(targetFieldCoordinate))
                return false;

            step = step.PreviousStep;
        }

        return true;
    }

    private bool IsFieldOnBoard(ChessboardCoordinate coordinate)
    {
        if (coordinate.X <= 0 || coordinate.Y <= 0 || coordinate.X > _chessboard.BoardSize || coordinate.Y > _chessboard.BoardSize)
            return false;

        return true;
    }

    private List<Step> PossibleNextSteps(Step currentStep)
    {
        List<Step> possibleSteps = new();

        for (int i = 0; i < KnightMoves.Moves.Length; i++)
        {
            ChessboardCoordinate nextCoordinate = currentStep.Field.Coordinate.Add(KnightMoves.Moves[i]);

            if (!IsFieldPlayable(currentStep, nextCoordinate))
                continue;

            Step possibleNextStep = new(currentStep, _chessboard.Fields[nextCoordinate]);

            possibleSteps.Add(possibleNextStep);
        }

        return possibleSteps;
    }

    private List<Step> SortStepsByPossibleNextSteps(List<Step> possibleNextSteps)
    {
        Dictionary<Step, int> possibleNextStepsCount = new();
        List<Step> sortetPossibleNextSteps = new();

        possibleNextSteps.ForEach(step =>
        {
            int count = PossibleNextSteps(step).Count;

            possibleNextStepsCount.Add(step, count);
        });

        sortetPossibleNextSteps = possibleNextStepsCount.OrderBy(keyValuePair => keyValuePair.Value).Select(keyValuePair => keyValuePair.Key).ToList();

        return sortetPossibleNextSteps;
    }
}

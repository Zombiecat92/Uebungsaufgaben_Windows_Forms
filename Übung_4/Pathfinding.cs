namespace Übung_4;

internal class Pathfinding
{
    private readonly Chessboard _chessboard;
    private readonly Animator _animator;

    public Pathfinding(Chessboard board, Animator animator)
    {
        _chessboard = board;
        _animator = animator;
    }

    async public Task<Step?> FindPath(Step currentStep)
    {
        // If current step the last one on board
        if (currentStep.StepCount == (_chessboard.BoardSize * _chessboard.BoardSize))
        {
            _ = _animator.UpdateAnimation(currentStep);
            return currentStep;
        }

        List<Step> possibleNextSteps = PossibleNextSteps(currentStep);

        List<Step> sortetPossibleNextSteps = SortStepsByPossibleNextSteps(possibleNextSteps);

        foreach (Step nextStep in sortetPossibleNextSteps)
        {
            await _animator.UpdateAnimation(nextStep);

            // If a FindPath finds a valid path, the last step of the path is returned
            Step? checkedStep = await FindPath(nextStep);

            if (checkedStep == null)
            {                
                await _animator.FailAnimation(nextStep);
                continue;
            }
            else
                return checkedStep;
        }

        return null;
    }

    // Check if the next step is valid
    private bool IsFieldPlayable(Step currendStep, ChessboardCoordinate targetFieldCoordinate)
    {
        if (!IsFieldOnBoard(targetFieldCoordinate))
            return false;

        Step? step = currendStep;

        // Loop through all previous steps, if any equal next step, the next step is invalid
        while (step != null)
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

    // Check if knight moves are valid, and retun them
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

    // Sorting the steps according to the number of possible next steps from the next steps
    private List<Step> SortStepsByPossibleNextSteps(List<Step> possibleNextSteps)
    {
        Dictionary<Step, int> possibleNextStepsCount = new();
        List<Step> sortetPossibleNextSteps = new();

        // Count the possible next steps and add them to the dictionary
        possibleNextSteps.ForEach(step =>
        {
            int count = PossibleNextSteps(step).Count;

            possibleNextStepsCount.Add(step, count);
        });

        // Sort the dictionary by possible next steps count and extract the values
        sortetPossibleNextSteps = possibleNextStepsCount.OrderBy(keyValuePair => keyValuePair.Value).Select(keyValuePair => keyValuePair.Key).ToList();

        return sortetPossibleNextSteps;
    }
}

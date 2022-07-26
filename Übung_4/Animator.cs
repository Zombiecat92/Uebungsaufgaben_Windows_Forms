namespace Übung_4;

internal class Animator
{
    // Delay between animaton
    private const int MillisecondsDelay = 500;

    private readonly Chessboard _chessboard;
    private readonly Image _knight_black;
    private readonly Image _knight_gray;

    public Animator(Chessboard chessboard)
    {
        _chessboard = chessboard;
        _knight_black = Properties.Resources.springer;
        _knight_gray = Properties.Resources.springer_transparent;
    }

    // Take a step and draw a knight for them and every previous steps
    public async Task UpdateAnimation(Step currentStep)
    {
        Step? step = currentStep.PreviousStep;

        ClearAnimation();

        // Current step become a black knight
        PlaceKnight(currentStep.Field.pictureBox, true);

        // Every previous step become a gray knight
        while (step != null)
        {
            PlaceKnight(step.Field.pictureBox, false);

            step = step.PreviousStep;
        }

        await Task.Delay(MillisecondsDelay);
    }

    // Highlights the last step
    public async Task FailAnimation(Step currentStep)
    {
        _ = UpdateAnimation(currentStep);

        Color cache = currentStep.Field.pictureBox.BackColor;

        currentStep.Field.pictureBox.BackColor = Color.Red;

        await Task.Delay(MillisecondsDelay);

        currentStep.Field.pictureBox.BackColor = cache;
    }

    // Remove every knight
    private void ClearAnimation()
    {
        PictureBox[] pictureBoxes = _chessboard.GetPictureBoxes();

        for (int i = 0; i < pictureBoxes.Length; i++)
        {
            pictureBoxes[i].Controls.Clear();
        }
    }

    // Add a knight to a picturebox
    private void PlaceKnight(PictureBox pictureBox, bool currentStep)
    {
        PictureBox newPictureBox = new()
        {
            Size = pictureBox.Size,
            Location = new Point(0,0),
            BackColor = Color.Transparent,
            SizeMode = PictureBoxSizeMode.Zoom,
            Image = currentStep ? _knight_black : _knight_gray
        };

        pictureBox.Controls.Add(newPictureBox);
    }
}

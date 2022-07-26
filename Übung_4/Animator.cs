namespace Übung_4;

internal class Animator
{
    private readonly Chessboard _chessboard;

    public Animator(Chessboard chessboard)
    {
        _chessboard = chessboard;
    }

    public async Task UpdateAnimation(Step currentStep)
    {
        Step? step = currentStep.PreviousStep;

        ClearAnimation();

        PlaceKnigth(currentStep.Field.pictureBox, true);

        while (step != null)
        {
            PlaceKnigth(step.Field.pictureBox, false);

            step = step.PreviousStep;
        }

        await Task.Delay(500);
    }

    private void ClearAnimation()
    {
        PictureBox[] pictureBoxes = _chessboard.GetPictureBoxes();

        for (int i = 0; i < pictureBoxes.Length; i++)
        {
            pictureBoxes[i].Controls.Clear();
        }
    }

    private void PlaceKnigth(PictureBox pictureBox, bool currentStep)
    {
        PictureBox newPictureBox = new PictureBox
        {
            Size = pictureBox.Size,
            Location = new Point(0,0),
            BackColor = Color.Transparent,
            SizeMode = PictureBoxSizeMode.Zoom
        };

        if (currentStep)
            newPictureBox.Image = Properties.Resources.springer;
        else
            newPictureBox.Image = Properties.Resources.springer_transparent;

        pictureBox.Controls.Add(newPictureBox);
    }
}

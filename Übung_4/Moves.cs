namespace Übung_4;

internal static class KnightMoves
{
    public static readonly ChessboardCoordinate[] Moves = new ChessboardCoordinate[8] {
        new ChessboardCoordinate(-1, 2),
        new ChessboardCoordinate(1, 2),
        new ChessboardCoordinate(2, 1),
        new ChessboardCoordinate(2, -1),
        new ChessboardCoordinate(1, -2),
        new ChessboardCoordinate(-1, -2),
        new ChessboardCoordinate(-2, -1),
        new ChessboardCoordinate(-2, 1)
    };
}

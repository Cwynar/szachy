public class ChessPiece
{
    public enum PieceColor { White, Black }
    public enum PieceType { King, Queen, Rook, Bishop, Knight, Pawn }

    public PieceColor Color { get; set; }
    public PieceType Type { get; set; }
    public int Row { get; set; }
    public int Column { get; set; }

    public ChessPiece(PieceColor color, PieceType type, int row, int column)
    {
        Color = color;
        Type = type;
        Row = row;
        Column = column;
    }
}

public ChessPiece GetPieceAt(BoardPosition position)
{
    if (position.X < 0 || position.X >= 8 || position.Y < 0 || position.Y >= 8)
    {
        return null;
    }

    return _board[position.X, position.Y];
}
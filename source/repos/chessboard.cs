public class ChessBoard
{
    private readonly ChessPiece[,] _board;
    private readonly List<ChessPiece> _whitePieces;
    private readonly List<ChessPiece> _blackPieces;

    public ChessBoard()
    {
        _board = new ChessPiece[8, 8];
        _whitePieces = new List<ChessPiece>();
        _blackPieces = new List<ChessPiece>();

        // Inicjalizacja planszy z figurami
        _board[0, 0] = new Rook(ChessColor.White, new BoardPosition(0, 0));
        _board[0, 1] = new Knight(ChessColor.White, new BoardPosition(0, 1));
        _board[0, 2] = new Bishop(ChessColor.White, new BoardPosition(0, 2));
        _board[0, 3] = new Queen(ChessColor.White, new BoardPosition(0, 3));
        _board[0, 4] = new King(ChessColor.White, new BoardPosition(0, 4));
        _board[0, 5] = new Bishop(ChessColor.White, new BoardPosition(0, 5));
        _board[0, 6] = new Knight(ChessColor.White, new BoardPosition(0, 6));
        _board[0, 7] = new Rook(ChessColor.White, new BoardPosition(0, 7));

        _board[1, 0] = new Pawn(ChessColor.White, new BoardPosition(1, 0));
        _board[1, 1] = new Pawn(ChessColor.White, new BoardPosition(1, 1));
        _board[1, 2] = new Pawn(ChessColor.White, new BoardPosition(1, 2));
        _board[1, 3] = new Pawn(ChessColor.White, new BoardPosition(1, 3));
        _board[1, 4] = new Pawn(ChessColor.White, new BoardPosition(1, 4));
        _board[1, 5] = new Pawn(ChessColor.White, new BoardPosition(1, 5));
        _board[1, 6] = new Pawn(ChessColor.White, new BoardPosition(1, 6));
        _board[1, 7] = new Pawn(ChessColor.White, new BoardPosition(1, 7));

        _board[6, 0] = new Pawn(ChessColor.Black, new BoardPosition(6, 0));
        _board[6, 1] = new Pawn(ChessColor.Black, new BoardPosition(6, 1));
        _board[6, 2] = new Pawn(ChessColor.Black, new BoardPosition(6, 2));
        _board[6, 3] = new Pawn(ChessColor.Black, new BoardPosition(6, 3));
        _board[6, 4] = new Pawn(ChessColor.Black, new BoardPosition(6, 4));
        _board[6, 5] = new Pawn(ChessColor.Black, new BoardPosition(6, 5));
        _board[6, 6] = new Pawn(ChessColor.Black, new BoardPosition(6, 6));
        _board[6, 7] = new Pawn(ChessColor.Black, new BoardPosition(6, 7));

        _board[7, 0] = new Rook(ChessColor.Black, new BoardPosition(7, 0));
        _board[7, 1] = new Knight(ChessColor.Black, new BoardPosition(7, 1));
        _board[7, 2] = new Bishop(ChessColor.Black, new BoardPosition(7, 2));
        _board[7, 3] = new Queen(ChessColor.Black, new BoardPosition(7, 3));
        _board[7, 4] = new King(ChessColor.Black, new BoardPosition(7, 4));
        _board[7, 5] = new Bishop(ChessColor.Black, new BoardPosition(7, 5));
        _board[7, 6] = new Knight(ChessColor.Black, new BoardPosition(7, 6));
        _board[7, 7] = new Rook(ChessColor.Black, new BoardPosition(7, 7));
    }
}
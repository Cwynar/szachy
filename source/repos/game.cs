public class Game
{
    private ChessBoard _board;
    private Player _whitePlayer;
    private Player _blackPlayer;
    private Player _currentPlayer;

    public Game(Player whitePlayer, Player blackPlayer)
    {
        _board = new ChessBoard();
        _whitePlayer = whitePlayer;
        _blackPlayer = blackPlayer;
        _currentPlayer = _whitePlayer;
    }

    public void Play()
    {
        while (!IsGameOver())
        {
            Console.WriteLine($"{_currentPlayer.Color} player's turn");
            Console.WriteLine("Enter move (e.g. 'e2 e4'):");
            string input = Console.ReadLine();
            string[] positions = input.Split(' ');
            BoardPosition from = new BoardPosition(positions[0]);
            BoardPosition to = new BoardPosition(positions[1]);
            Move move = new Move(_board, from, to);
            if (_currentPlayer.MakeMove(move))
            {
                // Successful move
                if (_currentPlayer == _whitePlayer)
                {
                    _currentPlayer = _blackPlayer;
                }
                else
                {
                    _currentPlayer = _whitePlayer;
                }
            }
            else
            {
                // Invalid move
                Console.WriteLine("Invalid move!");
            }
        }

        Console.WriteLine("Game over");
        Console.WriteLine($"{GetWinner()} wins!");
    }

    private bool IsGameOver()
    {
        // Game over if one player's king is captured
        return _whitePlayer.Pieces.All(p => p.GetType() != typeof(King)) ||
            _blackPlayer.Pieces.All(p => p.GetType() != typeof(King));
    }

    private ChessColor GetWinner()
    {
        if (_whitePlayer.Pieces.All(p => p.GetType() != typeof(King)))
        {
            return ChessColor.Black;
        }
        else
        {
            return ChessColor.White;
        }
    }
}


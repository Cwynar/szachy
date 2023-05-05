class ChessBoard : public QGraphicsScene
{
    Q_OBJECT

public:
    ChessBoard(QObject * parent = nullptr);

public slots:
    void onSquareClicked(int x, int y);

signals:
void pieceSelected(int x, int y);
void pieceMoved(int fromX, int fromY, int toX, int toY);

private:
    void drawBoard();
void drawPieces();
void drawPiece(int x, int y, const QString& fileName);

int m_selectedX = -1;
int m_selectedY = -1;
};

ChessBoard::ChessBoard(QObject * parent) : QGraphicsScene(parent) {
    drawBoard();
    drawPieces();
}

void ChessBoard::drawBoard() {
    for (int y = 0; y < 8; ++y)
    {
        for (int x = 0; x < 8; ++x)
        {
            QBrush brush((x +y) % 2 == 0 ? Qt::white : Qt::gray);
    addRect(x * 50, y * 50, 50, 50, QPen(Qt::black), brush);
}
    }
}

void ChessBoard::drawPieces() {
    drawPiece(0, 0, "rook.png");
    drawPiece(1, 0, "knight.png");
    drawPiece(2, 0, "bishop.png");
    drawPiece(3, 0, "queen.png");
    drawPiece(4, 0, "king.png");
    drawPiece(5, 0, "bishop.png");
    drawPiece(6, 0, "knight.png");
    drawPiece(7, 0, "rook.png");

    for (int x = 0; x < 8; ++x)
    {
        drawPiece(x, 1, "pawn
class ChessBoard : public QGraphicsScene
{
    Q_OBJECT

public:
    ChessBoard(QObject * parent = nullptr);

public slots:
    void onSquareClicked(int x, int y);

signals:
void pieceSelected(int x, int y);
void pieceMoved(int fromX, int fromY, int toX, int toY);

private:
    void drawBoard();
void drawPieces();
void drawPiece(int x, int y, const QString& fileName);

int m_selectedX = -1;
int m_selectedY = -1;
};

ChessBoard::ChessBoard(QObject * parent) : QGraphicsScene(parent) {
    drawBoard();
    drawPieces();
}

void ChessBoard::drawBoard() {
    for (int y = 0; y < 8; ++y)
    {
        for (int x = 0; x < 8; ++x)
        {
            QBrush brush((x +y) % 2 == 0 ? Qt::white : Qt::gray);
    addRect(x * 50, y * 50, 50, 50, QPen(Qt::black), brush);
}
    }
}

void ChessBoard::drawPieces() {
    drawPiece(0, 0, "rook.png");
    drawPiece(1, 0, "knight.png");
    drawPiece(2, 0, "bishop.png");
    drawPiece(3, 0, "queen.png");
    drawPiece(4, 0, "king.png");
    drawPiece(5, 0, "bishop.png");
    drawPiece(6, 0, "knight.png");
    drawPiece(7, 0, "rook.png");

    for (int x = 0; x < 8; ++x)
    {
        drawPiece(x, 1, "pawn.png");
        drawPiece(x, 6, "pawn.png");
    }

    drawPiece(0, 7, "rook.png");
    drawPiece(1, 7, "knight.png");
    drawPiece(2, 7, "bishop.png");
    drawPiece(3, 7, "queen.png");
    drawPiece(4, 7, "king.png");
    drawPiece(5, 7, "bishop.png");
    drawPiece(6, 7, "knight.png");
    drawPiece(7, 7, "rook.png");

    void ChessBoard::drawPiece(int x, int y, const QString&fileName) {
        QGraphicsPixmapItem* item = addPixmap(QPixmap(fileName));
        item->setPos(x * 50, y * 50);
    }

    void ChessBoard::onSquareClicked(int x, int y) {
        if (m_selectedX == -1 && m_selectedY == -1)
        {
            m_selectedX = x;
            m_selectedY = y;
            emit pieceSelected(x, y);
        }
        else
        {
            emit pieceMoved(m_selectedX, m_selectedY, x, y);
            m_selectedX = -1;
            m_selectedY = -1;
        }
    } 
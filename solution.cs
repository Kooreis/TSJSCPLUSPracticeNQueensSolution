function placeQueens(board, colIndex, n) {
    if (colIndex >= n) {
        printBoard(board, n);
        return;
    }

    for (let i = 0; i < n; i++) {
        if (isSafe(board, i, colIndex, n)) {
            board[i][colIndex] = 1;
            placeQueens(board, colIndex + 1, n);
            board[i][colIndex] = 0;
        }
    }
}
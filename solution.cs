function solveNQueens(n) {
    const board = Array(n).fill().map(() => Array(n).fill(0));
    placeQueens(board, 0, n);
}
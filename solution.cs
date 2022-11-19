Here is a JavaScript solution for the N-Queens problem:

```javascript
function solveNQueens(n) {
    const board = Array(n).fill().map(() => Array(n).fill(0));
    placeQueens(board, 0, n);
}

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

function isSafe(board, rowIndex, colIndex, n) {
    for (let i = 0; i < colIndex; i++) {
        if (board[rowIndex][i] === 1) {
            return false;
        }
    }

    for (let i = rowIndex, j = colIndex; i >= 0 && j >= 0; i--, j--) {
        if (board[i][j] === 1) {
            return false;
        }
    }

    for (let i = rowIndex, j = colIndex; j >= 0 && i < n; i++, j--) {
        if (board[i][j] === 1) {
            return false;
        }
    }

    return true;
}

function printBoard(board, n) {
    for (let i = 0; i < n; i++) {
        let row = '';
        for (let j = 0; j < n; j++) {
            row += board[i][j] === 1 ? 'Q ' : '. ';
        }
        console.log(row);
    }
    console.log('\n');
}

solveNQueens(4);
```

This program will print all possible solutions for placing 4 queens on a 4x4 chessboard. You can change the argument of the `solveNQueens` function to solve the problem for a different size of chessboard.
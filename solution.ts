Here is a TypeScript solution for the N-Queens problem:

```typescript
class NQueens {
    private solution: number[];
    private N: number;

    constructor(N: number) {
        this.N = N;
        this.solution = new Array(N).fill(-1);
    }

    public solveNQ() {
        if (this.solve(0)) {
            this.printSolution();
        } else {
            console.log("No solution exists.");
        }
    }

    private solve(col: number): boolean {
        if (col === this.N) {
            return true;
        }

        for (let row = 0; row < this.N; row++) {
            if (this.isSafe(row, col)) {
                this.solution[row] = col;
                if (this.solve(col + 1)) {
                    return true;
                }
                this.solution[row] = -1;
            }
        }

        return false;
    }

    private isSafe(row: number, col: number): boolean {
        for (let i = 0; i < col; i++) {
            if (this.solution[i] === row || 
                this.solution[i] === row - col + i || 
                this.solution[i] === row + col - i) {
                return false;
            }
        }

        return true;
    }

    private printSolution() {
        for (let row = 0; row < this.N; row++) {
            let line = "";
            for (let col = 0; col < this.N; col++) {
                if (this.solution[row] === col) {
                    line += " Q ";
                } else {
                    line += " - ";
                }
            }
            console.log(line);
        }
    }
}

let nQueens = new NQueens(4);
nQueens.solveNQ();
```

This program creates a class `NQueens` that solves the N-Queens problem for a given size of the chessboard. The `solveNQ` method starts the process of finding a solution. The `solve` method is a recursive function that tries to place a queen in each row of the current column and then moves to the next column. If no safe spot is found, it returns false. The `isSafe` method checks if a queen can be placed at the given row and column without being attacked by another queen. The `printSolution` method prints the solution to the console.
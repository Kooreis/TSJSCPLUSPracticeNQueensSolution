public solveNQ() {
        if (this.solve(0)) {
            this.printSolution();
        } else {
            console.log("No solution exists.");
        }
    }
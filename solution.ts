class NQueens {
    private solution: number[];
    private N: number;

    constructor(N: number) {
        this.N = N;
        this.solution = new Array(N).fill(-1);
    }
}
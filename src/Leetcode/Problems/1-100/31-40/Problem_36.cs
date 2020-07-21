namespace Leetcode.Problems
{
    /// <summary>
    /// 36. Valid Sudoku
    /// Determine if a Sudoku is valid, according to: Sudoku Puzzles - The Rules.
    /// The Sudoku board could be partially filled, where empty cells are filled with the character '.'.
    /// A partially filled sudoku which is valid.
    /// Note:
    /// A valid Sudoku board(partially filled) is not necessarily solvable.Only the filled cells need to be validated.
    /// </summary>
    public class Problem_36
    {
        public bool IsValidSudoku(char[,] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] != '.')
                    {
                        for (int ci = i + 1; ci < 9; ci++)
                        {
                            if (board[i, j] == board[ci, j]) return false;
                        }
                        for (int cj = j + 1; cj < 9; cj++)
                        {
                            if (board[i, j] == board[i, cj]) return false;
                        }
                        int Zonei = i / 3;
                        int Zonej = j / 3;

                        for (int zi = Zonei * 3; zi < Zonei * 3 + 3; zi++)
                        {
                            for (int zj = Zonej * 3; zj < Zonej * 3 + 3; zj++)
                            {
                                if (i != zi && j != zj)
                                {
                                    if (board[i, j] == board[zi, zj]) return false;
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}

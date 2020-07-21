using System.Collections.Generic;

namespace Leetcode.Problems
{
    /// <summary>
    /// 37. Sudoku Solver
    /// Write a program to solve a Sudoku puzzle by filling the empty cells.
    /// A sudoku solution must satisfy all of the following rules:
    /// Each of the digits 1-9 must occur exactly once in each row.
    /// Each of the digits 1-9 must occur exactly once in each column.
    /// Each of the the digits 1-9 must occur exactly once in each of the 9 3x3 sub-boxes of the grid.
    /// Empty cells are indicated by the character '.'.
    /// </summary>
    public class Problem_37
    {
        public class Node
        {
            public List<char> values = new List<char>{ (char)1, (char)2, (char)3, (char)4, (char)5, (char)6, (char)7, (char)8, (char)9 };
        }

        public Node[][] GetNewNodes()
        {
            Node[][] nodes = new Node[9][];
            for (int i = 0; i < 9; i++)
            {
                nodes[i] = GetNewNodeArray();
            }
            return nodes;
        }

        public Node[] GetNewNodeArray()
        {
            return new Node[9];
        }

        private bool SetNode(char[][] board, Node[][] nodes, int ci, int j)
        {
            if (nodes[ci][j].values.Count == 1)
            {
                board[ci][j] = nodes[ci][j].values[0];
                return true;
            }
            return false;
        }

        private void ZoneChecker(char[][] board, Node[][] nodes, int i, int j)
        {
            int Zonei = i / 3;
            int Zonej = j / 3;

            for (int zi = Zonei * 3; zi < Zonei * 3 + 3; zi++)
            {
                for (int zj = Zonej * 3; zj < Zonej * 3 + 3; zj++)
                {
                    if (i != zi && j != zj)
                    {
                        if (board[zi][zj] != '.')
                        {
                            nodes[i][j].values.Remove(board[zi][zj]);
                        }
                    }
                }
            }
        }

        private void ColumnChecker(char[][] board, Node[][] nodes, int i, int j)
        {
            for (int cj = j + 1; cj < 9; cj++)
            {
                if (board[i][cj] != '.')
                {
                    nodes[i][j].values.Remove(board[i][cj]);
                }
            }
        }

        private void RowChecker(char[][] board, Node[][] nodes, int i, int j)
        {
            for (int ci = i + 1; ci < 9; ci++)
            {
                if (board[ci][j] != '.')
                {
                    nodes[i][j].values.Remove(board[ci][j]);
                }
            }
        }

        public void SolveSudoku(char[][] board)
        {
            Node[][] nodes = GetNewNodes();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                    {
                        if (nodes[i][j] == null) nodes[i][j] = new Node();
                        
                        RowChecker(board, nodes, i, j);
                        if (SetNode(board, nodes, i, j)) break;

                        ColumnChecker(board, nodes, i, j);
                        if (SetNode(board, nodes, i, j)) break;

                        ZoneChecker(board, nodes, i, j);
                        if (SetNode(board, nodes, i, j)) break;
                    }
                    else
                    {
                        for (int ci = i + 1; ci < 9; ci++)
                        {
                            if (nodes[ci][j] == null) nodes[ci][j] = new Node();
                            if (board[ci][j] != '.')
                            {
                                nodes[ci][j].values.Remove(board[i][j]);
                                SetNode(board, nodes, ci, j);
                            }
                        }

                        for (int cj = j + 1; cj < 9; cj++)
                        {
                            if (nodes[i][cj] == null) nodes[i][cj] = new Node();
                            if (board[i][cj] == '.')
                            {
                                nodes[i][cj].values.Remove(board[i][j]);
                                SetNode(board, nodes, i, cj);
                            }
                        }

                        int Zonei = i / 3;
                        int Zonej = j / 3;

                        for (int zi = Zonei * 3; zi < Zonei * 3 + 3; zi++)
                        {
                            for (int zj = Zonej * 3; zj < Zonej * 3 + 3; zj++)
                            {
                                if (nodes[zi][zj] == null) nodes[zi][zj] = new Node();
                                if (i != zi && j != zj)
                                {
                                    if (board[zi][zj] == '.')
                                    {
                                        nodes[zi][zj].values.Remove(board[i][j]);
                                        SetNode(board, nodes, zi, zj);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

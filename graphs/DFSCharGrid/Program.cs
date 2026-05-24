DFSGrid dFSGrid = new DFSGrid();
dFSGrid.Start();
public class DFSGrid
{
    // Directions: right, down, up, left
    readonly (int dx, int dy)[] directions = new (int, int)[]
    {
        (0, 1),
        (1, 0),
        (-1, 0),
        (0, -1)
    };

    // Grid declared as requested
    private readonly char[,] grid = new char[,]
    {
            { '.', '.', '.', '#' },
            { '#', '.', '#', '.' },
            { '.', '.', '.', '.' },
            { '.', '#', '.', '.' }
    };

    private readonly bool[,] bools;
    private bool[,] visited = null!;

    public DFSGrid()
    {
        // initialize bools and visited using grid dimensions
        bools = new bool[grid.GetLength(0), grid.GetLength(1)];
        visited = bools;
    }

    // DFS uses the grid and visited fields
    private void DFS(char[,] gridParam, int x, int y)
    {
        int rows = gridParam.GetLength(0);
        int cols = gridParam.GetLength(1);

        if (x < 0 || y < 0 || x >= rows || y >= cols || visited[x, y] || gridParam[x, y] == '#')
            return;

        visited[x, y] = true;
        Console.WriteLine($"Visited ({x}, {y})");

        foreach (var dir in directions)
        {
            DFS(gridParam, x + dir.dx, y + dir.dy);
        }
    }

    public void Start()
    {
        Console.WriteLine("DFS from (0,4):");
        DFS(grid, 0, 0);
    }
}
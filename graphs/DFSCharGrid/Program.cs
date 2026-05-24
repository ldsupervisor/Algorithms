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

    private bool[,] visited = null!;

    public DFSGrid()
    {
        ResetVisited();
    }

    private void ResetVisited()
    {
        visited = new bool[grid.GetLength(0), grid.GetLength(1)];
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

    private bool DFSFindPath(char[,] gridParam, int x, int y, int targetX, int targetY, List<(int x, int y)> path)
    {
        int rows = gridParam.GetLength(0);
        int cols = gridParam.GetLength(1);

        if (x < 0 || y < 0 || x >= rows || y >= cols)
            return false;

        if (visited[x, y] || gridParam[x, y] == '#')
            return false;

        visited[x, y] = true;
        path.Add((x, y));

        if (x == targetX && y == targetY)
            return true;

        foreach (var dir in directions)
        {
            if (DFSFindPath(gridParam, x + dir.dx, y + dir.dy, targetX, targetY, path))
                return true;
        }

        path.RemoveAt(path.Count - 1);
        return false;
    }

    public void Start()
    {
        Console.WriteLine("DFS from (0,0):");
        DFS(grid, 0, 0);
        ResetVisited();
        var path = new List<(int x, int y)>();

        Console.WriteLine("DFS path from (0,0) to (2,2):");

        bool found = DFSFindPath(grid, 0, 0, 2, 2, path);

        if (found)
        {
            Console.WriteLine("Path found:");
            foreach (var point in path)
                Console.WriteLine($"({point.x}, {point.y})");
        }
        else
        {
            Console.WriteLine("Path not found.");
        }
    }
}
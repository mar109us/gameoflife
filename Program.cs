// Any live cell with fewer than two live neighbours dies, as if by underpopulation.
// Any live cell with two or three live neighbours lives on to the next generation.
// Any live cell with more than three live neighbours dies, as if by overpopulation.
// Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction

using System.Text;


class Program {
    static void Main(string[] args) {
        Console.CursorVisible = false;

        int[][] dot = [[0, 1], [1, 1], [5, 5], [8, 3], [9, 5]];
        foreach (var mainDot in dot) {
            foreach (var restDots in dot) {
                if (mainDot != restDots) {
                    if (restDots[0] == mainDot[0] - 1 && restDots[1] == mainDot[1]) {
                        Console.WriteLine($"pixel on left of {mainDot[0]},{mainDot[1]}");
                    }
                    if (restDots[0] == mainDot[0] + 1 && restDots[1] == mainDot[1]) {
                        Console.WriteLine($"pixel on right {mainDot[0]},{mainDot[1]}");
                    }
                }
            }
        }
        DrawScreen(dot);
    }

    private static void DrawScreen(int[][] dot) {
        while (true) {
            var width = Console.WindowWidth;
            var height = Console.WindowHeight;
            var screen = new StringBuilder();
            for (var i = 0; i < height; i++) {
                for (var j = 0; j < width; j++) {
                    foreach (var pos in dot) {
                        if (pos[0] == i && pos[1] == j) {
                            screen.Append("█");
                        }
                    }

                    screen.Append(" ");
                }
            }

            Console.Write(screen.ToString());
            Thread.Sleep(500);
            Console.SetCursorPosition(0, 0);
        }
    }
}
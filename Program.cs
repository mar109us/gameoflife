// Any live cell with fewer than two live neighbours dies, as if by underpopulation.
// Any live cell with two or three live neighbours lives on to the next generation.
// Any live cell with more than three live neighbours dies, as if by overpopulation.
// Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction

using System.Text;

int[][] dot = [[5, 5]];

Console.CursorVisible = false;
Console.Clear();

while (true) {
    var width = Console.WindowWidth;
    var height = Console.WindowHeight;
    var screen = new StringBuilder();
    for (var i = 0; i < height - 1; i++) {
        for (var j = 0; j < width; j++) {
            if (dot[i][j] == j && dot[0][] == i) {
                screen.Append("█");
            }
            else {
                screen.Append(" ");
            }
        }
    }

    Console.SetCursorPosition(0, 0);
    Console.Write(screen.ToString());

    Thread.Sleep(16);
}
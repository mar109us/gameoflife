// Any live cell with fewer than two live neighbours dies, as if by underpopulation.
// Any live cell with two or three live neighbours lives on to the next generation.
// Any live cell with more than three live neighbours dies, as if by overpopulation.
// Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction

using System.Text;

// MAKE ARRAY FROM WIDTH/HEIGHT AS I NEED TO CHECK DEAD CELLS AS WELL
// MAKE ARRAY FROM WIDTH/HEIGHT AS I NEED TO CHECK DEAD CELLS AS WELL
// MAKE ARRAY FROM WIDTH/HEIGHT AS I NEED TO CHECK DEAD CELLS AS WELL

// LIST LIST LIST
class Program {
    static void Main(string[] args) {
        Console.CursorVisible = false;

        
        DrawScreen();
    }

    private static void DrawScreen() {
        while (true) {
            var dot = makeList();
            var width = Width();
            var height = Height();
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
            FrameLoop(screen);
        }
    }

    private static void FrameLoop(StringBuilder screen) {
        Console.Write(screen.ToString());
        Thread.Sleep(500);
        Console.SetCursorPosition(0, 0);
    }

    private static List<int[]> makeList() {
        List<int[]> dot = [[5, 5], [6, 5]];
        foreach (var mainDot in dot) {
            foreach (var restDots in dot) {
                if (mainDot != restDots) {
                    //row
                    if (restDots[0] == mainDot[0] - 1 && restDots[1] == mainDot[1]) {
                        Console.WriteLine($"Pixel on left of {mainDot[0]},{mainDot[1]}");
                    }
                    else {
                        Console.WriteLine($"No pixel on left of {mainDot[0]},{mainDot[1]}");
                    }
                    if (restDots[0] == mainDot[0] + 1 && restDots[1] == mainDot[1]) {
                        Console.WriteLine($"Pixel on right {mainDot[0]},{mainDot[1]}");
                    }
                    else {
                        Console.WriteLine($"No pixel on right {mainDot[0]},{mainDot[1]}");
                    }
                    //column
                    if (restDots[1] == mainDot[1] - 1 && restDots[0] == mainDot[0]) {
                        Console.WriteLine($"Pixel on top of {mainDot[0]},{mainDot[1]}");
                    }
                    else {
                        Console.WriteLine($"No pixel on top of {mainDot[0]},{mainDot[1]}");
                    }
                    if (restDots[1] == mainDot[1] + 1 && restDots[0] == mainDot[0]) {
                        Console.WriteLine($"Pixel on bottom of {mainDot[0]},{mainDot[1]}");
                    }
                    else {
                        Console.WriteLine($"No pixel on bottom of {mainDot[0]},{mainDot[1]}");
                    }
                }
            }
        }

        return dot;
    }

    private static int Height() {
        var height = Console.WindowHeight;
        return height;
    }

    private static int Width() {
        var width = Console.WindowWidth;
        return width;
    }
}
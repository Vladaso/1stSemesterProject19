namespace Testing{
    public class Canvas{
        public string[] frame = {
            @"
    ┌───────────────────────────────────────────────────────────────┐
    │                                                               │
    │                                                               │
    │                                                               │
    │                                                               │
    │                                          ┌─────────┐          │
    │                                          │         │          │
    │                                          │         │          │
    │                                          │         │          │
    │                                          │         │          │
    │                                          └─────────┘          │
    │                                                               │
    │                                                               │
    │                                                               │
    │                                                               │
    │                                                               │
    │                                                               │
    │                                                               │
    │                                                               │
    │                                                               │
    │                                                               │
    │                                                               │
    │                                                               │
    └───────────────────────────────────────────────────────────────┘
",
@"
    ┌─────────────────────────────────┬───────────────┬──────────────────────────────────┐
    │       ───────────────────────── │               │ ──────────────────────────────   │
    ├─────────────┐ ─     ─── ┌──=────┘               └──────────┐      ──────────────── │
    │       o  ~  │       ─── │  =  +                          ~ │           ─── ─────── │
    │   >('>   ┌──┘   ─────── │__=8                      +      +│ ───       ─── ──      │
    │          │ ───────────  │__\|,-                            │ ───────────── ──      │
    │   #,#    │ ── ┌──────┐  │,-`=--.                           └─────────────┐ ──      │
    │    #o#  +│ ── │      │  │ / |\                                          +│ ───     │
    ├─────┐#   │ ─  │      └──┘   |                            ><_>            │ ───     │
    │ ─── │ +  │ ─  │          ~ +                             ┌───────┐       │ ───     │
    │ ─── │    │ ── │                                         ~│ ───── │       │ ─────── │
    │     └────┘ ── │                                          │ ────  │    ┌──┘ ──────  │
    │     ───────── │                             #o#   ~ ┌────┘ ───── │    │ ── ┌────┐  │
    │     ────────  │                   mmm     ####o#   +│   ──────── │    │ ── │ + +│  │
    │     ─── ┌─────┘   O  o            )-(    #o# \#|_ ~ │ ────── ┌───┘    └────┘   +│  │
    │     ─── │    _\_   o             (   )  ###\─|/─────┤ ────── │                  │  │
    │     ─── │ \\/  o\ .              |   |  ┌#─{}{}{{───┘ ─── ┌──┘                  │  │
    │     ─── │ //\___=                |   |  │ ─────────────── │                 _\/_│  │
    │         │~   ''                  |___|  │ ─────────       │_\/_            ~//o\│  │
    │     ─── │                    ┌──────────┘ ───            ┌┘/o\\ _ +       ┌─┐ | │  │
    │ ─────── │                    │        ───────       ──── │+'-|-,_┌────────┘ │'|'│  │
    │ ──── ┌──┘                    │ ──────────────       ──── └───────┘ ─────────└───┘  │
    │ ──── │                       │       ───────────    ────────────────────────────── │
    └──────┴───────────────────────┴─────────────────────────────────────────────────────┘
"
        };
    private char[,] frameArray = new char[0, 0];
    
    public void Draw() {
        splitFrame();
        // DrawFrame();
        System.Console.WriteLine(frame[1]);
    }

    private void splitFrame() {
        string[] lines = frame[1].Split('\n');
        int frameLenght = lines.Max(line => line.Length);
        frameArray = new char[lines.Length, frameLenght];
        for (int i = 0; i < lines.Length; i ++)
        {
            string line = lines[i].TrimEnd();
            for (int j = 0; j < lines[i].Length; j++)
            {
                frameArray[i, j] = lines[i][j];
            }

            for (int j = lines[i].Length; j < frameLenght; j++)
            {
                frameArray[i, j] = ' ';
            }
            
        }
    }

    public bool IsCollision(int x, int y) {
        return frameArray[y, x] != ' ';
    }

    private void DrawFrame() {
        for (int i = 0; i < frameArray.GetLength(0); i++)
        {
            for (int j = 0; j < frameArray.GetLength(1); j++)
            {
                System.Console.Write(frameArray[i, j]);
            }
            System.Console.WriteLine();
        }
    }
    }
}
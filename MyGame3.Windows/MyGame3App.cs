using Stride.Engine;

namespace MyGame3
{
    class MyGame3App
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}

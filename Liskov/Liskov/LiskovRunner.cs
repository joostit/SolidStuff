namespace Liskov
{
    internal class LiskovRunner
    {

        public void Run()
        {

            int totalSurface = 0;

            List<Rectangle> rectangles = new();

            for (int i = 1; i <= 10; i++)
            {
                Rectangle rect;
                
                if(i % 2 == 0)
                {
                    rect = new Rectangle()
                    {
                        Width = i,
                        Length = 2 * i
                    };
                }
                else
                {
                    rect = new Square()
                    {
                        Sidelength = i * 4
                    };
                }
                
                

                totalSurface += rect.Surface;
                rectangles.Add(rect);
            }


            Console.WriteLine($"Total surface: {totalSurface}");


        }

    }
}
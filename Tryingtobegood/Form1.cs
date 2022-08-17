namespace Tryingtobegood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point point1 = new(550, 300);
            Rectangle rect = new(point1.X,point1.Y, 2, 2);
            g.FillRectangle(Brushes.Black, rect);
            int step_count = 1;
            int step_limit = 2;
            int adder = 5;
            int x = point1.X;
            int y = point1.Y;
            for (int i = 1; i < 100000; i++, step_count++)
            {
                if (step_count <= .5 * step_limit)
                {
                    x += adder;
                    Point newPoint = new Point(x, y);
                    Rectangle rectangle = new(newPoint.X, newPoint.Y, 2, 2);
                    if (IsPrime(i))
                    {
                        g.FillRectangle(Brushes.Black, rectangle);
                    }
                    else
                    {
                        g.FillRectangle(Brushes.White, rectangle);
                    }
                    x = newPoint.X;
                    y = newPoint.Y;
                }
                else if (step_count <= step_limit)
                {
                    y += adder;
                    Point newPoint = new Point(x, y);
                    Rectangle rectangle = new(newPoint.X, newPoint.Y, 2, 2);
                    if (IsPrime(i))
                    {
                        g.FillRectangle(Brushes.Black, rectangle);
                    }
                    else
                    {
                        g.FillRectangle(Brushes.White, rectangle);
                    }
                    x = newPoint.X;
                    y = newPoint.Y;
                }
                if (step_count == step_limit)
                {
                    adder *= -1;
                    step_limit += 2;
                    step_count = 0;
                }




            }
        }
        private static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;
            for (int i = 2; i < Math.Sqrt(num); i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        
    }
}
using UnZipper.Classes;

namespace UnZipper
{
	public partial class FMain : Form
	{
		public FMain()
		{
			InitializeComponent();
		}

        // KISS - Keep It Simple, Stupid. - оставл€й это простым, придурок
        // DRY - Don't Repeat Yourself
        // SOLID

        private void bnBrowse_Click(object sender, EventArgs e)
		{
            IGetDir getDir = new GetDir(fbdBrowse);
            if (getDir.ShowAndOkDialog())
            {
                tbZipFile.Text = getDir.SelectedPath;
                IPushToList pushToList = new PushToList(lbItems);
                pushToList.Push(getDir.Files);
            }
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var path = "C:\\Temp\\Course";
			var zipName = "Result.zip";
			var combined = Path.Combine(path, zipName);
			var fi = new FileInfo(combined);
			if (fi.Exists)
				fi.Delete();


			var selected = lbItems.SelectedItems;

            IZip zip = new ZipUnzip(fi);
            zip.ZipTo(selected.Cast<FileInfo>());

            IUnZip unZip = new ZipUnzip(fi);
            var files = unZip.Unzip();


            //var listOfObject = new List<GeometricObject>();
            //listOfObject.Add(new Triangle());
            //listOfObject.Add(new CircleRed());
            //listOfObject.Add(new CircleGreen());
            //listOfObject.Add(new Triangle());
            //listOfObject.Add(new Square()); 
            //listOfObject.Add(new Square());
            //listOfObject.Add(new Line());

            //foreach (var geometricObject in listOfObject)
            //{
            //    geometricObject.Draw();
            //}
        }
	}

    public abstract class GeometricObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point TopLeft { get; set; }
        public Size Size { get; set; }
        public abstract void Draw();

        protected void DefineSquarePosition()
        {
            TopLeft = new Point(X, Y);
            Size = new Size(Size.Width, Size.Height);
        }
    }

    public class Triangle : GeometricObject
    {
        public override void Draw()
        {
            base.DefineSquarePosition();
            // Draw Triangle
        }
    }

    public class Square : GeometricObject
    {
        public override void Draw()
        {
            // Draw Square
        }
    }

    public class Circle : GeometricObject
    {
        public override void Draw()
        {
            // Draw Circle
        }
    }

    public class CircleRed : Circle
    {
        public override void Draw()
        {
            // Draw Circle
        }
    }

    public class CircleGreen : Circle
    {
        public override void Draw()
        {
            // Draw Circle
        }
    }

    public class Line : GeometricObject
    {
        public override void Draw()
        {

        }

        public void SwithcOnLight()
        {
            ///
        }
    }
}
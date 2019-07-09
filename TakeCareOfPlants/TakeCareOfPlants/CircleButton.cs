using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TakeCareOfPlants
{
    internal class CircleButton : Button
    {
        protected override void OnPaint(PaintEventArgs eventArgs)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region = new System.Drawing.Region(graphicsPath);
            base.OnPaint(eventArgs);
        }
    }
}

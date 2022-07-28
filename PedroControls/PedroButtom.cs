using System.Drawing.Drawing2D;

namespace SalvadorDeSenhas.PedroControls;

public class PedroButtom : Button
{
    // Fields
    private int borderSize = 0;
    private int borderRadius = 40;
    private Color borderColor = Color.PaleVioletRed;

    // Constructor
    public PedroButtom()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        Size = new Size(150, 40);
        BackColor = Color.MediumSlateBlue;
        ForeColor = Color.White;
    }

    // Methods
    private GraphicsPath GetFigurePath(RectangleF rect, float radius)
    {
        GraphicsPath path = new GraphicsPath();
        path.StartFigure();
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
        path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
        path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
        path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
        path.CloseFigure();

        return path;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        RectangleF rectSurface = new RectangleF(0, 0, Width, Height);
        RectangleF rectBorder = new RectangleF(1, 1, Width - 0.8F, Height - 1);

        if (borderRadius > 2)
        {
            using (GraphicsPath pathSurface)
        }
    }
}

using System.ComponentModel;

namespace SalvadorDeSenhas.PedroControls;

[DefaultEvent("_TextChanged")]
public partial class PedroTextBox : UserControl
{
    // Fields
    private Color borderColor = Color.MediumSlateBlue;
    private int borderSize = 2;
    private bool underlinedStyle = false;
    private Color borderFocusColor = Color.HotPink;
    private bool isFocused = false;

    private string placeholderText = "";
    private bool isPlaceholder = false;
    private bool isPasswordChar = false;

    public PedroTextBox()
    {
        InitializeComponent();
    }

    // Events
    public event EventHandler _TextChanged;

    // Properties
    [Category("Pedro Componentes")]
    public Color BorderColor
    {
        get => borderColor;
        set
        {
            borderColor = value;
            this.Invalidate();
        }
    }

    [Category("Pedro Componentes")]
    public int BorderSize
    {
        get => borderSize;
        set
        {
            borderSize = value;
            Invalidate();
        }
    }

    [Category("Pedro Componentes")]
    public bool PasswordChar
    {
    
        get
        {
            return isPasswordChar;
        }
        set
        {
                isPasswordChar = value;
                PedroTextBox1.UseSystemPasswordChar = value;       
        }
    
    }

    [Category("Pedro Componentes")]
    public bool UnderlinedStyle
    {
        get => underlinedStyle;
        set
        {
            underlinedStyle = value;
            Invalidate();
        }
    }

    [Category("Pedro Componentes")]
    public bool Multiline
    {
        get { return PedroTextBox1.Multiline; }
        set { PedroTextBox1.Multiline = value; }
    }

    [Category("Pedro Componentes")]
    public override Color BackColor
    {
        get { return base.BackColor; }
        set
        {
            base.BackColor = value;
            PedroTextBox1.BackColor = value;
        }
    }

    [Category("Pedro Componentes")]
    public override Color ForeColor
    {
        get { return base.ForeColor; }
        set
        {
            base.ForeColor = value;
            PedroTextBox1.ForeColor = value;
        }
    }

    [Category("Pedro Componentes")]
    public override Font Font
    {
        get { return base.Font; }
        set
        {
            base.Font = value;
            PedroTextBox1.Font = value;
            if (DesignMode)
                UpdateControlHeight();
        }
    }

    [Category("Pedro Componentes")]
    public string Texts
    {
        get 
        {
            if (isPlaceholder)
                return "";
            else 
                return PedroTextBox1.Text;
        }
        set 
        { 
            PedroTextBox1.Text = value;
            SetPlaceholder();
        }
    }

    [Category("Pedro Componentes")]
    public Color BorderFocusColor
    {
        get
        {
            return borderFocusColor;
        }
        set => borderFocusColor = value;
    }

    [Category("Pedro Componentes")]
    public string PlaceholderText
    {
        get
        {
            return placeholderText;
        }
        set
        {
            placeholderText = value;
            PedroTextBox1.Text = "";
            SetPlaceholder();
        }
    }

    // Overridden methods
    public void Clear()
    {
        PedroTextBox1.Clear();
        SetPlaceholder();
    }

    private void SetPlaceholder()
    {
        if (string.IsNullOrWhiteSpace(PedroTextBox1.Text) && placeholderText != "")
        {
            isPlaceholder = true;
            PedroTextBox1.Text = placeholderText;
            if (isPasswordChar)
                PedroTextBox1.UseSystemPasswordChar = false;
        }
    }

    private void RemovePlaceholder()
    {
        if (isPlaceholder && placeholderText != "")
        {
            isPlaceholder = false;
            PedroTextBox1.Text = "";
            if (isPasswordChar)
                PedroTextBox1.UseSystemPasswordChar = true;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics graph = e.Graphics;

        using (Pen penBorder = new Pen(borderColor, borderSize))
        {
            penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

            if (!isFocused)
            {
                if (underlinedStyle)
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
            else
            {
                penBorder.Color = borderFocusColor;
                if (underlinedStyle)
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        UpdateControlHeight();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        UpdateControlHeight();
    }

    private void UpdateControlHeight()
    {
        if (PedroTextBox1.Multiline == false)
        {
            int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
            PedroTextBox1.Multiline = true;
            PedroTextBox1.MinimumSize = new Size(0, txtHeight);
            PedroTextBox1.Multiline = false;

            Height = PedroTextBox1.Height + Padding.Top + Padding.Bottom;
        }
    }

    // Events
    private void PedroTextBox1_TextChanged(object sender, EventArgs e)
    {
        if (_TextChanged != null)
            _TextChanged.Invoke(sender, e);
    }

    private void PedroTextBox1_Enter(object sender, EventArgs e)
    {
        isFocused = true;
        Invalidate();
    }

    private void PedroTextBox1_Enter_1(object sender, EventArgs e)
    {
        isFocused = true;
        this.Invalidate();
        RemovePlaceholder();
    }

    private void PedroTextBox1_Leave(object sender, EventArgs e)
    {
        isFocused = false;
        this.Invalidate();
        SetPlaceholder();
    }
}
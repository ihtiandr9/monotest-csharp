using System;
using System.Drawing;
using System.Windows.Forms;

public class MainForm : Form
{
    private Label label;
    private Button button;
    private int clickCount;

    public MainForm()
    {
        Text = "Mono GUI Example";
        Size = new Size(400, 300);
        StartPosition = FormStartPosition.CenterScreen;

        label = new Label
        {
            Text = "Click the button!",
            Location = new Point(120, 80),
            Size = new Size(160, 30),
            TextAlign = ContentAlignment.MiddleCenter
        };

        button = new Button
        {
            Text = "Click me",
            Location = new Point(140, 130),
            Size = new Size(120, 40)
        };
        button.Click += OnButtonClick;

        Controls.Add(label);
        Controls.Add(button);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;

        using (var brush = new SolidBrush(Color.Red))
            g.FillEllipse(brush, 50, 50, 100, 100);

        using (var pen = new Pen(Color.Blue, 3))
            g.DrawRectangle(pen, 170, 50, 120, 80);

        using (var font = new Font("Arial", 14))
            g.DrawString("Привет!", font, Brushes.Black, 50, 180);
    }

    private void OnButtonClick(object sender, EventArgs e)
    {
        clickCount++;
        label.Text = $"Clicked {clickCount} time(s)!";
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new MainForm());
    }
}

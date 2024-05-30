namespace Struggle.Pal.Components;

public partial class Counter : ContentView
{
    public int Count { get; set; }

    public Counter()
    {
        InitializeComponent();
    }

    public void IncrementCount(object sender, EventArgs e)
    {
        Count++;
        CountLabel.Text = Count.ToString();
    }
}
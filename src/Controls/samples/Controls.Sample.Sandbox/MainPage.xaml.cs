namespace Maui.Controls.Sample;

public record struct TestRecord(string Name);

public partial class MainPage : ContentPage
{
	public TestRecord[] TestItems { get; set; } =
		[
			new TestRecord("Item 1"),
			new TestRecord("Item 2"),
			new TestRecord("Item 3")
		];

	public TestRecord CurrentItem => TestItems.First();

	public MainPage()
	{
		InitializeComponent();

		BindingContext = this;
	}
}
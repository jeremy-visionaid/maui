using System.Diagnostics;

namespace Maui.Controls.Sample;

public partial class MainPage : ContentPage
{
	bool alerted = false;

	public MainPage()
	{
		InitializeComponent();
	}

	void OnPinchUpdated1(object sender, PinchGestureUpdatedEventArgs e)
	{
		if (e.Status != GestureStatus.Running)
			Debug.WriteLine($"Pinch Updated: Status: {e.Status}");
	}

	async void OnPinchUpdated2(object sender, PinchGestureUpdatedEventArgs e)
	{
		if (e.Status != GestureStatus.Running)
			Debug.WriteLine($"Pinch Updated: Status: {e.Status}");

		if (e.Status == GestureStatus.Started)
		{
			if (!alerted)
			{
				alerted = true;
				await DisplayAlert("Pinch Updated", "Message", "OK");
			}
		}
	}
}
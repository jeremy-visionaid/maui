using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Maui.Controls;

namespace Maui.Controls.Sample.Pages
{
	public partial class PanGestureEventsGallery : ContentPage
	{
		readonly Queue<string> cursorHistory = new(100);

		public PanGestureEventsGallery()
		{
			InitializeComponent();
		}

		void OnPanGestureRecognizerUpdated(object sender, PanUpdatedEventArgs e)
		{
			if (e.StatusType is Microsoft.Maui.GestureStatus.Started)
			{
				cursorHistory.Clear();
			}

			string msg = $"{e.StatusType} {e.TotalX}";
			//Debug.WriteLine(msg);
			cursorHistory.Enqueue(msg);
			if (cursorHistory.Count > 100)
				cursorHistory.Dequeue();
			InfoLabel.Text = string.Join(Environment.NewLine, cursorHistory);
		}
	}
}
﻿using System;

using Xamarin.Forms;

namespace DovreKommune
{
	public class App : Application
	{
		public App ()
		{
			// Added a test comment

			// The root page of your application
			var NavigationPage = new NavigationPage (new FrontPage ());
			NavigationPage.ToolbarItems.Add (new ToolbarItem {
				Name = "Menu",
				Icon = "Meny2.png",
				Order = ToolbarItemOrder.Secondary,
				Command = new Command (() => NavigationPage.Navigation.PushAsync (new PostMessage ()))
			});
			NavigationPage.ToolbarItems.Add (new ToolbarItem {
				Order = ToolbarItemOrder.Secondary,
				Name="Logg inn",
				Command = new Command (() => NavigationPage.Navigation.PushAsync (new PostMessage ()))
			});


			MainPage = NavigationPage;
			NavigationPage.BarBackgroundColor = Color.FromRgb (132, 187, 255);
			NavigationPage.BarTextColor = Color.White;

		}


		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}


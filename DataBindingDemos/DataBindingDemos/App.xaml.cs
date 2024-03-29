﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DataBindingDemos
{
    public partial class App : Application
    {
        public SampleSettingsViewModel Settings { get; private set; }

        public App()
        {
            InitializeComponent();

            Settings = new SampleSettingsViewModel(Current.Properties);
            MainPage = new NavigationPage(new MainPage());
            



        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Settings.SaveState(Current.Properties);
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

using System;
using CVApp.ViewModels;
using Xamarin.Forms;

namespace CVApp
{
    public partial class MainPage : ContentPage
    {
        private CVViewModel ViewModel => BindingContext as CVViewModel;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddIdioma(object sender, EventArgs e)
        {
            var entry = sender as Entry;
            if (!string.IsNullOrWhiteSpace(entry.Text))
            {
                ViewModel.CV.Idiomas.Add(entry.Text);
                entry.Text = string.Empty; // Limpiar entrada
            }
        }

        private void OnAddAptitud(object sender, EventArgs e)
        {
            var entry = sender as Entry;
            if (!string.IsNullOrWhiteSpace(entry.Text))
            {
                ViewModel.CV.Aptitudes.Add(entry.Text);
                entry.Text = string.Empty; // Limpiar entrada
            }
        }
    }
}

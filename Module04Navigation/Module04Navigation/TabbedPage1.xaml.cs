using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        ObservableCollection<Toystory> toystories = new ObservableCollection<Toystory>();
        public ObservableCollection<Toystory> Toystories { get { return toystories; } }

        public TabbedPage1()
        {
            InitializeComponent();

            ToystoryView.ItemsSource = toystories;

            toystories.Add(new Toystory
            {
                DisplayName = "Woody",
                TagLine = "You are my favorite deputy",
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRAoXRwNWjU0oTwazCFkX7JUhqVQLINEv4ZHHVhV_iTAA&s"
            });
            toystories.Add(new Toystory
            {
                DisplayName = "Buzz Lightyear",
                TagLine = "To infinity and beyond",
                Image = "https://lumiere-a.akamaihd.net/v1/images/open-uri20150422-20810-a07syh_9331bd0a.jpeg?region=0,0,450,450"
            });
            toystories.Add(new Toystory
            {
                DisplayName = "Jessie",
                TagLine = "Ride like the wind, Bullseye!",
                Image = "https://lumiere-a.akamaihd.net/v1/images/open-uri20150422-20810-y1ys73_7dd5c0b7.jpeg?region=0,0,450,450"
            });
            toystories.Add(new Toystory
            {
                DisplayName = "Slinky Dog",
                TagLine = "Gaddily Bob-Howdy",
                Image = "https://lumiere-a.akamaihd.net/v1/images/open-uri20150422-20810-pzhioy_5a17fe4b.jpeg?region=0%2C0%2C450%2C450"
            });
            toystories.Add(new Toystory
            {
                DisplayName = "Mr. Potato Head",
                TagLine = "I'm a married spud, I'm a married spud",
                Image = "https://lumiere-a.akamaihd.net/v1/images/open-uri20150422-20810-enmr1e_871e8eac.jpeg?region=0,0,450,450"
            });
        }

        void OnSubmitEntry(object sender, EventArgs e)
        {
            string entry1Text = fcharac.Text;
            string entry2Text = comment.Text;
            string entry3Text = myRating.Text;
            DisplayAlert("Entered values",
                $"Favorite Character: {entry1Text}\nVillain I most Hate: {entry2Text}\nRating: {entry3Text}\n\nAre you sure you want to submit",
                "Ok", "Cancel");
        }
    }
}

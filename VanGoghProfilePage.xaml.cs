using System.Collections.ObjectModel;

namespace ProgressTest;

public partial class VanGoghProfilePage : ContentPage
{
    public ObservableCollection<Artwork> Artworks { get; set; }

    public VanGoghProfilePage()
    {
        InitializeComponent();
        LoadData();
        BindingContext = this;
    }

    private void LoadData()
    {
        Artworks = new ObservableCollection<Artwork>
        {
            new Artwork
            {
                Title = "Peach Tree in Blossom",
                Price = "$950,000",
                ImageUrl = "drawfive.jpeg"
            },
            new Artwork
            {
                Title = "Cafe Terrace at Night",
                Price = "$1,920,000",
                ImageUrl = "drawone.jpeg"
            },
            new Artwork
            {
                Title = "Starry Night",
                Price = "$100,000,000",
                ImageUrl = "drawtwo.jpeg"
            },
            new Artwork
            {
                Title = "Cypress against a Starry Sky",
                Price = "$50,000,000",
                ImageUrl = "drawtwo.jpeg"
            }
        };
    }
}

public class Artwork
{
    public string Title { get; set; }
    public string Price { get; set; }
    public string ImageUrl { get; set; }
}
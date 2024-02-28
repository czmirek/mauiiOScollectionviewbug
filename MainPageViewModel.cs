using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiIosCollectionViewBugTest;

public partial class MainPageViewModel : PageViewModel
{
    public ObservableCollection<ItemViewModel> Items { get; set; } = [];
    [ObservableProperty] ItemViewModel? selectedItem = null;

    //protected override Task OnPageAppearing()
    //{
    //    var item1 = new ItemViewModel { Name = "Item 1", Image = ImageSource.FromFile("dotnet_bot.png"), ImageBackground = new Color(193, 186, 168) };
    //    var item2 = new ItemViewModel { Name = "Item 2", Image = ImageSource.FromFile("dotnet_bot.png"), ImageBackground = new Color(193, 186, 168) };
    //    var item3 = new ItemViewModel { Name = "Item 3", Image = ImageSource.FromFile("dotnet_bot.png"), ImageBackground = new Color(193, 186, 168) };
    //
    //    Items.Add(item1);
    //    Items.Add(item2);
    //    Items.Add(item3);
    //    return Task.CompletedTask;
    //}

    [RelayCommand]
    async Task Clear()
    {
        System.Diagnostics.Debug.WriteLine("CLEARING ITEMS");
        Items.Clear();
        System.Diagnostics.Debug.WriteLine("ITEMS CLEARED");
    }

    [RelayCommand]
    async Task LoadItems()
    {
        var item1 = new ItemViewModel { Name = "Item 1", Image = ImageSource.FromFile("dotnet_bot.png"), ImageBackground = new Color(193, 186, 168) };
        var item2 = new ItemViewModel { Name = "Item 2", Image = ImageSource.FromFile("dotnet_bot.png"), ImageBackground = new Color(193, 186, 168) };
        var item3 = new ItemViewModel { Name = "Item 3", Image = ImageSource.FromFile("dotnet_bot.png"), ImageBackground = new Color(193, 186, 168) };

        System.Diagnostics.Debug.WriteLine("ADDING ITEMS");

        Items.Add(item1);
        Items.Add(item2);
        Items.Add(item3);

        System.Diagnostics.Debug.WriteLine("ITEMS ADDED");
    }

    [RelayCommand]
    async Task LoadItemsAndSelect()
    {
        var item1 = new ItemViewModel { Name = "Item 1", Image = ImageSource.FromFile("dotnet_bot.png"), ImageBackground = new Color(193, 186, 168) };
        var item2 = new ItemViewModel { Name = "Item 2", Image = ImageSource.FromFile("dotnet_bot.png"), ImageBackground = new Color(193, 186, 168) };
        var item3 = new ItemViewModel { Name = "Item 3", Image = ImageSource.FromFile("dotnet_bot.png"), ImageBackground = new Color(193, 186, 168) };

        System.Diagnostics.Debug.WriteLine("ADDING ITEMS");

        Items.Add(item1);
        Items.Add(item2);
        Items.Add(item3);

        System.Diagnostics.Debug.WriteLine("ITEMS ADDED");
        
        System.Diagnostics.Debug.WriteLine("SELECTING ITEM");
        SelectedItem = Items.FirstOrDefault(x => x.Name == "Item 3");
        System.Diagnostics.Debug.WriteLine("ITEM SELECTED");
    }
}
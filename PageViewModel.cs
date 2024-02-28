using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiIosCollectionViewBugTest;

public abstract class PageViewModel : ObservableObject
{
    public IAsyncRelayCommand AppearingCommand { get; private set; }

    public PageViewModel()
    {
        AppearingCommand = new AsyncRelayCommand(OnAppearing);
    }

    bool appeared = false;

    private async Task OnAppearing()
    {
        if (appeared)
            return;

        await OnPageAppearing();

        appeared = true;
    }

    protected virtual Task OnPageAppearing()
    {
        return Task.CompletedTask;
    }
}
namespace MauiIosCollectionViewBugTest;

public abstract class BaseContentPage : ContentPage
{
    private readonly PageViewModel pageVm;

    public BaseContentPage(PageViewModel pageVm)
    {
        this.pageVm = pageVm;
        this.BindingContext = pageVm;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        pageVm.AppearingCommand.Execute(null);
    }
}
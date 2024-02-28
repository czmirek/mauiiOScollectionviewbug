namespace MauiIosCollectionViewBugTest;

public partial class ItemControl : ContentView
{
    public static readonly BindableProperty IsSelectedProperty = BindableProperty.Create(
        nameof(IsSelected), typeof(bool), typeof(ItemControl), defaultValue: false, propertyChanged: SelectedChanged);

    private static void SelectedChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
        if (bindable is not ItemControl control || newvalue is not bool boolValue)
        {
            return;
        }

        //if (boolValue)
        //{
        //    control.OutlineBorder.BackgroundColor = Colors.Black;
        //    control.SelectedLabel.IsVisible = true;
        //}
        //else
        //{
        //    control.SelectedLabel.IsVisible = false;
        //    control.OutlineBorder.BackgroundColor = Colors.Transparent;
        //}
    }

    public bool IsSelected
    {
        get => (bool)GetValue(IsSelectedProperty);
        set => SetValue(IsSelectedProperty, value);
    }

    public ItemControl()
	{
		InitializeComponent();
	}
}
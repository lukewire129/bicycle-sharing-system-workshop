using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace BicycleSharingSystem.Kiosk.Pages.RentalOffice.Component;

public class RentalOfficePanel : ListBox
{
    protected override Control CreateContainerForItemOverride(object? item, int index, object? recycleKey)
    {
        return new RentalOfficeItem();
    }
}
using CommunityToolkit.Maui.Core;

namespace OOTBMauiApp.ViewModels;

public partial class DrawingViewModel : BaseViewModel
{
	[ObservableProperty]
	public ObservableCollection<IDrawingLine> lines = new();

	[RelayCommand]
	public void Clear()
	{
		Lines.Clear();
	}
}

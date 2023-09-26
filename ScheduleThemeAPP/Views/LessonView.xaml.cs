using ScheduleThemeAPP.ViewModels;

namespace ScheduleThemeAPP.Views;

public partial class LessonView : ContentView
{
	public LessonViewModel _lessonViewModel { get; set; } = new LessonViewModel(new Models.LessonModel());
	//public Rect Bounds => _lessonViewModel.Bounds;
	public LessonView(LessonViewModel lessonViewModel)
	{
		_lessonViewModel = lessonViewModel;
		BindingContext = _lessonViewModel;
        InitializeComponent();
		
	}
}
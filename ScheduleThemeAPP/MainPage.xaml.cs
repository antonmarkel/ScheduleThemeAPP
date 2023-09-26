namespace ScheduleThemeAPP;
using Models.Drawable;
using ScheduleThemeAPP.Models;
using ScheduleThemeAPP.Models.DataModels;
using ScheduleThemeAPP.ViewModels;
using ScheduleThemeAPP.ViewModels.Drawable;
using ScheduleThemeAPP.Views;

public partial class MainPage : ContentPage
{
	

	private void Upload(OptionsModel options)
	{

		LessonViewModel.Options = options;

        //ScheduleDrawable scheduleDrawable = new ScheduleDrawable(options);
        TimeLinesDrawable timeLinesDrawable = new TimeLinesDrawable(options);
        TimeScheduleDrawable timeScheduleDrawable = new TimeScheduleDrawable(options);

        gridBackground.Background = Color.FromRgba(245, 222, 179, 200);
		graphViewLines.HeightRequest = graphViewTime.HeightRequest =  options.CalculateSpaceRequired();

        graphViewLines.Drawable = timeLinesDrawable;
        graphViewTime.Drawable = timeScheduleDrawable;
    }

	public void Add(string Class,string Teacher,string Room,TimeSpan Start, TimeSpan End,bool notes,DateTime Day)
	{
        LessonModel model = new LessonModel()
        { 
            Day = Day,
            hasNotes = notes,
            ClassName = Class,
            Teacher = Teacher,
            Room = Room,
            Start = Start,
            Finish = End
        };
        LessonViewModel _viewModel = new LessonViewModel(model);
        layout.Children.Add(new LessonView(_viewModel));
    }

	public MainPage()
	{
		InitializeComponent();
		OptionsModel options = OptionsModel.GetInstance();
		Upload(options);

		Add("Хуесосология","Узурбатор М.И","каб 3-5 к.2",new TimeSpan(9,00,0),new TimeSpan(10,35,0), true, new DateTime(2023, 9, 24));
        Add("Завод", "Долинский М.С", "каб 3-1 к.2", new TimeSpan(10, 45, 0), new TimeSpan(12, 20, 0), false, new DateTime(2023, 9, 24));
        Add("Матхуй и геом майнкрафта", "Стив А.Л", "каб 1-1 к.1", new TimeSpan(12, 40, 0), new TimeSpan(14, 15, 0), true, new DateTime(2023, 9, 24));
        Add("Качалка", "Узбек228 А.Д.", "-", new TimeSpan(14, 35, 0), new TimeSpan(16, 10, 0), false, new DateTime(2023, 9, 24));

        Add("Еблановодство", "Узурбатор М.И", "каб 3-5 к.2", new TimeSpan(9, 00, 0), new TimeSpan(10, 35, 0), true, new DateTime(2023, 9, 25));
        Add("Математика и бычки", "Долинский М.С", "каб 3-1 к.2", new TimeSpan(10, 45, 0), new TimeSpan(12, 20, 0), false, new DateTime(2023, 9, 25));
        Add("Английский вместе с Бебрисом", "Стив А.Л", "каб 1-1 к.1", new TimeSpan(12, 40, 0), new TimeSpan(14, 15, 0), true, new DateTime(2023, 9, 25));
        Add("Жесткий набор массы", "Узбек228 А.Д.", "-", new TimeSpan(14, 35, 0), new TimeSpan(16, 10, 0), false, new DateTime(2023, 9, 25));

        Add("Хуесосология", "Узурбатор М.И", "каб 3-5 к.2", new TimeSpan(9, 00, 0), new TimeSpan(10, 35, 0), true, new DateTime(2023, 9, 26));
        Add("Завод", "Долинский М.С", "каб 3-1 к.2", new TimeSpan(10, 45, 0), new TimeSpan(12, 20, 0), false, new DateTime(2023, 9, 26));
        Add("Матхуй и геом майнкрафта", "Стив А.Л", "каб 1-1 к.1", new TimeSpan(12, 40, 0), new TimeSpan(14, 15, 0), true, new DateTime(2023, 9, 26));
        Add("Качалка", "Узбек228 А.Д.", "-", new TimeSpan(14, 35, 0), new TimeSpan(16, 10, 0), false, new DateTime(2023, 9, 26));

        Add("Еблановодство", "Узурбатор М.И", "каб 3-5 к.2", new TimeSpan(9, 00, 0), new TimeSpan(10, 35, 0), true, new DateTime(2023, 9, 27));
        Add("Матхуй и геом майнкрафта", "Долинский М.С", "каб 3-1 к.2", new TimeSpan(10, 45, 0), new TimeSpan(12, 20, 0), false, new DateTime(2023, 9, 27));
        Add("Матхуй и геом майнкрафта", "Стив А.Л", "каб 1-1 к.1", new TimeSpan(12, 40, 0), new TimeSpan(14, 15, 0), true, new DateTime(2023, 9, 27));
        Add("Завод", "Узбек228 А.Д.", "-", new TimeSpan(14, 35, 0), new TimeSpan(16, 10, 0), false, new DateTime(2023, 9, 27));

        Add("Хуесосология", "Узурбатор М.И", "каб 3-5 к.2", new TimeSpan(9, 00, 0), new TimeSpan(10, 35, 0), true, new DateTime(2023, 9, 28));
        Add("Завод", "Долинский М.С", "каб 3-1 к.2", new TimeSpan(10, 45, 0), new TimeSpan(12, 20, 0), false, new DateTime(2023, 9, 28));
        Add("Матхуй и геом майнкрафта", "Стив А.Л", "каб 1-1 к.1", new TimeSpan(12, 40, 0), new TimeSpan(14, 15, 0), true, new DateTime(2023, 9, 28));
        Add("Качалка", "Узбек228 А.Д.", "-", new TimeSpan(14, 35, 0), new TimeSpan(16, 10, 0), false, new DateTime(2023, 9, 28));

    }

	
}


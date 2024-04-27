using InspectorDTP.AppData;
using System;
using System.ComponentModel;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InspectorDTP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage(int id)
        {
            InitializeComponent();
        }
      
        //private void CkbHaveVictims_CheckedChanged(object sender, CheckedChangedEventArgs e)
        //{

        //    if (CkbHaveVictims.IsChecked)
        //    {
        //        LbKolVictim.IsVisible = true;
        //        PckQuanPeopVictim.IsVisible = true;
        //    }
        //    else
        //    {
        //        LbKolVictim.IsVisible = false;
        //        PckQuanPeopVictim.IsVisible = false;
        //    }
        //}

        //private void CkbHaveLoss_CheckedChanged(object sender, CheckedChangedEventArgs e)
        //{
        //    if (CkbHaveLoss.IsChecked)
        //    {
        //        LbKolLoss.IsVisible = true;
        //        PckQuanPeopLoss.IsVisible = true;
        //    }
        //    else
        //    {
        //        LbKolLoss.IsVisible = false;
        //        PckQuanPeopLoss.IsVisible = false;
        //    }
        //}
        //private void PckQuanPeopVictim_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch (PckQuanPeopVictim.SelectedIndex)
        //    {
        //        case 0:
        //            EntFioVictim1.IsVisible = true;
        //            EntFioVictim2.IsVisible = false;
        //            EntFioVictim3.IsVisible = false;
        //            EntFioVictim4.IsVisible = false;
        //            break;
        //        case 1:
        //            EntFioVictim1.IsVisible = true;
        //            EntFioVictim2.IsVisible = true;
        //            EntFioVictim3.IsVisible = false;
        //            EntFioVictim4.IsVisible = false;
        //            break;
        //        case 2:
        //            EntFioVictim1.IsVisible = true;
        //            EntFioVictim2.IsVisible = true;
        //            EntFioVictim3.IsVisible = true;
        //            EntFioVictim4.IsVisible = false;
        //            break;
        //        case 3:
        //            EntFioVictim1.IsVisible = true;
        //            EntFioVictim2.IsVisible = true;
        //            EntFioVictim3.IsVisible = true;
        //            EntFioVictim4.IsVisible = true;
        //            break;
        //    }
        //}
        //private void PckQuanPeopLoss_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch (PckQuanPeopLoss.SelectedIndex)
        //    {
        //        case 0:
        //            EntFioLoss1.IsVisible = true;
        //            EntFioLoss2.IsVisible = false;
        //            EntFioLoss3.IsVisible = false;
        //            EntFioLoss4.IsVisible = false;
        //            break;
        //        case 1:
        //            EntFioLoss1.IsVisible = true;
        //            EntFioLoss2.IsVisible = true;
        //            EntFioLoss3.IsVisible = false;
        //            EntFioLoss4.IsVisible = false;
        //            break;
        //        case 2:
        //            EntFioLoss1.IsVisible = true;
        //            EntFioLoss2.IsVisible = true;
        //            EntFioLoss3.IsVisible = true;
        //            EntFioLoss4.IsVisible = false;
        //            break;
        //        case 3:
        //            EntFioLoss1.IsVisible = true;
        //            EntFioLoss2.IsVisible = true;
        //            EntFioLoss3.IsVisible = true;
        //            EntFioLoss4.IsVisible = true;
        //            break;
        //    }
        //}
        //private void PckQuanPeopleCar_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch (PckQuanPeopleCar.SelectedIndex)
        //    {
        //        case 0:
        //            FrmFio2.IsVisible = false;
        //            FrmFio3.IsVisible = false;
        //            FrmFio4.IsVisible = false;
        //            break;
        //        case 1:
        //            FrmFio2.IsVisible = true;
        //            FrmFio3.IsVisible = false;
        //            FrmFio4.IsVisible = false;
        //            break;
        //        case 2:
        //            FrmFio2.IsVisible = true;
        //            FrmFio3.IsVisible = true;
        //            FrmFio4.IsVisible = false;
        //            break;
        //        case 3:
        //            FrmFio2.IsVisible = true;
        //            FrmFio3.IsVisible = true;
        //            FrmFio4.IsVisible = true;
        //            break;
        //    }
        //}
        //private void PckQuanCar_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (PckQuanCar.SelectedIndex == 0)
        //        FrmCar2.IsVisible = false;
        //    else
        //        FrmCar2.IsVisible = true;
        //}

        //string imagePath = "";
        //async void BtnLoadImage_Clicked(object sender, EventArgs e)
        //{
        //    (sender as Button).IsEnabled = false;
        //    Stream stream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync();
        //    if (stream != null)
        //    {
        //        ImgDTp.Source = ImageSource.FromStream(() => stream);
        //        //imagePath = Convert.ToString(ImgDTp.GetValue(ImageFilePathProperty));
        //    }
        //    (sender as Button).IsEnabled = true;
        //}
        //public static readonly BindableProperty ImageFilePathProperty =
        //BindableProperty.CreateAttached("ImageFilePath", typeof(string), typeof(Image), null);

        //public static void SetImageFilePath(BindableObject view, string value)
        //{
        //    view.SetValue(ImageFilePathProperty, value);
        //}
        //public static string GetImageFilePath(BindableObject view)
        //{
        //    return Convert.ToString(view.GetValue(ImageFilePathProperty));
        //}
        //private async void BtnSaveData_Clicked(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        await App.Database.SavePersonAsync(new DTP
        //        {
        //            //тип дпт
        //            TypeDTP = Convert.ToString(PckTypeDTP.SelectedItem),
        //            //место проишествия
        //            City = EntCity.Text,
        //            Street = EntStreet.Text,
        //            Home = EntHome.Text,
        //            CommentCity = EntComment1.Text,
        //            //сведения о дтп
        //            DateTimeDtp = new DateTime(DtpDate.Date.Year, DtpDate.Date.Month, DtpDate.Date.Day, TmpTime.Time.Hours, TmpTime.Time.Minutes, TmpTime.Time.Seconds),
        //            SideMove = Convert.ToString(PckSideMove.SelectedItem),
        //            RowMove = Convert.ToInt32(PckRowMove.SelectedItem),
        //            QuanCar = Convert.ToInt32(PckQuanCar.SelectedItem),
        //            CommentDTP = EntComment2.Text,
        //            //сведения об авто 1
        //            StampCar1 = EntStampCar1.Text,
        //            StateNumber1 = EntStateNumber1.Text,
        //            ColorCar1 = EntColorCar1.Text,
        //            PTSCar1 = EntPTSCar1.Text,
        //            RegNumber1 = EntRegNumber1.Text,
        //            CommentCar1 = EntComment3_1.Text,
        //            //сведения об авто 2
        //            StampCar2 = EntStampCar2.Text,
        //            StateNumber2 = EntStateNumber2.Text,
        //            ColorCar2 = EntColorCar2.Text,
        //            PTSCar2 = EntPTSCar2.Text,
        //            RegNumber2 = EntRegNumber2.Text,
        //            CommentCar2 = EntComment3_2.Text,
        //            //участники дтп
        //            QuanPeople = Convert.ToInt32(PckQuanPeopleCar.SelectedItem),
        //            FIOPeople1 = EntFioPeople1.Text,
        //            NumberAdoption1 = EntNumberAdoption1.Text,
        //            //
        //            FIOPeople2 = EntFioPeople1.Text,
        //            NumberAdoption2 = EntNumberAdoption1.Text,
        //            FIOPeople3 = EntFioPeople1.Text,
        //            NumberAdoption3 = EntNumberAdoption1.Text,
        //            FIOPeople4 = EntFioPeople1.Text,
        //            NumberAdoption4 = EntNumberAdoption1.Text,
        //            CommentPeopleDTP = EntComment4.Text,
        //            //жертвы и постадавшие
        //            QuanVictim = Convert.ToInt32(PckQuanPeopVictim.SelectedItem),
        //            FIOVictim1 = EntFioVictim1.Text,
        //            FIOVictim2 = EntFioVictim2.Text,
        //            FIOVictim3 = EntFioVictim3.Text,
        //            FIOVictim4 = EntFioVictim4.Text,
        //            QuanLoss = Convert.ToInt32(PckQuanPeopLoss.SelectedItem),
        //            FIOLoss1 = EntFioLoss1.Text,
        //            FIOLoss2 = EntFioLoss2.Text,
        //            FIOLoss3 = EntFioLoss3.Text,
        //            FIOLoss4 = EntFioLoss4.Text,
        //            CommentVictimDTP = EntComment5.Text

        //        });
        //        await DisplayAlert("Информация", "Данные были успешно сохранены!", null, "ОК");
        //    }
        //    catch (Exception ex)
        //    {
        //        await DisplayAlert("Ошибка", "Произошла критическая ошибка приложения!" + ex.ToString(), null, "ОК");
        //    }
        //}

        //private void BtnBack_Clicked(object sender, EventArgs e)

        //{
        //    App.Current.MainPage = new NavigationPage(new ItemsPage());
        //}
    }
}

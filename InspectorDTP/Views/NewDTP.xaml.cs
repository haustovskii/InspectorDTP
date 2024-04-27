using InspectorDTP.AppData;
using InspectorDTP.ViewModels;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InspectorDTP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage : ContentPage
    {

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
            DtpDate.Date = DateTime.Now;
            TmpTime.Time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }
        ImageSource imageSource;
        System.Drawing.Image ImgView;
        string filePath;
        System.IO.Stream stream;
        string testStr;
        private void CkbHaveVictims_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (CkbHaveVictims.IsChecked)
            {
                LbKolVictim.IsVisible = true;
                PckQuanPeopVictim.IsVisible = true;
            }
            else
            {
                LbKolVictim.IsVisible = false;
                PckQuanPeopVictim.IsVisible = false;
            }
        }

        private void CkbHaveLoss_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (CkbHaveLoss.IsChecked)
            {
                LbKolLoss.IsVisible = true;
                PckQuanPeopLoss.IsVisible = true;
            }
            else
            {
                LbKolLoss.IsVisible = false;
                PckQuanPeopLoss.IsVisible = false;
            }
        }
        private void PckQuanPeopVictim_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (PckQuanPeopVictim.SelectedIndex)
            {
                case 0:
                    EntFioVictim1.IsVisible = true;
                    EntFioVictim2.IsVisible = false;
                    EntFioVictim3.IsVisible = false;
                    EntFioVictim4.IsVisible = false;
                    break;
                case 1:
                    EntFioVictim1.IsVisible = true;
                    EntFioVictim2.IsVisible = true;
                    EntFioVictim3.IsVisible = false;
                    EntFioVictim4.IsVisible = false;
                    break;
                case 2:
                    EntFioVictim1.IsVisible = true;
                    EntFioVictim2.IsVisible = true;
                    EntFioVictim3.IsVisible = true;
                    EntFioVictim4.IsVisible = false;
                    break;
                case 3:
                    EntFioVictim1.IsVisible = true;
                    EntFioVictim2.IsVisible = true;
                    EntFioVictim3.IsVisible = true;
                    EntFioVictim4.IsVisible = true;
                    break;
            }
        }
        private void PckQuanPeopLoss_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (PckQuanPeopLoss.SelectedIndex)
            {
                case 0:
                    EntFioLoss1.IsVisible = true;
                    EntFioLoss2.IsVisible = false;
                    EntFioLoss3.IsVisible = false;
                    EntFioLoss4.IsVisible = false;
                    break;
                case 1:
                    EntFioLoss1.IsVisible = true;
                    EntFioLoss2.IsVisible = true;
                    EntFioLoss3.IsVisible = false;
                    EntFioLoss4.IsVisible = false;
                    break;
                case 2:
                    EntFioLoss1.IsVisible = true;
                    EntFioLoss2.IsVisible = true;
                    EntFioLoss3.IsVisible = true;
                    EntFioLoss4.IsVisible = false;
                    break;
                case 3:
                    EntFioLoss1.IsVisible = true;
                    EntFioLoss2.IsVisible = true;
                    EntFioLoss3.IsVisible = true;
                    EntFioLoss4.IsVisible = true;
                    break;
            }
        }
        private void PckQuanPeopleCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (PckQuanPeopleCar.SelectedIndex)
            {
                case 0:
                    FrmFio2.IsVisible = false;
                    FrmFio3.IsVisible = false;
                    FrmFio4.IsVisible = false;
                    break;
                case 1:
                    FrmFio2.IsVisible = true;
                    FrmFio3.IsVisible = false;
                    FrmFio4.IsVisible = false;
                    break;
                case 2:
                    FrmFio2.IsVisible = true;
                    FrmFio3.IsVisible = true;
                    FrmFio4.IsVisible = false;
                    break;
                case 3:
                    FrmFio2.IsVisible = true;
                    FrmFio3.IsVisible = true;
                    FrmFio4.IsVisible = true;
                    break;
            }
        }
        string imagePath;
        async void BtnLoadImage_Clicked(object sender, EventArgs e)
        {
            // Проверяем, есть ли у нас разрешение на чтение из хранилища
            var status = await Permissions.CheckStatusAsync<Permissions.StorageRead>();

            // Если разрешение не было предоставлено, запрашиваем его у пользователя
            if (status != Xamarin.Essentials.PermissionStatus.Granted)
            {
                status = await Permissions.RequestAsync<Permissions.StorageRead>();
                if (status != Xamarin.Essentials.PermissionStatus.Granted)
                {
                    // Если пользователь не предоставил разрешение, выводим сообщение об ошибке
                    await DisplayAlert("Ошибка", "Не удалось получить доступ к хранилищу телефона", "OK");
                    return;
                }
            }

            // Открываем диалоговое окно для выбора фотографии
            var result = await MediaPicker.PickPhotoAsync();

            // Если пользователь выбрал фотографию, загружаем ее в ImgDTp
            if (result != null)
            {
                ImgDTp.Source = ImageSource.FromFile(result.FullPath);
                // Сохраняем путь к выбранной фотографии
                string imagePath = result.FullPath;
            }

        }
        private void PckQuanCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PckQuanCar.SelectedIndex == 0)
                FrmCar2.IsVisible = false;
            else
                FrmCar2.IsVisible = true;
        }
        private async void BtnSaveData_Clicked(object sender, EventArgs e)
        {
            try
            {
                await App.Database.SaveDTPAsync(new DTP
                {
                    //тип дпт
                    TypeDTP = Convert.ToString(PckTypeDTP.SelectedItem),
                    //место проишествия
                    City = EntCity.Text,
                    Street = EntStreet.Text,
                    Home = EntHome.Text,
                    CommentCity = EntComment1.Text,
                    //сведения о дтп
                    DateTimeDtp = new DateTime(DtpDate.Date.Year, DtpDate.Date.Month, 
                    DtpDate.Date.Day, TmpTime.Time.Hours, TmpTime.Time.Minutes, TmpTime.Time.Seconds),
                    SideMove = Convert.ToString(PckSideMove.SelectedItem),
                    RowMove = Convert.ToInt32(PckRowMove.SelectedItem),
                    QuanCar = Convert.ToInt32(PckQuanCar.SelectedItem),
                    CommentDTP = EntComment2.Text,
                    //сведения об авто 1
                    StampCar1 = EntStampCar1.Text,
                    StateNumber1 = EntStateNumber1.Text,
                    ColorCar1 = EntColorCar1.Text,
                    PTSCar1 = EntPTSCar1.Text,
                    RegNumber1 = EntRegNumber1.Text,
                    CommentCar1 = EntComment3_1.Text,
                    //сведения об авто 2
                    StampCar2 = EntStampCar2.Text,
                    StateNumber2 = EntStateNumber2.Text,
                    ColorCar2 = EntColorCar2.Text,
                    PTSCar2 = EntPTSCar2.Text,
                    RegNumber2 = EntRegNumber2.Text,
                    CommentCar2 = EntComment3_2.Text,
                    //участники дтп
                    QuanPeople = Convert.ToInt32(PckQuanPeopleCar.SelectedItem),
                    FIOPeople1 = EntFioPeople1.Text,
                    NumberAdoption1 = EntNumberAdoption1.Text,
                    FIOPeople2 = EntFioPeople1.Text,
                    NumberAdoption2 = EntNumberAdoption1.Text,
                    FIOPeople3 = EntFioPeople1.Text,
                    NumberAdoption3 = EntNumberAdoption1.Text,
                    FIOPeople4 = EntFioPeople1.Text,
                    NumberAdoption4 = EntNumberAdoption1.Text,
                    CommentPeopleDTP = EntComment4.Text,
                    //жертвы и постадавшие
                    QuanVictim = Convert.ToInt32(PckQuanPeopVictim.SelectedItem),
                    FIOVictim1 = EntFioVictim1.Text,
                    FIOVictim2 = EntFioVictim2.Text,
                    FIOVictim3 = EntFioVictim3.Text,
                    FIOVictim4 = EntFioVictim4.Text,
                    QuanLoss = Convert.ToInt32(PckQuanPeopLoss.SelectedItem),
                    FIOLoss1 = EntFioLoss1.Text,
                    FIOLoss2 = EntFioLoss2.Text,
                    FIOLoss3 = EntFioLoss3.Text,
                    FIOLoss4 = EntFioLoss4.Text,
                    CommentVictimDTP = EntComment5.Text,
                    SourceImageDTP = imagePath
                });
                await DisplayAlert("Информация", "Данные были успешно сохранены!", null, "ОК");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ошибка", "Произошла критическая ошибка приложения!" + ex.ToString(), null, "ОК");
            }
        }

    }
}

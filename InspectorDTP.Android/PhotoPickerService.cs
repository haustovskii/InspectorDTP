﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using InspectorDTP.AppData;
using InspectorDTP.Droid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhotoPickerService))]
namespace InspectorDTP.Droid
{
    public class PhotoPickerService : IPhotoPickerService
    {
        public Task<Stream> GetImageStreamAsync()
        {
            Intent intent = new Intent();
            intent.SetType("image/*");
            intent.SetAction(Intent.ActionGetContent);

            MainActivity.Instance.StartActivityForResult(Intent.CreateChooser(intent, "Select Photo"), MainActivity.PickImageId);

            MainActivity.Instance.PickImageTaskCompletionSource = new TaskCompletionSource<Stream>();

            return MainActivity.Instance.PickImageTaskCompletionSource.Task;
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace InspectorDTP.AppData
{
    public interface IPhotoPickerService
    {
        Task<Stream> GetImageStreamAsync(); 
    }
}

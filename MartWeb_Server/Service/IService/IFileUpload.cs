﻿using Microsoft.AspNetCore.Components.Forms;

namespace MartWeb_Server.Service.IService
{
    public interface IFileUpload
    {
        Task<string> UploadFile(IBrowserFile file);
        bool DeleteFile(string filePath);
    }
}

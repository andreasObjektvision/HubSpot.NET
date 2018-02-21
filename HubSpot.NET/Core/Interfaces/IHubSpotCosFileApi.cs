using HubSpot.NET.Api.Files.Dto;

namespace HubSpot.NET.Core.Interfaces
{
    public interface IHubSpotCosFileApi
    {
        FolderHubSpotModel CreateFolder(FolderHubSpotModel folder);
        T Upload<T>(T entity) where T: FileHubSpotModel, new();
        FileListHubSpotModel<T> List<T>(ListRequestOptions opts = null) where T : FileHubSpotModel, new();
    }
}
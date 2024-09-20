namespace AzureFunctionsApp.Shared.Services.Interfaces;

public interface IDataService
{
    string GetData();
    Task<string> GetDataAsync();

    Task<string> SomeLongRunningOperationAsync();

    Task DoAnotherAsyncOperationAsync();
}
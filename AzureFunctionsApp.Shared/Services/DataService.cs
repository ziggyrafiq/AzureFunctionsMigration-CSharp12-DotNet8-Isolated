using AzureFunctionsApp.Shared.Services.Interfaces;

namespace AzureFunctionsApp.Shared.Services;

//OLD WAY
//public class DataService
//{
//    public async Task<string> GetData()
//    {

//        var data = await SomeLongRunningOperation();


//        await DoAnotherAsyncOperation();


//        return data;
//    }


//    public async Task<string> SomeLongRunningOperation()
//    {
//        await Task.Delay(1000); 
//        return "Data from long-running operation";
//    }


//    public async Task DoAnotherAsyncOperation()
//    {
//        await Task.Delay(500); 
//    }
//}

using AzureFunctionsApp.Shared.Services.Interfaces;
public class DataService: IDataService
{
    public string GetData()
    {
        return "Hello from Ziggy Rafiq!"; 
    }

    public async Task<string> GetDataAsync()
    {
        
        var data = await SomeLongRunningOperationAsync();

        
        await DoAnotherAsyncOperationAsync();

        
        return data;
    }

    
    public async Task<string> SomeLongRunningOperationAsync()
    {
        await Task.Delay(1000); 
        return "Long-running operation result";
    }

    public async Task DoAnotherAsyncOperationAsync()
    {
        await Task.Delay(500);
    }
}

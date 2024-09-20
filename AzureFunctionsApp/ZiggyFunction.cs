using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AzureFunctionsApp;

public class ZiggyFunction
{
    private readonly ILogger<ZiggyFunction> _logger;
    private readonly IConfiguration _configuration;

    public ZiggyFunction(ILogger<ZiggyFunction> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    
    [Function(nameof(ZiggyFunction))]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        string? ziggyAppSettingConfiguration = string.IsNullOrWhiteSpace(_configuration["ZiggyAppSetting"]) ? "ZiggyDefaultValue": _configuration["ZiggyAppSetting"];

        _logger.LogInformation("Hello from Ziggy Rafiq");
        return new OkObjectResult("Welcome to Ziggy Azure Functions!");
    }
}

using System;
using Azure;
using microsoft.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
namespace microsoft.Controllers;

[ApiController]
[Route("[controller]")]
public class CosmosDBServiceController : ControllerBase
{
    public static string databaseName = "ToDoList";
    public static string containerName = "Items";
    public static CosmosClient cosmosClient = new CosmosClient(connectionString);
    public Database dataBase = cosmosClient.GetDatabase(databaseName);
    public Container container = cosmosClient.GetContainer(databaseName, containerName);

    public CosmosDBServiceController() { }

    // Add to Cosmos
    [HttpGet]
    public async Task<ItemResponse<Recipe>> Get()
    {
        var example = new Recipe("example", true, "i1", "i2", "i3");

        var response = await container.CreateItemAsync(example);
        Console.WriteLine($"Response from adding to DB {response}");
        return response;

    }
}



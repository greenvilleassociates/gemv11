using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

[ApiController]
[Route("[controller]")]
public class WordPressGridController : ControllerBase
{
    private static readonly HttpClient httpClient = new HttpClient();
    private readonly string[] webServerNodes = {
        "https://10.144.0.152/fusionpro/w/rest/post/",
        "https://10.144.1.151/fusionpro/w/rest/post/",
        "https://10.144.2.151/fusionpro/w/rest/post/",
        "https://10.144.3.151/fusionpro/w/rest/post/"
    };

    [HttpPost]
    public async Task<IActionResult> SubmitGridData([FromQuery] int gridNumber, [FromQuery] string textMessage, [FromQuery] string mediaUrl)
    {
        // Validate Grid Number
        if (gridNumber <= 0)
        {
            return BadRequest(new { Error = "Grid number must be a positive integer." });
        }

        // Validate Text Length (≤ 500 words)
        if (string.IsNullOrWhiteSpace(textMessage) || textMessage.Split(' ').Length > 500)
        {
            return BadRequest(new { Error = "Text message must be between 1 and 500 words." });
        }

        // Validate Media URL (.jpg, .png, .mp4, .mov)
        if (string.IsNullOrWhiteSpace(mediaUrl) || (!mediaUrl.StartsWith("http") || (!mediaUrl.EndsWith(".jpg") && !mediaUrl.EndsWith(".png") && !mediaUrl.EndsWith(".mp4") && !mediaUrl.EndsWith(".mov"))))
        {
            return BadRequest(new { Error = "Invalid media URL. Only .jpg, .png, .mp4, or .mov formats are allowed." });
        }

        var requestData = new
        {
            GridNumber = gridNumber,
            TextMessage = textMessage,
            MediaUrl = mediaUrl
        };

        var jsonContent = new StringContent(JsonSerializer.Serialize(requestData), Encoding.UTF8, "application/json");

        var responses = new List<object>();

        foreach (var webServer in webServerNodes)
        {
            try
            {
                var response = await httpClient.PostAsync(webServer, jsonContent);
                string result = await response.Content.ReadAsStringAsync();
                responses.Add(new { Server = webServer, Status = response.StatusCode, Response = result });
            }
            catch (Exception ex)
            {
                responses.Add(new { Server = webServer, Status = "Failed", Error = ex.Message });
            }
        }

        return Ok(new
        {
            SubmittedGrid = requestData,
            WebServerResponses = responses
        });
    }
}

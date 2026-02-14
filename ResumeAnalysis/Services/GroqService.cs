using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Newtonsoft.Json;
using System.Text;

namespace ResumeAnalysis.Services
{
    public class GroqService
    {
        private readonly IConfiguration _config;
        private  readonly HttpClient _httpClient;

        public GroqService(IConfiguration config, HttpClient httpClient)
        {
            _config = config;
            _httpClient = httpClient;
        }

        public async Task<string> AnalyzeResumeAsync(string resumeText,string company,string role)
        {
            var apikey = _config["Groq:ApiKey"];

            var prompt = $@"
Analyze this resume for the role of {role} at {company}.

Return STRICT JSON only in this format:

{{
  ""matchPercentage"": number,
  ""strengths"": ""text"",
  ""weaknesses"": ""text"",
  ""improvements"": ""text"",
  ""companyFitAnalysis"": ""text""
}}

Resume:
{resumeText}
";


            var requestBody = new
            {
             model= "llama-3.1-8b-instant",
                messages = new[]
                {
                   new { role = "system", content = "You are an expert HR and technical recruiter." },
                    new { role = "user", content = prompt }
                }
            };

            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.groq.com/openai/v1/chat/completions");
            request.Headers.Add("Authorization", $"Bearer {apikey}");
            request.Content = new StringContent(
                JsonConvert.SerializeObject(requestBody),
                 Encoding.UTF8,
                "application/json"
                );

            var response = await _httpClient.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return $"Groq API Error: {result}";
            }

            var json = JsonConvert.DeserializeObject<dynamic>(result);

            string aiContent = json?.choices?[0]?.message?.content?.ToString();

            return aiContent ?? "No response from AI.";



        }
    }
}

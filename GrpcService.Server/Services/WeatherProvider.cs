using System.Threading.Tasks;
using Grpc.Core;

namespace GrpcService.Server.Services
{
    public class WeatherProvider : WeatherService.WeatherServiceBase
    {
        // This is the service name we defined in the proto file - GetWeather
        public override Task<WeatherResponse> GetWeather(GetCityWeather request, ServerCallContext context)
        {
            var city = request.City;
            var unit = request.Unit;
            
            // Do the service logic here...
            
            return Task.FromResult(new WeatherResponse
            {
                Temperature = 123,
                FeelsLike = 567
            });
        }
    }
}
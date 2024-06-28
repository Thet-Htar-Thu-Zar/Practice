namespace Middleware
{
    public static class LoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }

        public static IApplicationBuilder AddMiddleware(this WebApplication app)
        {
            return app.UseMiddleware<LoggingMiddleware>();
        }
    }
}

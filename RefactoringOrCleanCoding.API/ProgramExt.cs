namespace RefactoringOrCleanCoding.API
{
    public static class ProgramExt
    {
        public static IServiceCollection AddCommonService(this IServiceCollection services)
        {
            services.AddSession();
            services.AddMemoryCache();
            services.AddAntiforgery();

            return services;
        }
    }
}
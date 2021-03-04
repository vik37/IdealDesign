using IdealDesign_Services.Helper.ModelResource;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace IdealDesign_Services.Helper
{
    public static class MvcOptionsExtension
    {
        public static IMvcBuilder AddModelBindingMessagesLocalizer(this IMvcBuilder builder,IServiceCollection services)
        {
            return builder.AddMvcOptions(option =>
            {
                var type = typeof(MyDataAnnotation);
                var assamblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
                var factory = services.BuildServiceProvider().GetService<IStringLocalizerFactory>();
                var localizer = factory.Create("MyDataAnnotation", assamblyName.Name);

                option.ModelBindingMessageProvider
                      .SetAttemptedValueIsInvalidAccessor((x, y) => localizer["'{0}' is not a valid value for {1}", x, y]);

                option.ModelBindingMessageProvider
                      .SetValueMustBeANumberAccessor((x) => localizer["'{0}' must be a number.", x]);
            });
        }
    }
}

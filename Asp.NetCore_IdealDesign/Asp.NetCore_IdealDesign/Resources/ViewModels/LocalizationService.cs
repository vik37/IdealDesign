using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Asp.NetCore_IdealDesign.Resources.ViewModels
{
    public class LocalizationService
    {
        private readonly IStringLocalizer _localizer;
        public LocalizationService(IStringLocalizerFactory factory)
        {
            var type = typeof(AplicationResource);
            var asseamblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _localizer = factory.Create("AplicationResource", asseamblyName.Name);
        }
        public LocalizedString GetLocalizedHtmlString(string key)
        {
            return _localizer[key];
        }

    }
}

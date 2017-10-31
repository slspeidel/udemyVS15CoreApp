using Microsoft.AspNetCore.Mvc;
using MySecondVS15CoreApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondVS15CoreApp.ViewComponents
{
    public class FirstViewComponent : ViewComponent
    {
        private IMyInjectedService _service;

        public FirstViewComponent(IMyInjectedService service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var myGuidService = await GetGuidService();
            return View("Default", myGuidService);
        }

        private async Task<IMyInjectedService> GetGuidService()
        {
            return await Task.FromResult(_service);
        }
    }
}

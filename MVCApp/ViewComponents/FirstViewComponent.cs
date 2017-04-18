using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Services;

namespace MVCApp.ViewComponents
{
    public class FirstViewComponent:ViewComponent
    {
        private IMyInjectedService myService;

        public FirstViewComponent(IMyInjectedService service)
        {
            myService = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var myItem = await GetGuid();
            return View("Default", myItem);
        }

        public async Task<IMyInjectedService> GetGuid()
        {
            return await Task.FromResult(myService);
        }
    }
}

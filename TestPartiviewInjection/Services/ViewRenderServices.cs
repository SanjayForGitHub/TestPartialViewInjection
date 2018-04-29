using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestPartiviewInjection.Services
{
    public class ViewRenderServices : IViewRenderService
    {
        public string RenderHTML()
        {
            return "<div><h1>Hello World##PARTIALVIEW##</h1></div>";
        }
    }
}

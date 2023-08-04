using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Components.BaseComponents
{
	public class BaseCounterComponent : ComponentBase
	{
		[Parameter]
        public int Count { get; set; }
	}
}

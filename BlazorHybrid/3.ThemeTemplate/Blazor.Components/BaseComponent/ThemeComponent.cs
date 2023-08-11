using Blazor.Components.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Components.BaseComponent;

public class ThemeComponent : ComponentBase
{
	[Parameter]
	public int? Width { get; set; } = null;

	[Parameter]
	public int? Height { get; set; } = null;

	[CascadingParameter]
	public ThemeInfo? ThemeInfo { get; set; } = null;
}

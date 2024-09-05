using Microsoft.AspNetCore.Components;

namespace Icon;

public partial class Help
{
	/// <summary>
	///		颜色。默认值：inherit
	/// </summary>
	[Parameter]
	public string Color { get; set; } = "inherit";
}

using Microsoft.AspNetCore.Components;

namespace Icon;

/// <summary>
///		帮助图标
/// </summary>
public partial class Help
{
	/// <summary>
	///		颜色。默认值：inherit
	/// </summary>
	[Parameter]
	public string Color { get; set; } = "inherit";
}

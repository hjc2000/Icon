using Microsoft.AspNetCore.Components;

namespace Icon;

/// <summary>
///		终端图标。
/// </summary>
public partial class Terminal
{
	/// <summary>
	///		颜色。默认值：inherit
	/// </summary>
	[Parameter]
	public string Color { get; set; } = "inherit";
}

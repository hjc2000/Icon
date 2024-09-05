using Microsoft.AspNetCore.Components;

namespace Icon;

/// <summary>
///		大脑图标
/// </summary>
public partial class Brain
{
	/// <summary>
	///		颜色。默认值：inherit
	/// </summary>
	[Parameter]
	public string Color { get; set; } = "inherit";
}

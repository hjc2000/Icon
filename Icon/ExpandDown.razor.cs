using Microsoft.AspNetCore.Components;

namespace Icon;

/// <summary>
///		展开按钮图标。箭头方向向下。
/// </summary>
public partial class ExpandDown
{
	/// <summary>
	///		颜色。默认值：inherit
	/// </summary>
	[Parameter]
	public string Color { get; set; } = "inherit";
}

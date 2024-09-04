using Microsoft.AspNetCore.Components;

namespace Icon;

/// <summary>
///		垃圾桶图标
/// </summary>
public partial class TrashCan
{
	/// <summary>
	///		颜色。默认值：inherit
	/// </summary>
	[Parameter]
	public string Color { get; set; } = "inherit";
}

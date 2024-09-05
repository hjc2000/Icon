using Microsoft.AspNetCore.Components;

namespace Icon;

/// <summary>
///		代码分析图标
/// </summary>
public partial class CodeAnalysis
{
	/// <summary>
	///		颜色。默认值：inherit
	/// </summary>
	[Parameter]
	public string Color { get; set; } = "inherit";
}

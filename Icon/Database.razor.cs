using Microsoft.AspNetCore.Components;

namespace Icon;

/// <summary>
///		数据库图标
/// </summary>
public partial class Database
{
	/// <summary>
	///		颜色。默认值：inherit
	/// </summary>
	[Parameter]
	public string Color { get; set; } = "inherit";
}

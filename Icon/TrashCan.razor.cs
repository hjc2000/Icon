using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icon;

/// <summary>
///		垃圾桶图标
/// </summary>
public partial class TrashCan
{
	/// <summary>
	///		在捕获 Parameter 的最后，捕获所有之前未捕获的 html 标签属性。
	/// </summary>
	[Parameter(CaptureUnmatchedValues = true)]
	public Dictionary<string, object>? CaptureUnmatchedValues { get; set; }
}

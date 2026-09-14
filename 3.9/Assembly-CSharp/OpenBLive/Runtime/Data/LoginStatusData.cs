using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E50 RID: 3664
	[Token(Token = "0x2000E50")]
	public struct LoginStatusData
	{
		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06004B55 RID: 19285 RVA: 0x001723A8 File Offset: 0x001705A8
		// (set) Token: 0x06004B56 RID: 19286 RVA: 0x001723B8 File Offset: 0x001705B8
		[Token(Token = "0x17000972")]
		[JsonProperty("url")]
		public string Url
		{
			[Token(Token = "0x6004B55")]
			[Address(RVA = "0x8CDBE0", Offset = "0x8CC1E0", VA = "0x1808CDBE0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6004B56")]
			[Address(RVA = "0x8CDBF0", Offset = "0x8CC1F0", VA = "0x1808CDBF0")]
			[CompilerGenerated]
			set
			{
				this.<Url>k__BackingField = value;
			}
		}
	}
}

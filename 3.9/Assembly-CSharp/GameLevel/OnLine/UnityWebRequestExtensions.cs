using System;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine.Networking;

namespace GameLevel.OnLine
{
	// Token: 0x02000B73 RID: 2931
	[Token(Token = "0x2000B73")]
	public static class UnityWebRequestExtensions
	{
		// Token: 0x06003CF4 RID: 15604 RVA: 0x0013DC84 File Offset: 0x0013BE84
		[Token(Token = "0x6003CF4")]
		[Address(RVA = "0x838EC0", Offset = "0x8374C0", VA = "0x180838EC0")]
		public static UniTask SendWebRequestAsync(this UnityWebRequest request)
		{
			return default(UniTask);
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x0013DCA0 File Offset: 0x0013BEA0
		[Token(Token = "0x6003CF5")]
		[Address(RVA = "0x838F80", Offset = "0x837580", VA = "0x180838F80")]
		public static UniTask SendWebRequestAsync(this UnityWebRequest request, Action<float> progressCallback)
		{
			return default(UniTask);
		}
	}
}

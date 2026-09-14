using System;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine.Networking;

namespace GameLevel.OnLine
{
	// Token: 0x02000B31 RID: 2865
	[Token(Token = "0x2000B31")]
	public static class UnityWebRequestExtensions
	{
		// Token: 0x06003BA3 RID: 15267 RVA: 0x001389DC File Offset: 0x00136BDC
		[Token(Token = "0x6003BA3")]
		[Address(RVA = "0x7BCB70", Offset = "0x7BB170", VA = "0x1807BCB70")]
		public static UniTask SendWebRequestAsync(this UnityWebRequest request)
		{
			return default(UniTask);
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x001389F8 File Offset: 0x00136BF8
		[Token(Token = "0x6003BA4")]
		[Address(RVA = "0x7BCC30", Offset = "0x7BB230", VA = "0x1807BCC30")]
		public static UniTask SendWebRequestAsync(this UnityWebRequest request, Action<float> progressCallback)
		{
			return default(UniTask);
		}
	}
}

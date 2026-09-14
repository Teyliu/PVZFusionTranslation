using System;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;

namespace GameLevel.OnLine
{
	// Token: 0x02000B29 RID: 2857
	[Token(Token = "0x2000B29")]
	public class OnlineLevelLoader
	{
		// Token: 0x06003B8D RID: 15245 RVA: 0x001382C4 File Offset: 0x001364C4
		[Token(Token = "0x6003B8D")]
		[Address(RVA = "0x7B46A0", Offset = "0x7B2CA0", VA = "0x1807B46A0")]
		public UniTask<OnlineLevelListResponse> GetOnlineLevelsAsync()
		{
			return default(UniTask<OnlineLevelListResponse>);
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x001382E4 File Offset: 0x001364E4
		[Token(Token = "0x6003B8E")]
		[Address(RVA = "0x7B44A0", Offset = "0x7B2AA0", VA = "0x1807B44A0")]
		public UniTask<CustomLevelData> DownloadLevelDirectAsync(string levelId)
		{
			return default(UniTask<CustomLevelData>);
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x00138304 File Offset: 0x00136504
		[Token(Token = "0x6003B8F")]
		[Address(RVA = "0x7B4790", Offset = "0x7B2D90", VA = "0x1807B4790")]
		public static UniTask<string> GetQQGroup()
		{
			return default(UniTask<string>);
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x00138324 File Offset: 0x00136524
		[Token(Token = "0x6003B90")]
		[Address(RVA = "0x7B41A0", Offset = "0x7B27A0", VA = "0x1807B41A0")]
		public static UniTask<bool> CheckAPIKey()
		{
			return default(UniTask<bool>);
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x00138344 File Offset: 0x00136544
		[Token(Token = "0x6003B91")]
		[Address(RVA = "0x7B45B0", Offset = "0x7B2BB0", VA = "0x1807B45B0")]
		public UniTask<OnlineLevelListResponse> GetOnlineLevelsAsyncWithoutKey()
		{
			return default(UniTask<OnlineLevelListResponse>);
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x00138364 File Offset: 0x00136564
		[Token(Token = "0x6003B92")]
		[Address(RVA = "0x7B4390", Offset = "0x7B2990", VA = "0x1807B4390")]
		public UniTask<CustomLevelData> DownloadLevelDirectAsyncWithoutKey(string levelId)
		{
			return default(UniTask<CustomLevelData>);
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x00138384 File Offset: 0x00136584
		[Token(Token = "0x6003B93")]
		[Address(RVA = "0x7B4280", Offset = "0x7B2880", VA = "0x1807B4280")]
		public UniTask<OnlineLevelApiResponse> DeleteUserLevelAsync(string levelId)
		{
			return default(UniTask<OnlineLevelApiResponse>);
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x001383A4 File Offset: 0x001365A4
		[Token(Token = "0x6003B94")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public OnlineLevelLoader()
		{
		}

		// Token: 0x04002BF8 RID: 11256
		[Token(Token = "0x4002BF8")]
		public const string ServerBaseUrl = "http://121.196.227.142:3000/api";

		// Token: 0x04002BF9 RID: 11257
		[Token(Token = "0x4002BF9")]
		public const int TimeoutSeconds = 30;
	}
}

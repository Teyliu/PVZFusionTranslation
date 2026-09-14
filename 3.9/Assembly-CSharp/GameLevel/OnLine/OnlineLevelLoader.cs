using System;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;

namespace GameLevel.OnLine
{
	// Token: 0x02000B6B RID: 2923
	[Token(Token = "0x2000B6B")]
	public class OnlineLevelLoader
	{
		// Token: 0x06003CDE RID: 15582 RVA: 0x0013D5A0 File Offset: 0x0013B7A0
		[Token(Token = "0x6003CDE")]
		[Address(RVA = "0x82FFE0", Offset = "0x82E5E0", VA = "0x18082FFE0")]
		public UniTask<OnlineLevelListResponse> GetOnlineLevelsAsync()
		{
			return default(UniTask<OnlineLevelListResponse>);
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x0013D5C0 File Offset: 0x0013B7C0
		[Token(Token = "0x6003CDF")]
		[Address(RVA = "0x82FDE0", Offset = "0x82E3E0", VA = "0x18082FDE0")]
		public UniTask<CustomLevelData> DownloadLevelDirectAsync(string levelId)
		{
			return default(UniTask<CustomLevelData>);
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x0013D5E0 File Offset: 0x0013B7E0
		[Token(Token = "0x6003CE0")]
		[Address(RVA = "0x8300D0", Offset = "0x82E6D0", VA = "0x1808300D0")]
		public static UniTask<string> GetQQGroup()
		{
			return default(UniTask<string>);
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x0013D600 File Offset: 0x0013B800
		[Token(Token = "0x6003CE1")]
		[Address(RVA = "0x82FAE0", Offset = "0x82E0E0", VA = "0x18082FAE0")]
		public static UniTask<bool> CheckAPIKey()
		{
			return default(UniTask<bool>);
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x0013D620 File Offset: 0x0013B820
		[Token(Token = "0x6003CE2")]
		[Address(RVA = "0x82FEF0", Offset = "0x82E4F0", VA = "0x18082FEF0")]
		public UniTask<OnlineLevelListResponse> GetOnlineLevelsAsyncWithoutKey()
		{
			return default(UniTask<OnlineLevelListResponse>);
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x0013D640 File Offset: 0x0013B840
		[Token(Token = "0x6003CE3")]
		[Address(RVA = "0x82FCD0", Offset = "0x82E2D0", VA = "0x18082FCD0")]
		public UniTask<CustomLevelData> DownloadLevelDirectAsyncWithoutKey(string levelId)
		{
			return default(UniTask<CustomLevelData>);
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x0013D660 File Offset: 0x0013B860
		[Token(Token = "0x6003CE4")]
		[Address(RVA = "0x82FBC0", Offset = "0x82E1C0", VA = "0x18082FBC0")]
		public UniTask<OnlineLevelApiResponse> DeleteUserLevelAsync(string levelId)
		{
			return default(UniTask<OnlineLevelApiResponse>);
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x0013D680 File Offset: 0x0013B880
		[Token(Token = "0x6003CE5")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public OnlineLevelLoader()
		{
		}

		// Token: 0x04002D6C RID: 11628
		[Token(Token = "0x4002D6C")]
		public const string ServerBaseUrl = "http://121.196.227.142:3000/api";

		// Token: 0x04002D6D RID: 11629
		[Token(Token = "0x4002D6D")]
		public const int TimeoutSeconds = 30;
	}
}

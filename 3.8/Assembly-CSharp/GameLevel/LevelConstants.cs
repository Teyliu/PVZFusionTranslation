using System;
using System.IO;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B17 RID: 2839
	[Token(Token = "0x2000B17")]
	public static class LevelConstants
	{
		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06003B48 RID: 15176 RVA: 0x00136DB8 File Offset: 0x00134FB8
		[Token(Token = "0x1700049B")]
		public static string LevelFolderPath
		{
			[Token(Token = "0x6003B48")]
			[Address(RVA = "0x7B1200", Offset = "0x7AF800", VA = "0x1807B1200")]
			get
			{
				return Path.Combine(SaveInfo.GetDataPath(), "LevelData", "Levels");
			}
		}

		// Token: 0x04002B9D RID: 11165
		[Token(Token = "0x4002B9D")]
		public const string JsonExtension = "*.json";

		// Token: 0x04002B9E RID: 11166
		[Token(Token = "0x4002B9E")]
		public const int DefaultStartSun = 500;

		// Token: 0x04002B9F RID: 11167
		[Token(Token = "0x4002B9F")]
		public const int DefaultMaxWave = 10;

		// Token: 0x04002BA0 RID: 11168
		[Token(Token = "0x4002BA0")]
		public const int DefaultCardCount = 14;

		// Token: 0x04002BA1 RID: 11169
		[Token(Token = "0x4002BA1")]
		public const string ErrorDeserializeFailed = "反序列化失败，数据为空";

		// Token: 0x04002BA2 RID: 11170
		[Token(Token = "0x4002BA2")]
		public const string ErrorFileNotFound = "文件不存在: {0}";

		// Token: 0x04002BA3 RID: 11171
		[Token(Token = "0x4002BA3")]
		public const string ErrorDeleteFailed = "删除关卡失败: {0}";

		// Token: 0x04002BA4 RID: 11172
		[Token(Token = "0x4002BA4")]
		public const string ErrorReadFileFailed = "读取文件失败: {0}\n错误信息: {1}";

		// Token: 0x04002BA5 RID: 11173
		[Token(Token = "0x4002BA5")]
		public const string WarningDuplicateLevel = "发现重复关卡：{0}-{1}，已覆盖";

		// Token: 0x04002BA6 RID: 11174
		[Token(Token = "0x4002BA6")]
		public const string WarningOverwriteFile = "已经有一个同名文件了，这次会覆盖他";

		// Token: 0x04002BA7 RID: 11175
		[Token(Token = "0x4002BA7")]
		public const string SuccessFolderCreated = "创建关卡存档文件夹: {0}";

		// Token: 0x04002BA8 RID: 11176
		[Token(Token = "0x4002BA8")]
		public const string SuccessLevelLoaded = "从文件中读取到关卡：{0}，类型:{1}，编号:{2}";

		// Token: 0x04002BA9 RID: 11177
		[Token(Token = "0x4002BA9")]
		public const string SuccessLevelSaved = "已生成关卡文件: {0}";

		// Token: 0x04002BAA RID: 11178
		[Token(Token = "0x4002BAA")]
		public const string SuccessLevelOverwritten = "已覆盖并删除原关卡文件，新文件：{0}";
	}
}

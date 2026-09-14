using System;
using System.IO;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B59 RID: 2905
	[Token(Token = "0x2000B59")]
	public static class LevelConstants
	{
		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06003C99 RID: 15513 RVA: 0x0013C0F4 File Offset: 0x0013A2F4
		[Token(Token = "0x170004EB")]
		public static string LevelFolderPath
		{
			[Token(Token = "0x6003C99")]
			[Address(RVA = "0x82CB00", Offset = "0x82B100", VA = "0x18082CB00")]
			get
			{
				return Path.Combine(SaveInfo.GetDataPath(), "LevelData", "Levels");
			}
		}

		// Token: 0x04002D11 RID: 11537
		[Token(Token = "0x4002D11")]
		public const string JsonExtension = "*.json";

		// Token: 0x04002D12 RID: 11538
		[Token(Token = "0x4002D12")]
		public const int DefaultStartSun = 500;

		// Token: 0x04002D13 RID: 11539
		[Token(Token = "0x4002D13")]
		public const int DefaultMaxWave = 10;

		// Token: 0x04002D14 RID: 11540
		[Token(Token = "0x4002D14")]
		public const int DefaultCardCount = 14;

		// Token: 0x04002D15 RID: 11541
		[Token(Token = "0x4002D15")]
		public const string ErrorDeserializeFailed = "反序列化失败，数据为空";

		// Token: 0x04002D16 RID: 11542
		[Token(Token = "0x4002D16")]
		public const string ErrorFileNotFound = "文件不存在: {0}";

		// Token: 0x04002D17 RID: 11543
		[Token(Token = "0x4002D17")]
		public const string ErrorDeleteFailed = "删除关卡失败: {0}";

		// Token: 0x04002D18 RID: 11544
		[Token(Token = "0x4002D18")]
		public const string ErrorReadFileFailed = "读取文件失败: {0}\n错误信息: {1}";

		// Token: 0x04002D19 RID: 11545
		[Token(Token = "0x4002D19")]
		public const string WarningDuplicateLevel = "发现重复关卡：{0}-{1}，已覆盖";

		// Token: 0x04002D1A RID: 11546
		[Token(Token = "0x4002D1A")]
		public const string WarningOverwriteFile = "已经有一个同名文件了，这次会覆盖他";

		// Token: 0x04002D1B RID: 11547
		[Token(Token = "0x4002D1B")]
		public const string SuccessFolderCreated = "创建关卡存档文件夹: {0}";

		// Token: 0x04002D1C RID: 11548
		[Token(Token = "0x4002D1C")]
		public const string SuccessLevelLoaded = "从文件中读取到关卡：{0}，类型:{1}，编号:{2}";

		// Token: 0x04002D1D RID: 11549
		[Token(Token = "0x4002D1D")]
		public const string SuccessLevelSaved = "已生成关卡文件: {0}";

		// Token: 0x04002D1E RID: 11550
		[Token(Token = "0x4002D1E")]
		public const string SuccessLevelOverwritten = "已覆盖并删除原关卡文件，新文件：{0}";
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E11 RID: 3601
	[Token(Token = "0x2000E11")]
	public static class BApi
	{
		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06004A4F RID: 19023 RVA: 0x0016E410 File Offset: 0x0016C610
		[Token(Token = "0x1700096A")]
		private static string OpenLiveDomain
		{
			[Token(Token = "0x6004A4F")]
			[Address(RVA = "0x8C7F20", Offset = "0x8C6520", VA = "0x1808C7F20")]
			get
			{
				string text = "https://live-open.biliapi.com";
				if ("{il2cpp field on {'constant7' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x0}" != (ulong)0L)
				{
					text = "http://test-live-open.biliapi.net";
				}
				return text;
			}
		}

		// Token: 0x06004A50 RID: 19024 RVA: 0x0016E438 File Offset: 0x0016C638
		[Token(Token = "0x6004A50")]
		[Address(RVA = "0x8C7E00", Offset = "0x8C6400", VA = "0x1808C7E00")]
		public static Task<string> StartInteractivePlay(string code, string appId)
		{
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x0016E45C File Offset: 0x0016C65C
		[Token(Token = "0x6004A51")]
		[Address(RVA = "0x8C7970", Offset = "0x8C5F70", VA = "0x1808C7970")]
		public static Task<string> EndInteractivePlay(string appId, string gameId)
		{
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x06004A52 RID: 19026 RVA: 0x0016E480 File Offset: 0x0016C680
		[Token(Token = "0x6004A52")]
		[Address(RVA = "0x8C7BB0", Offset = "0x8C61B0", VA = "0x1808C7BB0")]
		public static Task<string> HeartBeatInteractivePlay(string gameId)
		{
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x0016E4A4 File Offset: 0x0016C6A4
		[Token(Token = "0x6004A53")]
		[Address(RVA = "0x8C7880", Offset = "0x8C5E80", VA = "0x1808C7880")]
		public static Task<string> BatchHeartBeatInteractivePlay(string[] gameIds)
		{
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x0016E4C8 File Offset: 0x0016C6C8
		[Token(Token = "0x6004A54")]
		[Address(RVA = "0x8C7CA0", Offset = "0x8C62A0", VA = "0x1808C7CA0")]
		private static Task<string> RequestWebUTF8(string url, string method, string param, [Optional] string cookie)
		{
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x0016E4EC File Offset: 0x0016C6EC
		[Token(Token = "0x6004A55")]
		[Address(RVA = "0x8C7A90", Offset = "0x8C6090", VA = "0x1808C7A90")]
		private static TaskAwaiter GetAwaiter(this AsyncOperation asyncOp)
		{
			TaskCompletionSource<object> taskCompletionSource = new TaskCompletionSource();
			TaskCompletionSource<object> tcs = taskCompletionSource;
			Action<AsyncOperation> action;
			asyncOp.completed += action;
			return tcs._task.GetAwaiter();
		}

		// Token: 0x040034BB RID: 13499
		[Token(Token = "0x40034BB")]
		public static bool isTestEnv;

		// Token: 0x040034BC RID: 13500
		[Token(Token = "0x40034BC")]
		private const string k_InteractivePlayStart = "/v2/app/start";

		// Token: 0x040034BD RID: 13501
		[Token(Token = "0x40034BD")]
		private const string k_InteractivePlayEnd = "/v2/app/end";

		// Token: 0x040034BE RID: 13502
		[Token(Token = "0x40034BE")]
		private const string k_InteractivePlayHeartBeat = "/v2/app/heartbeat";

		// Token: 0x040034BF RID: 13503
		[Token(Token = "0x40034BF")]
		private const string k_InteractivePlayBatchHeartBeat = "/v2/app/batchHeartbeat";

		// Token: 0x040034C0 RID: 13504
		[Token(Token = "0x40034C0")]
		private const string k_Post = "POST";
	}
}

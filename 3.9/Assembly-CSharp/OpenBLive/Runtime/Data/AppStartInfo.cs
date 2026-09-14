using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E43 RID: 3651
	[Token(Token = "0x2000E43")]
	public class AppStartInfo
	{
		// Token: 0x06004B4D RID: 19277 RVA: 0x001722AC File Offset: 0x001704AC
		[Token(Token = "0x6004B4D")]
		[Address(RVA = "0x8C7840", Offset = "0x8C5E40", VA = "0x1808C7840")]
		public string GetGameId()
		{
			AppStartInfoData data = this.Data;
			if (data != 0)
			{
				AppStartGameInfo gameInfo = data.GameInfo;
				if (gameInfo != 0)
				{
					return gameInfo.GameId;
				}
			}
			return null;
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x001722DC File Offset: 0x001704DC
		[Token(Token = "0x6004B4E")]
		[Address(RVA = "0x8C7860", Offset = "0x8C5E60", VA = "0x1808C7860")]
		public IList<string> GetWssLink()
		{
			AppStartInfoData data = this.Data;
			if (data != 0)
			{
				AppStartWebsocketInfo websocketInfo = data.WebsocketInfo;
				if (websocketInfo != 0)
				{
					List<string> wssLink = websocketInfo.WssLink;
				}
			}
			return null;
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x00172314 File Offset: 0x00170514
		[Token(Token = "0x6004B4F")]
		[Address(RVA = "0x8C7820", Offset = "0x8C5E20", VA = "0x1808C7820")]
		public string GetAuthBody()
		{
			AppStartInfoData data = this.Data;
			if (data != 0)
			{
				AppStartWebsocketInfo websocketInfo = data.WebsocketInfo;
				if (websocketInfo != 0)
				{
					return websocketInfo.AuthBody;
				}
			}
			return null;
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x00172344 File Offset: 0x00170544
		[Token(Token = "0x6004B50")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public AppStartInfo()
		{
		}

		// Token: 0x04003546 RID: 13638
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003546")]
		[JsonProperty("code")]
		public int Code;

		// Token: 0x04003547 RID: 13639
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003547")]
		[JsonProperty("message")]
		public string Message;

		// Token: 0x04003548 RID: 13640
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003548")]
		[JsonProperty("data")]
		public AppStartInfoData Data;
	}
}

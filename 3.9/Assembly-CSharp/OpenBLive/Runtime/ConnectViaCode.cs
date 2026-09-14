using System;
using System.IO;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using GameLevel.RogueShooting;
using NativeWebSocket;
using OpenBLive.Runtime.Data;
using OpenBLive.Runtime.Utilities;
using UnityEngine;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E25 RID: 3621
	[Token(Token = "0x2000E25")]
	public class ConnectViaCode : MonoBehaviour
	{
		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06004AB3 RID: 19123 RVA: 0x0016F764 File Offset: 0x0016D964
		[Token(Token = "0x1700096B")]
		public static ConnectViaCode Instance
		{
			[Token(Token = "0x6004AB3")]
			[Address(RVA = "0x8CBA50", Offset = "0x8CA050", VA = "0x1808CBA50")]
			get
			{
				ConnectViaCode connectViaCode = ConnectViaCode.instance;
				int num = 0;
				if (connectViaCode == num)
				{
					Type[] array = new Type[1];
					Type typeFromHandle = typeof(ConnectViaCode);
					if (typeFromHandle != 0)
					{
					}
					array[0] = typeFromHandle;
					ConnectViaCode.instance = new GameObject("ConnectViaCode", array).GetComponent<ConnectViaCode>();
				}
				return ConnectViaCode.instance;
			}
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x0016F7C4 File Offset: 0x0016D9C4
		[Token(Token = "0x6004AB4")]
		[Address(RVA = "0x8CAA80", Offset = "0x8C9080", VA = "0x1808CAA80")]
		public void Connect()
		{
			string text = Path.Combine(Application.persistentDataPath, "OpenBLive.json");
			if (!File.Exists(text))
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.GetDirectoryName(text));
				string text2 = JsonUtility.ToJson(new ConnectData(), true);
				File.WriteAllText(text, text2);
				string fullPath = Path.GetFullPath(Application.persistentDataPath);
				Application.OpenURL("file://" + fullPath);
				Debug.Log("请在文件OpenBLive中填写数据");
				InGameText inGameText = InGameText.Instance;
				return;
			}
			ConnectData connectData = JsonUtility.FromJson<ConnectData>(File.ReadAllText(text));
			this.data = connectData;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			string text3;
			OpenBLive.Runtime.Utilities.Logger.Log(text3, true);
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x0016F880 File Offset: 0x0016DA80
		[Token(Token = "0x6004AB5")]
		[Address(RVA = "0x8CAF80", Offset = "0x8C9580", VA = "0x1808CAF80")]
		public void LinkStart()
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x0016F8A4 File Offset: 0x0016DAA4
		[Token(Token = "0x6004AB6")]
		[Address(RVA = "0x8CADD0", Offset = "0x8C93D0", VA = "0x1808CADD0")]
		public UniTask LinkEnd()
		{
			int num = 0;
			int num2 = 0;
			if (num == 0)
			{
			}
			if (num2 < typeof(UniTask).TypeHandle)
			{
				num2 += num2;
				num2++;
				return default(UniTask);
			}
			return default(UniTask);
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x0016F8E0 File Offset: 0x0016DAE0
		[Token(Token = "0x6004AB7")]
		[Address(RVA = "0x8CB5F0", Offset = "0x8C9BF0", VA = "0x1808CB5F0")]
		private static void WebSocketBLiveClientOnGift(SendGift sendGift)
		{
			if (sendGift.fansMedalWearingStatus)
			{
				ShootingManager shootingManager = ShootingManager.Instance;
				int num = 0;
				int num2 = 0;
				if (shootingManager != num2)
				{
					ShootingManager.Instance.GiftSpawn((long)num2, num);
				}
			}
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x0016F91C File Offset: 0x0016DB1C
		[Token(Token = "0x6004AB8")]
		[Address(RVA = "0x8CB100", Offset = "0x8C9700", VA = "0x1808CB100")]
		private static void WebSocketBLiveClientOnDanmaku(Dm dm)
		{
			DamMenu damMenu = DamMenu.Instance;
			int num = 0;
			uint num2;
			uint num3;
			if (damMenu != num && !dm.msg.Contains((char)num2) && !dm.msg.Contains((char)num3))
			{
				DamMenu damMenu2 = DamMenu.Instance;
			}
			if (dm.fansMedalWearingStatus)
			{
			}
			ShootingManager shootingManager = ShootingManager.Instance;
			int num4 = 0;
			if (shootingManager != num4)
			{
				ShootingManager shootingManager2 = ShootingManager.Instance;
				string msg = dm.msg;
				int num5 = 0;
				uint num6;
				shootingManager2.DanmakuSpawn((int)num6, msg);
				if (GameAPP.config.liveConfig.scMode)
				{
					BLiveConfig liveConfig = GameAPP.config.liveConfig;
					int num7 = 0;
					BLiveConfig.<>c__DisplayClass8_0 CS$<>8__locals1;
					CS$<>8__locals1.FieldGetter(num7, msg, num5);
					string openId = dm.openId;
					CS$<>8__locals1.openId = openId;
					Predicate<BLiveConfig.Record> predicate;
					int num8 = liveConfig.scTimes.FindIndex(predicate);
					if (num8 != -1)
					{
						BLiveConfig.Record record = liveConfig.scTimes[num8];
						ShootingManager shootingManager3 = ShootingManager.Instance;
						int num9 = 0;
						bool flag;
						if (flag)
						{
							BLiveConfig liveConfig2 = GameAPP.config.liveConfig;
							int num10 = 0;
							BLiveConfig.<>c__DisplayClass9_0 CS$<>8__locals2;
							CS$<>8__locals2.FieldGetter(num10, msg, num9);
							string openId2 = dm.openId;
							CS$<>8__locals2.openId = openId2;
							Predicate<BLiveConfig.Record> predicate2;
							int num11 = liveConfig2.scTimes.FindIndex(predicate2);
							if (num11 != -1)
							{
								BLiveConfig.Record record2 = liveConfig2.scTimes[num11];
								liveConfig2.scTimes[num11] = record2;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x0016FA84 File Offset: 0x0016DC84
		[Token(Token = "0x6004AB9")]
		[Address(RVA = "0x8CB700", Offset = "0x8C9D00", VA = "0x1808CB700")]
		private static void WebSocketBLiveClientOnSuperChat(SuperChat superChat)
		{
			if (GameAPP.config.liveConfig.scMode)
			{
				ShootingManager shootingManager = ShootingManager.Instance;
				int num = 0;
				int num2 = 0;
				if (shootingManager != num2)
				{
					bool flag = ShootingManager.Instance.OnSc(num2, num);
				}
				BLiveConfig liveConfig = GameAPP.config.liveConfig;
			}
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x0016FAD8 File Offset: 0x0016DCD8
		[Token(Token = "0x6004ABA")]
		[Address(RVA = "0x8CB8A0", Offset = "0x8C9EA0", VA = "0x1808CB8A0")]
		private static void WebSocketBLiveClient_OnLike(Like like)
		{
			if (like.fans_medal_wearing_status)
			{
				ShootingManager shootingManager = ShootingManager.Instance;
				int num = 0;
				if (shootingManager != num)
				{
					ShootingManager.Instance.LikeSpawn((long)num);
				}
			}
		}

		// Token: 0x06004ABB RID: 19131 RVA: 0x0016FB14 File Offset: 0x0016DD14
		[Token(Token = "0x6004ABB")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
		private static void WebSocketBLiveClient_OnLiveEnd(LiveEnd liveEnd)
		{
		}

		// Token: 0x06004ABC RID: 19132 RVA: 0x0016FB24 File Offset: 0x0016DD24
		[Token(Token = "0x6004ABC")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
		private static void WebSocketBLiveClient_OnLiveStart(LiveStart liveStart)
		{
		}

		// Token: 0x06004ABD RID: 19133 RVA: 0x0016FB34 File Offset: 0x0016DD34
		[Token(Token = "0x6004ABD")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
		private static void WebSocketBLiveClient_OnEnter(Enter enter)
		{
		}

		// Token: 0x06004ABE RID: 19134 RVA: 0x0016FB44 File Offset: 0x0016DD44
		[Token(Token = "0x6004ABE")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
		private static void WebSocketBLiveClientOnGuardBuy(Guard guard)
		{
		}

		// Token: 0x06004ABF RID: 19135 RVA: 0x0016FB54 File Offset: 0x0016DD54
		[Token(Token = "0x6004ABF")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
		private static void PlayHeartBeat_HeartBeatSucceed()
		{
		}

		// Token: 0x06004AC0 RID: 19136 RVA: 0x0016FB64 File Offset: 0x0016DD64
		[Token(Token = "0x6004AC0")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
		private static void PlayHeartBeat_HeartBeatError(string json)
		{
		}

		// Token: 0x06004AC1 RID: 19137 RVA: 0x0016FB74 File Offset: 0x0016DD74
		[Token(Token = "0x6004AC1")]
		[Address(RVA = "0x8CB0A0", Offset = "0x8C96A0", VA = "0x1808CB0A0")]
		private void Update()
		{
			WebSocketBLiveClient webSocketBLiveClient = this.m_WebSocketBLiveClient;
			if (webSocketBLiveClient != 0)
			{
				WebSocket ws = webSocketBLiveClient.ws;
				if (ws != 0 && ws.State == WebSocketState.Open)
				{
					this.m_WebSocketBLiveClient.ws.DispatchMessageQueue();
					return;
				}
			}
		}

		// Token: 0x06004AC2 RID: 19138 RVA: 0x0016FBB8 File Offset: 0x0016DDB8
		[Token(Token = "0x6004AC2")]
		[Address(RVA = "0x8CB030", Offset = "0x8C9630", VA = "0x1808CB030")]
		private void OnDestroy()
		{
			if (this.m_WebSocketBLiveClient != (ulong)0L)
			{
				InteractivePlayHeartBeat playHeartBeat = this.m_PlayHeartBeat;
				playHeartBeat.m_Cancellation.Cancel();
				playHeartBeat.m_Cancellation.Dispose();
				this.m_WebSocketBLiveClient.Dispose();
			}
		}

		// Token: 0x06004AC3 RID: 19139 RVA: 0x0016FC00 File Offset: 0x0016DE00
		[Token(Token = "0x6004AC3")]
		[Address(RVA = "0x8CB9E0", Offset = "0x8C9FE0", VA = "0x1808CB9E0")]
		public ConnectViaCode()
		{
			ConnectData connectData = new ConnectData();
			this.data = connectData;
			base..ctor();
		}

		// Token: 0x040034F0 RID: 13552
		[Token(Token = "0x40034F0")]
		private static ConnectViaCode instance;

		// Token: 0x040034F1 RID: 13553
		[Token(Token = "0x40034F1")]
		private static readonly bool needFan;

		// Token: 0x040034F2 RID: 13554
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40034F2")]
		private WebSocketBLiveClient m_WebSocketBLiveClient;

		// Token: 0x040034F3 RID: 13555
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40034F3")]
		private InteractivePlayHeartBeat m_PlayHeartBeat;

		// Token: 0x040034F4 RID: 13556
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40034F4")]
		private string gameId;

		// Token: 0x040034F5 RID: 13557
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40034F5")]
		private ConnectData data;
	}
}

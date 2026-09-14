using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;
using OpenBLive.Runtime.Data;
using OpenBLive.Runtime.Utilities;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E22 RID: 3618
	[Token(Token = "0x2000E22")]
	public abstract class BLiveClient : IDisposable
	{
		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06004A8A RID: 19082 RVA: 0x0016EFA8 File Offset: 0x0016D1A8
		// (remove) Token: 0x06004A8B RID: 19083 RVA: 0x0016EFD8 File Offset: 0x0016D1D8
		[Token(Token = "0x1400001B")]
		public event ReceiveDanmakuEvent OnDanmaku
		{
			[Token(Token = "0x6004A8A")]
			[Address(RVA = "0x8C8F30", Offset = "0x8C7530", VA = "0x1808C8F30")]
			[CompilerGenerated]
			add
			{
				ReceiveDanmakuEvent onDanmaku = this.OnDanmaku;
				Delegate @delegate = Delegate.Combine(onDanmaku, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onDanmaku)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004A8B")]
			[Address(RVA = "0x8C96C0", Offset = "0x8C7CC0", VA = "0x1808C96C0")]
			[CompilerGenerated]
			remove
			{
				ReceiveDanmakuEvent onDanmaku = this.OnDanmaku;
				Delegate @delegate = Delegate.Remove(onDanmaku, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onDanmaku)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06004A8C RID: 19084 RVA: 0x0016F008 File Offset: 0x0016D208
		// (remove) Token: 0x06004A8D RID: 19085 RVA: 0x0016F038 File Offset: 0x0016D238
		[Token(Token = "0x1400001C")]
		public event ReceiveGiftEvent OnGift
		{
			[Token(Token = "0x6004A8C")]
			[Address(RVA = "0x8C9070", Offset = "0x8C7670", VA = "0x1808C9070")]
			[CompilerGenerated]
			add
			{
				ReceiveGiftEvent onGift = this.OnGift;
				Delegate @delegate = Delegate.Combine(onGift, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onGift)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004A8D")]
			[Address(RVA = "0x8C9800", Offset = "0x8C7E00", VA = "0x1808C9800")]
			[CompilerGenerated]
			remove
			{
				ReceiveGiftEvent onGift = this.OnGift;
				Delegate @delegate = Delegate.Remove(onGift, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onGift)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06004A8E RID: 19086 RVA: 0x0016F068 File Offset: 0x0016D268
		// (remove) Token: 0x06004A8F RID: 19087 RVA: 0x0016F098 File Offset: 0x0016D298
		[Token(Token = "0x1400001D")]
		public event ReceiveGuardBuyEvent OnGuardBuy
		{
			[Token(Token = "0x6004A8E")]
			[Address(RVA = "0x8C9110", Offset = "0x8C7710", VA = "0x1808C9110")]
			[CompilerGenerated]
			add
			{
				ReceiveGuardBuyEvent onGuardBuy = this.OnGuardBuy;
				Delegate @delegate = Delegate.Combine(onGuardBuy, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onGuardBuy)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004A8F")]
			[Address(RVA = "0x8C98A0", Offset = "0x8C7EA0", VA = "0x1808C98A0")]
			[CompilerGenerated]
			remove
			{
				ReceiveGuardBuyEvent onGuardBuy = this.OnGuardBuy;
				Delegate @delegate = Delegate.Remove(onGuardBuy, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onGuardBuy)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06004A90 RID: 19088 RVA: 0x0016F0C8 File Offset: 0x0016D2C8
		// (remove) Token: 0x06004A91 RID: 19089 RVA: 0x0016F0F8 File Offset: 0x0016D2F8
		[Token(Token = "0x1400001E")]
		public event ReceiveSuperChatEvent OnSuperChat
		{
			[Token(Token = "0x6004A90")]
			[Address(RVA = "0x8C9430", Offset = "0x8C7A30", VA = "0x1808C9430")]
			[CompilerGenerated]
			add
			{
				ReceiveSuperChatEvent onSuperChat = this.OnSuperChat;
				Delegate @delegate = Delegate.Combine(onSuperChat, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onSuperChat)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004A91")]
			[Address(RVA = "0x8C9BC0", Offset = "0x8C81C0", VA = "0x1808C9BC0")]
			[CompilerGenerated]
			remove
			{
				ReceiveSuperChatEvent onSuperChat = this.OnSuperChat;
				Delegate @delegate = Delegate.Remove(onSuperChat, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onSuperChat)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06004A92 RID: 19090 RVA: 0x0016F128 File Offset: 0x0016D328
		// (remove) Token: 0x06004A93 RID: 19091 RVA: 0x0016F158 File Offset: 0x0016D358
		[Token(Token = "0x1400001F")]
		public event ReceiveSuperChatDelEvent OnSuperChatDel
		{
			[Token(Token = "0x6004A92")]
			[Address(RVA = "0x8C9390", Offset = "0x8C7990", VA = "0x1808C9390")]
			[CompilerGenerated]
			add
			{
				ReceiveSuperChatDelEvent onSuperChatDel = this.OnSuperChatDel;
				Delegate @delegate = Delegate.Combine(onSuperChatDel, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onSuperChatDel)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004A93")]
			[Address(RVA = "0x8C9B20", Offset = "0x8C8120", VA = "0x1808C9B20")]
			[CompilerGenerated]
			remove
			{
				ReceiveSuperChatDelEvent onSuperChatDel = this.OnSuperChatDel;
				Delegate @delegate = Delegate.Remove(onSuperChatDel, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onSuperChatDel)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06004A94 RID: 19092 RVA: 0x0016F188 File Offset: 0x0016D388
		// (remove) Token: 0x06004A95 RID: 19093 RVA: 0x0016F1B8 File Offset: 0x0016D3B8
		[Token(Token = "0x14000020")]
		public event ReceiveLikeEvent OnLike
		{
			[Token(Token = "0x6004A94")]
			[Address(RVA = "0x8C91B0", Offset = "0x8C77B0", VA = "0x1808C91B0")]
			[CompilerGenerated]
			add
			{
				ReceiveLikeEvent onLike = this.OnLike;
				Delegate @delegate = Delegate.Combine(onLike, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onLike)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004A95")]
			[Address(RVA = "0x8C9940", Offset = "0x8C7F40", VA = "0x1808C9940")]
			[CompilerGenerated]
			remove
			{
				ReceiveLikeEvent onLike = this.OnLike;
				Delegate @delegate = Delegate.Remove(onLike, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onLike)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06004A96 RID: 19094 RVA: 0x0016F1E8 File Offset: 0x0016D3E8
		// (remove) Token: 0x06004A97 RID: 19095 RVA: 0x0016F218 File Offset: 0x0016D418
		[Token(Token = "0x14000021")]
		public event ReceiveEnterEvent OnEnter
		{
			[Token(Token = "0x6004A96")]
			[Address(RVA = "0x8C8FD0", Offset = "0x8C75D0", VA = "0x1808C8FD0")]
			[CompilerGenerated]
			add
			{
				ReceiveEnterEvent onEnter = this.OnEnter;
				Delegate @delegate = Delegate.Combine(onEnter, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onEnter)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004A97")]
			[Address(RVA = "0x8C9760", Offset = "0x8C7D60", VA = "0x1808C9760")]
			[CompilerGenerated]
			remove
			{
				ReceiveEnterEvent onEnter = this.OnEnter;
				Delegate @delegate = Delegate.Remove(onEnter, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onEnter)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06004A98 RID: 19096 RVA: 0x0016F248 File Offset: 0x0016D448
		// (remove) Token: 0x06004A99 RID: 19097 RVA: 0x0016F278 File Offset: 0x0016D478
		[Token(Token = "0x14000022")]
		public event ReceiveLiveStartEvent OnLiveStart
		{
			[Token(Token = "0x6004A98")]
			[Address(RVA = "0x8C92F0", Offset = "0x8C78F0", VA = "0x1808C92F0")]
			[CompilerGenerated]
			add
			{
				ReceiveLiveStartEvent onLiveStart = this.OnLiveStart;
				Delegate @delegate = Delegate.Combine(onLiveStart, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onLiveStart)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004A99")]
			[Address(RVA = "0x8C9A80", Offset = "0x8C8080", VA = "0x1808C9A80")]
			[CompilerGenerated]
			remove
			{
				ReceiveLiveStartEvent onLiveStart = this.OnLiveStart;
				Delegate @delegate = Delegate.Remove(onLiveStart, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onLiveStart)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06004A9A RID: 19098 RVA: 0x0016F2A8 File Offset: 0x0016D4A8
		// (remove) Token: 0x06004A9B RID: 19099 RVA: 0x0016F2D8 File Offset: 0x0016D4D8
		[Token(Token = "0x14000023")]
		public event ReceiveLiveEndEvent OnLiveEnd
		{
			[Token(Token = "0x6004A9A")]
			[Address(RVA = "0x8C9250", Offset = "0x8C7850", VA = "0x1808C9250")]
			[CompilerGenerated]
			add
			{
				ReceiveLiveEndEvent onLiveEnd = this.OnLiveEnd;
				Delegate @delegate = Delegate.Combine(onLiveEnd, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onLiveEnd)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004A9B")]
			[Address(RVA = "0x8C99E0", Offset = "0x8C7FE0", VA = "0x1808C99E0")]
			[CompilerGenerated]
			remove
			{
				ReceiveLiveEndEvent onLiveEnd = this.OnLiveEnd;
				Delegate @delegate = Delegate.Remove(onLiveEnd, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onLiveEnd)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06004A9C RID: 19100 RVA: 0x0016F308 File Offset: 0x0016D508
		// (remove) Token: 0x06004A9D RID: 19101 RVA: 0x0016F338 File Offset: 0x0016D538
		[Token(Token = "0x14000024")]
		public event ReceiveRawNotice ReceiveNotice
		{
			[Token(Token = "0x6004A9C")]
			[Address(RVA = "0x8C9570", Offset = "0x8C7B70", VA = "0x1808C9570")]
			[CompilerGenerated]
			add
			{
				ReceiveRawNotice receiveNotice = this.ReceiveNotice;
				Delegate @delegate = Delegate.Combine(receiveNotice, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != receiveNotice)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004A9D")]
			[Address(RVA = "0x8C9D00", Offset = "0x8C8300", VA = "0x1808C9D00")]
			[CompilerGenerated]
			remove
			{
				ReceiveRawNotice receiveNotice = this.ReceiveNotice;
				Delegate @delegate = Delegate.Remove(receiveNotice, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != receiveNotice)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06004A9E RID: 19102 RVA: 0x0016F368 File Offset: 0x0016D568
		// (remove) Token: 0x06004A9F RID: 19103 RVA: 0x0016F398 File Offset: 0x0016D598
		[Token(Token = "0x14000025")]
		public event EventHandler<int> UpdatePopularity
		{
			[Token(Token = "0x6004A9E")]
			[Address(RVA = "0x8C9610", Offset = "0x8C7C10", VA = "0x1808C9610")]
			[CompilerGenerated]
			add
			{
				EventHandler<int> updatePopularity = this.UpdatePopularity;
				Delegate @delegate = Delegate.Combine(updatePopularity, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != updatePopularity)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004A9F")]
			[Address(RVA = "0x8C9DA0", Offset = "0x8C83A0", VA = "0x1808C9DA0")]
			[CompilerGenerated]
			remove
			{
				EventHandler<int> updatePopularity = this.UpdatePopularity;
				Delegate @delegate = Delegate.Remove(updatePopularity, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != updatePopularity)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06004AA0 RID: 19104 RVA: 0x0016F3C8 File Offset: 0x0016D5C8
		// (remove) Token: 0x06004AA1 RID: 19105 RVA: 0x0016F3F8 File Offset: 0x0016D5F8
		[Token(Token = "0x14000026")]
		public event EventHandler Open
		{
			[Token(Token = "0x6004AA0")]
			[Address(RVA = "0x8C94D0", Offset = "0x8C7AD0", VA = "0x1808C94D0")]
			[CompilerGenerated]
			add
			{
				EventHandler open = this.Open;
				Delegate @delegate = Delegate.Combine(open, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != open)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004AA1")]
			[Address(RVA = "0x8C9C60", Offset = "0x8C8260", VA = "0x1808C9C60")]
			[CompilerGenerated]
			remove
			{
				EventHandler open = this.Open;
				Delegate @delegate = Delegate.Remove(open, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != open)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x06004AA2 RID: 19106
		[Token(Token = "0x6004AA2")]
		[Address(Slot = "5")]
		public abstract void Connect();

		// Token: 0x06004AA3 RID: 19107
		[Token(Token = "0x6004AA3")]
		[Address(Slot = "6")]
		public abstract void Connect(TimeSpan timeSpan, int count);

		// Token: 0x06004AA4 RID: 19108
		[Token(Token = "0x6004AA4")]
		[Address(Slot = "7")]
		public abstract void Disconnect();

		// Token: 0x06004AA5 RID: 19109
		[Token(Token = "0x6004AA5")]
		[Address(Slot = "8")]
		public abstract void Dispose();

		// Token: 0x06004AA6 RID: 19110
		[Token(Token = "0x6004AA6")]
		[Address(Slot = "9")]
		public abstract void Send(byte[] packet);

		// Token: 0x06004AA7 RID: 19111
		[Token(Token = "0x6004AA7")]
		[Address(Slot = "10")]
		public abstract Task SendAsync(byte[] packet);

		// Token: 0x06004AA8 RID: 19112
		[Token(Token = "0x6004AA8")]
		[Address(Slot = "11")]
		public abstract void Send(Packet packet);

		// Token: 0x06004AA9 RID: 19113
		[Token(Token = "0x6004AA9")]
		[Address(Slot = "12")]
		protected abstract Task SendAsync(Packet packet);

		// Token: 0x06004AAA RID: 19114 RVA: 0x0016F428 File Offset: 0x0016D628
		[Token(Token = "0x6004AAA")]
		[Address(RVA = "0x8C7F80", Offset = "0x8C6580", VA = "0x1808C7F80", Slot = "13")]
		protected virtual void OnOpen()
		{
			string text = this.token;
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			int num = bytes.Length;
			num += 16;
			Timer timer = this.m_Timer;
			if (timer != 0)
			{
				timer.Dispose();
			}
			TimerCallback timerCallback;
			if (BLiveClient.<>c.<>9__46_0 == 0)
			{
				timerCallback = delegate(object e)
				{
					if (e != 0)
					{
						Packet s_NoBodyHeartBeatPacket = Packet.s_NoBodyHeartBeatPacket;
					}
				};
				BLiveClient.<>c.<>9__46_0 = timerCallback;
			}
			int num2;
			ulong num3;
			Timer timer2 = new Timer(timerCallback, this, num2, (int)num3);
			num2 = 0;
			this.m_Timer = timer2;
			throw new NullReferenceException();
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x0016F4B8 File Offset: 0x0016D6B8
		[Token(Token = "0x6004AAB")]
		[Address(RVA = "0x8C8D00", Offset = "0x8C7300", VA = "0x1808C8D00")]
		protected void ProcessPacket(ReadOnlySpan<byte> bytes)
		{
			ByReference pointer = bytes._pointer;
			if (bytes != 0 && bytes != 0)
			{
				if (bytes == 0)
				{
					return;
				}
				if (pointer != (ulong)1L)
				{
					return;
				}
			}
			if (bytes <= (ulong)6L && this.UpdatePopularity != 0)
			{
				return;
			}
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x0016F518 File Offset: 0x0016D718
		[Token(Token = "0x6004AAC")]
		[Address(RVA = "0x8C8B10", Offset = "0x8C7110", VA = "0x1808C8B10")]
		private void ProcessPacketAsync(Packet packet)
		{
			PacketHeader header = packet.Header;
			if (packet != 0 && packet != 0)
			{
				if (packet == 0)
				{
					return;
				}
				if (header != (ulong)1L)
				{
					return;
				}
			}
			if (packet <= (ulong)6L)
			{
				byte[] packetBody = packet.PacketBody;
				if (this.UpdatePopularity != 0)
				{
					Encoding utf = Encoding.UTF8;
					string text;
					this.ProcessNotice(text);
					return;
				}
			}
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x0016F580 File Offset: 0x0016D780
		[Token(Token = "0x6004AAD")]
		[Address(RVA = "0x8C81D0", Offset = "0x8C67D0", VA = "0x1808C81D0")]
		private void ProcessNotice(string rawMessage)
		{
			int num = 0;
			JObject jobject = JObject.Parse(rawMessage);
			if (this.ReceiveNotice != 0)
			{
			}
			string text = jobject["data"].ToString();
			JToken jtoken = jobject["cmd"];
			if (jtoken != 0)
			{
				string text2 = jtoken.ToString();
				if (text2 != 0)
				{
					if (num < text2._stringLength)
					{
						long num2 = (long)((uint)text2[num] * (uint)16777619);
						num++;
					}
					if (!string.Equals(text2, "LIVE_OPEN_PLATFORM_SUPER_CHAT_DEL") || this.OnSuperChatDel == 0 || !string.Equals(text2, "LIVE_OPEN_PLATFORM_SUPER_CHAT") || this.OnSuperChat == 0 || !string.Equals(text2, "LIVE_OPEN_PLATFORM_SEND_GIFT") || this.OnGift == 0 || !string.Equals(text2, "LIVE_OPEN_PLATFORM_LIVE_ROOM_ENTER") || this.OnEnter == 0 || !string.Equals(text2, "LIVE_OPEN_PLATFORM_LIKE") || this.OnLike == 0 || !string.Equals(text2, "LIVE_OPEN_PLATFORM_DM") || this.OnDanmaku == 0 || !string.Equals(text2, "LIVE_OPEN_PLATFORM_LIVE_END") || !string.Equals(text2, "LIVE_OPEN_PLATFORM_LIVE_START") || this.OnLiveStart == 0 || !string.Equals(text2, "LIVE_OPEN_PLATFORM_GUARD") || this.OnGuardBuy != 0)
					{
					}
				}
			}
			TypeCode typeCode = num.GetTypeCode();
			string text3;
			Logger.LogWarning(text3);
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x0016F6F0 File Offset: 0x0016D8F0
		[Token(Token = "0x6004AAE")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		protected BLiveClient()
		{
		}

		// Token: 0x040034DC RID: 13532
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40034DC")]
		private Timer m_Timer;

		// Token: 0x040034DD RID: 13533
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40034DD")]
		protected string token;
	}
}

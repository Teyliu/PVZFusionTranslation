using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using NativeWebSocket;
using OpenBLive.Runtime.Data;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E2C RID: 3628
	[Token(Token = "0x2000E2C")]
	public class WebSocketBLiveClient : BLiveClient
	{
		// Token: 0x06004ADD RID: 19165 RVA: 0x001709B0 File Offset: 0x0016EBB0
		[Token(Token = "0x6004ADD")]
		[Address(RVA = "0x8DD8C0", Offset = "0x8DBEC0", VA = "0x1808DD8C0")]
		public WebSocketBLiveClient(AppStartInfo info)
		{
			AppStartWebsocketInfo websocketInfo = info.Data.WebsocketInfo;
			List<string> wssLink = websocketInfo.WssLink;
			this.WssLink = wssLink;
			string authBody = websocketInfo.AuthBody;
			this.token = authBody;
			throw new NullReferenceException();
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x001709F0 File Offset: 0x0016EBF0
		[Token(Token = "0x6004ADE")]
		[Address(RVA = "0x8DD860", Offset = "0x8DBE60", VA = "0x1808DD860")]
		public WebSocketBLiveClient(IList<string> wssLink, string authBody)
		{
			this.WssLink = wssLink;
			this.token = authBody;
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x00170A14 File Offset: 0x0016EC14
		[Token(Token = "0x6004ADF")]
		[Address(RVA = "0x8DD2A0", Offset = "0x8DB8A0", VA = "0x1808DD2A0", Slot = "5")]
		public override void Connect()
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x00170A34 File Offset: 0x0016EC34
		[Token(Token = "0x6004AE0")]
		[Address(RVA = "0x8DD350", Offset = "0x8DB950", VA = "0x1808DD350", Slot = "6")]
		public override void Connect(TimeSpan timeSpan, int count)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x00170A54 File Offset: 0x0016EC54
		[Token(Token = "0x6004AE1")]
		[Address(RVA = "0x8DD420", Offset = "0x8DBA20", VA = "0x1808DD420", Slot = "7")]
		public override void Disconnect()
		{
			global::NativeWebSocket.WebSocket webSocket = this.ws;
			if (webSocket != 0)
			{
				Task task = webSocket.Close();
			}
			this.ws = (ulong)0L;
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x00170A7C File Offset: 0x0016EC7C
		[Token(Token = "0x6004AE2")]
		[Address(RVA = "0x8DD460", Offset = "0x8DBA60", VA = "0x1808DD460", Slot = "8")]
		public override void Dispose()
		{
			this.Disconnect();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x00170A98 File Offset: 0x0016EC98
		[Token(Token = "0x6004AE3")]
		[Address(RVA = "0x8DD690", Offset = "0x8DBC90", VA = "0x1808DD690", Slot = "9")]
		public override void Send(byte[] packet)
		{
			ClientWebSocket socket = this.ws.m_Socket;
			global::System.Net.WebSockets.WebSocketState state = socket.State;
			if (socket == 0 || socket != 0)
			{
				return;
			}
			global::NativeWebSocket.WebSocket webSocket = this.ws;
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x00170AD4 File Offset: 0x0016ECD4
		[Token(Token = "0x6004AE4")]
		[Address(RVA = "0x8DD620", Offset = "0x8DBC20", VA = "0x1808DD620", Slot = "11")]
		public override void Send(Packet packet)
		{
			byte[] toBytes = packet.ToBytes;
		}

		// Token: 0x06004AE5 RID: 19173 RVA: 0x00170AE8 File Offset: 0x0016ECE8
		[Token(Token = "0x6004AE5")]
		[Address(RVA = "0x8DD4C0", Offset = "0x8DBAC0", VA = "0x1808DD4C0", Slot = "10")]
		public override Task SendAsync(byte[] packet)
		{
			return Task.Run(delegate
			{
				WebSocketBLiveClient <>4__this = this;
				throw new NullReferenceException();
			});
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x00170B20 File Offset: 0x0016ED20
		[Token(Token = "0x6004AE6")]
		[Address(RVA = "0x8DD5B0", Offset = "0x8DBBB0", VA = "0x1808DD5B0", Slot = "12")]
		protected override Task SendAsync(Packet packet)
		{
			byte[] toBytes = packet.ToBytes;
			return null;
		}

		// Token: 0x04003508 RID: 13576
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4003508")]
		public IList<string> WssLink;

		// Token: 0x04003509 RID: 13577
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4003509")]
		public global::NativeWebSocket.WebSocket ws;
	}
}

using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace NativeWebSocket
{
	// Token: 0x02000E09 RID: 3593
	[Token(Token = "0x2000E09")]
	public class WebSocket : IWebSocket
	{
		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06004A2C RID: 18988 RVA: 0x0016D520 File Offset: 0x0016B720
		// (remove) Token: 0x06004A2D RID: 18989 RVA: 0x0016D550 File Offset: 0x0016B750
		[Token(Token = "0x14000017")]
		public event WebSocketOpenEventHandler OnOpen
		{
			[Token(Token = "0x6004A2C")]
			[Address(RVA = "0x8DF4C0", Offset = "0x8DDAC0", VA = "0x1808DF4C0", Slot = "4")]
			[CompilerGenerated]
			add
			{
				WebSocketOpenEventHandler onOpen = this.OnOpen;
				Delegate @delegate = Delegate.Combine(onOpen, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onOpen)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004A2D")]
			[Address(RVA = "0x8DF7B0", Offset = "0x8DDDB0", VA = "0x1808DF7B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
				WebSocketOpenEventHandler onOpen = this.OnOpen;
				Delegate @delegate = Delegate.Remove(onOpen, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onOpen)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06004A2E RID: 18990 RVA: 0x0016D580 File Offset: 0x0016B780
		// (remove) Token: 0x06004A2F RID: 18991 RVA: 0x0016D5B0 File Offset: 0x0016B7B0
		[Token(Token = "0x14000018")]
		public event WebSocketMessageEventHandler OnMessage
		{
			[Token(Token = "0x6004A2E")]
			[Address(RVA = "0x8DF420", Offset = "0x8DDA20", VA = "0x1808DF420", Slot = "6")]
			[CompilerGenerated]
			add
			{
				WebSocketMessageEventHandler onMessage = this.OnMessage;
				Delegate @delegate = Delegate.Combine(onMessage, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onMessage)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004A2F")]
			[Address(RVA = "0x8DF710", Offset = "0x8DDD10", VA = "0x1808DF710", Slot = "7")]
			[CompilerGenerated]
			remove
			{
				WebSocketMessageEventHandler onMessage = this.OnMessage;
				Delegate @delegate = Delegate.Remove(onMessage, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onMessage)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06004A30 RID: 18992 RVA: 0x0016D5E0 File Offset: 0x0016B7E0
		// (remove) Token: 0x06004A31 RID: 18993 RVA: 0x0016D610 File Offset: 0x0016B810
		[Token(Token = "0x14000019")]
		public event WebSocketErrorEventHandler OnError
		{
			[Token(Token = "0x6004A30")]
			[Address(RVA = "0x8DF380", Offset = "0x8DD980", VA = "0x1808DF380", Slot = "8")]
			[CompilerGenerated]
			add
			{
				WebSocketErrorEventHandler onError = this.OnError;
				Delegate @delegate = Delegate.Combine(onError, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onError)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004A31")]
			[Address(RVA = "0x8DF670", Offset = "0x8DDC70", VA = "0x1808DF670", Slot = "9")]
			[CompilerGenerated]
			remove
			{
				WebSocketErrorEventHandler onError = this.OnError;
				Delegate @delegate = Delegate.Remove(onError, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onError)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06004A32 RID: 18994 RVA: 0x0016D640 File Offset: 0x0016B840
		// (remove) Token: 0x06004A33 RID: 18995 RVA: 0x0016D670 File Offset: 0x0016B870
		[Token(Token = "0x1400001A")]
		public event WebSocketCloseEventHandler OnClose
		{
			[Token(Token = "0x6004A32")]
			[Address(RVA = "0x8DF2E0", Offset = "0x8DD8E0", VA = "0x1808DF2E0", Slot = "10")]
			[CompilerGenerated]
			add
			{
				WebSocketCloseEventHandler onClose = this.OnClose;
				Delegate @delegate = Delegate.Combine(onClose, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onClose)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6004A33")]
			[Address(RVA = "0x8DF5D0", Offset = "0x8DDBD0", VA = "0x1808DF5D0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
				WebSocketCloseEventHandler onClose = this.OnClose;
				Delegate @delegate = Delegate.Remove(onClose, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onClose)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x0016D6A0 File Offset: 0x0016B8A0
		[Token(Token = "0x6004A34")]
		[Address(RVA = "0x8DEBD0", Offset = "0x8DD1D0", VA = "0x1808DEBD0")]
		public WebSocket(string url, [Optional] Dictionary<string, string> headers)
		{
			ClientWebSocket clientWebSocket = new ClientWebSocket();
			this.m_Socket = clientWebSocket;
			object obj = new object();
			this.OutgoingMessageLock = obj;
			object obj2 = new object();
			this.IncomingMessageLock = obj2;
			List<ArraySegment<byte>> list = new List();
			this.sendBytesQueue = list;
			List<ArraySegment<byte>> list2 = new List();
			this.sendTextQueue = list2;
			List<byte[]> list3 = new List();
			this.m_MessageList = list3;
			base..ctor();
			Uri uri = new Uri(url);
			this.uri = uri;
			if (headers == 0)
			{
				Dictionary<string, string> dictionary = new Dictionary();
			}
			this.headers = headers;
			List<string> list4 = new List();
			this.subprotocols = list4;
			string scheme = this.uri.Scheme;
			if (scheme.Equals("ws") || scheme.Equals("wss"))
			{
				return;
			}
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x0016D764 File Offset: 0x0016B964
		[Token(Token = "0x6004A35")]
		[Address(RVA = "0x8DEF10", Offset = "0x8DD510", VA = "0x1808DEF10")]
		public WebSocket(string url, string subprotocol, [Optional] Dictionary<string, string> headers)
		{
			ClientWebSocket clientWebSocket = new ClientWebSocket();
			this.m_Socket = clientWebSocket;
			object obj = new object();
			this.OutgoingMessageLock = obj;
			object obj2 = new object();
			this.IncomingMessageLock = obj2;
			List<ArraySegment<byte>> list = new List();
			this.sendBytesQueue = list;
			List<ArraySegment<byte>> list2 = new List();
			this.sendTextQueue = list2;
			List<byte[]> list3 = new List();
			this.m_MessageList = list3;
			int num = 0;
			base.FieldGetter(num, subprotocol, headers);
			Uri uri = new Uri(url);
			this.uri = uri;
			if (headers == 0)
			{
				Dictionary<string, string> dictionary = new Dictionary();
			}
			this.headers = headers;
			List<string> list4 = new List();
			int size = list4._size;
			this.subprotocols = list4;
			string scheme = this.uri.Scheme;
			if (scheme.Equals("ws") || scheme.Equals("wss"))
			{
				return;
			}
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x0016D840 File Offset: 0x0016BA40
		[Token(Token = "0x6004A36")]
		[Address(RVA = "0x8DE8B0", Offset = "0x8DCEB0", VA = "0x1808DE8B0")]
		public WebSocket(string url, List<string> subprotocols, [Optional] Dictionary<string, string> headers)
		{
			ClientWebSocket clientWebSocket = new ClientWebSocket();
			this.m_Socket = clientWebSocket;
			object obj = new object();
			this.OutgoingMessageLock = obj;
			object obj2 = new object();
			this.IncomingMessageLock = obj2;
			List<ArraySegment<byte>> list = new List();
			this.sendBytesQueue = list;
			List<ArraySegment<byte>> list2 = new List();
			this.sendTextQueue = list2;
			List<byte[]> list3 = new List();
			this.m_MessageList = list3;
			base..ctor();
			Uri uri = new Uri(url);
			this.uri = uri;
			if (headers == 0)
			{
				Dictionary<string, string> dictionary = new Dictionary();
			}
			this.headers = headers;
			this.subprotocols = subprotocols;
			string scheme = this.uri.Scheme;
			if (scheme.Equals("ws") || scheme.Equals("wss"))
			{
				return;
			}
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x0016D8FC File Offset: 0x0016BAFC
		[Token(Token = "0x6004A37")]
		[Address(RVA = "0x8DDF80", Offset = "0x8DC580", VA = "0x1808DDF80")]
		public void CancelConnection()
		{
			CancellationTokenSource tokenSource = this.m_TokenSource;
			if (tokenSource != 0)
			{
				tokenSource.Cancel();
				return;
			}
		}

		// Token: 0x06004A38 RID: 19000 RVA: 0x0016D91C File Offset: 0x0016BB1C
		[Token(Token = "0x6004A38")]
		[Address(RVA = "0x8DE070", Offset = "0x8DC670", VA = "0x1808DE070")]
		public Task Connect()
		{
			Task task;
			return task;
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x0016D930 File Offset: 0x0016BB30
		[Token(Token = "0x6004A39")]
		[Address(RVA = "0x8DE140", Offset = "0x8DC740", VA = "0x1808DE140")]
		public Task Connect(TimeSpan timeSpan, int maxCount)
		{
			Task task;
			return task;
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06004A3A RID: 19002 RVA: 0x0016D944 File Offset: 0x0016BB44
		[Token(Token = "0x17000969")]
		public WebSocketState State
		{
			[Token(Token = "0x6004A3A")]
			[Address(RVA = "0x8DF560", Offset = "0x8DDB60", VA = "0x1808DF560", Slot = "12")]
			get
			{
				ClientWebSocket socket = this.m_Socket;
				WebSocketState state = socket.State;
				if (socket == 0 || socket == 0 || socket == 0 || socket != 0)
				{
				}
				throw new NullReferenceException();
			}
		}

		// Token: 0x06004A3B RID: 19003 RVA: 0x0016D984 File Offset: 0x0016BB84
		[Token(Token = "0x6004A3B")]
		[Address(RVA = "0x8DE820", Offset = "0x8DCE20", VA = "0x1808DE820")]
		public Task Send(byte[] bytes)
		{
			List<ArraySegment<byte>> list = this.sendBytesQueue;
			int num = 0;
			return this.SendMessage(list, (WebSocketMessageType)((uint)1), num);
		}

		// Token: 0x06004A3C RID: 19004 RVA: 0x0016D9A8 File Offset: 0x0016BBA8
		[Token(Token = "0x6004A3C")]
		[Address(RVA = "0x8DE750", Offset = "0x8DCD50", VA = "0x1808DE750")]
		public Task SendText(string message)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(message);
			List<ArraySegment<byte>> list = this.sendTextQueue;
			int num = 0;
			int num2 = 0;
			return this.SendMessage(list, (WebSocketMessageType)num2, num);
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x0016D9E4 File Offset: 0x0016BBE4
		[Token(Token = "0x6004A3D")]
		[Address(RVA = "0x8DE620", Offset = "0x8DCC20", VA = "0x1808DE620")]
		private Task SendMessage(List<ArraySegment<byte>> queue, WebSocketMessageType messageType, ArraySegment<byte> buffer)
		{
			Task task;
			return task;
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x0016D9F8 File Offset: 0x0016BBF8
		[Token(Token = "0x6004A3E")]
		[Address(RVA = "0x8DE420", Offset = "0x8DCA20", VA = "0x1808DE420")]
		private Task HandleQueue(List<ArraySegment<byte>> queue, WebSocketMessageType messageType)
		{
			Task task;
			return task;
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x0016DA0C File Offset: 0x0016BC0C
		[Token(Token = "0x6004A3F")]
		[Address(RVA = "0x8DE240", Offset = "0x8DC840", VA = "0x1808DE240")]
		public void DispatchMessageQueue()
		{
			int num;
			List<byte[]> messageList2;
			List<byte[]> list;
			do
			{
				num = 0;
				List<byte[]> messageList = this.m_MessageList;
				object incomingMessageLock = this.IncomingMessageLock;
				Monitor.Enter(incomingMessageLock, num != 0);
				messageList2 = this.m_MessageList;
				list = new List(messageList2);
				List<byte[]> messageList3 = this.m_MessageList;
				int size = messageList3._size;
				messageList3._size = num;
				if (size > 0)
				{
				}
				Monitor.Exit(incomingMessageLock);
				Monitor.Exit(incomingMessageLock);
			}
			while (num != 0);
			int num2 = 0;
			if (list._size > 0)
			{
				if (messageList2 != 0)
				{
					byte[] array = list[num2];
				}
				num2++;
			}
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x0016DAA0 File Offset: 0x0016BCA0
		[Token(Token = "0x6004A40")]
		[Address(RVA = "0x8DE530", Offset = "0x8DCB30", VA = "0x1808DE530")]
		public Task Receive()
		{
			Task task;
			return task;
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x0016DAB4 File Offset: 0x0016BCB4
		[Token(Token = "0x6004A41")]
		[Address(RVA = "0x8DDFA0", Offset = "0x8DC5A0", VA = "0x1808DDFA0")]
		public Task Close()
		{
			Task task;
			return task;
		}

		// Token: 0x04003486 RID: 13446
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003486")]
		private Uri uri;

		// Token: 0x04003487 RID: 13447
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003487")]
		private Dictionary<string, string> headers;

		// Token: 0x04003488 RID: 13448
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003488")]
		private List<string> subprotocols;

		// Token: 0x04003489 RID: 13449
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003489")]
		private ClientWebSocket m_Socket;

		// Token: 0x0400348A RID: 13450
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400348A")]
		private int ReConnectCount;

		// Token: 0x0400348B RID: 13451
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400348B")]
		private CancellationTokenSource m_TokenSource;

		// Token: 0x0400348C RID: 13452
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400348C")]
		private CancellationToken m_CancellationToken;

		// Token: 0x0400348D RID: 13453
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400348D")]
		private readonly object OutgoingMessageLock;

		// Token: 0x0400348E RID: 13454
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400348E")]
		private readonly object IncomingMessageLock;

		// Token: 0x0400348F RID: 13455
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400348F")]
		private bool isSending;

		// Token: 0x04003490 RID: 13456
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4003490")]
		private List<ArraySegment<byte>> sendBytesQueue;

		// Token: 0x04003491 RID: 13457
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4003491")]
		private List<ArraySegment<byte>> sendTextQueue;

		// Token: 0x04003492 RID: 13458
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4003492")]
		private List<byte[]> m_MessageList;
	}
}

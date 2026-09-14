using System;
using Cpp2IlInjected;

namespace NativeWebSocket
{
	// Token: 0x02000DFE RID: 3582
	[Token(Token = "0x2000DFE")]
	public sealed class WebSocketCloseEventHandler : MulticastDelegate
	{
		// Token: 0x06004A0C RID: 18956 RVA: 0x0016D264 File Offset: 0x0016B464
		[Token(Token = "0x6004A0C")]
		[Address(RVA = "0x8DD9B0", Offset = "0x8DBFB0", VA = "0x1808DD9B0")]
		public WebSocketCloseEventHandler(object @object, IntPtr method)
		{
			this.method = method;
			this.m_target = @object;
			this.method_code = this;
			if (@object != 0)
			{
				object target = this.m_target;
				this.method_code = target;
				IntPtr method_ptr = this.method_ptr;
				this.invoke_impl = method_ptr;
				return;
			}
			throw new ArgumentException();
		}

		// Token: 0x06004A0D RID: 18957 RVA: 0x0016D2B0 File Offset: 0x0016B4B0
		[Token(Token = "0x6004A0D")]
		[Address(RVA = "0x8CC660", Offset = "0x8CAC60", VA = "0x1808CC660", Slot = "12")]
		public void Invoke(WebSocketCloseCode closeCode)
		{
		}

		// Token: 0x06004A0E RID: 18958 RVA: 0x0016D2C0 File Offset: 0x0016B4C0
		[Token(Token = "0x6004A0E")]
		[Address(RVA = "0x8DD930", Offset = "0x8DBF30", VA = "0x1808DD930", Slot = "13")]
		public IAsyncResult BeginInvoke(WebSocketCloseCode closeCode, AsyncCallback callback, object @object)
		{
			return typeof(WebSocketCloseCode).TypeHandle;
		}

		// Token: 0x06004A0F RID: 18959 RVA: 0x0016D2D4 File Offset: 0x0016B4D4
		[Token(Token = "0x6004A0F")]
		[Address(RVA = "0x8CC650", Offset = "0x8CAC50", VA = "0x1808CC650", Slot = "14")]
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}

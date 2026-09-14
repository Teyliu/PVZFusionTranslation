using System;
using Cpp2IlInjected;

namespace NativeWebSocket
{
	// Token: 0x02000DFC RID: 3580
	[Token(Token = "0x2000DFC")]
	public sealed class WebSocketMessageEventHandler : MulticastDelegate
	{
		// Token: 0x06004A04 RID: 18948 RVA: 0x0016D16C File Offset: 0x0016B36C
		[Token(Token = "0x6004A04")]
		[Address(RVA = "0x8CC670", Offset = "0x8CAC70", VA = "0x1808CC670")]
		public WebSocketMessageEventHandler(object @object, IntPtr method)
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

		// Token: 0x06004A05 RID: 18949 RVA: 0x0016D1B8 File Offset: 0x0016B3B8
		[Token(Token = "0x6004A05")]
		[Address(RVA = "0x8CC660", Offset = "0x8CAC60", VA = "0x1808CC660", Slot = "12")]
		public void Invoke(byte[] data)
		{
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x0016D1C8 File Offset: 0x0016B3C8
		[Token(Token = "0x6004A06")]
		[Address(RVA = "0x8CC620", Offset = "0x8CAC20", VA = "0x1808CC620", Slot = "13")]
		public IAsyncResult BeginInvoke(byte[] data, AsyncCallback callback, object @object)
		{
			return null;
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x0016D1D8 File Offset: 0x0016B3D8
		[Token(Token = "0x6004A07")]
		[Address(RVA = "0x8CC650", Offset = "0x8CAC50", VA = "0x1808CC650", Slot = "14")]
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}

using System;
using Cpp2IlInjected;

namespace NativeWebSocket
{
	// Token: 0x02000DFD RID: 3581
	[Token(Token = "0x2000DFD")]
	public sealed class WebSocketErrorEventHandler : MulticastDelegate
	{
		// Token: 0x06004A08 RID: 18952 RVA: 0x0016D1E8 File Offset: 0x0016B3E8
		[Token(Token = "0x6004A08")]
		[Address(RVA = "0x8CC670", Offset = "0x8CAC70", VA = "0x1808CC670")]
		public WebSocketErrorEventHandler(object @object, IntPtr method)
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

		// Token: 0x06004A09 RID: 18953 RVA: 0x0016D234 File Offset: 0x0016B434
		[Token(Token = "0x6004A09")]
		[Address(RVA = "0x8CC660", Offset = "0x8CAC60", VA = "0x1808CC660", Slot = "12")]
		public void Invoke(string errorMsg)
		{
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x0016D244 File Offset: 0x0016B444
		[Token(Token = "0x6004A0A")]
		[Address(RVA = "0x8CC620", Offset = "0x8CAC20", VA = "0x1808CC620", Slot = "13")]
		public IAsyncResult BeginInvoke(string errorMsg, AsyncCallback callback, object @object)
		{
			return null;
		}

		// Token: 0x06004A0B RID: 18955 RVA: 0x0016D254 File Offset: 0x0016B454
		[Token(Token = "0x6004A0B")]
		[Address(RVA = "0x8CC650", Offset = "0x8CAC50", VA = "0x1808CC650", Slot = "14")]
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}

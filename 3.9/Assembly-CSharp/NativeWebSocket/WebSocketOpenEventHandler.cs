using System;
using Cpp2IlInjected;

namespace NativeWebSocket
{
	// Token: 0x02000DFB RID: 3579
	[Token(Token = "0x2000DFB")]
	public sealed class WebSocketOpenEventHandler : MulticastDelegate
	{
		// Token: 0x06004A00 RID: 18944 RVA: 0x0016D0F0 File Offset: 0x0016B2F0
		[Token(Token = "0x6004A00")]
		[Address(RVA = "0x8CC760", Offset = "0x8CAD60", VA = "0x1808CC760")]
		public WebSocketOpenEventHandler(object @object, IntPtr method)
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

		// Token: 0x06004A01 RID: 18945 RVA: 0x0016D13C File Offset: 0x0016B33C
		[Token(Token = "0x6004A01")]
		[Address(RVA = "0x3E8000", Offset = "0x3E6600", VA = "0x1803E8000", Slot = "12")]
		public void Invoke()
		{
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x0016D14C File Offset: 0x0016B34C
		[Token(Token = "0x6004A02")]
		[Address(RVA = "0x8CC730", Offset = "0x8CAD30", VA = "0x1808CC730", Slot = "13")]
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			return null;
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x0016D15C File Offset: 0x0016B35C
		[Token(Token = "0x6004A03")]
		[Address(RVA = "0x8CC650", Offset = "0x8CAC50", VA = "0x1808CC650", Slot = "14")]
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}

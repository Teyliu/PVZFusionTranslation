using System;
using Cpp2IlInjected;
using OpenBLive.Runtime.Data;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E1B RID: 3611
	[Token(Token = "0x2000E1B")]
	public sealed class ReceiveSuperChatEvent : MulticastDelegate
	{
		// Token: 0x06004A6E RID: 19054 RVA: 0x0016EBDC File Offset: 0x0016CDDC
		[Token(Token = "0x6004A6E")]
		[Address(RVA = "0x8D0CC0", Offset = "0x8CF2C0", VA = "0x1808D0CC0")]
		public ReceiveSuperChatEvent(object @object, IntPtr method)
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

		// Token: 0x06004A6F RID: 19055 RVA: 0x0016EC28 File Offset: 0x0016CE28
		[Token(Token = "0x6004A6F")]
		[Address(RVA = "0x8D0C50", Offset = "0x8CF250", VA = "0x1808D0C50", Slot = "12")]
		public void Invoke(SuperChat e)
		{
			IntPtr invoke_impl = this.invoke_impl;
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x0016EC3C File Offset: 0x0016CE3C
		[Token(Token = "0x6004A70")]
		[Address(RVA = "0x8D0BD0", Offset = "0x8CF1D0", VA = "0x1808D0BD0", Slot = "13")]
		public IAsyncResult BeginInvoke(SuperChat e, AsyncCallback callback, object @object)
		{
			return typeof(SuperChat).TypeHandle;
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x0016EC50 File Offset: 0x0016CE50
		[Token(Token = "0x6004A71")]
		[Address(RVA = "0x8CC650", Offset = "0x8CAC50", VA = "0x1808CC650", Slot = "14")]
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}

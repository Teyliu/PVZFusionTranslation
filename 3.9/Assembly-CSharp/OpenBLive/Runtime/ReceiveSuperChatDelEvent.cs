using System;
using Cpp2IlInjected;
using OpenBLive.Runtime.Data;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E1C RID: 3612
	[Token(Token = "0x2000E1C")]
	public sealed class ReceiveSuperChatDelEvent : MulticastDelegate
	{
		// Token: 0x06004A72 RID: 19058 RVA: 0x0016EC60 File Offset: 0x0016CE60
		[Token(Token = "0x6004A72")]
		[Address(RVA = "0x8D0B20", Offset = "0x8CF120", VA = "0x1808D0B20")]
		public ReceiveSuperChatDelEvent(object @object, IntPtr method)
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

		// Token: 0x06004A73 RID: 19059 RVA: 0x0016ECAC File Offset: 0x0016CEAC
		[Token(Token = "0x6004A73")]
		[Address(RVA = "0x8D0AF0", Offset = "0x8CF0F0", VA = "0x1808D0AF0", Slot = "12")]
		public void Invoke(SuperChatDel e)
		{
			IntPtr invoke_impl = this.invoke_impl;
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x0016ECC0 File Offset: 0x0016CEC0
		[Token(Token = "0x6004A74")]
		[Address(RVA = "0x8D0A70", Offset = "0x8CF070", VA = "0x1808D0A70", Slot = "13")]
		public IAsyncResult BeginInvoke(SuperChatDel e, AsyncCallback callback, object @object)
		{
			return typeof(SuperChatDel).TypeHandle;
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x0016ECD4 File Offset: 0x0016CED4
		[Token(Token = "0x6004A75")]
		[Address(RVA = "0x8CC650", Offset = "0x8CAC50", VA = "0x1808CC650", Slot = "14")]
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}

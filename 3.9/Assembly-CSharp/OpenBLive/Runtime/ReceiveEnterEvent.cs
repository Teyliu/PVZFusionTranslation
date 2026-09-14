using System;
using Cpp2IlInjected;
using OpenBLive.Runtime.Data;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E1E RID: 3614
	[Token(Token = "0x2000E1E")]
	public sealed class ReceiveEnterEvent : MulticastDelegate
	{
		// Token: 0x06004A7A RID: 19066 RVA: 0x0016ED88 File Offset: 0x0016CF88
		[Token(Token = "0x6004A7A")]
		[Address(RVA = "0x8D0500", Offset = "0x8CEB00", VA = "0x1808D0500")]
		public ReceiveEnterEvent(object @object, IntPtr method)
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

		// Token: 0x06004A7B RID: 19067 RVA: 0x0016EDD4 File Offset: 0x0016CFD4
		[Token(Token = "0x6004A7B")]
		[Address(RVA = "0x8D04C0", Offset = "0x8CEAC0", VA = "0x1808D04C0", Slot = "12")]
		public void Invoke(Enter enter)
		{
			IntPtr invoke_impl = this.invoke_impl;
			string uface = enter.uface;
		}

		// Token: 0x06004A7C RID: 19068 RVA: 0x0016EDF0 File Offset: 0x0016CFF0
		[Token(Token = "0x6004A7C")]
		[Address(RVA = "0x8D0440", Offset = "0x8CEA40", VA = "0x1808D0440", Slot = "13")]
		public IAsyncResult BeginInvoke(Enter enter, AsyncCallback callback, object @object)
		{
			return typeof(Enter).TypeHandle;
		}

		// Token: 0x06004A7D RID: 19069 RVA: 0x0016EE04 File Offset: 0x0016D004
		[Token(Token = "0x6004A7D")]
		[Address(RVA = "0x8CC650", Offset = "0x8CAC50", VA = "0x1808CC650", Slot = "14")]
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}

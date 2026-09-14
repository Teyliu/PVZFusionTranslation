using System;
using Cpp2IlInjected;
using OpenBLive.Runtime.Data;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E20 RID: 3616
	[Token(Token = "0x2000E20")]
	public sealed class ReceiveLiveEndEvent : MulticastDelegate
	{
		// Token: 0x06004A82 RID: 19074 RVA: 0x0016EEA0 File Offset: 0x0016D0A0
		[Token(Token = "0x6004A82")]
		[Address(RVA = "0x8D0500", Offset = "0x8CEB00", VA = "0x1808D0500")]
		public ReceiveLiveEndEvent(object @object, IntPtr method)
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

		// Token: 0x06004A83 RID: 19075 RVA: 0x0016EEEC File Offset: 0x0016D0EC
		[Token(Token = "0x6004A83")]
		[Address(RVA = "0x8D04C0", Offset = "0x8CEAC0", VA = "0x1808D04C0", Slot = "12")]
		public void Invoke(LiveEnd liveEnd)
		{
			IntPtr invoke_impl = this.invoke_impl;
			long room_id = liveEnd.room_id;
		}

		// Token: 0x06004A84 RID: 19076 RVA: 0x0016EF08 File Offset: 0x0016D108
		[Token(Token = "0x6004A84")]
		[Address(RVA = "0x8D0860", Offset = "0x8CEE60", VA = "0x1808D0860", Slot = "13")]
		public IAsyncResult BeginInvoke(LiveEnd liveEnd, AsyncCallback callback, object @object)
		{
			return typeof(LiveEnd).TypeHandle;
		}

		// Token: 0x06004A85 RID: 19077 RVA: 0x0016EF1C File Offset: 0x0016D11C
		[Token(Token = "0x6004A85")]
		[Address(RVA = "0x8CC650", Offset = "0x8CAC50", VA = "0x1808CC650", Slot = "14")]
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}

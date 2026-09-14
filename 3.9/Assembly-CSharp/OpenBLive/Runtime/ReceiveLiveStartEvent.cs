using System;
using Cpp2IlInjected;
using OpenBLive.Runtime.Data;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E1F RID: 3615
	[Token(Token = "0x2000E1F")]
	public sealed class ReceiveLiveStartEvent : MulticastDelegate
	{
		// Token: 0x06004A7E RID: 19070 RVA: 0x0016EE14 File Offset: 0x0016D014
		[Token(Token = "0x6004A7E")]
		[Address(RVA = "0x8D0500", Offset = "0x8CEB00", VA = "0x1808D0500")]
		public ReceiveLiveStartEvent(object @object, IntPtr method)
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

		// Token: 0x06004A7F RID: 19071 RVA: 0x0016EE60 File Offset: 0x0016D060
		[Token(Token = "0x6004A7F")]
		[Address(RVA = "0x8D04C0", Offset = "0x8CEAC0", VA = "0x1808D04C0", Slot = "12")]
		public void Invoke(LiveStart liveStart)
		{
			IntPtr invoke_impl = this.invoke_impl;
			long room_id = liveStart.room_id;
		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x0016EE7C File Offset: 0x0016D07C
		[Token(Token = "0x6004A80")]
		[Address(RVA = "0x8D08E0", Offset = "0x8CEEE0", VA = "0x1808D08E0", Slot = "13")]
		public IAsyncResult BeginInvoke(LiveStart liveStart, AsyncCallback callback, object @object)
		{
			return typeof(LiveStart).TypeHandle;
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x0016EE90 File Offset: 0x0016D090
		[Token(Token = "0x6004A81")]
		[Address(RVA = "0x8CC650", Offset = "0x8CAC50", VA = "0x1808CC650", Slot = "14")]
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}

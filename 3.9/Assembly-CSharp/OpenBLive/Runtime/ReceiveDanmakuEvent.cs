using System;
using Cpp2IlInjected;
using OpenBLive.Runtime.Data;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E18 RID: 3608
	[Token(Token = "0x2000E18")]
	public sealed class ReceiveDanmakuEvent : MulticastDelegate
	{
		// Token: 0x06004A62 RID: 19042 RVA: 0x0016EA04 File Offset: 0x0016CC04
		[Token(Token = "0x6004A62")]
		[Address(RVA = "0x8D0390", Offset = "0x8CE990", VA = "0x1808D0390")]
		public ReceiveDanmakuEvent(object @object, IntPtr method)
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

		// Token: 0x06004A63 RID: 19043 RVA: 0x0016EA50 File Offset: 0x0016CC50
		[Token(Token = "0x6004A63")]
		[Address(RVA = "0x8D0330", Offset = "0x8CE930", VA = "0x1808D0330", Slot = "12")]
		public void Invoke(Dm dm)
		{
			IntPtr invoke_impl = this.invoke_impl;
			string userName = dm.userName;
			long timestamp = dm.timestamp;
			long fansMedalLevel = dm.fansMedalLevel;
			bool fansMedalWearingStatus = dm.fansMedalWearingStatus;
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x0016EA84 File Offset: 0x0016CC84
		[Token(Token = "0x6004A64")]
		[Address(RVA = "0x8D02B0", Offset = "0x8CE8B0", VA = "0x1808D02B0", Slot = "13")]
		public IAsyncResult BeginInvoke(Dm dm, AsyncCallback callback, object @object)
		{
			return typeof(Dm).TypeHandle;
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x0016EA98 File Offset: 0x0016CC98
		[Token(Token = "0x6004A65")]
		[Address(RVA = "0x8CC650", Offset = "0x8CAC50", VA = "0x1808CC650", Slot = "14")]
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}

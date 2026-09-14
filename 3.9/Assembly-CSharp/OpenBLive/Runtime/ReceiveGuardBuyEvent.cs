using System;
using Cpp2IlInjected;
using OpenBLive.Runtime.Data;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E1A RID: 3610
	[Token(Token = "0x2000E1A")]
	public sealed class ReceiveGuardBuyEvent : MulticastDelegate
	{
		// Token: 0x06004A6A RID: 19050 RVA: 0x0016EB34 File Offset: 0x0016CD34
		[Token(Token = "0x6004A6A")]
		[Address(RVA = "0x8D0390", Offset = "0x8CE990", VA = "0x1808D0390")]
		public ReceiveGuardBuyEvent(object @object, IntPtr method)
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

		// Token: 0x06004A6B RID: 19051 RVA: 0x0016EB80 File Offset: 0x0016CD80
		[Token(Token = "0x6004A6B")]
		[Address(RVA = "0x8D0330", Offset = "0x8CE930", VA = "0x1808D0330", Slot = "12")]
		public void Invoke(Guard guard)
		{
			IntPtr invoke_impl = this.invoke_impl;
			string guardUnit = guard.guardUnit;
			string fansMedalName = guard.fansMedalName;
			UserInfo userInfo = guard.userInfo;
			string userName = guard.userInfo.userName;
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x0016EBB8 File Offset: 0x0016CDB8
		[Token(Token = "0x6004A6C")]
		[Address(RVA = "0x8D0760", Offset = "0x8CED60", VA = "0x1808D0760", Slot = "13")]
		public IAsyncResult BeginInvoke(Guard guard, AsyncCallback callback, object @object)
		{
			return typeof(Guard).TypeHandle;
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x0016EBCC File Offset: 0x0016CDCC
		[Token(Token = "0x6004A6D")]
		[Address(RVA = "0x8CC650", Offset = "0x8CAC50", VA = "0x1808CC650", Slot = "14")]
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}

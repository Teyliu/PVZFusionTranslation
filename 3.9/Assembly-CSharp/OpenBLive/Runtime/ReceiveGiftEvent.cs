using System;
using Cpp2IlInjected;
using OpenBLive.Runtime.Data;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E19 RID: 3609
	[Token(Token = "0x2000E19")]
	public sealed class ReceiveGiftEvent : MulticastDelegate
	{
		// Token: 0x06004A66 RID: 19046 RVA: 0x0016EAA8 File Offset: 0x0016CCA8
		[Token(Token = "0x6004A66")]
		[Address(RVA = "0x8D06B0", Offset = "0x8CECB0", VA = "0x1808D06B0")]
		public ReceiveGiftEvent(object @object, IntPtr method)
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

		// Token: 0x06004A67 RID: 19047 RVA: 0x0016EAF4 File Offset: 0x0016CCF4
		[Token(Token = "0x6004A67")]
		[Address(RVA = "0x8D0630", Offset = "0x8CEC30", VA = "0x1808D0630", Slot = "12")]
		public void Invoke(SendGift sendGift)
		{
			string openId = sendGift.openId;
			IntPtr invoke_impl = this.invoke_impl;
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x0016EB10 File Offset: 0x0016CD10
		[Token(Token = "0x6004A68")]
		[Address(RVA = "0x8D05B0", Offset = "0x8CEBB0", VA = "0x1808D05B0", Slot = "13")]
		public IAsyncResult BeginInvoke(SendGift sendGift, AsyncCallback callback, object @object)
		{
			return typeof(SendGift).TypeHandle;
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x0016EB24 File Offset: 0x0016CD24
		[Token(Token = "0x6004A69")]
		[Address(RVA = "0x8CC650", Offset = "0x8CAC50", VA = "0x1808CC650", Slot = "14")]
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}

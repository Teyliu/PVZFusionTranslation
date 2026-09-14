using System;
using Cpp2IlInjected;
using OpenBLive.Runtime.Data;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E1D RID: 3613
	[Token(Token = "0x2000E1D")]
	public sealed class ReceiveLikeEvent : MulticastDelegate
	{
		// Token: 0x06004A76 RID: 19062 RVA: 0x0016ECE4 File Offset: 0x0016CEE4
		[Token(Token = "0x6004A76")]
		[Address(RVA = "0x8D0390", Offset = "0x8CE990", VA = "0x1808D0390")]
		public ReceiveLikeEvent(object @object, IntPtr method)
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

		// Token: 0x06004A77 RID: 19063 RVA: 0x0016ED30 File Offset: 0x0016CF30
		[Token(Token = "0x6004A77")]
		[Address(RVA = "0x8D0330", Offset = "0x8CE930", VA = "0x1808D0330", Slot = "12")]
		public void Invoke(Like like)
		{
			IntPtr invoke_impl = this.invoke_impl;
			string openId = like.openId;
			long timestamp = like.timestamp;
			string like_text = like.like_text;
			bool fans_medal_wearing_status = like.fans_medal_wearing_status;
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x0016ED64 File Offset: 0x0016CF64
		[Token(Token = "0x6004A78")]
		[Address(RVA = "0x8D07E0", Offset = "0x8CEDE0", VA = "0x1808D07E0", Slot = "13")]
		public IAsyncResult BeginInvoke(Like like, AsyncCallback callback, object @object)
		{
			return typeof(Like).TypeHandle;
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x0016ED78 File Offset: 0x0016CF78
		[Token(Token = "0x6004A79")]
		[Address(RVA = "0x8CC650", Offset = "0x8CAC50", VA = "0x1808CC650", Slot = "14")]
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}

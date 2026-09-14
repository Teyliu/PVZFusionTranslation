using System;
using Cpp2IlInjected;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E28 RID: 3624
	[Token(Token = "0x2000E28")]
	public sealed class HeartBeatSucceed : MulticastDelegate
	{
		// Token: 0x06004AC9 RID: 19145 RVA: 0x0017055C File Offset: 0x0016E75C
		[Token(Token = "0x6004AC9")]
		[Address(RVA = "0x8CC760", Offset = "0x8CAD60", VA = "0x1808CC760")]
		public HeartBeatSucceed(object @object, IntPtr method)
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

		// Token: 0x06004ACA RID: 19146 RVA: 0x001705A8 File Offset: 0x0016E7A8
		[Token(Token = "0x6004ACA")]
		[Address(RVA = "0x3E8000", Offset = "0x3E6600", VA = "0x1803E8000", Slot = "12")]
		public void Invoke()
		{
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x001705B8 File Offset: 0x0016E7B8
		[Token(Token = "0x6004ACB")]
		[Address(RVA = "0x8CC730", Offset = "0x8CAD30", VA = "0x1808CC730", Slot = "13")]
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			return null;
		}

		// Token: 0x06004ACC RID: 19148 RVA: 0x001705C8 File Offset: 0x0016E7C8
		[Token(Token = "0x6004ACC")]
		[Address(RVA = "0x8CC650", Offset = "0x8CAC50", VA = "0x1808CC650", Slot = "14")]
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}

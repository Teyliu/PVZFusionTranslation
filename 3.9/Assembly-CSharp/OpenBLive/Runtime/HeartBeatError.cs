using System;
using Cpp2IlInjected;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E29 RID: 3625
	[Token(Token = "0x2000E29")]
	public sealed class HeartBeatError : MulticastDelegate
	{
		// Token: 0x06004ACD RID: 19149 RVA: 0x001705D8 File Offset: 0x0016E7D8
		[Token(Token = "0x6004ACD")]
		[Address(RVA = "0x8CC670", Offset = "0x8CAC70", VA = "0x1808CC670")]
		public HeartBeatError(object @object, IntPtr method)
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

		// Token: 0x06004ACE RID: 19150 RVA: 0x00170624 File Offset: 0x0016E824
		[Token(Token = "0x6004ACE")]
		[Address(RVA = "0x8CC660", Offset = "0x8CAC60", VA = "0x1808CC660", Slot = "12")]
		public void Invoke(string json)
		{
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x00170634 File Offset: 0x0016E834
		[Token(Token = "0x6004ACF")]
		[Address(RVA = "0x8CC620", Offset = "0x8CAC20", VA = "0x1808CC620", Slot = "13")]
		public IAsyncResult BeginInvoke(string json, AsyncCallback callback, object @object)
		{
			return null;
		}

		// Token: 0x06004AD0 RID: 19152 RVA: 0x00170644 File Offset: 0x0016E844
		[Token(Token = "0x6004AD0")]
		[Address(RVA = "0x8CC650", Offset = "0x8CAC50", VA = "0x1808CC650", Slot = "14")]
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}

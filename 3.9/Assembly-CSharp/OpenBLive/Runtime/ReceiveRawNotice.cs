using System;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E21 RID: 3617
	[Token(Token = "0x2000E21")]
	public sealed class ReceiveRawNotice : MulticastDelegate
	{
		// Token: 0x06004A86 RID: 19078 RVA: 0x0016EF2C File Offset: 0x0016D12C
		[Token(Token = "0x6004A86")]
		[Address(RVA = "0x8D09B0", Offset = "0x8CEFB0", VA = "0x1808D09B0")]
		public ReceiveRawNotice(object @object, IntPtr method)
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

		// Token: 0x06004A87 RID: 19079 RVA: 0x0016EF78 File Offset: 0x0016D178
		[Token(Token = "0x6004A87")]
		[Address(RVA = "0x8D09A0", Offset = "0x8CEFA0", VA = "0x1808D09A0", Slot = "12")]
		public void Invoke(string raw, JObject jObject)
		{
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x0016EF88 File Offset: 0x0016D188
		[Token(Token = "0x6004A88")]
		[Address(RVA = "0x8D0960", Offset = "0x8CEF60", VA = "0x1808D0960", Slot = "13")]
		public IAsyncResult BeginInvoke(string raw, JObject jObject, AsyncCallback callback, object @object)
		{
			return null;
		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x0016EF98 File Offset: 0x0016D198
		[Token(Token = "0x6004A89")]
		[Address(RVA = "0x8CC650", Offset = "0x8CAC50", VA = "0x1808CC650", Slot = "14")]
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}

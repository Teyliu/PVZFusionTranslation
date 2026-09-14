using System;
using Cpp2IlInjected;
using UnityEngine;

namespace com.cyborgAssets.internalIBP
{
	// Token: 0x02000DF1 RID: 3569
	[Token(Token = "0x2000DF1")]
	[Serializable]
	public struct SerializedMethod
	{
		// Token: 0x04003424 RID: 13348
		[Token(Token = "0x4003424")]
		public const string NameProp = "name";

		// Token: 0x04003425 RID: 13349
		[Token(Token = "0x4003425")]
		public const string SignatureProp = "signature";

		// Token: 0x04003426 RID: 13350
		[Token(Token = "0x4003426")]
		public const string ParametersProp = "parameters";

		// Token: 0x04003427 RID: 13351
		[Token(Token = "0x4003427")]
		public const string UnsupportedArgs = "unsupportedArgs";

		// Token: 0x04003428 RID: 13352
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003428")]
		[SerializeField]
		private string name;

		// Token: 0x04003429 RID: 13353
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003429")]
		[SerializeField]
		private string signature;

		// Token: 0x0400342A RID: 13354
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400342A")]
		[SerializeField]
		private SerializedParameter[] parameters;

		// Token: 0x0400342B RID: 13355
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400342B")]
		[SerializeField]
		private string[] unsupportedArgs;
	}
}

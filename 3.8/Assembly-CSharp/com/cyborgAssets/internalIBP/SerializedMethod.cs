using System;
using Cpp2IlInjected;
using UnityEngine;

namespace com.cyborgAssets.internalIBP
{
	// Token: 0x02000D25 RID: 3365
	[Token(Token = "0x2000D25")]
	[Serializable]
	public struct SerializedMethod
	{
		// Token: 0x04003205 RID: 12805
		[Token(Token = "0x4003205")]
		public const string NameProp = "name";

		// Token: 0x04003206 RID: 12806
		[Token(Token = "0x4003206")]
		public const string SignatureProp = "signature";

		// Token: 0x04003207 RID: 12807
		[Token(Token = "0x4003207")]
		public const string ParametersProp = "parameters";

		// Token: 0x04003208 RID: 12808
		[Token(Token = "0x4003208")]
		public const string UnsupportedArgs = "unsupportedArgs";

		// Token: 0x04003209 RID: 12809
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003209")]
		[SerializeField]
		private string name;

		// Token: 0x0400320A RID: 12810
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400320A")]
		[SerializeField]
		private string signature;

		// Token: 0x0400320B RID: 12811
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400320B")]
		[SerializeField]
		private SerializedParameter[] parameters;

		// Token: 0x0400320C RID: 12812
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400320C")]
		[SerializeField]
		private string[] unsupportedArgs;
	}
}

using System;
using Cpp2IlInjected;
using UnityEngine;

namespace com.cyborgAssets.internalIBP
{
	// Token: 0x02000D27 RID: 3367
	[Token(Token = "0x2000D27")]
	[Serializable]
	public struct SerializedParameter
	{
		// Token: 0x04003220 RID: 12832
		[Token(Token = "0x4003220")]
		public const string NameProp = "name";

		// Token: 0x04003221 RID: 12833
		[Token(Token = "0x4003221")]
		public const string TypeProp = "type";

		// Token: 0x04003222 RID: 12834
		[Token(Token = "0x4003222")]
		public const string IntegerProp = "integerValue";

		// Token: 0x04003223 RID: 12835
		[Token(Token = "0x4003223")]
		public const string BooleanProp = "booleanValue";

		// Token: 0x04003224 RID: 12836
		[Token(Token = "0x4003224")]
		public const string FloatProp = "floatValue";

		// Token: 0x04003225 RID: 12837
		[Token(Token = "0x4003225")]
		public const string StringProp = "stringValue";

		// Token: 0x04003226 RID: 12838
		[Token(Token = "0x4003226")]
		public const string ColorProp = "colorValue";

		// Token: 0x04003227 RID: 12839
		[Token(Token = "0x4003227")]
		public const string ObjectReferenceProp = "objectReferenceValue";

		// Token: 0x04003228 RID: 12840
		[Token(Token = "0x4003228")]
		public const string EnumProp = "enumValue";

		// Token: 0x04003229 RID: 12841
		[Token(Token = "0x4003229")]
		public const string Vector2Prop = "vector2Value";

		// Token: 0x0400322A RID: 12842
		[Token(Token = "0x400322A")]
		public const string Vector3Prop = "vector3Value";

		// Token: 0x0400322B RID: 12843
		[Token(Token = "0x400322B")]
		public const string Vector4Prop = "vector4Value";

		// Token: 0x0400322C RID: 12844
		[Token(Token = "0x400322C")]
		public const string RectProp = "rectValue";

		// Token: 0x0400322D RID: 12845
		[Token(Token = "0x400322D")]
		public const string AnimationCurveProp = "animationCurveValue";

		// Token: 0x0400322E RID: 12846
		[Token(Token = "0x400322E")]
		public const string BoundsProp = "boundsValue";

		// Token: 0x0400322F RID: 12847
		[Token(Token = "0x400322F")]
		public const string QuaternionProp = "quaternionValue";

		// Token: 0x04003230 RID: 12848
		[Token(Token = "0x4003230")]
		public const string Vector2IntProp = "vector2IntValue";

		// Token: 0x04003231 RID: 12849
		[Token(Token = "0x4003231")]
		public const string Vector3IntProp = "vector3IntValue";

		// Token: 0x04003232 RID: 12850
		[Token(Token = "0x4003232")]
		public const string RectIntProp = "rectIntValue";

		// Token: 0x04003233 RID: 12851
		[Token(Token = "0x4003233")]
		public const string BoundsInProp = "boundsInValue";

		// Token: 0x04003234 RID: 12852
		[Token(Token = "0x4003234")]
		public const string UnsupportedProp = "unsupported";

		// Token: 0x04003235 RID: 12853
		[Token(Token = "0x4003235")]
		public const string RealTypeProp = "realType";

		// Token: 0x04003236 RID: 12854
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003236")]
		[SerializeField]
		private string name;

		// Token: 0x04003237 RID: 12855
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003237")]
		[SerializeField]
		private SerializedParameterType type;

		// Token: 0x04003238 RID: 12856
		[FieldOffset(Offset = "0x9")]
		[Token(Token = "0x4003238")]
		[SerializeField]
		private bool unsupported;

		// Token: 0x04003239 RID: 12857
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4003239")]
		[SerializeField]
		private int integerValue;

		// Token: 0x0400323A RID: 12858
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400323A")]
		[SerializeField]
		private bool booleanValue;

		// Token: 0x0400323B RID: 12859
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400323B")]
		[SerializeField]
		private float floatValue;

		// Token: 0x0400323C RID: 12860
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400323C")]
		[SerializeField]
		private string stringValue;

		// Token: 0x0400323D RID: 12861
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400323D")]
		[SerializeField]
		private Color colorValue;

		// Token: 0x0400323E RID: 12862
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400323E")]
		[SerializeField]
		private global::UnityEngine.Object objectReferenceValue;

		// Token: 0x0400323F RID: 12863
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400323F")]
		[SerializeField]
		private string realType;

		// Token: 0x04003240 RID: 12864
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003240")]
		[SerializeField]
		private int enumValue;

		// Token: 0x04003241 RID: 12865
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4003241")]
		[SerializeField]
		private Vector2 vector2Value;

		// Token: 0x04003242 RID: 12866
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4003242")]
		[SerializeField]
		private Vector3 vector3Value;

		// Token: 0x04003243 RID: 12867
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003243")]
		[SerializeField]
		private Vector4 vector4Value;

		// Token: 0x04003244 RID: 12868
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003244")]
		[SerializeField]
		private Rect rectValue;

		// Token: 0x04003245 RID: 12869
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4003245")]
		[SerializeField]
		private AnimationCurve animationCurveValue;

		// Token: 0x04003246 RID: 12870
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4003246")]
		[SerializeField]
		private Bounds boundsValue;

		// Token: 0x04003247 RID: 12871
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4003247")]
		[SerializeField]
		private Quaternion quaternionValue;

		// Token: 0x04003248 RID: 12872
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4003248")]
		[SerializeField]
		private Vector2Int vector2IntValue;

		// Token: 0x04003249 RID: 12873
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4003249")]
		[SerializeField]
		private Vector3Int vector3IntValue;

		// Token: 0x0400324A RID: 12874
		[FieldOffset(Offset = "0xBC")]
		[Token(Token = "0x400324A")]
		[SerializeField]
		private RectInt rectIntValue;

		// Token: 0x0400324B RID: 12875
		[FieldOffset(Offset = "0xCC")]
		[Token(Token = "0x400324B")]
		[SerializeField]
		private BoundsInt boundsInValue;
	}
}

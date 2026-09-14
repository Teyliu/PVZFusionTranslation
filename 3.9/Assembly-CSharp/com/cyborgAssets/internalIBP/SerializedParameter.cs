using System;
using Cpp2IlInjected;
using UnityEngine;

namespace com.cyborgAssets.internalIBP
{
	// Token: 0x02000DF3 RID: 3571
	[Token(Token = "0x2000DF3")]
	[Serializable]
	public struct SerializedParameter
	{
		// Token: 0x0400343F RID: 13375
		[Token(Token = "0x400343F")]
		public const string NameProp = "name";

		// Token: 0x04003440 RID: 13376
		[Token(Token = "0x4003440")]
		public const string TypeProp = "type";

		// Token: 0x04003441 RID: 13377
		[Token(Token = "0x4003441")]
		public const string IntegerProp = "integerValue";

		// Token: 0x04003442 RID: 13378
		[Token(Token = "0x4003442")]
		public const string BooleanProp = "booleanValue";

		// Token: 0x04003443 RID: 13379
		[Token(Token = "0x4003443")]
		public const string FloatProp = "floatValue";

		// Token: 0x04003444 RID: 13380
		[Token(Token = "0x4003444")]
		public const string StringProp = "stringValue";

		// Token: 0x04003445 RID: 13381
		[Token(Token = "0x4003445")]
		public const string ColorProp = "colorValue";

		// Token: 0x04003446 RID: 13382
		[Token(Token = "0x4003446")]
		public const string ObjectReferenceProp = "objectReferenceValue";

		// Token: 0x04003447 RID: 13383
		[Token(Token = "0x4003447")]
		public const string EnumProp = "enumValue";

		// Token: 0x04003448 RID: 13384
		[Token(Token = "0x4003448")]
		public const string Vector2Prop = "vector2Value";

		// Token: 0x04003449 RID: 13385
		[Token(Token = "0x4003449")]
		public const string Vector3Prop = "vector3Value";

		// Token: 0x0400344A RID: 13386
		[Token(Token = "0x400344A")]
		public const string Vector4Prop = "vector4Value";

		// Token: 0x0400344B RID: 13387
		[Token(Token = "0x400344B")]
		public const string RectProp = "rectValue";

		// Token: 0x0400344C RID: 13388
		[Token(Token = "0x400344C")]
		public const string AnimationCurveProp = "animationCurveValue";

		// Token: 0x0400344D RID: 13389
		[Token(Token = "0x400344D")]
		public const string BoundsProp = "boundsValue";

		// Token: 0x0400344E RID: 13390
		[Token(Token = "0x400344E")]
		public const string QuaternionProp = "quaternionValue";

		// Token: 0x0400344F RID: 13391
		[Token(Token = "0x400344F")]
		public const string Vector2IntProp = "vector2IntValue";

		// Token: 0x04003450 RID: 13392
		[Token(Token = "0x4003450")]
		public const string Vector3IntProp = "vector3IntValue";

		// Token: 0x04003451 RID: 13393
		[Token(Token = "0x4003451")]
		public const string RectIntProp = "rectIntValue";

		// Token: 0x04003452 RID: 13394
		[Token(Token = "0x4003452")]
		public const string BoundsInProp = "boundsInValue";

		// Token: 0x04003453 RID: 13395
		[Token(Token = "0x4003453")]
		public const string UnsupportedProp = "unsupported";

		// Token: 0x04003454 RID: 13396
		[Token(Token = "0x4003454")]
		public const string RealTypeProp = "realType";

		// Token: 0x04003455 RID: 13397
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003455")]
		[SerializeField]
		private string name;

		// Token: 0x04003456 RID: 13398
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003456")]
		[SerializeField]
		private SerializedParameterType type;

		// Token: 0x04003457 RID: 13399
		[FieldOffset(Offset = "0x9")]
		[Token(Token = "0x4003457")]
		[SerializeField]
		private bool unsupported;

		// Token: 0x04003458 RID: 13400
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4003458")]
		[SerializeField]
		private int integerValue;

		// Token: 0x04003459 RID: 13401
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003459")]
		[SerializeField]
		private bool booleanValue;

		// Token: 0x0400345A RID: 13402
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400345A")]
		[SerializeField]
		private float floatValue;

		// Token: 0x0400345B RID: 13403
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400345B")]
		[SerializeField]
		private string stringValue;

		// Token: 0x0400345C RID: 13404
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400345C")]
		[SerializeField]
		private Color colorValue;

		// Token: 0x0400345D RID: 13405
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400345D")]
		[SerializeField]
		private global::UnityEngine.Object objectReferenceValue;

		// Token: 0x0400345E RID: 13406
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400345E")]
		[SerializeField]
		private string realType;

		// Token: 0x0400345F RID: 13407
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400345F")]
		[SerializeField]
		private int enumValue;

		// Token: 0x04003460 RID: 13408
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4003460")]
		[SerializeField]
		private Vector2 vector2Value;

		// Token: 0x04003461 RID: 13409
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4003461")]
		[SerializeField]
		private Vector3 vector3Value;

		// Token: 0x04003462 RID: 13410
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003462")]
		[SerializeField]
		private Vector4 vector4Value;

		// Token: 0x04003463 RID: 13411
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003463")]
		[SerializeField]
		private Rect rectValue;

		// Token: 0x04003464 RID: 13412
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4003464")]
		[SerializeField]
		private AnimationCurve animationCurveValue;

		// Token: 0x04003465 RID: 13413
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4003465")]
		[SerializeField]
		private Bounds boundsValue;

		// Token: 0x04003466 RID: 13414
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4003466")]
		[SerializeField]
		private Quaternion quaternionValue;

		// Token: 0x04003467 RID: 13415
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4003467")]
		[SerializeField]
		private Vector2Int vector2IntValue;

		// Token: 0x04003468 RID: 13416
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4003468")]
		[SerializeField]
		private Vector3Int vector3IntValue;

		// Token: 0x04003469 RID: 13417
		[FieldOffset(Offset = "0xBC")]
		[Token(Token = "0x4003469")]
		[SerializeField]
		private RectInt rectIntValue;

		// Token: 0x0400346A RID: 13418
		[FieldOffset(Offset = "0xCC")]
		[Token(Token = "0x400346A")]
		[SerializeField]
		private BoundsInt boundsInValue;
	}
}

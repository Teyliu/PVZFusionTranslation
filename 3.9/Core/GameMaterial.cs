using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Core
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public static class GameMaterial
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x940740", Offset = "0x93ED40", VA = "0x180940740")]
		public static Material GetMaterial(MaterialType materialType)
		{
			return null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x940C40", Offset = "0x93F240", VA = "0x180940C40")]
		public static void SetMaterial(this Image renderer, MaterialType materialType)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x940EB0", Offset = "0x93F4B0", VA = "0x180940EB0")]
		public static void SetMaterial(this List<Image> renderer, MaterialType materialType)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x940B50", Offset = "0x93F150", VA = "0x180940B50")]
		public static void SetBrightness(this Image renderer, float brightness)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x940BD0", Offset = "0x93F1D0", VA = "0x180940BD0")]
		public static void SetMaterial(this SpriteRenderer renderer, MaterialType materialType)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x940CF0", Offset = "0x93F2F0", VA = "0x180940CF0")]
		public static void SetMaterial(this List<SpriteRenderer> renderer, MaterialType materialType)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x9408C0", Offset = "0x93EEC0", VA = "0x1809408C0")]
		public static void SetBrightness(this SpriteRenderer renderer, float brightness)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x9409E0", Offset = "0x93EFE0", VA = "0x1809409E0")]
		public static void SetBrightness(this List<SpriteRenderer> renderers, float brightness)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x9407E0", Offset = "0x93EDE0", VA = "0x1809407E0")]
		public static void SetBrightness(this SpriteRenderer[] renderers, float brightness)
		{
		}

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		private static readonly Dictionary<MaterialType, Material> MaterialsDic;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		public static MaterialPropertyBlock propBlock;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		public static Material UIHightLight;
	}
}

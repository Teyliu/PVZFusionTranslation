using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D0C RID: 3340
	[Token(Token = "0x2000D0C")]
	public class CherryChomper : BaseConfig
	{
		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x0600455B RID: 17755 RVA: 0x001647D4 File Offset: 0x001629D4
		[Token(Token = "0x170006E7")]
		public override string Role
		{
			[Token(Token = "0x600455B")]
			[Address(RVA = "0x8A9DA0", Offset = "0x8A83A0", VA = "0x1808A9DA0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600455C RID: 17756 RVA: 0x001647E8 File Offset: 0x001629E8
		[Token(Token = "0x170006E8")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600455C")]
			[Address(RVA = "0x3F3460", Offset = "0x3F1A60", VA = "0x1803F3460", Slot = "4")]
			get
			{
				return PlantType.CherryChomper;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600455D RID: 17757 RVA: 0x001647FC File Offset: 0x001629FC
		[Token(Token = "0x170006E9")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600455D")]
			[Address(RVA = "0x8A9C90", Offset = "0x8A8290", VA = "0x1808A9C90", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x00164828 File Offset: 0x00162A28
		[Token(Token = "0x600455E")]
		[Address(RVA = "0x8A9BF0", Offset = "0x8A81F0", VA = "0x1808A9BF0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			bool flag = "{il2cpp field on {'Chomper' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(Chomper).TypeHandle;
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x0016484C File Offset: 0x00162A4C
		[Token(Token = "0x600455F")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public CherryChomper()
		{
		}
	}
}

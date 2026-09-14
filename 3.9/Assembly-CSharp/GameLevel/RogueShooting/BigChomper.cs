using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D10 RID: 3344
	[Token(Token = "0x2000D10")]
	public class BigChomper : BaseConfig
	{
		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x00164A84 File Offset: 0x00162C84
		[Token(Token = "0x170006F8")]
		public override string Role
		{
			[Token(Token = "0x6004574")]
			[Address(RVA = "0x8A8990", Offset = "0x8A6F90", VA = "0x1808A8990", Slot = "7")]
			get
			{
				return "防御";
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06004575 RID: 17781 RVA: 0x00164A98 File Offset: 0x00162C98
		[Token(Token = "0x170006F9")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004575")]
			[Address(RVA = "0x8A8980", Offset = "0x8A6F80", VA = "0x1808A8980", Slot = "4")]
			get
			{
				return PlantType.BigChomper;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06004576 RID: 17782 RVA: 0x00164AAC File Offset: 0x00162CAC
		[Token(Token = "0x170006FA")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004576")]
			[Address(RVA = "0x8A8870", Offset = "0x8A6E70", VA = "0x1808A8870", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x00164AD8 File Offset: 0x00162CD8
		[Token(Token = "0x6004577")]
		[Address(RVA = "0x8A87D0", Offset = "0x8A6DD0", VA = "0x1808A87D0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			bool flag = "{il2cpp field on {'Chomper' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(Chomper).TypeHandle;
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x00164AFC File Offset: 0x00162CFC
		[Token(Token = "0x6004578")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public BigChomper()
		{
		}
	}
}

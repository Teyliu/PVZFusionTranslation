using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D0B RID: 3339
	[Token(Token = "0x2000D0B")]
	public class Chomper : BaseConfig
	{
		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06004556 RID: 17750 RVA: 0x00164744 File Offset: 0x00162944
		[Token(Token = "0x170006E4")]
		public override string Role
		{
			[Token(Token = "0x6004556")]
			[Address(RVA = "0x8AA4E0", Offset = "0x8A8AE0", VA = "0x1808AA4E0", Slot = "7")]
			get
			{
				return "输出/防御";
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06004557 RID: 17751 RVA: 0x00164758 File Offset: 0x00162958
		[Token(Token = "0x170006E5")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004557")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "4")]
			get
			{
				return PlantType.Chomper;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06004558 RID: 17752 RVA: 0x00164768 File Offset: 0x00162968
		[Token(Token = "0x170006E6")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004558")]
			[Address(RVA = "0x8AA340", Offset = "0x8A8940", VA = "0x1808AA340", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x0016479C File Offset: 0x0016299C
		[Token(Token = "0x6004559")]
		[Address(RVA = "0x8AA2A0", Offset = "0x8A88A0", VA = "0x1808AA2A0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			bool flag = "{il2cpp field on {'Chomper' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(Chomper).TypeHandle;
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x001647C0 File Offset: 0x001629C0
		[Token(Token = "0x600455A")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public Chomper()
		{
		}
	}
}

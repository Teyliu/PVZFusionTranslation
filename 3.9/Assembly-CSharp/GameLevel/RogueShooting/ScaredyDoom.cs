using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D39 RID: 3385
	[Token(Token = "0x2000D39")]
	public class ScaredyDoom : BaseConfig
	{
		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x0600465D RID: 18013 RVA: 0x001662F8 File Offset: 0x001644F8
		[Token(Token = "0x1700078B")]
		public override string Role
		{
			[Token(Token = "0x600465D")]
			[Address(RVA = "0x8B36C0", Offset = "0x8B1CC0", VA = "0x1808B36C0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x0600465E RID: 18014 RVA: 0x0016630C File Offset: 0x0016450C
		[Token(Token = "0x1700078C")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600465E")]
			[Address(RVA = "0x8B36B0", Offset = "0x8B1CB0", VA = "0x1808B36B0", Slot = "4")]
			get
			{
				return PlantType.ScaredyDoom;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x0600465F RID: 18015 RVA: 0x00166320 File Offset: 0x00164520
		[Token(Token = "0x1700078D")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600465F")]
			[Address(RVA = "0x8B35A0", Offset = "0x8B1BA0", VA = "0x1808B35A0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x0016634C File Offset: 0x0016454C
		[Token(Token = "0x6004660")]
		[Address(RVA = "0x8B3560", Offset = "0x8B1B60", VA = "0x1808B3560", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 19f, num2 != 0, num);
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x00166374 File Offset: 0x00164574
		[Token(Token = "0x6004661")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public ScaredyDoom()
		{
		}
	}
}

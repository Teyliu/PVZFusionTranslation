using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D47 RID: 3399
	[Token(Token = "0x2000D47")]
	public class ThreeSquash : BaseConfig
	{
		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x060046AD RID: 18093 RVA: 0x00166B6C File Offset: 0x00164D6C
		[Token(Token = "0x170007BE")]
		public override string Role
		{
			[Token(Token = "0x60046AD")]
			[Address(RVA = "0x8B91B0", Offset = "0x8B77B0", VA = "0x1808B91B0", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x060046AE RID: 18094 RVA: 0x00166B80 File Offset: 0x00164D80
		[Token(Token = "0x170007BF")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60046AE")]
			[Address(RVA = "0x8B91A0", Offset = "0x8B77A0", VA = "0x1808B91A0", Slot = "4")]
			get
			{
				return PlantType.ThreeSquash;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060046AF RID: 18095 RVA: 0x00166B94 File Offset: 0x00164D94
		[Token(Token = "0x170007C0")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60046AF")]
			[Address(RVA = "0x8B9090", Offset = "0x8B7690", VA = "0x1808B9090", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060046B0 RID: 18096 RVA: 0x00166BC0 File Offset: 0x00164DC0
		[Token(Token = "0x60046B0")]
		[Address(RVA = "0x8B8F80", Offset = "0x8B7580", VA = "0x1808B8F80", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			Action<object> action;
			EventManager.RemoveListener((GameEvent)((uint)5), action);
			int num3 = 0;
			Action<object> action2;
			EventManager.AddListener_obj((GameEvent)((uint)5), action2, num3 != 0);
		}

		// Token: 0x060046B1 RID: 18097 RVA: 0x00166C00 File Offset: 0x00164E00
		[Token(Token = "0x60046B1")]
		[Address(RVA = "0x8B8EE0", Offset = "0x8B74E0", VA = "0x1808B8EE0")]
		private void OnZombieTakeDamage(object obj)
		{
			if (obj == 0 || obj != 0)
			{
			}
		}

		// Token: 0x060046B2 RID: 18098 RVA: 0x00166C1C File Offset: 0x00164E1C
		[Token(Token = "0x60046B2")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public ThreeSquash()
		{
		}
	}
}

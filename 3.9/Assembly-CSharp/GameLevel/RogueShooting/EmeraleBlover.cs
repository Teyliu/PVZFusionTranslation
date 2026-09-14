using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000DAF RID: 3503
	[Token(Token = "0x2000DAF")]
	public class EmeraleBlover : BaseConfig
	{
		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x060048F0 RID: 18672 RVA: 0x0016AC00 File Offset: 0x00168E00
		[Token(Token = "0x17000919")]
		public override string Role
		{
			[Token(Token = "0x60048F0")]
			[Address(RVA = "0x8AB910", Offset = "0x8A9F10", VA = "0x1808AB910", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x060048F1 RID: 18673 RVA: 0x0016AC14 File Offset: 0x00168E14
		[Token(Token = "0x1700091A")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60048F1")]
			[Address(RVA = "0x7D16A0", Offset = "0x7CFCA0", VA = "0x1807D16A0", Slot = "4")]
			get
			{
				return PlantType.EmeraldUmbrella;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x060048F2 RID: 18674 RVA: 0x0016AC28 File Offset: 0x00168E28
		[Token(Token = "0x1700091B")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60048F2")]
			[Address(RVA = "0x8AB800", Offset = "0x8A9E00", VA = "0x1808AB800", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x0016AC58 File Offset: 0x00168E58
		[Token(Token = "0x60048F3")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x0016AC68 File Offset: 0x00168E68
		[Token(Token = "0x60048F4")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public EmeraleBlover()
		{
		}
	}
}

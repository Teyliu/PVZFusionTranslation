using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D79 RID: 3449
	[Token(Token = "0x2000D79")]
	public class Melonpult : BaseConfig
	{
		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060047C6 RID: 18374 RVA: 0x00168E34 File Offset: 0x00167034
		[Token(Token = "0x17000865")]
		public override string Role
		{
			[Token(Token = "0x60047C6")]
			[Address(RVA = "0x8AFD40", Offset = "0x8AE340", VA = "0x1808AFD40", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060047C7 RID: 18375 RVA: 0x00168E48 File Offset: 0x00167048
		[Token(Token = "0x17000866")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60047C7")]
			[Address(RVA = "0x71D570", Offset = "0x71BB70", VA = "0x18071D570", Slot = "4")]
			get
			{
				return PlantType.Melonpult;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x060047C8 RID: 18376 RVA: 0x00168E58 File Offset: 0x00167058
		[Token(Token = "0x17000867")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60047C8")]
			[Address(RVA = "0x8AFA90", Offset = "0x8AE090", VA = "0x1808AFA90", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x00168E9C File Offset: 0x0016709C
		[Token(Token = "0x60047C9")]
		[Address(RVA = "0x8A89C0", Offset = "0x8A6FC0", VA = "0x1808A89C0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x00168EC4 File Offset: 0x001670C4
		[Token(Token = "0x60047CA")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public Melonpult()
		{
		}
	}
}

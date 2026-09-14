using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C99 RID: 3225
	[Token(Token = "0x2000C99")]
	public class Cabbagepult : BaseConfig
	{
		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06004392 RID: 17298 RVA: 0x0015B3A4 File Offset: 0x001595A4
		[Token(Token = "0x170006D1")]
		public override string Role
		{
			[Token(Token = "0x6004392")]
			[Address(RVA = "0x82E910", Offset = "0x82CF10", VA = "0x18082E910", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06004393 RID: 17299 RVA: 0x0015B3B8 File Offset: 0x001595B8
		[Token(Token = "0x170006D2")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004393")]
			[Address(RVA = "0x6A11A0", Offset = "0x69F7A0", VA = "0x1806A11A0", Slot = "4")]
			get
			{
				return PlantType.Cabbagepult;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06004394 RID: 17300 RVA: 0x0015B3C8 File Offset: 0x001595C8
		[Token(Token = "0x170006D3")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004394")]
			[Address(RVA = "0x82E770", Offset = "0x82CD70", VA = "0x18082E770", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)26L);
				upgradeBuff.targetType = (PlantType)((ulong)1135L);
				int size = list._size;
				UpgradeBuff upgradeBuff2;
				upgradeBuff2.sourceType = (PlantType)((ulong)26L);
				upgradeBuff2.targetType = (PlantType)((ulong)1342L);
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x0015B42C File Offset: 0x0015962C
		[Token(Token = "0x6004395")]
		[Address(RVA = "0x82E720", Offset = "0x82CD20", VA = "0x18082E720", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 14f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x0015B460 File Offset: 0x00159660
		[Token(Token = "0x6004396")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public Cabbagepult()
		{
		}
	}
}

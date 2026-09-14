using System;
using Cpp2IlInjected;

// Token: 0x0200002A RID: 42
[Token(Token = "0x200002A")]
public class Debuff_逆行炼狱 : BaseDebuff
{
	// Token: 0x1700002A RID: 42
	// (get) Token: 0x060000B2 RID: 178 RVA: 0x000045E8 File Offset: 0x000027E8
	[Token(Token = "0x1700002A")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x3A7340", Offset = "0x3A5940", VA = "0x1803A7340", Slot = "12")]
		get
		{
			return TravelDebuff.逆行炼狱;
		}
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x000045FC File Offset: 0x000027FC
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x3A71E0", Offset = "0x3A57E0", VA = "0x1803A71E0", Slot = "13")]
	public override string GetDescription()
	{
		return "逆行炼狱：究极植物的数值倍率降低为原来的10%，非究极植物的数值倍率提高4000%，速度提高200%";
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00004610 File Offset: 0x00002810
	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x3A7210", Offset = "0x3A5810", VA = "0x1803A7210", Slot = "18")]
	public override void ReinforcePlant(Board board, Plant plant)
	{
		if (!Lawnf.IsUltiPlant(plant.thePlantType) && plant.thePlantType != PlantType.BigSunNut)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)49), 39f, num2 != 0, num);
			int num3 = 0;
			plant.ModifyHealth((PlantHealthAdder)((uint)11), 39f, num3 != 0);
			plant.attackSpeedAdder = 2f;
			plant.attributeSpeed = 3f;
			float num4 = plant.thePlantSpeed * 3f;
			plant.thePlantSpeed = num4;
			float num5 = plant.thePlantProduceInterval * 0.33f;
			plant.thePlantProduceInterval = num5;
			return;
		}
		int num6 = 0;
		int num7 = 0;
		plant.ModifyDamage((PlantDamageAdder)((uint)49), -0.9f, num7 != 0, num6);
		int num8 = 0;
		plant.ModifyHealth((PlantHealthAdder)((uint)11), -0.9f, num8 != 0);
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x000046D0 File Offset: 0x000028D0
	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x39F6E0", Offset = "0x39DCE0", VA = "0x18039F6E0")]
	public Debuff_逆行炼狱()
	{
	}
}

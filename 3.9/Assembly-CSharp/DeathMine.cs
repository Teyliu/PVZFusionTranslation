using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000310 RID: 784
[Token(Token = "0x2000310")]
public class DeathMine : PotatoMine
{
	// Token: 0x06000E52 RID: 3666 RVA: 0x00051FD8 File Offset: 0x000501D8
	[Token(Token = "0x6000E52")]
	[Address(RVA = "0x4461E0", Offset = "0x4447E0", VA = "0x1804461E0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 30f;
		this.anim.Play("in");
	}

	// Token: 0x06000E53 RID: 3667 RVA: 0x0005200C File Offset: 0x0005020C
	[Token(Token = "0x6000E53")]
	[Address(RVA = "0x445A20", Offset = "0x444020", VA = "0x180445A20", Slot = "72")]
	public override void Explode()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num2 = 0;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)141), num2, 11, num4 != 0UL, (float)num3);
		GameAPP.PlaySound(47, 0.5f, 1f);
		ScreenShake.TriggerShake(0.15f);
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x0005206C File Offset: 0x0005026C
	[Token(Token = "0x6000E54")]
	[Address(RVA = "0x445A00", Offset = "0x444000", VA = "0x180445A00", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		this.Killing();
	}

	// Token: 0x06000E55 RID: 3669 RVA: 0x00052084 File Offset: 0x00050284
	[Token(Token = "0x6000E55")]
	[Address(RVA = "0x445B60", Offset = "0x444160", VA = "0x180445B60")]
	private void Killing()
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int num = 0;
		int attackDamage = this.attackDamage;
		BoardAction boardAction2 = this.board.boardAction;
		PlantType thePlantType2 = this.thePlantType;
		int num2 = 0;
		int attackDamage2 = this.attackDamage;
		int thePlantRow = this.thePlantRow;
		ulong num3;
		boardAction2.CreateFireLine(thePlantRow, attackDamage2, num2 != 0, num != 0, num3 != 0UL, num, thePlantType2);
		int num4 = this.thePlantRow;
		List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, num4);
		int size = list._size;
		int num5 = size - 1;
		if (size > 0)
		{
			num4 = num5;
			Plant plant = list[num4];
			PlantType thePlantType3 = plant.thePlantType;
			if (thePlantType3 == PlantType.EndoFlame || thePlantType3 == PlantType.DeathChomper || thePlantType3 == PlantType.DeathMine)
			{
				num4 = num5;
				list.RemoveAt(num4);
			}
			if (plant.plantTag != (ulong)0L || plant.isLily)
			{
				num4 = num5;
				list.RemoveAt(num4);
			}
		}
		DeathChomper.KillPlants(list);
		Transform axis = this.axis;
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x00052190 File Offset: 0x00050390
	[Token(Token = "0x6000E56")]
	[Address(RVA = "0x445D90", Offset = "0x444390", VA = "0x180445D90")]
	public static void SetVo(Plant plant, Vector2 center)
	{
		LayerMask zombieLayer = plant.zombieLayer;
		List<Zombie> list = new List();
		int num = 0;
		int num2 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = plant.thePlantRow;
			}
			num2++;
		}
		Func<Zombie, long> func;
		if (DeathMine.<>c.<>9__4_0 == 0)
		{
			DeathMine.<>c.<>9__4_0 = func;
		}
		Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderByDescending<Zombie, long>(list, func));
		Transform axis = plant.axis;
		CreateZombie instance = CreateZombie.Instance;
		int num3 = 0;
		Zombie zombie2;
		if (zombie2 != num3)
		{
			VoodooDollZombie component = zombie2.GetComponent<VoodooDollZombie>();
			ZombieType theZombieType = zombie.theZombieType;
			component.VoodooZombieType = theZombieType;
			long totalAllHealth = zombie.TotalAllHealth;
			component.theMaxHealth = totalAllHealth;
			component.theHealth = totalAllHealth;
			component.UpdateHealthText();
			int theZombieType2 = (int)zombie.theZombieType;
			bool flag2;
			if (flag2)
			{
				float num4 = component.rate * 0.5f;
				component.rate = num4;
			}
			bool flag3;
			if (flag3)
			{
				float rate = component.rate;
				component.rate = rate;
			}
		}
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x00052294 File Offset: 0x00050494
	[Token(Token = "0x6000E57")]
	[Address(RVA = "0x446250", Offset = "0x444850", VA = "0x180446250")]
	public DeathMine()
	{
	}
}

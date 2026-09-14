using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000300 RID: 768
[Token(Token = "0x2000300")]
public class DeathMine : PotatoMine
{
	// Token: 0x06000E09 RID: 3593 RVA: 0x0005102C File Offset: 0x0004F22C
	[Token(Token = "0x6000E09")]
	[Address(RVA = "0x401F20", Offset = "0x400520", VA = "0x180401F20", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 30f;
		this.anim.Play("in");
	}

	// Token: 0x06000E0A RID: 3594 RVA: 0x00051060 File Offset: 0x0004F260
	[Token(Token = "0x6000E0A")]
	[Address(RVA = "0x401760", Offset = "0x3FFD60", VA = "0x180401760", Slot = "73")]
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

	// Token: 0x06000E0B RID: 3595 RVA: 0x000510C0 File Offset: 0x0004F2C0
	[Token(Token = "0x6000E0B")]
	[Address(RVA = "0x401740", Offset = "0x3FFD40", VA = "0x180401740", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		this.Killing();
	}

	// Token: 0x06000E0C RID: 3596 RVA: 0x000510D8 File Offset: 0x0004F2D8
	[Token(Token = "0x6000E0C")]
	[Address(RVA = "0x4018A0", Offset = "0x3FFEA0", VA = "0x1804018A0")]
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

	// Token: 0x06000E0D RID: 3597 RVA: 0x000511E4 File Offset: 0x0004F3E4
	[Token(Token = "0x6000E0D")]
	[Address(RVA = "0x401AD0", Offset = "0x4000D0", VA = "0x180401AD0")]
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
		Func<Zombie, int> func;
		if (DeathMine.<>c.<>9__4_0 == 0)
		{
			DeathMine.<>c.<>9__4_0 = func;
		}
		Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderByDescending<Zombie, int>(list, func));
		Transform axis = plant.axis;
		CreateZombie instance = CreateZombie.Instance;
		int num3 = 0;
		Zombie zombie2;
		if (zombie2 != num3)
		{
			VoodooDollZombie component = zombie2.GetComponent<VoodooDollZombie>();
			ZombieType theZombieType = zombie.theZombieType;
			component.VoodooZombieType = theZombieType;
			int totalAllHealth = zombie.TotalAllHealth;
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

	// Token: 0x06000E0E RID: 3598 RVA: 0x000512E8 File Offset: 0x0004F4E8
	[Token(Token = "0x6000E0E")]
	[Address(RVA = "0x401F90", Offset = "0x400590", VA = "0x180401F90")]
	public DeathMine()
	{
		this.flashInterval = 3f;
		base..ctor();
	}
}

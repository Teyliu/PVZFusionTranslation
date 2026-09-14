using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000526 RID: 1318
[Token(Token = "0x2000526")]
public class LanternFume : Shooter
{
	// Token: 0x06001886 RID: 6278 RVA: 0x00085550 File Offset: 0x00083750
	[Token(Token = "0x6001886")]
	[Address(RVA = "0x4D24E0", Offset = "0x4D0AE0", VA = "0x1804D24E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		ParticleSystem component = base.transform.Find("LanternShine").GetComponent<ParticleSystem>();
		this.lightShine = component;
		throw new NullReferenceException();
	}

	// Token: 0x06001887 RID: 6279 RVA: 0x00085588 File Offset: 0x00083788
	[Token(Token = "0x6001887")]
	[Address(RVA = "0x4D2160", Offset = "0x4D0760", VA = "0x1804D2160", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		ParticleSystem.MainModule main = this.lightShine.main;
	}

	// Token: 0x06001888 RID: 6280 RVA: 0x000855B4 File Offset: 0x000837B4
	[Token(Token = "0x6001888")]
	[Address(RVA = "0x4D2580", Offset = "0x4D0B80", VA = "0x1804D2580", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		Board board = this.board;
		PlantType thePlantType = this.thePlantType;
		Action action = new Action(this.AttackZombie);
		throw new NullReferenceException();
	}

	// Token: 0x06001889 RID: 6281 RVA: 0x000855F0 File Offset: 0x000837F0
	[Token(Token = "0x6001889")]
	[Address(RVA = "0x4D21E0", Offset = "0x4D07E0", VA = "0x1804D21E0")]
	private void AttackZombie()
	{
		int num2;
		ulong num5;
		do
		{
			int num = 0;
			List<Zombie> zombiesByRow = Lawnf.GetZombiesByRow(this.thePlantRow, num != 0);
			num2 = 0;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				Transform axis = this.axis;
				int num3 = 0;
				int num4 = this.currentLightLevel;
				num4 -= num3;
				PlantType thePlantType = this.thePlantType;
			}
		}
		while (num5 != (ulong)0L);
		uint num6;
		GameAPP.PlaySound((int)num6, 1f, (float)num2);
	}

	// Token: 0x0600188A RID: 6282 RVA: 0x00085670 File Offset: 0x00083870
	[Token(Token = "0x600188A")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public LanternFume()
	{
	}

	// Token: 0x04000E10 RID: 3600
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E10")]
	private ParticleSystem lightShine;
}

using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000553 RID: 1363
[Token(Token = "0x2000553")]
public class LanternFume : Shooter
{
	// Token: 0x06001956 RID: 6486 RVA: 0x00089204 File Offset: 0x00087404
	[Token(Token = "0x6001956")]
	[Address(RVA = "0x532DC0", Offset = "0x5313C0", VA = "0x180532DC0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		ParticleSystem component = base.transform.Find("LanternShine").GetComponent<ParticleSystem>();
		this.lightShine = component;
		throw new NullReferenceException();
	}

	// Token: 0x06001957 RID: 6487 RVA: 0x0008923C File Offset: 0x0008743C
	[Token(Token = "0x6001957")]
	[Address(RVA = "0x532A40", Offset = "0x531040", VA = "0x180532A40", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		ParticleSystem.MainModule main = this.lightShine.main;
	}

	// Token: 0x06001958 RID: 6488 RVA: 0x00089268 File Offset: 0x00087468
	[Token(Token = "0x6001958")]
	[Address(RVA = "0x532E60", Offset = "0x531460", VA = "0x180532E60", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		Board board = this.board;
		PlantType thePlantType = this.thePlantType;
		Action action = new Action(this.AttackZombie);
		throw new NullReferenceException();
	}

	// Token: 0x06001959 RID: 6489 RVA: 0x000892A4 File Offset: 0x000874A4
	[Token(Token = "0x6001959")]
	[Address(RVA = "0x532AC0", Offset = "0x5310C0", VA = "0x180532AC0")]
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

	// Token: 0x0600195A RID: 6490 RVA: 0x00089324 File Offset: 0x00087524
	[Token(Token = "0x600195A")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public LanternFume()
	{
	}

	// Token: 0x04000ECB RID: 3787
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000ECB")]
	private ParticleSystem lightShine;
}

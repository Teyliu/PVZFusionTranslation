using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200051C RID: 1308
[Token(Token = "0x200051C")]
public class FumeChomper : PeaChomper
{
	// Token: 0x0600187E RID: 6270 RVA: 0x00084E50 File Offset: 0x00083050
	[Token(Token = "0x600187E")]
	[Address(RVA = "0x5243F0", Offset = "0x5229F0", VA = "0x1805243F0", Slot = "76")]
	public override Bullet AnimShoot()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		int num = 0;
		Transform shoot = this.shoot;
		ParticleManager instance = ParticleManager.Instance;
		int num2 = 0;
		int thePlantRow = this.thePlantRow;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)162), num2, thePlantRow, num3 != 0UL, (float)num);
		GameAPP.PlaySound((SoundType)((uint)58), 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x0600187F RID: 6271 RVA: 0x00084EC0 File Offset: 0x000830C0
	[Token(Token = "0x600187F")]
	[Address(RVA = "0x524670", Offset = "0x522C70", VA = "0x180524670", Slot = "38")]
	protected override void OnUpdate()
	{
	}

	// Token: 0x06001880 RID: 6272 RVA: 0x00084ED0 File Offset: 0x000830D0
	[Token(Token = "0x6001880")]
	[Address(RVA = "0x524690", Offset = "0x522C90", VA = "0x180524690", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		Transform shoot = this.shoot;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus((ZombieStatus)num))
			{
				int thePlantRow = this.thePlantRow;
			}
			num++;
			GameObject gameObject;
			return gameObject;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001881 RID: 6273 RVA: 0x00084F20 File Offset: 0x00083120
	[Token(Token = "0x6001881")]
	[Address(RVA = "0x5245C0", Offset = "0x522BC0", VA = "0x1805245C0")]
	private void Attack()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001882 RID: 6274 RVA: 0x00084F40 File Offset: 0x00083140
	[Token(Token = "0x6001882")]
	[Address(RVA = "0x524880", Offset = "0x522E80", VA = "0x180524880")]
	public FumeChomper()
	{
	}
}

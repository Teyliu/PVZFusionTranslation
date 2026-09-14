using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200008F RID: 143
[Token(Token = "0x200008F")]
public class Blow : MonoBehaviour
{
	// Token: 0x0600024C RID: 588 RVA: 0x000081E4 File Offset: 0x000063E4
	[Token(Token = "0x600024C")]
	[Address(RVA = "0x3F0AC0", Offset = "0x3EF0C0", VA = "0x1803F0AC0")]
	private void Start()
	{
		float plantMaxVisionX = Board.Instance.plantMaxVisionX;
		this.vision = plantMaxVisionX;
		Zombie component = base.GetComponent<Zombie>();
		this.zombie = component;
		Zombie zombie = this.zombie;
		int num = 0;
		if (!(zombie == num))
		{
			ZombieStatus theStatus = this.zombie.theStatus;
			int num2 = 0;
			if (theStatus == ZombieStatus.Flying || theStatus <= ZombieStatus.Dying)
			{
			}
			this.blowType = (Blow.BlowType)num2;
			Zombie zombie2 = this.zombie;
			if ((zombie2.isBlowed ? 1 : 0) != num2)
			{
				this.blowType = (Blow.BlowType)num2;
			}
			ZombieType theZombieType = zombie2.theZombieType;
			BombThrower component2;
			if (theZombieType > ZombieType.SuperKirov)
			{
				bool flag;
				if (theZombieType > ZombieType.SuperLevatation)
				{
					if (theZombieType == ZombieType.MachineLevatation)
					{
						goto IL_00F5;
					}
					if (theZombieType == ZombieType.PortalBalloonZombie)
					{
						global::UnityEngine.Object.Destroy(this);
						return;
					}
					if (flag <= true)
					{
						goto IL_012C;
					}
				}
				if (flag)
				{
					this.blowType = (Blow.BlowType)((ulong)4L);
					component2 = base.GetComponent<BombThrower>();
					this.bombThrower = component2;
				}
				if (component2 == (ulong)221L)
				{
					goto IL_012C;
				}
				if (component2 == (ulong)236L)
				{
					goto IL_00F5;
				}
			}
			if (component2 <= (ulong)29L)
			{
				goto IL_0124;
			}
			if (component2 != (ulong)53L)
			{
				goto IL_0111;
			}
			IL_00F5:
			Zombie zombie3 = this.zombie;
			if (zombie3.theStatus != ZombieStatus.Flying)
			{
				goto IL_0169;
			}
			this.blowType = (Blow.BlowType)((ulong)5L);
			IL_0111:
			if (zombie3 == (ulong)119L)
			{
				goto IL_0150;
			}
			if (zombie3 == (ulong)205L)
			{
				goto IL_012C;
			}
			IL_0124:
			if (zombie3 != (ulong)26L)
			{
				goto IL_0148;
			}
			IL_012C:
			Zombie zombie4 = this.zombie;
			if (zombie4.theStatus != ZombieStatus.Flying)
			{
				goto IL_0169;
			}
			this.blowType = (Blow.BlowType)((ulong)1L);
			IL_0148:
			if (zombie4 != (ulong)29L)
			{
				goto IL_0169;
			}
			IL_0150:
			this.blowType = (Blow.BlowType)((ulong)3L);
			IronBalloonZombie component3 = base.GetComponent<IronBalloonZombie>();
			this.ironBalloonZombie = component3;
			IL_0169:
			if (this.blowType == Blow.BlowType.Default)
			{
			}
			AdvantureData data = AdvantureConfig.data;
			bool flag2;
			while (!flag2)
			{
			}
			float num3 = this.blowForce * 1.2f;
			this.blowForce = num3;
			return;
		}
		Debug.LogError("不能吹走非僵尸");
	}

	// Token: 0x0600024D RID: 589 RVA: 0x00008398 File Offset: 0x00006598
	[Token(Token = "0x600024D")]
	[Address(RVA = "0x3F0E40", Offset = "0x3EF440", VA = "0x1803F0E40")]
	private void Update()
	{
		float deltaTime = Time.deltaTime;
		Blow.BlowType blowType = this.blowType;
		this.blowTime = deltaTime;
		Zombie zombie = this.zombie;
		if (blowType != Blow.BlowType.BlowKirov)
		{
			zombie.isBlowed = true;
			Transform transform = base.transform;
			float num = this.blowForce;
			float deltaTime2 = Time.deltaTime;
			return;
		}
		Transform axis = zombie.axis;
		float num2 = this.vision;
		Transform transform2 = base.transform;
		float num3 = this.blowForce;
		float deltaTime3 = Time.deltaTime;
		if (this.blowForce > 1f)
		{
			Transform transform3 = base.transform;
			float num4 = this.blowForce;
			float num5 = Time.deltaTime;
		}
		BombThrower bombThrower = this.bombThrower;
		float num6 = this.blowTime;
		GameObject patels = bombThrower.patels1;
		int num7 = 0;
		patels.SetActive(num7 != 0);
		ulong num8;
		this.bombThrower.patels2.SetActive(num8 != 0UL);
		GameObject patels2 = this.bombThrower.patels2;
		int num9 = 0;
		patels2.SetActive(num9 != 0);
		if (this.blowForce > 1f)
		{
			Transform transform4 = base.transform;
			float num10 = this.blowForce;
			float num5 = Time.deltaTime;
		}
		IronBalloonZombie ironBalloonZombie = this.ironBalloonZombie;
		float num11 = this.blowTime;
		GameObject petals = ironBalloonZombie.Petals1;
		int num12 = 0;
		petals.SetActive(num12 != 0);
		GameObject petals2 = this.ironBalloonZombie.Petals2;
		ulong num13;
		petals2.SetActive(num13 != 0UL);
		ulong num14;
		petals2.SetActive(num14 != 0UL);
		GameObject petals3 = this.ironBalloonZombie.Petals2;
		Transform axis2 = this.zombie.axis;
		float num15 = this.vision;
		Transform transform5 = base.transform;
		float num16 = this.blowForce;
		float deltaTime4 = Time.deltaTime;
		Transform axis3 = this.zombie.axis;
		float num17 = this.vision;
		bool flag;
		if (!flag)
		{
			Transform transform6 = base.transform;
			float num18 = this.blowForce;
			float deltaTime5 = Time.deltaTime;
		}
		float num19 = this.blowTime;
		global::UnityEngine.Object.Destroy(this);
		throw new NullReferenceException();
	}

	// Token: 0x0600024E RID: 590 RVA: 0x00008578 File Offset: 0x00006778
	[Token(Token = "0x600024E")]
	[Address(RVA = "0x3F13C0", Offset = "0x3EF9C0", VA = "0x1803F13C0")]
	public Blow()
	{
	}

	// Token: 0x0400009A RID: 154
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400009A")]
	private Zombie zombie;

	// Token: 0x0400009B RID: 155
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400009B")]
	private Blow.BlowType blowType;

	// Token: 0x0400009C RID: 156
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400009C")]
	private float blowTime;

	// Token: 0x0400009D RID: 157
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400009D")]
	private IronBalloonZombie ironBalloonZombie;

	// Token: 0x0400009E RID: 158
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400009E")]
	private BombThrower bombThrower;

	// Token: 0x0400009F RID: 159
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400009F")]
	private float vision;

	// Token: 0x040000A0 RID: 160
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000A0")]
	private float blowForce = 1f;

	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	private enum BlowType
	{
		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		Default,
		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		BlowKirov,
		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		BlowZombieOnWater,
		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		BlowIronBalloon,
		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		BombThrower,
		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		BlowLevatation
	}
}

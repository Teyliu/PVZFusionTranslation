using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200008A RID: 138
[Token(Token = "0x200008A")]
public class Blow : MonoBehaviour
{
	// Token: 0x06000231 RID: 561 RVA: 0x00007E00 File Offset: 0x00006000
	[Token(Token = "0x6000231")]
	[Address(RVA = "0x3A4B30", Offset = "0x3A3130", VA = "0x1803A4B30")]
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

	// Token: 0x06000232 RID: 562 RVA: 0x00007FB4 File Offset: 0x000061B4
	[Token(Token = "0x6000232")]
	[Address(RVA = "0x3A4EB0", Offset = "0x3A34B0", VA = "0x1803A4EB0")]
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

	// Token: 0x06000233 RID: 563 RVA: 0x00008194 File Offset: 0x00006394
	[Token(Token = "0x6000233")]
	[Address(RVA = "0x3A5430", Offset = "0x3A3A30", VA = "0x1803A5430")]
	public Blow()
	{
	}

	// Token: 0x0400008D RID: 141
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400008D")]
	private Zombie zombie;

	// Token: 0x0400008E RID: 142
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400008E")]
	private Blow.BlowType blowType;

	// Token: 0x0400008F RID: 143
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400008F")]
	private float blowTime;

	// Token: 0x04000090 RID: 144
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000090")]
	private IronBalloonZombie ironBalloonZombie;

	// Token: 0x04000091 RID: 145
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000091")]
	private BombThrower bombThrower;

	// Token: 0x04000092 RID: 146
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000092")]
	private float vision;

	// Token: 0x04000093 RID: 147
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000093")]
	private float blowForce = 1f;

	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	private enum BlowType
	{
		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		Default,
		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		BlowKirov,
		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		BlowZombieOnWater,
		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		BlowIronBalloon,
		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		BombThrower,
		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		BlowLevatation
	}
}

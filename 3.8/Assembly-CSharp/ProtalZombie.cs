using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006BA RID: 1722
[Token(Token = "0x20006BA")]
public class ProtalZombie : DoorZombie
{
	// Token: 0x060021CC RID: 8652 RVA: 0x000B1AF4 File Offset: 0x000AFCF4
	[Token(Token = "0x60021CC")]
	[Address(RVA = "0x569E40", Offset = "0x568440", VA = "0x180569E40", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(0.5f, 1.5f);
		this.attributeCountDown = num;
	}

	// Token: 0x060021CD RID: 8653 RVA: 0x000B1B20 File Offset: 0x000AFD20
	[Token(Token = "0x60021CD")]
	[Address(RVA = "0x569E80", Offset = "0x568480", VA = "0x180569E80", Slot = "60")]
	public override GameObject DropArmor()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = Resources.Load<GameObject>("Items/PortalHeart");
		Board board = this.board;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = board.transform;
		GameObject gameObject2;
		return gameObject2;
	}

	// Token: 0x060021CE RID: 8654 RVA: 0x000B1B6C File Offset: 0x000AFD6C
	[Token(Token = "0x60021CE")]
	[Address(RVA = "0x534430", Offset = "0x532A30", VA = "0x180534430", Slot = "33")]
	protected override void LoseHeadEvent()
	{
	}

	// Token: 0x060021CF RID: 8655 RVA: 0x000B1B7C File Offset: 0x000AFD7C
	[Token(Token = "0x60021CF")]
	[Address(RVA = "0x569B10", Offset = "0x568110", VA = "0x180569B10", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.SecondArmorBroken();
		GameObject theSecondArmor = this.theSecondArmor;
		int num = 0;
		if (theSecondArmor != num)
		{
			int num2 = this.shootCount;
			num2++;
			this.shootCount = num2;
			if (num2 == 4 && num2 != 4)
			{
				int num3 = 0;
				this.shootCount = num3;
				List<ZombieType> list = new List();
				int num4 = list._size;
				int num5 = 0;
				CreateZombie instance = CreateZombie.Instance;
				num4 = global::UnityEngine.Random.Range(num5, num4);
				ZombieType zombieType = list[num4];
				Transform shoot = this.shoot;
				int num6 = list._size;
				int num7 = 0;
				CreateZombie instance2 = CreateZombie.Instance;
				num6 = global::UnityEngine.Random.Range(num7, num6);
				ZombieType zombieType2 = list[num6];
				Transform shoot2 = this.shoot;
				Transform shoot3 = this.shoot;
				Vector3 vector;
				float z = vector.z;
			}
		}
		Animator anim = this.anim;
		this.attributeCountDown = 1.5f;
		anim.SetTrigger("shoot");
	}

	// Token: 0x060021D0 RID: 8656 RVA: 0x000B1C70 File Offset: 0x000AFE70
	[Token(Token = "0x60021D0")]
	[Address(RVA = "0x569980", Offset = "0x567F80", VA = "0x180569980")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		int num = 0;
		if (!(shoot == num))
		{
			Transform shoot2 = this.shoot;
			CreateBullet instance = CreateBullet.Instance;
			Bullet bullet;
			bullet.Damage = 20;
		}
	}

	// Token: 0x060021D1 RID: 8657 RVA: 0x000B1CB4 File Offset: 0x000AFEB4
	[Token(Token = "0x60021D1")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "64")]
	protected override void SecondArmorBroken()
	{
	}

	// Token: 0x060021D2 RID: 8658 RVA: 0x000B1CC4 File Offset: 0x000AFEC4
	[Token(Token = "0x60021D2")]
	[Address(RVA = "0x55BE80", Offset = "0x55A480", VA = "0x18055BE80")]
	public ProtalZombie()
	{
	}

	// Token: 0x0400111F RID: 4383
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x400111F")]
	private int shootCount;
}

using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006F2 RID: 1778
[Token(Token = "0x20006F2")]
public class ProtalZombie : DoorZombie
{
	// Token: 0x060022E6 RID: 8934 RVA: 0x000B67FC File Offset: 0x000B49FC
	[Token(Token = "0x60022E6")]
	[Address(RVA = "0x5CD720", Offset = "0x5CBD20", VA = "0x1805CD720", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(0.5f, 1.5f);
		this.attributeCountDown = num;
	}

	// Token: 0x060022E7 RID: 8935 RVA: 0x000B6828 File Offset: 0x000B4A28
	[Token(Token = "0x60022E7")]
	[Address(RVA = "0x5CD760", Offset = "0x5CBD60", VA = "0x1805CD760", Slot = "62")]
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

	// Token: 0x060022E8 RID: 8936 RVA: 0x000B6874 File Offset: 0x000B4A74
	[Token(Token = "0x60022E8")]
	[Address(RVA = "0x58B110", Offset = "0x589710", VA = "0x18058B110", Slot = "34")]
	protected override void LoseHeadEvent()
	{
	}

	// Token: 0x060022E9 RID: 8937 RVA: 0x000B6884 File Offset: 0x000B4A84
	[Token(Token = "0x60022E9")]
	[Address(RVA = "0x5CD3F0", Offset = "0x5CB9F0", VA = "0x1805CD3F0", Slot = "24")]
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

	// Token: 0x060022EA RID: 8938 RVA: 0x000B6978 File Offset: 0x000B4B78
	[Token(Token = "0x60022EA")]
	[Address(RVA = "0x5CD260", Offset = "0x5CB860", VA = "0x1805CD260")]
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

	// Token: 0x060022EB RID: 8939 RVA: 0x000B69BC File Offset: 0x000B4BBC
	[Token(Token = "0x60022EB")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "66")]
	protected override void SecondArmorBroken()
	{
	}

	// Token: 0x060022EC RID: 8940 RVA: 0x000B69CC File Offset: 0x000B4BCC
	[Token(Token = "0x60022EC")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public ProtalZombie()
	{
	}

	// Token: 0x040011EC RID: 4588
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40011EC")]
	private int shootCount;
}

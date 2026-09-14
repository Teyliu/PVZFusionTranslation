using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004FD RID: 1277
[Token(Token = "0x20004FD")]
public class ChomperScaredy : ScaredyShroom
{
	// Token: 0x06001800 RID: 6144 RVA: 0x00083164 File Offset: 0x00081364
	[Token(Token = "0x6001800")]
	[Address(RVA = "0x51F2D0", Offset = "0x51D8D0", VA = "0x18051F2D0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		GameObject gameObject = this.stomach;
		this.theStatus = (PlantStatus)((ulong)0L);
		int num = 0;
		gameObject.SetActive(num != 0);
		Animator anim = this.anim;
		int num2 = 0;
		anim.SetBool("NearZombie", num2 != 0);
	}

	// Token: 0x06001801 RID: 6145 RVA: 0x000831AC File Offset: 0x000813AC
	[Token(Token = "0x6001801")]
	[Address(RVA = "0x51F350", Offset = "0x51D950", VA = "0x18051F350", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound(57, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001802 RID: 6146 RVA: 0x00083208 File Offset: 0x00081408
	[Token(Token = "0x6001802")]
	[Address(RVA = "0x51EF20", Offset = "0x51D520", VA = "0x18051EF20")]
	private void AnimScared()
	{
		int num = 0;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && !flag2 && Lawnf.InLandStatus((ZombieStatus)num))
			{
				ParticleManager instance = ParticleManager.Instance;
				uint num3;
				if (num3 <= (uint)0)
				{
					goto IL_004E;
				}
			}
			num++;
		}
		IL_004E:
		GameObject gameObject = this.stomach;
		this.attributeCountdown = 40f;
		this.theStatus = (PlantStatus)((ulong)25L);
		ulong num4;
		gameObject.SetActive(num4 != 0UL);
	}

	// Token: 0x06001803 RID: 6147 RVA: 0x00083290 File Offset: 0x00081490
	[Token(Token = "0x6001803")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public ChomperScaredy()
	{
	}

	// Token: 0x04000E62 RID: 3682
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E62")]
	public GameObject stomach;
}

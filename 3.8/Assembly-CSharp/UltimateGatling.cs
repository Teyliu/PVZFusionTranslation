using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005AC RID: 1452
[Token(Token = "0x20005AC")]
public class UltimateGatling : SuperCherryShooter
{
	// Token: 0x06001AFD RID: 6909 RVA: 0x00090C98 File Offset: 0x0008EE98
	[Token(Token = "0x6001AFD")]
	[Address(RVA = "0x481100", Offset = "0x47F700", VA = "0x180481100", Slot = "46")]
	protected override void UpdateAttackCountDown()
	{
		base.UpdateAttackCountDown();
		if (Lawnf.TravelUltimate((UltiBuff)((uint)3)))
		{
			float thePlantAttackCountDown = this.thePlantAttackCountDown;
			float deltaTime = Time.deltaTime;
			this.thePlantAttackCountDown = thePlantAttackCountDown;
		}
	}

	// Token: 0x06001AFE RID: 6910 RVA: 0x00090CCC File Offset: 0x0008EECC
	[Token(Token = "0x6001AFE")]
	[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "57")]
	protected override bool OnStarUp()
	{
		return true;
	}

	// Token: 0x06001AFF RID: 6911 RVA: 0x00090CDC File Offset: 0x0008EEDC
	[Token(Token = "0x6001AFF")]
	[Address(RVA = "0x4FE150", Offset = "0x4FC750", VA = "0x1804FE150")]
	private void CheatShoot()
	{
		UltimateGatling.<Shooting>d__3 <Shooting>d__;
		<Shooting>d__.System.IDisposable.Dispose();
		<Shooting>d__.<>1__state = (int)((ulong)0L);
		<Shooting>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Shooting>d__);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
	}

	// Token: 0x06001B00 RID: 6912 RVA: 0x00090D20 File Offset: 0x0008EF20
	[Token(Token = "0x6001B00")]
	[Address(RVA = "0x4FE7B0", Offset = "0x4FCDB0", VA = "0x1804FE7B0")]
	private IEnumerator Shooting()
	{
		UltimateGatling.<Shooting>d__3 <Shooting>d__;
		<Shooting>d__.System.IDisposable.Dispose();
		<Shooting>d__.<>1__state = (int)((ulong)0L);
		<Shooting>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001B01 RID: 6913 RVA: 0x00090D44 File Offset: 0x0008EF44
	[Token(Token = "0x6001B01")]
	[Address(RVA = "0x4FE220", Offset = "0x4FC820", VA = "0x1804FE220", Slot = "69")]
	protected override Bullet Shoot1()
	{
		UltimateGatling.<Shooting>d__3 <Shooting>d__;
		<Shooting>d__.System.IDisposable.Dispose();
		int num = 0;
		<Shooting>d__.<>4__this = this;
		<Shooting>d__.<>1__state = num;
		Coroutine coroutine = base.StartCoroutine(<Shooting>d__);
		uint num2;
		uint num3;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num2, (int)num3), 0.5f, 1f);
		Bullet bullet = base.Shoot1();
		bool flag;
		if (flag)
		{
			CreateBullet instance = CreateBullet.Instance;
			Transform shoot = this.shoot;
			Transform shoot2 = this.shoot;
			CreateBullet instance2 = CreateBullet.Instance;
			Transform shoot3 = this.shoot;
			Transform shoot4 = this.shoot;
			int attackDamage = this.attackDamage;
			Bullet bullet2;
			bullet2.Damage = attackDamage;
			PlantType thePlantType = this.thePlantType;
			bullet2.fromType = thePlantType;
			int attackDamage2 = this.attackDamage;
			Bullet bullet3;
			bullet3.Damage = attackDamage2;
			bullet3.theExistTime = 0.5f;
			PlantType thePlantType2 = this.thePlantType;
			bullet3.fromType = thePlantType2;
		}
		bool flag2;
		if (!flag2)
		{
			bool flag3;
			if (!flag3)
			{
				goto IL_00E2;
			}
			uint num4;
			bullet.rogueStatus = (int)num4;
		}
		uint num5;
		bullet.rogueStatus = (int)num5;
		IL_00E2:
		Transform transform = bullet.transform;
		Vector3 vector;
		float z = vector.z;
		uint num6 = num5 + 1U;
		Bullet bullet4 = base.Shoot1();
		Transform transform2 = bullet4.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		PlantType thePlantType3 = this.thePlantType;
		bullet4.fromType = thePlantType3;
		Transform transform3 = bullet4.transform;
		Vector3 vector3;
		float z3 = vector3.z;
		num5 += (uint)1;
		PlantType thePlantType4 = this.thePlantType;
		bullet.fromType = thePlantType4;
		return bullet;
	}

	// Token: 0x06001B02 RID: 6914 RVA: 0x00090EAC File Offset: 0x0008F0AC
	[Token(Token = "0x6001B02")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public UltimateGatling()
	{
	}
}

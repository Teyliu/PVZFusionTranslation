using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000531 RID: 1329
[Token(Token = "0x2000531")]
public class LunarCabbage : SolarCabbage
{
	// Token: 0x060018BF RID: 6335 RVA: 0x00086820 File Offset: 0x00084A20
	[Token(Token = "0x60018BF")]
	[Address(RVA = "0x4D5270", Offset = "0x4D3870", VA = "0x1804D5270", Slot = "78")]
	protected override void UniqueEffect(Bullet bullet)
	{
		int num = 0;
		bool flag;
		if (!flag)
		{
			int num2 = this.attackDamage;
			uint num3;
			num2 += (int)num3;
		}
		bullet.Damage = num;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x060018C0 RID: 6336 RVA: 0x00086860 File Offset: 0x00084A60
	[Token(Token = "0x60018C0")]
	[Address(RVA = "0x4D5000", Offset = "0x4D3600", VA = "0x1804D5000", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_lunarCabbage;
	}

	// Token: 0x060018C1 RID: 6337 RVA: 0x00086874 File Offset: 0x00084A74
	[Token(Token = "0x60018C1")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "40")]
	protected override void AttributeEvent()
	{
	}

	// Token: 0x060018C2 RID: 6338 RVA: 0x00086884 File Offset: 0x00084A84
	[Token(Token = "0x60018C2")]
	[Address(RVA = "0x4D5010", Offset = "0x4D3610", VA = "0x1804D5010", Slot = "43")]
	public override bool SuperSkill()
	{
		float flashCountDown = this.flashCountDown;
		int num = 0;
		if (flashCountDown > (float)num)
		{
			throw new NullReferenceException();
		}
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num2 = 0;
		ulong num3;
		base.Recover(z, (DamageType)num2, true, num3 != 0UL);
		GameAPP.PlaySound(66, 0.5f, 1f);
		Animator anim = this.anim;
		this.flashCountDown = 2f;
		anim.SetTrigger("super");
		Lunar instance = Lunar.Instance;
		int num4 = 0;
		if (instance != num4)
		{
			Lunar instance2 = Lunar.Instance;
			float lifeTimer = instance2.lifeTimer;
			instance2.Init();
			Lunar instance3 = Lunar.Instance;
			float lifeTimer2 = instance3.lifeTimer;
			instance3.lifeTimer = lifeTimer2;
			return true;
		}
		LunarCabbage.CreateLunar(this.board);
		GameAPP.PlaySound(95, 0.5f, 1f);
		return true;
	}

	// Token: 0x060018C3 RID: 6339 RVA: 0x00086960 File Offset: 0x00084B60
	[Token(Token = "0x60018C3")]
	[Address(RVA = "0x4D4E10", Offset = "0x4D3410", VA = "0x1804D4E10")]
	public static void CreateLunar(Board board)
	{
		int plantCount = Lawnf.GetPlantCount((PlantType)((uint)302), board);
		GameObject[] itemPrefab = GameAPP.itemPrefab;
		GameObject gameObject = GameAPP.itemPrefab[55];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = board.transform;
		GameObject gameObject2;
		gameObject2.GetComponent<Lunar>().Init();
	}

	// Token: 0x060018C4 RID: 6340 RVA: 0x000869B4 File Offset: 0x00084BB4
	[Token(Token = "0x60018C4")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public LunarCabbage()
	{
	}
}

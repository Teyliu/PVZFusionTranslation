using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200055E RID: 1374
[Token(Token = "0x200055E")]
public class LunarCabbage : SolarCabbage
{
	// Token: 0x0600198F RID: 6543 RVA: 0x0008A4E4 File Offset: 0x000886E4
	[Token(Token = "0x600198F")]
	[Address(RVA = "0x535B50", Offset = "0x534150", VA = "0x180535B50", Slot = "77")]
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

	// Token: 0x06001990 RID: 6544 RVA: 0x0008A524 File Offset: 0x00088724
	[Token(Token = "0x6001990")]
	[Address(RVA = "0x5358E0", Offset = "0x533EE0", VA = "0x1805358E0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_lunarCabbage;
	}

	// Token: 0x06001991 RID: 6545 RVA: 0x0008A538 File Offset: 0x00088738
	[Token(Token = "0x6001991")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "39")]
	protected override void AttributeEvent()
	{
	}

	// Token: 0x06001992 RID: 6546 RVA: 0x0008A548 File Offset: 0x00088748
	[Token(Token = "0x6001992")]
	[Address(RVA = "0x5358F0", Offset = "0x533EF0", VA = "0x1805358F0", Slot = "42")]
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

	// Token: 0x06001993 RID: 6547 RVA: 0x0008A624 File Offset: 0x00088824
	[Token(Token = "0x6001993")]
	[Address(RVA = "0x5356F0", Offset = "0x533CF0", VA = "0x1805356F0")]
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

	// Token: 0x06001994 RID: 6548 RVA: 0x0008A678 File Offset: 0x00088878
	[Token(Token = "0x6001994")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public LunarCabbage()
	{
	}
}

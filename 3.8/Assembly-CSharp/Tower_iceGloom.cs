using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005D7 RID: 1495
[Token(Token = "0x20005D7")]
public class Tower_iceGloom : TowerPlant
{
	// Token: 0x06001C11 RID: 7185 RVA: 0x00095EB4 File Offset: 0x000940B4
	[Token(Token = "0x6001C11")]
	[Address(RVA = "0x510D30", Offset = "0x50F330", VA = "0x180510D30", Slot = "75")]
	public override string GetUniqueText()
	{
		float num = this.slowTimer;
		return string.Format("减速时长：{0:F0}秒", "减速时长：{0:F0}秒");
	}

	// Token: 0x06001C12 RID: 7186 RVA: 0x00095ED8 File Offset: 0x000940D8
	[Token(Token = "0x6001C12")]
	[Address(RVA = "0x510F00", Offset = "0x50F500", VA = "0x180510F00", Slot = "74")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float num = this.slowTimer;
		this.slowTimer = num;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001C13 RID: 7187 RVA: 0x00095F1C File Offset: 0x0009411C
	[Token(Token = "0x6001C13")]
	[Address(RVA = "0x510AB0", Offset = "0x50F0B0", VA = "0x180510AB0")]
	private void AttackZombie()
	{
		Transform shoot = this.shoot;
		int num = 0;
		int num2 = 0;
		int num3 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && base.SearchUniqueZombie(num))
			{
				PlantType thePlantType = this.thePlantType;
				if (this.freezeLevel > 0)
				{
					int num4 = this.freezeLevel;
				}
			}
			num++;
		}
		if (num2 != 0)
		{
			uint num5;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num5), 0.5f, 1f);
		}
	}

	// Token: 0x06001C14 RID: 7188 RVA: 0x00095F9C File Offset: 0x0009419C
	[Token(Token = "0x6001C14")]
	[Address(RVA = "0x510A40", Offset = "0x50F040", VA = "0x180510A40", Slot = "72")]
	public override void AnimShoot()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		this.AttackZombie();
	}

	// Token: 0x06001C15 RID: 7189 RVA: 0x00095FC4 File Offset: 0x000941C4
	[Token(Token = "0x6001C15")]
	[Address(RVA = "0x510DA0", Offset = "0x50F3A0", VA = "0x180510DA0", Slot = "44")]
	protected override GameObject SearchZombie()
	{
		Transform shoot = this.shoot;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (!flag || !base.SearchUniqueZombie(num))
			{
				num++;
			}
			GameObject gameObject;
			return gameObject;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001C16 RID: 7190 RVA: 0x00096010 File Offset: 0x00094210
	[Token(Token = "0x6001C16")]
	[Address(RVA = "0x510F60", Offset = "0x50F560", VA = "0x180510F60")]
	public Tower_iceGloom()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}

	// Token: 0x04000F04 RID: 3844
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F04")]
	private float slowTimer = 1f;

	// Token: 0x04000F05 RID: 3845
	[FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4000F05")]
	private int freezeLevel;
}

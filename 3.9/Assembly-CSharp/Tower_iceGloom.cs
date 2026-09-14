using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200060C RID: 1548
[Token(Token = "0x200060C")]
public class Tower_iceGloom : TowerPlant
{
	// Token: 0x06001D10 RID: 7440 RVA: 0x0009AADC File Offset: 0x00098CDC
	[Token(Token = "0x6001D10")]
	[Address(RVA = "0x5786E0", Offset = "0x576CE0", VA = "0x1805786E0", Slot = "74")]
	public override string GetUniqueText()
	{
		float num = this.slowTimer;
		return string.Format("减速时长：{0:F0}秒", num);
	}

	// Token: 0x06001D11 RID: 7441 RVA: 0x0009AB00 File Offset: 0x00098D00
	[Token(Token = "0x6001D11")]
	[Address(RVA = "0x5788B0", Offset = "0x576EB0", VA = "0x1805788B0", Slot = "73")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float num = this.slowTimer;
		this.slowTimer = num;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001D12 RID: 7442 RVA: 0x0009AB44 File Offset: 0x00098D44
	[Token(Token = "0x6001D12")]
	[Address(RVA = "0x578460", Offset = "0x576A60", VA = "0x180578460")]
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
				int damage = base.Damage;
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

	// Token: 0x06001D13 RID: 7443 RVA: 0x0009ABCC File Offset: 0x00098DCC
	[Token(Token = "0x6001D13")]
	[Address(RVA = "0x5783F0", Offset = "0x5769F0", VA = "0x1805783F0", Slot = "71")]
	public override void AnimShoot()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		this.AttackZombie();
	}

	// Token: 0x06001D14 RID: 7444 RVA: 0x0009ABF4 File Offset: 0x00098DF4
	[Token(Token = "0x6001D14")]
	[Address(RVA = "0x578750", Offset = "0x576D50", VA = "0x180578750", Slot = "43")]
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

	// Token: 0x06001D15 RID: 7445 RVA: 0x0009AC40 File Offset: 0x00098E40
	[Token(Token = "0x6001D15")]
	[Address(RVA = "0x578910", Offset = "0x576F10", VA = "0x180578910")]
	public Tower_iceGloom()
	{
	}

	// Token: 0x04000FCC RID: 4044
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000FCC")]
	private float slowTimer = 1f;

	// Token: 0x04000FCD RID: 4045
	[FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4000FCD")]
	private int freezeLevel;
}

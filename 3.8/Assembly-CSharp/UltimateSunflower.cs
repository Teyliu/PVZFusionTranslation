using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005C4 RID: 1476
[Token(Token = "0x20005C4")]
public class UltimateSunflower : Producer
{
	// Token: 0x06001B84 RID: 7044 RVA: 0x00093650 File Offset: 0x00091850
	[Token(Token = "0x6001B84")]
	[Address(RVA = "0x518490", Offset = "0x516A90", VA = "0x180518490", Slot = "43")]
	public override bool SuperSkill()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		ulong num2;
		base.Recover(z, (DamageType)num, true, num2 != 0UL);
		GameAPP.PlaySound(66, 0.5f, 1f);
		bool activeSelf = this.blink.activeSelf;
		GameObject gameObject = this.blink;
		if (activeSelf)
		{
			int num3 = 0;
			gameObject.SetActive(num3 != 0);
			int attackDamage = this.attackDamage;
			int attributeCount = this.attributeCount;
			this.Shoot(attributeCount);
			this.attributeCount = (int)((ulong)0L);
			base.UpdateText();
			return true;
		}
		gameObject.SetActive(true);
		return true;
	}

	// Token: 0x06001B85 RID: 7045 RVA: 0x000936EC File Offset: 0x000918EC
	[Token(Token = "0x6001B85")]
	[Address(RVA = "0x517DE0", Offset = "0x5163E0", VA = "0x180517DE0", Slot = "70")]
	protected override void ProduceSun()
	{
		Transform shoot = this.shoot;
		int num = 0;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		int num3 = 0;
		CreateItem instance = CreateItem.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		uint num4;
		GameObject gameObject = instance.SetCoin(thePlantColumn, thePlantRow, (int)num4, num, num3, num3 != 0);
		Transform shoot2 = this.shoot;
		LayerMask bulletLayer = this.bulletLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				Team <Team>k__BackingField = this.<Team>k__BackingField;
				CreateItem instance2 = CreateItem.Instance;
				Vector3 vector;
				float z = vector.z;
				GameObject gameObject2;
				CoinSun component = gameObject2.GetComponent<CoinSun>();
				component.theMoveType = (int)((ulong)2L);
				component.followValue = gameObject2;
				Transform shoot3 = this.shoot;
				component.target = shoot3;
				Action<int> action;
				component.action = action;
			}
			num++;
		}
	}

	// Token: 0x06001B86 RID: 7046 RVA: 0x000937C0 File Offset: 0x000919C0
	[Token(Token = "0x6001B86")]
	[Address(RVA = "0x5183A0", Offset = "0x5169A0", VA = "0x1805183A0")]
	private void SunAction(int value)
	{
		bool activeSelf = this.blink.activeSelf;
		if (activeSelf)
		{
			this.attributeCount = (activeSelf ? 1 : 0);
		}
		this.attributeCount = (activeSelf ? 1 : 0);
		int attackDamage = this.attackDamage;
		this.attributeCount = (activeSelf ? 1 : 0);
		this.Shoot(attackDamage);
		int attackDamage2 = this.attackDamage;
		bool flag;
		if (flag)
		{
		}
		Board board = this.board;
		this.attributeCount = attackDamage2;
		ulong num;
		board.GetSun(flag, num != 0UL);
		throw new NullReferenceException();
	}

	// Token: 0x06001B87 RID: 7047 RVA: 0x0009382C File Offset: 0x00091A2C
	[Token(Token = "0x6001B87")]
	[Address(RVA = "0x518260", Offset = "0x516860", VA = "0x180518260")]
	private void Shoot(int damage)
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		float num = global::UnityEngine.Random.Range(-0.5f, 0.5f);
		float num2 = global::UnityEngine.Random.Range(-0.5f, 0.5f);
		Bullet bullet;
		bullet.Damage = damage;
		if (Lawnf.TravelUltimate((UltiBuff)((uint)38)))
		{
			bullet.theStatus = (BulletStatus)((ulong)9L);
		}
	}

	// Token: 0x06001B88 RID: 7048 RVA: 0x00093890 File Offset: 0x00091A90
	[Token(Token = "0x6001B88")]
	[Address(RVA = "0x517D10", Offset = "0x516310", VA = "0x180517D10", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001B89 RID: 7049 RVA: 0x000938B0 File Offset: 0x00091AB0
	[Token(Token = "0x6001B89")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public UltimateSunflower()
	{
	}

	// Token: 0x04000EE1 RID: 3809
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000EE1")]
	public GameObject blink;
}

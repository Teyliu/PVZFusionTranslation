using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005F6 RID: 1526
[Token(Token = "0x20005F6")]
public class UltimateSunflower : Producer
{
	// Token: 0x06001C77 RID: 7287 RVA: 0x00097EE4 File Offset: 0x000960E4
	[Token(Token = "0x6001C77")]
	[Address(RVA = "0x56D970", Offset = "0x56BF70", VA = "0x18056D970", Slot = "42")]
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

	// Token: 0x06001C78 RID: 7288 RVA: 0x00097F80 File Offset: 0x00096180
	[Token(Token = "0x6001C78")]
	[Address(RVA = "0x56D2C0", Offset = "0x56B8C0", VA = "0x18056D2C0", Slot = "69")]
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

	// Token: 0x06001C79 RID: 7289 RVA: 0x00098054 File Offset: 0x00096254
	[Token(Token = "0x6001C79")]
	[Address(RVA = "0x56D880", Offset = "0x56BE80", VA = "0x18056D880")]
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

	// Token: 0x06001C7A RID: 7290 RVA: 0x000980C0 File Offset: 0x000962C0
	[Token(Token = "0x6001C7A")]
	[Address(RVA = "0x56D740", Offset = "0x56BD40", VA = "0x18056D740")]
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

	// Token: 0x06001C7B RID: 7291 RVA: 0x00098124 File Offset: 0x00096324
	[Token(Token = "0x6001C7B")]
	[Address(RVA = "0x56D1F0", Offset = "0x56B7F0", VA = "0x18056D1F0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001C7C RID: 7292 RVA: 0x00098144 File Offset: 0x00096344
	[Token(Token = "0x6001C7C")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public UltimateSunflower()
	{
	}

	// Token: 0x04000FA0 RID: 4000
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000FA0")]
	public GameObject blink;
}

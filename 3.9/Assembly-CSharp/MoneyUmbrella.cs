using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000404 RID: 1028
[Token(Token = "0x2000404")]
public class MoneyUmbrella : CornUmbrella
{
	// Token: 0x060012F1 RID: 4849 RVA: 0x0006A20C File Offset: 0x0006840C
	[Token(Token = "0x60012F1")]
	[Address(RVA = "0x4AB340", Offset = "0x4A9940", VA = "0x1804AB340", Slot = "68")]
	public override void Block(Bullet bullet)
	{
		base.Block(bullet);
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
		GameAPP.PlaySound(97, 0.5f, 1f);
	}

	// Token: 0x060012F2 RID: 4850 RVA: 0x0006A250 File Offset: 0x00068450
	[Token(Token = "0x60012F2")]
	[Address(RVA = "0x4AB250", Offset = "0x4A9850", VA = "0x1804AB250", Slot = "70")]
	protected override void BlockEffect(Zombie zombie)
	{
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(40, this, (DamageType)((uint)4), thePlantType, num != 0UL);
		Plant umbrellaPot = base.UmbrellaPot;
		int num2 = 0;
		if (!(umbrellaPot == num2))
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060012F3 RID: 4851 RVA: 0x0006A28C File Offset: 0x0006848C
	[Token(Token = "0x60012F3")]
	[Address(RVA = "0x4AB620", Offset = "0x4A9C20", VA = "0x1804AB620", Slot = "42")]
	public override bool SuperSkill()
	{
		float flashCountDown = this.flashCountDown;
		int num = 0;
		if (flashCountDown <= (float)num)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num2 = 0;
			ulong num3;
			base.Recover(z, (DamageType)num2, true, num3 != 0UL);
			GameAPP.PlaySound(66, 0.5f, 1f);
			this.anim.SetTrigger("super");
			Board board = this.board;
			this.flashCountDown = 7.5f;
			return true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060012F4 RID: 4852 RVA: 0x0006A320 File Offset: 0x00068520
	[Token(Token = "0x60012F4")]
	[Address(RVA = "0x4AAC50", Offset = "0x4A9250", VA = "0x1804AAC50", Slot = "41")]
	protected override void AnimSuperShoot()
	{
		uint num;
		GameAPP.PlaySound((int)num, 0.5f, 1f);
		Transform axis = this.axis;
		int num2 = 0;
		int num3 = 0;
		LayerMask zombieLayer = this.zombieLayer;
		int num4 = zombieLayer;
		int num5 = 0;
		int num6 = 0;
		Collider2D[] array;
		if (num5 < array.Length)
		{
			bool flag;
			if (flag)
			{
				int num7 = 0;
				if ((num7 <= 10 || (num7 != 12 && 18446744073709551595UL > (ulong)3L)) && num7 != 7 && num7 != 10 && 18446744073709551575UL > (ulong)1L && num7 != 65)
				{
					if (num7 == 32 || num7 == 34 || num7 == 209)
					{
						int num8 = 0;
						PogoZombie pogoZombie;
						pogoZombie.LoseJumper(num8);
					}
					bool flag2;
					if ((!flag2 && base.PotType != PlantType.UmbrellaPot) || base.PotType != PlantType.UmbrellaPot)
					{
					}
					PlantType thePlantType = this.thePlantType;
					num6++;
					num3++;
					Blow blow = num6.AddComponent<Blow>();
					num3++;
				}
			}
			num6++;
		}
		if (num2 != 0)
		{
			CreateItem instance = CreateItem.Instance;
			CreateItem instance2 = CreateItem.Instance;
			CreateItem instance3 = CreateItem.Instance;
		}
		int num9 = 0;
		if (num3 != 0 && num3 > 0)
		{
			int num10 = 0;
			CreateItem instance4 = CreateItem.Instance;
			int thePlantRow = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			uint num11;
			GameObject gameObject = instance4.SetCoin(thePlantColumn, thePlantRow, (int)num11, num9, num10, num10 != 0);
			num9++;
		}
	}

	// Token: 0x060012F5 RID: 4853 RVA: 0x0006A484 File Offset: 0x00068684
	[Token(Token = "0x60012F5")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	protected virtual void ConvertZombie(Zombie zombie, float goldRatio, float silverRatio)
	{
	}

	// Token: 0x060012F6 RID: 4854 RVA: 0x0006A494 File Offset: 0x00068694
	[Token(Token = "0x60012F6")]
	[Address(RVA = "0x4AB4E0", Offset = "0x4A9AE0", VA = "0x1804AB4E0", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		Money instance = Money.Instance;
		int num = 0;
		if (!(instance != num))
		{
			InGameUI instance2 = InGameUI.Instance;
			int num2 = 0;
			if (instance2 != num2)
			{
				InGameUI.Instance.MoneyBank.SetActive(true);
			}
			return;
		}
		Money.Instance.EnableMoneyBank();
	}

	// Token: 0x060012F7 RID: 4855 RVA: 0x0006A4E8 File Offset: 0x000686E8
	[Token(Token = "0x60012F7")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public MoneyUmbrella()
	{
	}
}

using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020003EA RID: 1002
[Token(Token = "0x20003EA")]
public class MoneyUmbrella : CornUmbrella
{
	// Token: 0x0600127E RID: 4734 RVA: 0x00068468 File Offset: 0x00066668
	[Token(Token = "0x600127E")]
	[Address(RVA = "0x455EC0", Offset = "0x4544C0", VA = "0x180455EC0", Slot = "69")]
	public override void Block(Bullet bullet)
	{
		base.Block(bullet);
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
		GameAPP.PlaySound(97, 0.5f, 1f);
	}

	// Token: 0x0600127F RID: 4735 RVA: 0x000684AC File Offset: 0x000666AC
	[Token(Token = "0x600127F")]
	[Address(RVA = "0x455DD0", Offset = "0x4543D0", VA = "0x180455DD0", Slot = "70")]
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

	// Token: 0x06001280 RID: 4736 RVA: 0x000684E8 File Offset: 0x000666E8
	[Token(Token = "0x6001280")]
	[Address(RVA = "0x4561A0", Offset = "0x4547A0", VA = "0x1804561A0", Slot = "43")]
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

	// Token: 0x06001281 RID: 4737 RVA: 0x0006857C File Offset: 0x0006677C
	[Token(Token = "0x6001281")]
	[Address(RVA = "0x4557D0", Offset = "0x453DD0", VA = "0x1804557D0", Slot = "42")]
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
					base.BlockZombies();
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

	// Token: 0x06001282 RID: 4738 RVA: 0x000686E8 File Offset: 0x000668E8
	[Token(Token = "0x6001282")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "72")]
	protected virtual void ConvertZombie(Zombie zombie, float goldRatio, float silverRatio)
	{
	}

	// Token: 0x06001283 RID: 4739 RVA: 0x000686F8 File Offset: 0x000668F8
	[Token(Token = "0x6001283")]
	[Address(RVA = "0x456060", Offset = "0x454660", VA = "0x180456060", Slot = "55")]
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

	// Token: 0x06001284 RID: 4740 RVA: 0x0006874C File Offset: 0x0006694C
	[Token(Token = "0x6001284")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public MoneyUmbrella()
	{
	}
}

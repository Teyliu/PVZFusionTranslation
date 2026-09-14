using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200055F RID: 1375
[Token(Token = "0x200055F")]
public class SolarCabbage : Thrower
{
	// Token: 0x0600198F RID: 6543 RVA: 0x00089F34 File Offset: 0x00088134
	[Token(Token = "0x600198F")]
	[Address(RVA = "0x4E3010", Offset = "0x4E1610", VA = "0x1804E3010", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.flightTime = 1f;
		SortingGroup component = base.transform.Find("back").GetComponent<SortingGroup>();
		this.back = component;
		base.AttributeCountdown = 10f;
	}

	// Token: 0x06001990 RID: 6544 RVA: 0x00089F80 File Offset: 0x00088180
	[Token(Token = "0x6001990")]
	[Address(RVA = "0x4E2E50", Offset = "0x4E1450", VA = "0x1804E2E50", Slot = "40")]
	protected override void AttributeEvent()
	{
		Board board = this.board;
		if (this.attributeCount + 1 > 0)
		{
			Board board2 = this.board;
			GameObject gameObject = this.solarBombPrefab;
			Transform transform = board2.transform;
			SolarBomb component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<SolarBomb>();
			int attackDamage = this.attackDamage;
			component.dmg = attackDamage;
			int attributeCount = this.attributeCount;
			component.count = attributeCount;
		}
		base.AttributeCountdown = 3f;
		Solar instance = Solar.Instance;
		int num = 0;
		if (instance != num)
		{
			Solar.Instance.SetDamage();
		}
	}

	// Token: 0x06001991 RID: 6545 RVA: 0x0008A018 File Offset: 0x00088218
	[Token(Token = "0x6001991")]
	[Address(RVA = "0x4E33D0", Offset = "0x4E19D0", VA = "0x1804E33D0", Slot = "78")]
	protected override void UniqueEffect(Bullet bullet)
	{
		bool flag;
		if (flag)
		{
			Board board = this.board;
			if (board.theSun > 15000)
			{
				int theSun = board.theSun;
				ulong num;
				num += num;
				bullet._damage = theSun;
				this.board.UseSun((float)num);
			}
		}
		Board board2 = this.board;
		int num2 = bullet._damage;
		num2 += num2;
		bullet.Damage = num2;
	}

	// Token: 0x06001992 RID: 6546 RVA: 0x0008A088 File Offset: 0x00088288
	[Token(Token = "0x6001992")]
	[Address(RVA = "0x4E30C0", Offset = "0x4E16C0", VA = "0x1804E30C0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_sunCabbage;
	}

	// Token: 0x06001993 RID: 6547 RVA: 0x0008A098 File Offset: 0x00088298
	[Token(Token = "0x6001993")]
	[Address(RVA = "0x4E3170", Offset = "0x4E1770", VA = "0x1804E3170", Slot = "43")]
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
		this.flashCountDown = 2f;
		Solar instance = Solar.Instance;
		int num4 = 0;
		if (instance != num4)
		{
			float deathTime = Solar.Instance.deathTime;
			this.anim.SetTrigger("super");
			Solar.Instance.SetDamage();
			return true;
		}
		Board board = this.board;
		float solarCountDown = board.solarCountDown;
		board.solarCountDown = solarCountDown;
		return true;
	}

	// Token: 0x06001994 RID: 6548 RVA: 0x0008A154 File Offset: 0x00088354
	[Token(Token = "0x6001994")]
	[Address(RVA = "0x4E30D0", Offset = "0x4E16D0", VA = "0x1804E30D0", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
	}

	// Token: 0x06001995 RID: 6549 RVA: 0x0008A164 File Offset: 0x00088364
	[Token(Token = "0x6001995")]
	[Address(RVA = "0x4E3100", Offset = "0x4E1700", VA = "0x1804E3100", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x06001996 RID: 6550 RVA: 0x0008A174 File Offset: 0x00088374
	[Token(Token = "0x6001996")]
	[Address(RVA = "0x4E3390", Offset = "0x4E1990", VA = "0x1804E3390")]
	private void SuperStart()
	{
		this.theStatus = (PlantStatus)((ulong)14L);
		this.back.sortingOrder = 30;
	}

	// Token: 0x06001997 RID: 6551 RVA: 0x0008A1A0 File Offset: 0x000883A0
	[Token(Token = "0x6001997")]
	[Address(RVA = "0x4E3130", Offset = "0x4E1730", VA = "0x1804E3130")]
	private void SuperEnd()
	{
		this.theStatus = (PlantStatus)((ulong)0L);
		this.back.sortingOrder = 1;
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x0008A1C8 File Offset: 0x000883C8
	[Token(Token = "0x6001998")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public SolarCabbage()
	{
	}

	// Token: 0x04000E46 RID: 3654
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E46")]
	private SortingGroup back;

	// Token: 0x04000E47 RID: 3655
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000E47")]
	public GameObject solarBombPrefab;
}

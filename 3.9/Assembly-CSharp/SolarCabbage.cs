using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200058F RID: 1423
[Token(Token = "0x200058F")]
public class SolarCabbage : Thrower
{
	// Token: 0x06001A6F RID: 6767 RVA: 0x0008DFBC File Offset: 0x0008C1BC
	[Token(Token = "0x6001A6F")]
	[Address(RVA = "0x541480", Offset = "0x53FA80", VA = "0x180541480", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.flightTime = 1f;
		SortingGroup component = base.transform.Find("back").GetComponent<SortingGroup>();
		this.back = component;
		base.AttributeCountdown = 10f;
	}

	// Token: 0x06001A70 RID: 6768 RVA: 0x0008E008 File Offset: 0x0008C208
	[Token(Token = "0x6001A70")]
	[Address(RVA = "0x5412C0", Offset = "0x53F8C0", VA = "0x1805412C0", Slot = "39")]
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

	// Token: 0x06001A71 RID: 6769 RVA: 0x0008E0A0 File Offset: 0x0008C2A0
	[Token(Token = "0x6001A71")]
	[Address(RVA = "0x541840", Offset = "0x53FE40", VA = "0x180541840", Slot = "77")]
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

	// Token: 0x06001A72 RID: 6770 RVA: 0x0008E110 File Offset: 0x0008C310
	[Token(Token = "0x6001A72")]
	[Address(RVA = "0x541530", Offset = "0x53FB30", VA = "0x180541530", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_sunCabbage;
	}

	// Token: 0x06001A73 RID: 6771 RVA: 0x0008E120 File Offset: 0x0008C320
	[Token(Token = "0x6001A73")]
	[Address(RVA = "0x5415E0", Offset = "0x53FBE0", VA = "0x1805415E0", Slot = "42")]
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

	// Token: 0x06001A74 RID: 6772 RVA: 0x0008E1DC File Offset: 0x0008C3DC
	[Token(Token = "0x6001A74")]
	[Address(RVA = "0x541540", Offset = "0x53FB40", VA = "0x180541540", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
	}

	// Token: 0x06001A75 RID: 6773 RVA: 0x0008E1EC File Offset: 0x0008C3EC
	[Token(Token = "0x6001A75")]
	[Address(RVA = "0x541570", Offset = "0x53FB70", VA = "0x180541570", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x06001A76 RID: 6774 RVA: 0x0008E1FC File Offset: 0x0008C3FC
	[Token(Token = "0x6001A76")]
	[Address(RVA = "0x541800", Offset = "0x53FE00", VA = "0x180541800")]
	private void SuperStart()
	{
		this.theStatus = (PlantStatus)((ulong)14L);
		this.back.sortingOrder = 30;
	}

	// Token: 0x06001A77 RID: 6775 RVA: 0x0008E228 File Offset: 0x0008C428
	[Token(Token = "0x6001A77")]
	[Address(RVA = "0x5415A0", Offset = "0x53FBA0", VA = "0x1805415A0")]
	private void SuperEnd()
	{
		this.theStatus = (PlantStatus)((ulong)0L);
		this.back.sortingOrder = 1;
	}

	// Token: 0x06001A78 RID: 6776 RVA: 0x0008E250 File Offset: 0x0008C450
	[Token(Token = "0x6001A78")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public SolarCabbage()
	{
	}

	// Token: 0x04000F04 RID: 3844
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F04")]
	private SortingGroup back;

	// Token: 0x04000F05 RID: 3845
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000F05")]
	public GameObject solarBombPrefab;
}

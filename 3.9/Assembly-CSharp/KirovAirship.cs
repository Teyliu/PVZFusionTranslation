using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006CA RID: 1738
[Token(Token = "0x20006CA")]
public class KirovAirship : Zombie, IAirCrashable
{
	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x06002197 RID: 8599 RVA: 0x000B0E78 File Offset: 0x000AF078
	[Token(Token = "0x170001A4")]
	public virtual float CrashNeedCount
	{
		[Token(Token = "0x6002197")]
		[Address(RVA = "0x5BCDC0", Offset = "0x5BB3C0", VA = "0x1805BCDC0", Slot = "80")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x06002198 RID: 8600 RVA: 0x000B0E8C File Offset: 0x000AF08C
	// (set) Token: 0x06002199 RID: 8601 RVA: 0x000B0EA0 File Offset: 0x000AF0A0
	[Token(Token = "0x170001A5")]
	public float CurrentCount
	{
		[Token(Token = "0x6002198")]
		[Address(RVA = "0x5BCDD0", Offset = "0x5BB3D0", VA = "0x1805BCDD0", Slot = "77")]
		get;
		[Token(Token = "0x6002199")]
		[Address(RVA = "0x5BCDE0", Offset = "0x5BB3E0", VA = "0x1805BCDE0", Slot = "78")]
		set;
	}

	// Token: 0x0600219A RID: 8602 RVA: 0x000B0EB4 File Offset: 0x000AF0B4
	[Token(Token = "0x600219A")]
	[Address(RVA = "0x5BC960", Offset = "0x5BAF60", VA = "0x1805BC960", Slot = "79")]
	public void OnCrash(float value)
	{
		this.<CurrentCount>k__BackingField = value;
		float crashNeedCount = this.CrashNeedCount;
		this.anim.SetTrigger("crash");
		global::UnityEngine.Object.Destroy(this.col);
		GameAPP.PlaySound(83, 1f, 1f);
		this.beforeDying = true;
	}

	// Token: 0x0600219B RID: 8603 RVA: 0x000B0F08 File Offset: 0x000AF108
	[Token(Token = "0x600219B")]
	[Address(RVA = "0x5BBD10", Offset = "0x5BA310", VA = "0x1805BBD10", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)10L);
	}

	// Token: 0x0600219C RID: 8604 RVA: 0x000B0F28 File Offset: 0x000AF128
	[Token(Token = "0x600219C")]
	[Address(RVA = "0x5BCCD0", Offset = "0x5BB2D0", VA = "0x1805BCCD0", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
		base.SetMindControl(controlLevel);
		this.towards = (Towards)((ulong)1L);
	}

	// Token: 0x0600219D RID: 8605 RVA: 0x000B0F48 File Offset: 0x000AF148
	[Token(Token = "0x600219D")]
	[Address(RVA = "0x5BCCF0", Offset = "0x5BB2F0", VA = "0x1805BCCF0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
	}

	// Token: 0x0600219E RID: 8606 RVA: 0x000B0F5C File Offset: 0x000AF15C
	[Token(Token = "0x600219E")]
	[Address(RVA = "0x5BCA60", Offset = "0x5BB060", VA = "0x1805BCA60", Slot = "81")]
	protected virtual void PlayMachineSound()
	{
		if (!GameAPP.config.ra2Sound)
		{
			GameAPP.PlaySound(76, 1f, 1f);
			return;
		}
		GameAPP.PlaySound(92, 1f, 1f);
	}

	// Token: 0x0600219F RID: 8607 RVA: 0x000B0FA0 File Offset: 0x000AF1A0
	[Token(Token = "0x600219F")]
	[Address(RVA = "0x5BCB10", Offset = "0x5BB110", VA = "0x1805BCB10", Slot = "22")]
	protected override void PositionUpdate()
	{
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)6)))
		{
		}
		Board board = this.board;
		Transform axis = this.axis;
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x060021A0 RID: 8608 RVA: 0x000B0FF0 File Offset: 0x000AF1F0
	[Token(Token = "0x60021A0")]
	[Address(RVA = "0x5BCCA0", Offset = "0x5BB2A0", VA = "0x1805BCCA0", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetCold(time, num, true);
	}

	// Token: 0x060021A1 RID: 8609 RVA: 0x000B1008 File Offset: 0x000AF208
	[Token(Token = "0x60021A1")]
	[Address(RVA = "0x5BBD30", Offset = "0x5BA330", VA = "0x1805BBD30", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		long num = this.theHealth;
		num -= (long)theDamage;
		this.theHealth = num;
		long num2 = this.theMaxHealth;
		num2 += num2;
		int num3 = 0;
		float num4;
		if (num4 > (float)num3)
		{
			Transform transform = base.transform;
			int num5 = 0;
			GameObject gameObject = transform.GetChild(num5).gameObject;
			int num6 = 0;
			gameObject.SetActive(num6 != 0);
			uint num7;
			ulong num8;
			base.transform.GetChild((int)num7).gameObject.SetActive(num8 != 0UL);
			uint num9;
			GameObject gameObject2 = base.transform.GetChild((int)num9).gameObject;
			int num10 = 0;
			gameObject2.SetActive(num10 != 0);
		}
		int num11 = 0;
		float num12;
		if (num12 > (float)num11)
		{
			Transform transform2 = base.transform;
			int num13 = 0;
			GameObject gameObject3 = transform2.GetChild(num13).gameObject;
			int num14 = 0;
			gameObject3.SetActive(num14 != 0);
			uint num15;
			GameObject gameObject4 = base.transform.GetChild((int)num15).gameObject;
			int num16 = 0;
			gameObject4.SetActive(num16 != 0);
			uint num17;
			ulong num18;
			base.transform.GetChild((int)num17).gameObject.SetActive(num18 != 0UL);
			return;
		}
	}

	// Token: 0x060021A2 RID: 8610 RVA: 0x000B1110 File Offset: 0x000AF310
	[Token(Token = "0x60021A2")]
	[Address(RVA = "0x5BC8D0", Offset = "0x5BAED0", VA = "0x1805BC8D0", Slot = "18")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (this.existBomb)
		{
		}
	}

	// Token: 0x060021A3 RID: 8611 RVA: 0x000B112C File Offset: 0x000AF32C
	[Token(Token = "0x60021A3")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060021A4 RID: 8612 RVA: 0x000B113C File Offset: 0x000AF33C
	[Token(Token = "0x60021A4")]
	[Address(RVA = "0x5BBF90", Offset = "0x5BA590", VA = "0x1805BBF90", Slot = "82")]
	protected virtual void BombUpdate()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theZombieRow = this.theZombieRow;
				if ((num <= 10 || (num != 12 && 18446744073709551596UL > (ulong)4L)) && num != 1 && num != 10)
				{
					this.anim.SetTrigger("throw");
					this.existBomb = false;
					GameAPP.PlaySound(theZombieRow, 0.5f, 1f);
				}
			}
			num++;
			LayerMask plantLayer = this.plantLayer;
			Collider2D[] array2;
			if (num < array2.Length)
			{
				bool flag2;
				if (flag2)
				{
					int theZombieRow2 = this.theZombieRow;
					bool flag3;
					if (!flag3)
					{
						this.anim.SetTrigger("throw");
						this.existBomb = false;
						GameAPP.PlaySound(flag3 ? 1 : 0, 0.5f, 1f);
					}
				}
				num++;
			}
		}
	}

	// Token: 0x060021A5 RID: 8613 RVA: 0x000B1218 File Offset: 0x000AF418
	[Token(Token = "0x60021A5")]
	[Address(RVA = "0x5BC400", Offset = "0x5BAA00", VA = "0x1805BC400", Slot = "83")]
	protected virtual void CreateBomb()
	{
		GameObject gameObject = GameAPP.itemPrefab[3];
		Transform transform = base.transform.Find("Bomb").transform;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform2 = this.board.transform;
		GameObject gameObject2;
		KirovBomb kirovBomb = gameObject2.AddComponent<KirovBomb>();
		int theZombieRow = this.theZombieRow;
		kirovBomb.bombRow = theZombieRow;
		SpriteRenderer component = gameObject2.GetComponent<SpriteRenderer>();
		int theZombieRow2 = this.theZombieRow;
		string text = string.Format("bullet{0}", component);
		component.sortingLayerName = text;
		gameObject2.GetComponent<KirovBomb>().fromHypno = true;
	}

	// Token: 0x060021A6 RID: 8614 RVA: 0x000B12B8 File Offset: 0x000AF4B8
	[Token(Token = "0x60021A6")]
	[Address(RVA = "0x5BCC90", Offset = "0x5BB290", VA = "0x1805BCC90")]
	private void ReplaceBomb()
	{
		this.existBomb = true;
	}

	// Token: 0x060021A7 RID: 8615 RVA: 0x000B12CC File Offset: 0x000AF4CC
	[Token(Token = "0x60021A7")]
	[Address(RVA = "0x5BC6B0", Offset = "0x5BACB0", VA = "0x1805BC6B0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[34];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
	}

	// Token: 0x060021A8 RID: 8616 RVA: 0x000B1324 File Offset: 0x000AF524
	[Token(Token = "0x60021A8")]
	[Address(RVA = "0x5BC8B0", Offset = "0x5BAEB0", VA = "0x1805BC8B0", Slot = "28")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x060021A9 RID: 8617 RVA: 0x000B1338 File Offset: 0x000AF538
	[Token(Token = "0x60021A9")]
	[Address(RVA = "0x5BC370", Offset = "0x5BA970", VA = "0x1805BC370")]
	private void CrashEvent()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		throw new NullReferenceException();
	}

	// Token: 0x060021AA RID: 8618 RVA: 0x000B135C File Offset: 0x000AF55C
	[Token(Token = "0x60021AA")]
	[Address(RVA = "0x5BCD70", Offset = "0x5BB370", VA = "0x1805BCD70")]
	public KirovAirship()
	{
	}

	// Token: 0x040011A2 RID: 4514
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011A2")]
	protected bool existBomb = true;
}

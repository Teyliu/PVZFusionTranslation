using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000693 RID: 1683
[Token(Token = "0x2000693")]
public class KirovAirship : Zombie, IAirCrashable
{
	// Token: 0x1700015E RID: 350
	// (get) Token: 0x06002080 RID: 8320 RVA: 0x000AC248 File Offset: 0x000AA448
	[Token(Token = "0x1700015E")]
	public virtual float CrashNeedCount
	{
		[Token(Token = "0x6002080")]
		[Address(RVA = "0x5588F0", Offset = "0x556EF0", VA = "0x1805588F0", Slot = "78")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06002081 RID: 8321 RVA: 0x000AC25C File Offset: 0x000AA45C
	// (set) Token: 0x06002082 RID: 8322 RVA: 0x000AC270 File Offset: 0x000AA470
	[Token(Token = "0x1700015F")]
	public float CurrentCount
	{
		[Token(Token = "0x6002081")]
		[Address(RVA = "0x558900", Offset = "0x556F00", VA = "0x180558900", Slot = "75")]
		get;
		[Token(Token = "0x6002082")]
		[Address(RVA = "0x558910", Offset = "0x556F10", VA = "0x180558910", Slot = "76")]
		set;
	}

	// Token: 0x06002083 RID: 8323 RVA: 0x000AC284 File Offset: 0x000AA484
	[Token(Token = "0x6002083")]
	[Address(RVA = "0x5584A0", Offset = "0x556AA0", VA = "0x1805584A0", Slot = "77")]
	public void OnCrash(float value)
	{
		this.<CurrentCount>k__BackingField = value;
		float crashNeedCount = this.CrashNeedCount;
		this.anim.SetTrigger("crash");
		global::UnityEngine.Object.Destroy(this.col);
		GameAPP.PlaySound(83, 1f, 1f);
	}

	// Token: 0x06002084 RID: 8324 RVA: 0x000AC2D4 File Offset: 0x000AA4D4
	[Token(Token = "0x6002084")]
	[Address(RVA = "0x557870", Offset = "0x555E70", VA = "0x180557870", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)10L);
	}

	// Token: 0x06002085 RID: 8325 RVA: 0x000AC2F4 File Offset: 0x000AA4F4
	[Token(Token = "0x6002085")]
	[Address(RVA = "0x558800", Offset = "0x556E00", VA = "0x180558800", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
		base.SetMindControl(controlLevel);
		this.towards = (Towards)((ulong)1L);
	}

	// Token: 0x06002086 RID: 8326 RVA: 0x000AC314 File Offset: 0x000AA514
	[Token(Token = "0x6002086")]
	[Address(RVA = "0x558820", Offset = "0x556E20", VA = "0x180558820", Slot = "15")]
	protected override void Start()
	{
		base.Start();
	}

	// Token: 0x06002087 RID: 8327 RVA: 0x000AC328 File Offset: 0x000AA528
	[Token(Token = "0x6002087")]
	[Address(RVA = "0x558590", Offset = "0x556B90", VA = "0x180558590", Slot = "79")]
	protected virtual void PlayMachineSound()
	{
		if (!GameAPP.config.ra2Sound)
		{
			GameAPP.PlaySound(76, 1f, 1f);
			return;
		}
		GameAPP.PlaySound(92, 1f, 1f);
	}

	// Token: 0x06002088 RID: 8328 RVA: 0x000AC36C File Offset: 0x000AA56C
	[Token(Token = "0x6002088")]
	[Address(RVA = "0x558640", Offset = "0x556C40", VA = "0x180558640", Slot = "21")]
	protected override void PositionUpdate()
	{
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)6)))
		{
		}
		Board board = this.board;
		Transform axis = this.axis;
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x06002089 RID: 8329 RVA: 0x000AC3BC File Offset: 0x000AA5BC
	[Token(Token = "0x6002089")]
	[Address(RVA = "0x5587D0", Offset = "0x556DD0", VA = "0x1805587D0", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetCold(time, num, true);
	}

	// Token: 0x0600208A RID: 8330 RVA: 0x000AC3D4 File Offset: 0x000AA5D4
	[Token(Token = "0x600208A")]
	[Address(RVA = "0x557890", Offset = "0x555E90", VA = "0x180557890", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		int num = this.theHealth;
		num -= theDamage;
		this.theHealth = num;
		int num2 = this.theMaxHealth;
		num2 += num2;
		Transform transform = base.transform;
		int num3 = 0;
		GameObject gameObject = transform.GetChild(num3).gameObject;
		int num4 = 0;
		gameObject.SetActive(num4 != 0);
		uint num5;
		ulong num6;
		base.transform.GetChild((int)num5).gameObject.SetActive(num6 != 0UL);
		uint num7;
		GameObject gameObject2 = base.transform.GetChild((int)num7).gameObject;
		int num8 = 0;
		gameObject2.SetActive(num8 != 0);
		Transform transform2 = base.transform;
		int num9 = 0;
		GameObject gameObject3 = transform2.GetChild(num9).gameObject;
		int num10 = 0;
		gameObject3.SetActive(num10 != 0);
		uint num11;
		GameObject gameObject4 = base.transform.GetChild((int)num11).gameObject;
		int num12 = 0;
		gameObject4.SetActive(num12 != 0);
		uint num13;
		ulong num14;
		base.transform.GetChild((int)num13).gameObject.SetActive(num14 != 0UL);
	}

	// Token: 0x0600208B RID: 8331 RVA: 0x000AC4C8 File Offset: 0x000AA6C8
	[Token(Token = "0x600208B")]
	[Address(RVA = "0x558410", Offset = "0x556A10", VA = "0x180558410", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (this.existBomb)
		{
		}
	}

	// Token: 0x0600208C RID: 8332 RVA: 0x000AC4E4 File Offset: 0x000AA6E4
	[Token(Token = "0x600208C")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x0600208D RID: 8333 RVA: 0x000AC4F4 File Offset: 0x000AA6F4
	[Token(Token = "0x600208D")]
	[Address(RVA = "0x557AD0", Offset = "0x5560D0", VA = "0x180557AD0", Slot = "80")]
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

	// Token: 0x0600208E RID: 8334 RVA: 0x000AC5D0 File Offset: 0x000AA7D0
	[Token(Token = "0x600208E")]
	[Address(RVA = "0x557F40", Offset = "0x556540", VA = "0x180557F40", Slot = "81")]
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

	// Token: 0x0600208F RID: 8335 RVA: 0x000AC670 File Offset: 0x000AA870
	[Token(Token = "0x600208F")]
	[Address(RVA = "0x5587C0", Offset = "0x556DC0", VA = "0x1805587C0")]
	private void ReplaceBomb()
	{
		this.existBomb = true;
	}

	// Token: 0x06002090 RID: 8336 RVA: 0x000AC684 File Offset: 0x000AA884
	[Token(Token = "0x6002090")]
	[Address(RVA = "0x5581F0", Offset = "0x5567F0", VA = "0x1805581F0", Slot = "28")]
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

	// Token: 0x06002091 RID: 8337 RVA: 0x000AC6DC File Offset: 0x000AA8DC
	[Token(Token = "0x6002091")]
	[Address(RVA = "0x5583F0", Offset = "0x5569F0", VA = "0x1805583F0", Slot = "27")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x06002092 RID: 8338 RVA: 0x000AC6F0 File Offset: 0x000AA8F0
	[Token(Token = "0x6002092")]
	[Address(RVA = "0x557EB0", Offset = "0x5564B0", VA = "0x180557EB0")]
	private void CrashEvent()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		throw new NullReferenceException();
	}

	// Token: 0x06002093 RID: 8339 RVA: 0x000AC714 File Offset: 0x000AA914
	[Token(Token = "0x6002093")]
	[Address(RVA = "0x5588A0", Offset = "0x556EA0", VA = "0x1805588A0")]
	public KirovAirship()
	{
	}

	// Token: 0x040010D5 RID: 4309
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40010D5")]
	protected bool existBomb = true;
}

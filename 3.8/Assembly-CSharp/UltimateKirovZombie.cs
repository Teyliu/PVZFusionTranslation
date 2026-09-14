using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000701 RID: 1793
[Token(Token = "0x2000701")]
public class UltimateKirovZombie : Zombie
{
	// Token: 0x060023C5 RID: 9157 RVA: 0x000BAEB8 File Offset: 0x000B90B8
	[Token(Token = "0x60023C5")]
	[Address(RVA = "0x531BD0", Offset = "0x5301D0", VA = "0x180531BD0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 3f;
	}

	// Token: 0x060023C6 RID: 9158 RVA: 0x000BAED8 File Offset: 0x000B90D8
	[Token(Token = "0x60023C6")]
	[Address(RVA = "0x5824D0", Offset = "0x580AD0", VA = "0x1805824D0", Slot = "15")]
	protected override void Start()
	{
		int num = 0;
		base.Start();
		Board board = this.board;
		Lawnf.SetZombieHealth(this, (float)num);
	}

	// Token: 0x060023C7 RID: 9159 RVA: 0x000BAF04 File Offset: 0x000B9104
	[Token(Token = "0x60023C7")]
	[Address(RVA = "0x589EA0", Offset = "0x5884A0", VA = "0x180589EA0", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("shoot");
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			Zombie zombie = CreateZombie.Instance.SetZombie(num, (ZombieType)((uint)205), 9.9f, num != 0);
			Board board2 = this.board;
			num++;
		}
		this.attributeCountDown = 3f;
	}

	// Token: 0x060023C8 RID: 9160 RVA: 0x000BAF68 File Offset: 0x000B9168
	[Token(Token = "0x60023C8")]
	[Address(RVA = "0x589C00", Offset = "0x588200", VA = "0x180589C00")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		GameObject gameObject = this.weaponPrefab;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		SpiderWeapon component = gameObject2.GetComponent<SpiderWeapon>();
		int theZombieRow = this.theZombieRow;
		component.theRow = theZombieRow;
		bool isMindControlled = this.isMindControlled;
		component.isMindControl = isMindControlled;
		Board board = this.board;
		component.board = board;
		SpriteRenderer component2 = component.GetComponent<SpriteRenderer>();
		int theZombieRow2 = this.theZombieRow;
		string text = string.Format("bullet{0}", component2);
		component2.sortingLayerName = text;
		Rigidbody2D rb = component.rb;
	}

	// Token: 0x060023C9 RID: 9161 RVA: 0x000BB014 File Offset: 0x000B9214
	[Token(Token = "0x60023C9")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060023CA RID: 9162 RVA: 0x000BB024 File Offset: 0x000B9224
	[Token(Token = "0x60023CA")]
	[Address(RVA = "0x58A670", Offset = "0x588C70", VA = "0x18058A670")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x060023CB RID: 9163 RVA: 0x000BB044 File Offset: 0x000B9244
	[Token(Token = "0x60023CB")]
	[Address(RVA = "0x58A620", Offset = "0x588C20", VA = "0x18058A620", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix = false, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
			return 5000;
		}
		return 1;
	}

	// Token: 0x060023CC RID: 9164 RVA: 0x000BB064 File Offset: 0x000B9264
	[Token(Token = "0x60023CC")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060023CD RID: 9165 RVA: 0x000BB074 File Offset: 0x000B9274
	[Token(Token = "0x60023CD")]
	[Address(RVA = "0x589FB0", Offset = "0x5885B0", VA = "0x180589FB0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num11;
		do
		{
			int num = this.theHealth;
			num -= theDamage;
			this.theHealth = num;
			int num2 = this.theMaxHealth;
			num2 += num2;
			num -= theDamage;
			this.anim.SetTrigger("fly");
			this.theStatus = (ZombieStatus)((ulong)25L);
			int num3 = this.theMaxHealth;
			num3 += num3;
			bool flag;
			if (flag)
			{
				List<Transform> changeSprites = this.changeSprites;
				bool flag2;
				if (flag2)
				{
					int num4 = 0;
					SpriteRenderer spriteRenderer;
					spriteRenderer.enabled = num4 != 0;
					Transform transform;
					ulong num5;
					transform.GetComponent<SpriteRenderer>().enabled = num5 != 0UL;
					Transform transform2;
					SpriteRenderer component = transform2.GetComponent<SpriteRenderer>();
					int num6 = 0;
					component.enabled = num6 != 0;
				}
				ulong num7;
				if (num7 != (ulong)0L)
				{
					goto IL_00FF;
				}
			}
			bool flag3;
			if (flag3)
			{
				int num8 = 0;
				SpriteRenderer spriteRenderer2;
				spriteRenderer2.enabled = num8 != 0;
				Transform transform3;
				SpriteRenderer component2 = transform3.GetComponent<SpriteRenderer>();
				int num9 = 0;
				component2.enabled = num9 != 0;
				Transform transform4;
				ulong num10;
				transform4.GetComponent<SpriteRenderer>().enabled = num10 != 0UL;
			}
		}
		while (num11 != (ulong)0L);
		return;
		IL_00FF:
		throw new NullReferenceException();
	}

	// Token: 0x060023CE RID: 9166 RVA: 0x000BB1A4 File Offset: 0x000B93A4
	[Token(Token = "0x60023CE")]
	[Address(RVA = "0x533270", Offset = "0x531870", VA = "0x180533270", Slot = "27")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x060023CF RID: 9167 RVA: 0x000BB1C4 File Offset: 0x000B93C4
	[Token(Token = "0x60023CF")]
	[Address(RVA = "0x58A440", Offset = "0x588A40", VA = "0x18058A440", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		GameObject[] particlePrefab = GameAPP.particlePrefab;
		Transform axis = this.axis;
		GameObject gameObject = particlePrefab[34];
		Transform axis2 = this.axis;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
	}

	// Token: 0x060023D0 RID: 9168 RVA: 0x000BB220 File Offset: 0x000B9420
	[Token(Token = "0x60023D0")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060023D1 RID: 9169 RVA: 0x000BB230 File Offset: 0x000B9430
	[Token(Token = "0x60023D1")]
	[Address(RVA = "0x58A6B0", Offset = "0x588CB0", VA = "0x18058A6B0", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x060023D2 RID: 9170 RVA: 0x000BB24C File Offset: 0x000B944C
	[Token(Token = "0x60023D2")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x060023D3 RID: 9171 RVA: 0x000BB25C File Offset: 0x000B945C
	[Token(Token = "0x60023D3")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060023D4 RID: 9172 RVA: 0x000BB26C File Offset: 0x000B946C
	[Token(Token = "0x60023D4")]
	[Address(RVA = "0x58A6D0", Offset = "0x588CD0", VA = "0x18058A6D0")]
	public UltimateKirovZombie()
	{
	}

	// Token: 0x0400119A RID: 4506
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400119A")]
	public GameObject weaponPrefab;
}

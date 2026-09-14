using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000657 RID: 1623
[Token(Token = "0x2000657")]
public class BalloonZombie : Zombie
{
	// Token: 0x06001EAF RID: 7855 RVA: 0x000A3F48 File Offset: 0x000A2148
	[Token(Token = "0x6001EAF")]
	[Address(RVA = "0x587350", Offset = "0x585950", VA = "0x180587350", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.theStatus = (ZombieStatus)((ulong)10L);
		GameAPP.PlaySound(86, 0.5f, 1f);
	}

	// Token: 0x06001EB0 RID: 7856 RVA: 0x000A3F78 File Offset: 0x000A2178
	[Token(Token = "0x6001EB0")]
	[Address(RVA = "0x5873F0", Offset = "0x5859F0", VA = "0x1805873F0", Slot = "17")]
	protected override void Update()
	{
		base.Update();
		if (Lawnf.EveBalaced())
		{
			Transform axis = this.axis;
			int num = global::UnityEngine.Random.Range(0, 1);
			this.Fall();
		}
		Board board = this.board;
		Transform axis2 = this.axis;
	}

	// Token: 0x06001EB1 RID: 7857 RVA: 0x000A3FC4 File Offset: 0x000A21C4
	[Token(Token = "0x6001EB1")]
	[Address(RVA = "0x587300", Offset = "0x585900", VA = "0x180587300", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x06001EB2 RID: 7858 RVA: 0x000A3FE8 File Offset: 0x000A21E8
	[Token(Token = "0x6001EB2")]
	[Address(RVA = "0x586EF0", Offset = "0x5854F0", VA = "0x180586EF0", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[57];
		component.sprite = sprite;
	}

	// Token: 0x06001EB3 RID: 7859 RVA: 0x000A4018 File Offset: 0x000A2218
	[Token(Token = "0x6001EB3")]
	[Address(RVA = "0x5870B0", Offset = "0x5856B0", VA = "0x1805870B0", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		this.Fall();
		return 0;
	}

	// Token: 0x06001EB4 RID: 7860 RVA: 0x000A4030 File Offset: 0x000A2230
	[Token(Token = "0x6001EB4")]
	[Address(RVA = "0x586FA0", Offset = "0x5855A0", VA = "0x180586FA0", Slot = "76")]
	public virtual void Fall()
	{
		if (!this.fall)
		{
			this.fall = true;
			int num = 0;
			base.ChangeStatus((ZombieStatus)num);
			GameAPP.PlaySound(77, 0.5f, 1f);
			if (base.BoxType != BoxType.Water)
			{
				int num2 = 0;
				this.theFirstArmorHealth = num2;
				this.theFirstArmorType = (Zombie.FirstArmorType)num2;
				this.theFirstArmor = num2;
				this.anim.SetTrigger("fall");
			}
		}
	}

	// Token: 0x06001EB5 RID: 7861 RVA: 0x000A40A0 File Offset: 0x000A22A0
	[Token(Token = "0x6001EB5")]
	[Address(RVA = "0x5870F0", Offset = "0x5856F0", VA = "0x1805870F0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int theZombieRow = this.theZombieRow;
			this.Fall();
		}
	}

	// Token: 0x06001EB6 RID: 7862 RVA: 0x000A40C8 File Offset: 0x000A22C8
	[Token(Token = "0x6001EB6")]
	[Address(RVA = "0x5871A0", Offset = "0x5857A0", VA = "0x1805871A0", Slot = "22")]
	protected override void PositionUpdate()
	{
		base.PositionUpdate();
		Board board = this.board;
		Transform axis = this.axis;
		float deltaTime = Time.deltaTime;
		Transform axis2 = this.axis;
		Vector3 vector;
		if (vector.y > 0.5f)
		{
			this.Fall();
			Transform axis3 = this.axis;
		}
	}

	// Token: 0x06001EB7 RID: 7863 RVA: 0x000A4120 File Offset: 0x000A2320
	[Token(Token = "0x6001EB7")]
	[Address(RVA = "0x5874D0", Offset = "0x585AD0", VA = "0x1805874D0")]
	public BalloonZombie()
	{
	}

	// Token: 0x040010FB RID: 4347
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40010FB")]
	protected bool fall;
}

using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000622 RID: 1570
[Token(Token = "0x2000622")]
public class BalloonZombie : Zombie
{
	// Token: 0x06001DB0 RID: 7600 RVA: 0x0009F944 File Offset: 0x0009DB44
	[Token(Token = "0x6001DB0")]
	[Address(RVA = "0x5307D0", Offset = "0x52EDD0", VA = "0x1805307D0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.theStatus = (ZombieStatus)((ulong)10L);
		GameAPP.PlaySound(86, 0.5f, 1f);
	}

	// Token: 0x06001DB1 RID: 7601 RVA: 0x0009F974 File Offset: 0x0009DB74
	[Token(Token = "0x6001DB1")]
	[Address(RVA = "0x530870", Offset = "0x52EE70", VA = "0x180530870", Slot = "16")]
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

	// Token: 0x06001DB2 RID: 7602 RVA: 0x0009F9C0 File Offset: 0x0009DBC0
	[Token(Token = "0x6001DB2")]
	[Address(RVA = "0x530780", Offset = "0x52ED80", VA = "0x180530780", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x06001DB3 RID: 7603 RVA: 0x0009F9E4 File Offset: 0x0009DBE4
	[Token(Token = "0x6001DB3")]
	[Address(RVA = "0x530370", Offset = "0x52E970", VA = "0x180530370", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[57];
		component.sprite = sprite;
	}

	// Token: 0x06001DB4 RID: 7604 RVA: 0x0009FA14 File Offset: 0x0009DC14
	[Token(Token = "0x6001DB4")]
	[Address(RVA = "0x530530", Offset = "0x52EB30", VA = "0x180530530", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		this.Fall();
		return 0;
	}

	// Token: 0x06001DB5 RID: 7605 RVA: 0x0009FA2C File Offset: 0x0009DC2C
	[Token(Token = "0x6001DB5")]
	[Address(RVA = "0x530420", Offset = "0x52EA20", VA = "0x180530420", Slot = "74")]
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

	// Token: 0x06001DB6 RID: 7606 RVA: 0x0009FA9C File Offset: 0x0009DC9C
	[Token(Token = "0x6001DB6")]
	[Address(RVA = "0x530570", Offset = "0x52EB70", VA = "0x180530570")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int theZombieRow = this.theZombieRow;
			this.Fall();
		}
	}

	// Token: 0x06001DB7 RID: 7607 RVA: 0x0009FAC4 File Offset: 0x0009DCC4
	[Token(Token = "0x6001DB7")]
	[Address(RVA = "0x530620", Offset = "0x52EC20", VA = "0x180530620", Slot = "21")]
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

	// Token: 0x06001DB8 RID: 7608 RVA: 0x0009FB1C File Offset: 0x0009DD1C
	[Token(Token = "0x6001DB8")]
	[Address(RVA = "0x530950", Offset = "0x52EF50", VA = "0x180530950")]
	public BalloonZombie()
	{
	}

	// Token: 0x04001033 RID: 4147
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001033")]
	protected bool fall;
}

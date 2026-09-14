using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005B2 RID: 1458
[Token(Token = "0x20005B2")]
public class UltimateHypno : Shooter
{
	// Token: 0x06001B1B RID: 6939 RVA: 0x000915D0 File Offset: 0x0008F7D0
	[Token(Token = "0x6001B1B")]
	[Address(RVA = "0x4FF550", Offset = "0x4FDB50", VA = "0x1804FF550", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		float attributeFloat = this.attributeFloat;
		Bullet bullet;
		bullet.shootingfloat = attributeFloat;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound(57, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001B1C RID: 6940 RVA: 0x0009162C File Offset: 0x0008F82C
	[Token(Token = "0x6001B1C")]
	[Address(RVA = "0x4FF370", Offset = "0x4FD970", VA = "0x1804FF370", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		GameObject gameObject = base.SearchZombie();
		int num2 = 0;
		bool flag;
		if (!(gameObject != num2))
		{
			Zombie zombie = base.SearchBoss();
			int num3 = 0;
			if (!(zombie != num3))
			{
				flag = base.SearchGoldMagnet();
				if (!flag)
				{
					return;
				}
			}
		}
		PlantStatus theStatus = this.theStatus;
		Animator anim = this.anim;
		if (!flag)
		{
			return;
		}
		if (!flag)
		{
			return;
		}
		if (theStatus == PlantStatus.GoldMagnet_attrack)
		{
			return;
		}
		anim.SetTrigger("shoot");
	}

	// Token: 0x06001B1D RID: 6941 RVA: 0x000916C4 File Offset: 0x0008F8C4
	[Token(Token = "0x6001B1D")]
	[Address(RVA = "0x4FF6B0", Offset = "0x4FDCB0", VA = "0x1804FF6B0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (this.theStatus <= PlantStatus.UltimateHypno_Charge3)
		{
			GameObject gameObject = this.mag1;
			int num = 0;
			gameObject.SetActive(num != 0);
			GameObject gameObject2 = this.mag2;
			int num2 = 0;
			gameObject2.SetActive(num2 != 0);
			GameObject gameObject3 = this.mag3;
			int num3 = 0;
			gameObject3.SetActive(num3 != 0);
		}
		bool flag;
		if (!flag)
		{
			this.thePlantAttackInterval = 2f;
			return;
		}
		this.thePlantAttackInterval = 1f;
		this.theStatus = (PlantStatus)((ulong)5L);
	}

	// Token: 0x06001B1E RID: 6942 RVA: 0x00091784 File Offset: 0x0008F984
	[Token(Token = "0x6001B1E")]
	[Address(RVA = "0x4E0440", Offset = "0x4DEA40", VA = "0x1804E0440", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06001B1F RID: 6943 RVA: 0x000917A0 File Offset: 0x0008F9A0
	[Token(Token = "0x6001B1F")]
	[Address(RVA = "0x4FF820", Offset = "0x4FDE20", VA = "0x1804FF820", Slot = "61")]
	public override bool UseItem(BucketType type, Bucket bucket)
	{
		int num = 0;
		if (bucket != num)
		{
			global::UnityEngine.Object.Destroy(bucket.gameObject);
		}
		PlantStatus theStatus = this.theStatus;
		if (theStatus == PlantStatus.Default)
		{
			this.theStatus = (PlantStatus)((ulong)4L);
		}
		if (theStatus == PlantStatus.UltimateHypno_Charge1)
		{
			this.theStatus = (PlantStatus)((ulong)5L);
		}
		if (theStatus == PlantStatus.UltimateHypno_Charge2 && Lawnf.TravelUltimate((UltiBuff)((uint)19)))
		{
			float attributeCountdown = this.attributeCountdown;
			this.theStatus = (PlantStatus)((ulong)6L);
			base.AttributeCountdown = attributeCountdown;
		}
		float attributeCountdown2 = this.attributeCountdown;
		base.AttributeCountdown = attributeCountdown2;
		return true;
	}

	// Token: 0x06001B20 RID: 6944 RVA: 0x00091820 File Offset: 0x0008FA20
	[Token(Token = "0x6001B20")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public UltimateHypno()
	{
	}

	// Token: 0x04000EBF RID: 3775
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EBF")]
	public GameObject mag1;

	// Token: 0x04000EC0 RID: 3776
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000EC0")]
	public GameObject mag2;

	// Token: 0x04000EC1 RID: 3777
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000EC1")]
	public GameObject mag3;

	// Token: 0x04000EC2 RID: 3778
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000EC2")]
	public CherrySubmarine cherrySubmarine;
}

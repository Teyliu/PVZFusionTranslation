using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005E3 RID: 1507
[Token(Token = "0x20005E3")]
public class UltimateHypno : Shooter
{
	// Token: 0x06001C02 RID: 7170 RVA: 0x000959D0 File Offset: 0x00093BD0
	[Token(Token = "0x6001C02")]
	[Address(RVA = "0x566090", Offset = "0x564690", VA = "0x180566090", Slot = "68")]
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

	// Token: 0x06001C03 RID: 7171 RVA: 0x00095A2C File Offset: 0x00093C2C
	[Token(Token = "0x6001C03")]
	[Address(RVA = "0x565EB0", Offset = "0x5644B0", VA = "0x180565EB0", Slot = "44")]
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

	// Token: 0x06001C04 RID: 7172 RVA: 0x00095AC4 File Offset: 0x00093CC4
	[Token(Token = "0x6001C04")]
	[Address(RVA = "0x5661F0", Offset = "0x5647F0", VA = "0x1805661F0", Slot = "16")]
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

	// Token: 0x06001C05 RID: 7173 RVA: 0x00095B84 File Offset: 0x00093D84
	[Token(Token = "0x6001C05")]
	[Address(RVA = "0x53E550", Offset = "0x53CB50", VA = "0x18053E550", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06001C06 RID: 7174 RVA: 0x00095BA0 File Offset: 0x00093DA0
	[Token(Token = "0x6001C06")]
	[Address(RVA = "0x566360", Offset = "0x564960", VA = "0x180566360", Slot = "60")]
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

	// Token: 0x06001C07 RID: 7175 RVA: 0x00095C20 File Offset: 0x00093E20
	[Token(Token = "0x6001C07")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public UltimateHypno()
	{
	}

	// Token: 0x04000F7E RID: 3966
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000F7E")]
	public GameObject mag1;

	// Token: 0x04000F7F RID: 3967
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F7F")]
	public GameObject mag2;

	// Token: 0x04000F80 RID: 3968
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000F80")]
	public GameObject mag3;

	// Token: 0x04000F81 RID: 3969
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000F81")]
	public CherrySubmarine cherrySubmarine;
}

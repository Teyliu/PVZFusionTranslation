using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004DF RID: 1247
[Token(Token = "0x20004DF")]
public class Shooter : Attacker
{
	// Token: 0x0600177D RID: 6013 RVA: 0x000806B0 File Offset: 0x0007E8B0
	[Token(Token = "0x600177D")]
	[Address(RVA = "0x5164A0", Offset = "0x514AA0", VA = "0x1805164A0", Slot = "16")]
	protected override void Update()
	{
		if (base.Active)
		{
			Board board = this.board;
			base.PlantShootUpdate();
		}
		base.Update();
	}

	// Token: 0x0600177E RID: 6014 RVA: 0x000806E0 File Offset: 0x0007E8E0
	[Token(Token = "0x600177E")]
	[Address(RVA = "0x515EA0", Offset = "0x5144A0", VA = "0x180515EA0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
			int num = 0;
			if (this.fastShoot)
			{
				float num2 = this.fastShootTimer;
				float fixedDeltaTime = Time.fixedDeltaTime;
				this.fastShootTimer = num2;
				this.fastShootTimer = 0f;
				this.fastShoot = false;
				if (!this.fastShoot)
				{
					int num3 = this.onShootTimes;
					num3++;
					this.onShootTimes = num3;
					if (num3 > 50 && (AdvantureConfig.data.CheckTalent((TalentType)((uint)43)) || Lawnf.TravelAdvanced((AdvBuff)((uint)2004))))
					{
						this.fastShootTimer = 1f;
						this.fastShoot = true;
						this.onShootTimes = (int)((ulong)0L);
					}
					EventManager.TriggerEvent((GameEvent)((uint)6), this);
				}
				Bullet bullet = this.Shoot1();
			}
			float num4 = this.dreamTime;
			if (num4 > (float)num)
			{
				float fixedDeltaTime2 = Time.fixedDeltaTime;
				this.dreamTime = num4;
				this.dreamTime = 0f;
			}
		}
	}

	// Token: 0x0600177F RID: 6015 RVA: 0x000807D8 File Offset: 0x0007E9D8
	[Token(Token = "0x600177F")]
	[Address(RVA = "0x5160B0", Offset = "0x5146B0", VA = "0x1805160B0")]
	private void OnShoot()
	{
		if (!this.fastShoot)
		{
			int num = this.onShootTimes;
			num++;
			this.onShootTimes = num;
			if (num > 50 && (AdvantureConfig.data.CheckTalent((TalentType)((uint)43)) || Lawnf.TravelAdvanced((AdvBuff)((uint)2004))))
			{
				this.fastShootTimer = 1f;
				this.fastShoot = true;
				this.onShootTimes = (int)((ulong)0L);
			}
			EventManager.TriggerEvent((GameEvent)((uint)6), this);
			return;
		}
	}

	// Token: 0x06001780 RID: 6016 RVA: 0x00080850 File Offset: 0x0007EA50
	[Token(Token = "0x6001780")]
	[Address(RVA = "0x496230", Offset = "0x494830", VA = "0x180496230")]
	public Bullet PublicShoot1()
	{
		return null;
	}

	// Token: 0x06001781 RID: 6017 RVA: 0x00080860 File Offset: 0x0007EA60
	[Token(Token = "0x6001781")]
	[Address(RVA = "0x515D40", Offset = "0x514340", VA = "0x180515D40")]
	public Bullet AnimShoot()
	{
		if (!this.fastShoot)
		{
			int num = this.onShootTimes;
			num++;
			this.onShootTimes = num;
			if (num > 50 && (AdvantureConfig.data.CheckTalent((TalentType)((uint)43)) || Lawnf.TravelAdvanced((AdvBuff)((uint)2004))))
			{
				this.fastShootTimer = 1f;
				this.fastShoot = true;
				this.onShootTimes = (int)((ulong)0L);
			}
			EventManager.TriggerEvent((GameEvent)((uint)6), this);
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001782 RID: 6018 RVA: 0x000808D8 File Offset: 0x0007EAD8
	[Token(Token = "0x6001782")]
	[Address(RVA = "0x515D20", Offset = "0x514320", VA = "0x180515D20")]
	protected void AnimShoot2()
	{
	}

	// Token: 0x06001783 RID: 6019 RVA: 0x000808E8 File Offset: 0x0007EAE8
	[Token(Token = "0x6001783")]
	[Address(RVA = "0x516200", Offset = "0x514800", VA = "0x180516200", Slot = "68")]
	protected virtual Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001784 RID: 6020 RVA: 0x00080938 File Offset: 0x0007EB38
	[Token(Token = "0x6001784")]
	[Address(RVA = "0x516350", Offset = "0x514950", VA = "0x180516350", Slot = "69")]
	protected virtual Bullet Shoot2()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001785 RID: 6021 RVA: 0x00080988 File Offset: 0x0007EB88
	[Token(Token = "0x6001785")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "70")]
	protected virtual BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x06001786 RID: 6022 RVA: 0x000809A0 File Offset: 0x0007EBA0
	[Token(Token = "0x6001786")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "71")]
	protected virtual BulletMoveWay GetBulletMoveWay()
	{
		return BulletMoveWay.MoveRight;
	}

	// Token: 0x06001787 RID: 6023 RVA: 0x000809B8 File Offset: 0x0007EBB8
	[Token(Token = "0x6001787")]
	[Address(RVA = "0x5090F0", Offset = "0x5076F0", VA = "0x1805090F0")]
	public Shooter()
	{
	}

	// Token: 0x04000E3A RID: 3642
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000E3A")]
	public float dreamTime = 0.1f;

	// Token: 0x04000E3B RID: 3643
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000E3B")]
	public int onShootTimes;

	// Token: 0x04000E3C RID: 3644
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000E3C")]
	protected float fastShootTimer;

	// Token: 0x04000E3D RID: 3645
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000E3D")]
	public bool fastShoot;
}

using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004BB RID: 1211
[Token(Token = "0x20004BB")]
public class Shooter : Attacker
{
	// Token: 0x060016D3 RID: 5843 RVA: 0x0007DA4C File Offset: 0x0007BC4C
	[Token(Token = "0x60016D3")]
	[Address(RVA = "0x4AA870", Offset = "0x4A8E70", VA = "0x1804AA870", Slot = "16")]
	protected override void Update()
	{
		if (base.Active)
		{
			Board board = this.board;
			base.PlantShootUpdate();
		}
		base.Update();
	}

	// Token: 0x060016D4 RID: 5844 RVA: 0x0007DA7C File Offset: 0x0007BC7C
	[Token(Token = "0x60016D4")]
	[Address(RVA = "0x4AA270", Offset = "0x4A8870", VA = "0x1804AA270", Slot = "17")]
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

	// Token: 0x060016D5 RID: 5845 RVA: 0x0007DB74 File Offset: 0x0007BD74
	[Token(Token = "0x60016D5")]
	[Address(RVA = "0x4AA480", Offset = "0x4A8A80", VA = "0x1804AA480")]
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

	// Token: 0x060016D6 RID: 5846 RVA: 0x0007DBEC File Offset: 0x0007BDEC
	[Token(Token = "0x60016D6")]
	[Address(RVA = "0x4442E0", Offset = "0x4428E0", VA = "0x1804442E0")]
	public Bullet PublicShoot1()
	{
		return null;
	}

	// Token: 0x060016D7 RID: 5847 RVA: 0x0007DBFC File Offset: 0x0007BDFC
	[Token(Token = "0x60016D7")]
	[Address(RVA = "0x4AA110", Offset = "0x4A8710", VA = "0x1804AA110")]
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

	// Token: 0x060016D8 RID: 5848 RVA: 0x0007DC74 File Offset: 0x0007BE74
	[Token(Token = "0x60016D8")]
	[Address(RVA = "0x4AA0F0", Offset = "0x4A86F0", VA = "0x1804AA0F0")]
	protected void AnimShoot2()
	{
	}

	// Token: 0x060016D9 RID: 5849 RVA: 0x0007DC84 File Offset: 0x0007BE84
	[Token(Token = "0x60016D9")]
	[Address(RVA = "0x4AA5D0", Offset = "0x4A8BD0", VA = "0x1804AA5D0", Slot = "69")]
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

	// Token: 0x060016DA RID: 5850 RVA: 0x0007DCD4 File Offset: 0x0007BED4
	[Token(Token = "0x60016DA")]
	[Address(RVA = "0x4AA720", Offset = "0x4A8D20", VA = "0x1804AA720", Slot = "70")]
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

	// Token: 0x060016DB RID: 5851 RVA: 0x0007DD24 File Offset: 0x0007BF24
	[Token(Token = "0x60016DB")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "71")]
	protected virtual BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x060016DC RID: 5852 RVA: 0x0007DD3C File Offset: 0x0007BF3C
	[Token(Token = "0x60016DC")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "72")]
	protected virtual BulletMoveWay GetBulletMoveWay()
	{
		return BulletMoveWay.MoveRight;
	}

	// Token: 0x060016DD RID: 5853 RVA: 0x0007DD54 File Offset: 0x0007BF54
	[Token(Token = "0x60016DD")]
	[Address(RVA = "0x499DE0", Offset = "0x4983E0", VA = "0x180499DE0")]
	public Shooter()
	{
	}

	// Token: 0x04000DA1 RID: 3489
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000DA1")]
	public float dreamTime = 0.1f;

	// Token: 0x04000DA2 RID: 3490
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000DA2")]
	public int onShootTimes;

	// Token: 0x04000DA3 RID: 3491
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000DA3")]
	protected float fastShootTimer;

	// Token: 0x04000DA4 RID: 3492
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000DA4")]
	public bool fastShoot;
}

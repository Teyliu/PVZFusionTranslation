using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003FA RID: 1018
[Token(Token = "0x20003FA")]
public class MelonNut : WallNut
{
	// Token: 0x060012C5 RID: 4805 RVA: 0x00069264 File Offset: 0x00067464
	[Token(Token = "0x60012C5")]
	[Address(RVA = "0x4A8870", Offset = "0x4A6E70", VA = "0x1804A8870", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Board board = this.board;
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)15), action, num != 0);
	}

	// Token: 0x060012C6 RID: 4806 RVA: 0x00069294 File Offset: 0x00067494
	[Token(Token = "0x60012C6")]
	[Address(RVA = "0x4A7F40", Offset = "0x4A6540", VA = "0x1804A7F40", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Board board = this.board;
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)15), action);
	}

	// Token: 0x060012C7 RID: 4807 RVA: 0x000692B8 File Offset: 0x000674B8
	[Token(Token = "0x60012C7")]
	[Address(RVA = "0x4A8520", Offset = "0x4A6B20", VA = "0x1804A8520")]
	private void OnPlantInjured(object obj)
	{
		bool flag;
		if (obj != 0 && obj != 0 && flag)
		{
			int num;
			this.SaveDamage(num);
		}
	}

	// Token: 0x060012C8 RID: 4808 RVA: 0x000692E0 File Offset: 0x000674E0
	[Token(Token = "0x60012C8")]
	[Address(RVA = "0x4A8150", Offset = "0x4A6750", VA = "0x1804A8150", Slot = "31")]
	protected override int GetDamage(int damage)
	{
		int damage2 = base.GetDamage(damage);
		this.SaveDamage(damage);
		return damage2;
	}

	// Token: 0x060012C9 RID: 4809 RVA: 0x00069300 File Offset: 0x00067500
	[Token(Token = "0x60012C9")]
	[Address(RVA = "0x4A8660", Offset = "0x4A6C60", VA = "0x1804A8660", Slot = "69")]
	protected virtual void SaveDamage(int damage)
	{
		if (damage <= 100 || damage <= 500 || damage > 1000)
		{
		}
		Board board = this.board;
		int num = this.shootingLevel;
		int num2 = this.attributeCount;
		num++;
		int num3 = num * damage;
		num2 -= num3;
		this.attributeCount = num2;
		int num4 = Mathf.Min(num2, damage);
		this.attributeCount = num4;
		throw new NullReferenceException();
	}

	// Token: 0x060012CA RID: 4810 RVA: 0x00069364 File Offset: 0x00067564
	[Token(Token = "0x60012CA")]
	[Address(RVA = "0x4A7FF0", Offset = "0x4A65F0", VA = "0x1804A7FF0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
			Zombie targetZombie = this.GetTargetZombie();
			int num = 0;
			if (targetZombie != num)
			{
				this.anim.SetTrigger("shoot");
				int attributeCount = this.attributeCount;
				this.theStatus = (PlantStatus)((ulong)33L);
				MelonNut.<GetTempShield>d__7 <GetTempShield>d__;
				<GetTempShield>d__.System.IDisposable.Dispose();
				<GetTempShield>d__.<>1__state = (int)((ulong)0L);
				<GetTempShield>d__.<>4__this = this;
				<GetTempShield>d__.value = attributeCount;
				Coroutine coroutine = base.StartCoroutine(<GetTempShield>d__);
			}
		}
	}

	// Token: 0x060012CB RID: 4811 RVA: 0x000693E4 File Offset: 0x000675E4
	[Token(Token = "0x60012CB")]
	[Address(RVA = "0x4A8760", Offset = "0x4A6D60", VA = "0x1804A8760")]
	private void SearchUpdate()
	{
		Zombie targetZombie = this.GetTargetZombie();
		int num = 0;
		if (targetZombie != num)
		{
			this.anim.SetTrigger("shoot");
			int attributeCount = this.attributeCount;
			this.theStatus = (PlantStatus)((ulong)33L);
			MelonNut.<GetTempShield>d__7 <GetTempShield>d__;
			<GetTempShield>d__.System.IDisposable.Dispose();
			<GetTempShield>d__.<>1__state = (int)((ulong)0L);
			<GetTempShield>d__.<>4__this = this;
			<GetTempShield>d__.value = attributeCount;
			Coroutine coroutine = base.StartCoroutine(<GetTempShield>d__);
		}
	}

	// Token: 0x060012CC RID: 4812 RVA: 0x00069454 File Offset: 0x00067654
	[Token(Token = "0x60012CC")]
	[Address(RVA = "0x4A83D0", Offset = "0x4A69D0", VA = "0x1804A83D0")]
	private IEnumerator GetTempShield(int value)
	{
		MelonNut.<GetTempShield>d__7 <GetTempShield>d__;
		<GetTempShield>d__.System.IDisposable.Dispose();
		<GetTempShield>d__.<>1__state = (int)((ulong)0L);
		<GetTempShield>d__.<>4__this = this;
		<GetTempShield>d__.value = value;
		return null;
	}

	// Token: 0x060012CD RID: 4813 RVA: 0x00069480 File Offset: 0x00067680
	[Token(Token = "0x60012CD")]
	[Address(RVA = "0x4A8640", Offset = "0x4A6C40", VA = "0x1804A8640", Slot = "68")]
	protected override void OnTriggerStay2D(Collider2D collision)
	{
		base.OnTriggerStay2D(collision);
	}

	// Token: 0x060012CE RID: 4814 RVA: 0x00069498 File Offset: 0x00067698
	[Token(Token = "0x60012CE")]
	[Address(RVA = "0x4A8190", Offset = "0x4A6790", VA = "0x1804A8190")]
	private Zombie GetTargetZombie()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
				if (!Lawnf.InLandStatus((ZombieStatus)num))
				{
					continue;
				}
				Transform axis = this.axis;
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x060012CF RID: 4815 RVA: 0x00069504 File Offset: 0x00067704
	[Token(Token = "0x60012CF")]
	[Address(RVA = "0x4A8140", Offset = "0x4A6740", VA = "0x1804A8140", Slot = "70")]
	protected virtual BulletType GetBulletType()
	{
		return BulletType.Bullet_melon;
	}

	// Token: 0x060012D0 RID: 4816 RVA: 0x00069514 File Offset: 0x00067714
	[Token(Token = "0x60012D0")]
	[Address(RVA = "0x4A7A70", Offset = "0x4A6070", VA = "0x1804A7A70")]
	private void AnimShoot()
	{
		GameAPP.PlaySound(3, 5f, 1f);
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int num = 0;
		int attributeCount = this.attributeCount;
		Bullet bullet;
		bullet.Damage = attributeCount;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		this.attributeCount = num;
		base.UpdateText();
		Zombie targetZombie = this.GetTargetZombie();
		int num2 = 0;
		int num3 = 0;
		if (!(targetZombie != num3))
		{
			Board board = this.board;
			Mouse instance2 = Mouse.Instance;
			int columnNum = board.columnNum;
			float boxXFromColumn = instance2.GetBoxXFromColumn(columnNum);
			Mouse instance3 = Mouse.Instance;
			int thePlantRow = this.thePlantRow;
			float landY = instance3.GetLandY(boxXFromColumn, thePlantRow);
		}
		Vector2 velocity = targetZombie.Velocity;
		int num4 = 0;
		Vector2 colliderPosition = targetZombie.ColliderPosition;
		float num5;
		bullet.SetSpeed(num4, num2, colliderPosition, num5);
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)12017)))
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}
	}

	// Token: 0x060012D1 RID: 4817 RVA: 0x00069628 File Offset: 0x00067828
	[Token(Token = "0x60012D1")]
	[Address(RVA = "0x4A7E70", Offset = "0x4A6470", VA = "0x1804A7E70")]
	private void CheckBullet(Bullet originalBullet)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060012D2 RID: 4818 RVA: 0x0006964C File Offset: 0x0006784C
	[Token(Token = "0x60012D2")]
	[Address(RVA = "0x4A8450", Offset = "0x4A6A50", VA = "0x1804A8450", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060012D3 RID: 4819 RVA: 0x0006966C File Offset: 0x0006786C
	[Token(Token = "0x60012D3")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public MelonNut()
	{
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000496 RID: 1174
[Token(Token = "0x2000496")]
public class Umbrellaleaf : Plant
{
	// Token: 0x060015F3 RID: 5619 RVA: 0x00079CC4 File Offset: 0x00077EC4
	[Token(Token = "0x60015F3")]
	[Address(RVA = "0x496490", Offset = "0x494A90", VA = "0x180496490", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		SortingGroup component = transform.GetChild(num).GetComponent<SortingGroup>();
		this._sortingGroup = component;
		throw new NullReferenceException();
	}

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x060015F4 RID: 5620 RVA: 0x00079CFC File Offset: 0x00077EFC
	[Token(Token = "0x17000113")]
	public Plant UmbrellaPot
	{
		[Token(Token = "0x60015F4")]
		[Address(RVA = "0x496A50", Offset = "0x495050", VA = "0x180496A50")]
		get
		{
			ulong num;
			do
			{
				GridSystem gridSystem = this.board.gridSystem;
				int thePlantRow = this.thePlantRow;
				int thePlantColumn = this.thePlantColumn;
				List<Plant> plants = gridSystem.GetGrid(thePlantColumn, thePlantRow).plants;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != (ulong)0L);
			throw new NullReferenceException();
		}
	}

	// Token: 0x060015F5 RID: 5621 RVA: 0x00079D54 File Offset: 0x00077F54
	[Token(Token = "0x60015F5")]
	[Address(RVA = "0x4966B0", Offset = "0x494CB0", VA = "0x1804966B0", Slot = "69")]
	public virtual void Block(Bullet bullet)
	{
		bullet.hit = true;
		Umbrellaleaf.<DelayBlock>d__7 <DelayBlock>d__;
		<DelayBlock>d__.System.IDisposable.Dispose();
		<DelayBlock>d__.<>1__state = (int)((ulong)0L);
		<DelayBlock>d__.bullet = bullet;
		Coroutine coroutine = base.StartCoroutine(<DelayBlock>d__);
		if (!this.blocking)
		{
			this.anim.SetTrigger("block");
			this.blocking = true;
		}
		bullet.sortingGroup.sortingLayerName = "bullet11";
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		if (flag)
		{
			CreateBullet instance = CreateBullet.Instance;
			Transform transform = bullet.transform;
			Transform transform2 = bullet.transform;
			BulletType theBulletType = bullet.theBulletType;
			float detaVy = bullet.detaVy;
			float vx = bullet.Vx;
			float vy = bullet.Vy;
			PlantType thePlantType = this.thePlantType;
			int num = bullet._damage;
			num += 200;
			bullet.Die();
		}
		BulletType theBulletType2 = bullet.theBulletType;
		if (theBulletType2 == BulletType.Bullet_superCherry || theBulletType2 == BulletType.Bullet_jackbox_black)
		{
			base.FlashOnce();
		}
		float num2 = bullet.Vy * -1f;
		bullet.Vy = num2;
		float vx2 = bullet.Vx;
		bullet.Vx = vx2;
	}

	// Token: 0x060015F6 RID: 5622 RVA: 0x00079E64 File Offset: 0x00078064
	[Token(Token = "0x60015F6")]
	[Address(RVA = "0x496510", Offset = "0x494B10", VA = "0x180496510")]
	public void BlockBungi(BungiZombie bungi)
	{
		if (!this.blocking)
		{
			GameAPP.PlaySound(106, 0.5f, 1f);
			this.anim.SetTrigger("block");
			this.blocking = true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x00079EA8 File Offset: 0x000780A8
	[Token(Token = "0x60015F7")]
	[Address(RVA = "0x4969E0", Offset = "0x494FE0", VA = "0x1804969E0")]
	protected IEnumerator DelayBlock(Bullet bullet)
	{
		Umbrellaleaf.<DelayBlock>d__7 <DelayBlock>d__;
		<DelayBlock>d__.System.IDisposable.Dispose();
		<DelayBlock>d__.<>1__state = (int)((ulong)0L);
		<DelayBlock>d__.bullet = bullet;
		return null;
	}

	// Token: 0x060015F8 RID: 5624 RVA: 0x00079ECC File Offset: 0x000780CC
	[Token(Token = "0x60015F8")]
	[Address(RVA = "0x496640", Offset = "0x494C40", VA = "0x180496640")]
	private void BlockStart()
	{
		this._sortingGroup.sortingLayerName = "fog";
		this._sortingGroup.sortAtRoot = true;
	}

	// Token: 0x060015F9 RID: 5625 RVA: 0x00079EFC File Offset: 0x000780FC
	[Token(Token = "0x60015F9")]
	[Address(RVA = "0x4965D0", Offset = "0x494BD0", VA = "0x1804965D0")]
	private void BlockOver()
	{
		this._sortingGroup.sortingLayerName = "Default";
		SortingGroup sortingGroup = this._sortingGroup;
		int num = 0;
		sortingGroup.sortAtRoot = num != 0;
	}

	// Token: 0x060015FA RID: 5626 RVA: 0x00079F30 File Offset: 0x00078130
	[Token(Token = "0x60015FA")]
	[Address(RVA = "0x496480", Offset = "0x494A80", VA = "0x180496480")]
	private void AllBlockOver()
	{
		this.blocking = false;
	}

	// Token: 0x060015FB RID: 5627 RVA: 0x00079F44 File Offset: 0x00078144
	[Token(Token = "0x60015FB")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public Umbrellaleaf()
	{
	}

	// Token: 0x04000D64 RID: 3428
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D64")]
	public SortingGroup _sortingGroup;

	// Token: 0x04000D65 RID: 3429
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D65")]
	public bool blocking;
}

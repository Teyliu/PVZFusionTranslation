using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Rendering;

// Token: 0x0200076D RID: 1901
[Token(Token = "0x200076D")]
public class BulletPoolManager : MonoBehaviour
{
	// Token: 0x06002685 RID: 9861 RVA: 0x000CD784 File Offset: 0x000CB984
	[Token(Token = "0x6002685")]
	[Address(RVA = "0x5D5CB0", Offset = "0x5D42B0", VA = "0x1805D5CB0")]
	private void Awake()
	{
		ulong num5;
		do
		{
			int num = 0;
			BulletPoolManager.Instance = this;
			Board instance = Board.Instance;
			this.board = instance;
			List<BulletType> allBullets = GameAPP.resourcesManager.allBullets;
			bool flag;
			if (flag)
			{
				BulletPoolManager.<>c__DisplayClass3_0 CS$<>8__locals1;
				CS$<>8__locals1.<>4__this = this;
				CS$<>8__locals1.item = (BulletType)num;
				Func<Bullet> func;
				Action<Bullet> action;
				Action<Bullet> action2;
				Action<Bullet> action3;
				ulong num2;
				ulong num3;
				ulong num4;
				ObjectPool<Bullet> objectPool = new ObjectPool(func, action, action2, action3, num2 != 0UL, (int)num3, (int)num4);
				Dictionary<BulletType, ObjectPool<Bullet>> dictionary = this.pools;
				BulletType item = CS$<>8__locals1.item;
				dictionary.Add(item, objectPool);
			}
		}
		while (num5 != (ulong)0L);
	}

	// Token: 0x06002686 RID: 9862 RVA: 0x000CD810 File Offset: 0x000CBA10
	[Token(Token = "0x6002686")]
	[Address(RVA = "0x5D6050", Offset = "0x5D4650", VA = "0x1805D6050")]
	private Bullet CreateBullet(BulletType theBulletType)
	{
		Dictionary<BulletType, GameObject> bulletPrefabs = GameAPP.resourcesManager.bulletPrefabs;
		bool flag;
		if (!flag)
		{
		}
		Transform transform = base.transform;
		GameObject gameObject;
		SortingGroup sortingGroup = gameObject.AddComponent<SortingGroup>();
		Rigidbody2D rigidbody2D = gameObject.AddComponent<Rigidbody2D>();
		ulong num;
		rigidbody2D.isKinematic = num != 0UL;
		Bullet component = gameObject.GetComponent<Bullet>();
		Board instance = Board.Instance;
		component.board = instance;
		component.theBulletType = theBulletType;
		component.rb = rigidbody2D;
		Collider2D component2 = component.GetComponent<Collider2D>();
		component.col = component2;
		int mask = LayerMask.GetMask(new string[] { "Zombie" });
		component.zombieLayer = mask;
		float boardMinX = this.board.boardMinX;
		component.minX = boardMinX;
		float boardMinY = this.board.boardMinY;
		component.minY = boardMinY;
		float boardMaxX = this.board.boardMaxX;
		component.maxX = boardMaxX;
		float boardMaxY = this.board.boardMaxY;
		component.maxY = boardMaxY;
		Transform transform2 = component.transform.Find("Shadow");
		component.shadow = transform2;
		BulletMovement movement = BulletMovement.GetMovement(BulletMoveWay.MoveRight);
		component.bulletMovement = movement;
		component.bulletMovement.bullet = component;
		if (GameAPP.config.showBulletDamage)
		{
			DamageHUD damageHUD = global::UnityEngine.Object.Instantiate<DamageHUD>(Resources.Load<DamageHUD>("Image/HealthIcon/DamageHUD"));
			Transform transform3 = damageHUD.transform;
			Transform uiparent = this.board.UIParent;
			int num2 = 0;
			transform3.SetParent(uiparent, num2 != 0);
			damageHUD.follow = component;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002687 RID: 9863 RVA: 0x000CD99C File Offset: 0x000CBB9C
	[Token(Token = "0x6002687")]
	[Address(RVA = "0x3ECB10", Offset = "0x3EB110", VA = "0x1803ECB10")]
	private void GetBullet(Bullet obj)
	{
		obj.gameObject.SetActive(true);
	}

	// Token: 0x06002688 RID: 9864 RVA: 0x000CD9BC File Offset: 0x000CBBBC
	[Token(Token = "0x6002688")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10")]
	private void ReleaseBullet(Bullet obj)
	{
	}

	// Token: 0x06002689 RID: 9865 RVA: 0x000CD9CC File Offset: 0x000CBBCC
	[Token(Token = "0x6002689")]
	[Address(RVA = "0x5D64A0", Offset = "0x5D4AA0", VA = "0x1805D64A0")]
	private void DestoryBullet(Bullet obj)
	{
		global::UnityEngine.Object.Destroy(obj.gameObject);
	}

	// Token: 0x0600268A RID: 9866 RVA: 0x000CD9EC File Offset: 0x000CBBEC
	[Token(Token = "0x600268A")]
	[Address(RVA = "0x5D6510", Offset = "0x5D4B10", VA = "0x1805D6510")]
	public BulletPoolManager()
	{
		Dictionary<BulletType, ObjectPool<Bullet>> dictionary = new Dictionary();
		this.pools = dictionary;
		base..ctor();
	}

	// Token: 0x0400141A RID: 5146
	[Token(Token = "0x400141A")]
	public static BulletPoolManager Instance;

	// Token: 0x0400141B RID: 5147
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400141B")]
	public Dictionary<BulletType, ObjectPool<Bullet>> pools;

	// Token: 0x0400141C RID: 5148
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400141C")]
	private Board board;
}

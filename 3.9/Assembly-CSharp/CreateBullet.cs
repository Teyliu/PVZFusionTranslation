using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Rendering;

// Token: 0x0200020E RID: 526
[Token(Token = "0x200020E")]
public class CreateBullet : MonoBehaviour
{
	// Token: 0x060008E1 RID: 2273 RVA: 0x0002DBB4 File Offset: 0x0002BDB4
	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x8E6F40", Offset = "0x8E5540", VA = "0x1808E6F40")]
	private void Awake()
	{
		CreateBullet.Instance = this;
		Board instance = Board.Instance;
		this.board = instance;
		BoardEntity boardEntity = this.board.boardEntity;
		this.boardEntity = boardEntity;
		throw new NullReferenceException();
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x0002DBEC File Offset: 0x0002BDEC
	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x8E7070", Offset = "0x8E5670", VA = "0x1808E7070")]
	public Bullet SetBullet(float x, float y, int theRow, BulletType theBulletType, BulletMoveWay theMovingWay, bool fromEnermy = false)
	{
		Dictionary<BulletType, ObjectPool<Bullet>> pools = BulletPoolManager.Instance.pools;
		bool flag;
		if (flag)
		{
			Bullet bullet;
			Transform transform = bullet.transform;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Rigidbody2D rb = bullet.rb;
			bullet.theBulletRow = theRow;
			bullet.<Team>k__BackingField = Team.Player;
			this.AddToList(bullet);
			this.SetLayer(bullet, 11);
			bullet.InitData();
			return bullet;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x0002DC50 File Offset: 0x0002BE50
	[Token(Token = "0x60008E3")]
	[Address(RVA = "0x8E6DB0", Offset = "0x8E53B0", VA = "0x1808E6DB0")]
	private void AddToList(Bullet bullet)
	{
		Queue<int> availableIndices = this._availableIndices;
		List<Bullet> bulletArray = this.boardEntity.bulletArray;
		int size = bulletArray._size;
		bulletArray._size = availableIndices;
		int size2 = this.boardEntity.bulletArray._size;
		bullet.indexInArray = size2;
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x0002DCAC File Offset: 0x0002BEAC
	[Token(Token = "0x60008E4")]
	[Address(RVA = "0x8E6FE0", Offset = "0x8E55E0", VA = "0x1808E6FE0")]
	public void RemoveFromList(Bullet bullet)
	{
		List<Bullet> bulletArray = this.boardEntity.bulletArray;
		int num = 0;
		int indexInArray = bullet.indexInArray;
		bulletArray[indexInArray] = num;
		Queue<int> availableIndices = this._availableIndices;
		int indexInArray2 = bullet.indexInArray;
		availableIndices.Enqueue(indexInArray2);
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x0002DCF4 File Offset: 0x0002BEF4
	[Token(Token = "0x60008E5")]
	[Address(RVA = "0x8E72A0", Offset = "0x8E58A0", VA = "0x1808E72A0")]
	public void SetLayer(Bullet bullet, int theRow)
	{
		SortingGroup component = bullet.GetComponent<SortingGroup>();
		bullet.sortingGroup = component;
		string text = string.Format("bullet{0}", component);
		component.sortingLayerName = text;
		int currentBulletNum = this.board.currentBulletNum;
		component.sortingOrder = currentBulletNum;
		Transform shadow = bullet.shadow;
		int num = 0;
		if (shadow != num)
		{
			SortingGroup component2 = bullet.shadow.GetComponent<SortingGroup>();
			int num2 = 0;
			if (component2 == num2)
			{
				bullet.shadow.gameObject.AddComponent<SortingGroup>().sortAtRoot = true;
			}
		}
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x0002DD84 File Offset: 0x0002BF84
	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x8E7460", Offset = "0x8E5A60", VA = "0x1808E7460")]
	public CreateBullet()
	{
		Queue<int> queue = new Queue();
		this._availableIndices = queue;
		base..ctor();
	}

	// Token: 0x04000468 RID: 1128
	[Token(Token = "0x4000468")]
	public static CreateBullet Instance;

	// Token: 0x04000469 RID: 1129
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000469")]
	private Board board;

	// Token: 0x0400046A RID: 1130
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400046A")]
	private BoardEntity boardEntity;

	// Token: 0x0400046B RID: 1131
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400046B")]
	private readonly Queue<int> _availableIndices;
}

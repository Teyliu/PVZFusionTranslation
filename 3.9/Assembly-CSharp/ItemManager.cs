using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007AF RID: 1967
[Token(Token = "0x20007AF")]
public class ItemManager
{
	// Token: 0x060027D6 RID: 10198 RVA: 0x000D3258 File Offset: 0x000D1458
	[Token(Token = "0x60027D6")]
	[Address(RVA = "0x646D20", Offset = "0x645320", VA = "0x180646D20")]
	public ItemManager()
	{
		Dictionary<BucketType, GameObject> dictionary = new Dictionary();
		this.bucketPrefabs = dictionary;
		base..ctor();
		Dictionary<BucketType, GameObject> dict = global::Core.Lawnf.GetDict<BucketType, GameObject>("Items/", true);
		this.bucketPrefabs = dict;
	}

	// Token: 0x060027D7 RID: 10199 RVA: 0x000D328C File Offset: 0x000D148C
	[Token(Token = "0x60027D7")]
	[Address(RVA = "0x646B80", Offset = "0x645180", VA = "0x180646B80")]
	public Bucket SetBucket(Board board, BucketType theBucketType, Vector2 position)
	{
		Dictionary<BucketType, GameObject> dictionary = this.bucketPrefabs;
		bool flag;
		if (!flag)
		{
		}
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = board.transform;
		GameObject gameObject;
		gameObject.GetComponent<Bucket>().theBucketType = theBucketType;
		throw new NullReferenceException();
	}

	// Token: 0x060027D8 RID: 10200 RVA: 0x000D32D0 File Offset: 0x000D14D0
	[Token(Token = "0x60027D8")]
	[Address(RVA = "0x646B00", Offset = "0x645100", VA = "0x180646B00")]
	private void LoadBuckets()
	{
		Dictionary<BucketType, GameObject> dict = global::Core.Lawnf.GetDict<BucketType, GameObject>("Items/", true);
		this.bucketPrefabs = dict;
	}

	// Token: 0x0400152F RID: 5423
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400152F")]
	public Dictionary<BucketType, GameObject> bucketPrefabs;
}

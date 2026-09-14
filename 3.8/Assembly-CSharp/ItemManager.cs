using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000776 RID: 1910
[Token(Token = "0x2000776")]
public class ItemManager
{
	// Token: 0x060026A7 RID: 9895 RVA: 0x000CE228 File Offset: 0x000CC428
	[Token(Token = "0x60026A7")]
	[Address(RVA = "0x5E39F0", Offset = "0x5E1FF0", VA = "0x1805E39F0")]
	public ItemManager()
	{
		Dictionary<BucketType, GameObject> dictionary = new Dictionary();
		this.bucketPrefabs = dictionary;
		base..ctor();
		Dictionary<BucketType, GameObject> dict = global::Core.Lawnf.GetDict<BucketType, GameObject>("Items/", true);
		this.bucketPrefabs = dict;
	}

	// Token: 0x060026A8 RID: 9896 RVA: 0x000CE25C File Offset: 0x000CC45C
	[Token(Token = "0x60026A8")]
	[Address(RVA = "0x5E3850", Offset = "0x5E1E50", VA = "0x1805E3850")]
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

	// Token: 0x060026A9 RID: 9897 RVA: 0x000CE2A0 File Offset: 0x000CC4A0
	[Token(Token = "0x60026A9")]
	[Address(RVA = "0x5E37D0", Offset = "0x5E1DD0", VA = "0x1805E37D0")]
	private void LoadBuckets()
	{
		Dictionary<BucketType, GameObject> dict = global::Core.Lawnf.GetDict<BucketType, GameObject>("Items/", true);
		this.bucketPrefabs = dict;
	}

	// Token: 0x04001453 RID: 5203
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001453")]
	public Dictionary<BucketType, GameObject> bucketPrefabs;
}

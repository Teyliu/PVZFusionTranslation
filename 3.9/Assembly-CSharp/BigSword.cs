using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002B4 RID: 692
[Token(Token = "0x20002B4")]
public class BigSword : MonoBehaviour
{
	// Token: 0x06000C27 RID: 3111 RVA: 0x000451A4 File Offset: 0x000433A4
	[Token(Token = "0x6000C27")]
	[Address(RVA = "0x41B6C0", Offset = "0x419CC0", VA = "0x18041B6C0")]
	private void Awake()
	{
		SortingGroup component = base.GetComponent<SortingGroup>();
		this.sortingGroup = component;
		Transform transform = base.transform;
		int num = 0;
		SpriteRenderer component2 = transform.GetChild(num).GetComponent<SpriteRenderer>();
		this.r = component2;
		throw new NullReferenceException();
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x000451E4 File Offset: 0x000433E4
	[Token(Token = "0x6000C28")]
	[Address(RVA = "0x41B7D0", Offset = "0x419DD0", VA = "0x18041B7D0")]
	private void Start()
	{
		this.AttackZombies();
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x000451F8 File Offset: 0x000433F8
	[Token(Token = "0x6000C29")]
	[Address(RVA = "0x41B230", Offset = "0x419830", VA = "0x18041B230")]
	private void AttackZombies()
	{
		List<Zombie> list;
		ulong num3;
		do
		{
			int num = 0;
			list = new List();
			List<Zombie> zombieArray = Board.Instance.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		bool flag2;
		if (!flag2)
		{
		}
		float num4 = global::UnityEngine.Random.Range(-6f, 6f);
		float num5 = global::UnityEngine.Random.Range(-3f, 3f);
		int num6 = list._size;
		num6 = global::UnityEngine.Random.Range(0, num6);
		Transform axis = list[num6].axis;
		float num7 = global::UnityEngine.Random.Range(-1f, 1f);
		Mouse instance = Mouse.Instance;
		float y = this.targetPosition.y;
		int rowFromY = instance.GetRowFromY(1f, y);
		string text = string.Format("bullet{0}", rowFromY);
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x000452D8 File Offset: 0x000434D8
	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0x41B7E0", Offset = "0x419DE0", VA = "0x18041B7E0")]
	private void Update()
	{
		if (!this.land)
		{
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			Transform transform2 = base.transform;
			float num = this.moveSpeed;
			float deltaTime = Time.deltaTime;
			Vector3 vector2;
			float num2 = num * vector2.z;
			Vector2 gravity = Physics2D.gravity;
			float deltaTime2 = Time.deltaTime;
			this.moveSpeed = deltaTime2;
			Transform transform3 = base.transform;
			Transform transform4 = base.transform;
			float y = this.targetPosition.y;
			BigSword.<Enumerator>d__12 <Enumerator>d__;
			<Enumerator>d__.System.IDisposable.Dispose();
			<Enumerator>d__.<>1__state = (int)((ulong)0L);
			<Enumerator>d__.<>4__this = this;
			Coroutine coroutine = base.StartCoroutine(<Enumerator>d__);
			Action<Vector2> action = this.action;
			this.land = true;
			if (action != 0)
			{
				Transform transform5 = base.transform;
			}
			base.transform.GetChild(1).gameObject.SetActive(true);
			Transform child = base.transform.GetChild(1);
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			child.rotation = identityQuaternion;
		}
		float deltaTime3 = Time.deltaTime;
		this.existTimer = deltaTime3;
		if (deltaTime3 > 10f)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x00045404 File Offset: 0x00043604
	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0x41B760", Offset = "0x419D60", VA = "0x18041B760")]
	private IEnumerator Enumerator()
	{
		BigSword.<Enumerator>d__12 <Enumerator>d__;
		<Enumerator>d__.System.IDisposable.Dispose();
		<Enumerator>d__.<>1__state = (int)((ulong)0L);
		<Enumerator>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x00045428 File Offset: 0x00043628
	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x41BC50", Offset = "0x41A250", VA = "0x18041BC50")]
	public BigSword()
	{
	}

	// Token: 0x0400081C RID: 2076
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400081C")]
	[SerializeField]
	private Vector2 targetPosition;

	// Token: 0x0400081D RID: 2077
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400081D")]
	[SerializeField]
	private bool land;

	// Token: 0x0400081E RID: 2078
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400081E")]
	private float moveSpeed = 20f;

	// Token: 0x0400081F RID: 2079
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400081F")]
	private float existTimer;

	// Token: 0x04000820 RID: 2080
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000820")]
	public Plant plant;

	// Token: 0x04000821 RID: 2081
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000821")]
	public Action<Vector2> action;

	// Token: 0x04000822 RID: 2082
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000822")]
	private SpriteRenderer r;

	// Token: 0x04000823 RID: 2083
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000823")]
	private SortingGroup sortingGroup;
}

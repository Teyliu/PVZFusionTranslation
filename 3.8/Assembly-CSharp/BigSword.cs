using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002A9 RID: 681
[Token(Token = "0x20002A9")]
public class BigSword : MonoBehaviour
{
	// Token: 0x06000BFE RID: 3070 RVA: 0x00044E84 File Offset: 0x00043084
	[Token(Token = "0x6000BFE")]
	[Address(RVA = "0x3CE830", Offset = "0x3CCE30", VA = "0x1803CE830")]
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

	// Token: 0x06000BFF RID: 3071 RVA: 0x00044EC4 File Offset: 0x000430C4
	[Token(Token = "0x6000BFF")]
	[Address(RVA = "0x3CE940", Offset = "0x3CCF40", VA = "0x1803CE940")]
	private void Start()
	{
		this.AttackZombies();
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x00044ED8 File Offset: 0x000430D8
	[Token(Token = "0x6000C00")]
	[Address(RVA = "0x3CE3A0", Offset = "0x3CC9A0", VA = "0x1803CE3A0")]
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

	// Token: 0x06000C01 RID: 3073 RVA: 0x00044FB8 File Offset: 0x000431B8
	[Token(Token = "0x6000C01")]
	[Address(RVA = "0x3CE950", Offset = "0x3CCF50", VA = "0x1803CE950")]
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

	// Token: 0x06000C02 RID: 3074 RVA: 0x000450E4 File Offset: 0x000432E4
	[Token(Token = "0x6000C02")]
	[Address(RVA = "0x3CE8D0", Offset = "0x3CCED0", VA = "0x1803CE8D0")]
	private IEnumerator Enumerator()
	{
		BigSword.<Enumerator>d__12 <Enumerator>d__;
		<Enumerator>d__.System.IDisposable.Dispose();
		<Enumerator>d__.<>1__state = (int)((ulong)0L);
		<Enumerator>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x00045108 File Offset: 0x00043308
	[Token(Token = "0x6000C03")]
	[Address(RVA = "0x3CEDC0", Offset = "0x3CD3C0", VA = "0x1803CEDC0")]
	public BigSword()
	{
	}

	// Token: 0x040007FD RID: 2045
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007FD")]
	[SerializeField]
	private Vector2 targetPosition;

	// Token: 0x040007FE RID: 2046
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007FE")]
	[SerializeField]
	private bool land;

	// Token: 0x040007FF RID: 2047
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40007FF")]
	private float moveSpeed = 20f;

	// Token: 0x04000800 RID: 2048
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000800")]
	private float existTimer;

	// Token: 0x04000801 RID: 2049
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000801")]
	public Plant plant;

	// Token: 0x04000802 RID: 2050
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000802")]
	public Action<Vector2> action;

	// Token: 0x04000803 RID: 2051
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000803")]
	private SpriteRenderer r;

	// Token: 0x04000804 RID: 2052
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000804")]
	private SortingGroup sortingGroup;
}

using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020007A5 RID: 1957
[Token(Token = "0x20007A5")]
public class Portal : MonoBehaviour
{
	// Token: 0x060027AE RID: 10158 RVA: 0x000D263C File Offset: 0x000D083C
	[Token(Token = "0x60027AE")]
	[Address(RVA = "0x649D30", Offset = "0x648330", VA = "0x180649D30")]
	private void Awake()
	{
		Transform transform = base.transform.Find("Shadow").transform;
		this.axis = transform;
		throw new NullReferenceException();
	}

	// Token: 0x060027AF RID: 10159 RVA: 0x000D266C File Offset: 0x000D086C
	[Token(Token = "0x60027AF")]
	[Address(RVA = "0x64A400", Offset = "0x648A00", VA = "0x18064A400")]
	private void Start()
	{
		SortingGroup component = base.GetComponent<SortingGroup>();
		int num = this.thePortalRow;
		string text = string.Format("particle{0}", component);
		component.sortingLayerName = text;
	}

	// Token: 0x060027B0 RID: 10160 RVA: 0x000D26A0 File Offset: 0x000D08A0
	[Token(Token = "0x60027B0")]
	[Address(RVA = "0x64A090", Offset = "0x648690", VA = "0x18064A090")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		Portal portal = this.next;
		int num = 0;
		if (portal != num && collision.TryGetComponent<Zombie>(num))
		{
			int num2 = this.thePortalRow;
			int num3 = this.next.thePortalRow;
			Transform transform = this.next.axis;
			Portal portal2 = this.next;
			Mouse instance = Mouse.Instance;
			if (this.Towards == Towards.Right)
			{
				int num4 = 0;
				Transform transform2 = instance.transform;
				transform2.rotation = num4;
				Vector3 position = transform2.position;
				int num5 = 0;
				Transform transform3;
				transform3.rotation = num5;
			}
		}
	}

	// Token: 0x060027B1 RID: 10161 RVA: 0x000D2734 File Offset: 0x000D0934
	[Token(Token = "0x60027B1")]
	[Address(RVA = "0x64A030", Offset = "0x648630", VA = "0x18064A030")]
	public void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060027B2 RID: 10162 RVA: 0x000D274C File Offset: 0x000D094C
	[Token(Token = "0x60027B2")]
	[Address(RVA = "0x649DA0", Offset = "0x6483A0", VA = "0x180649DA0")]
	public static Portal CreatePortal(int theColumn, int theRow)
	{
		float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(theRow);
		float landY = Mouse.Instance.GetLandY(boxXFromColumn, theRow);
		GameObject gameObject = Resources.Load<GameObject>("Items/Protal/PortalPrefab");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = Board.Instance.transform;
		GameObject gameObject2;
		Portal component = gameObject2.GetComponent<Portal>();
		SortingGroup component2 = component.GetComponent<SortingGroup>();
		string text = string.Format("particle{0}", component2);
		component2.sortingLayerName = text;
		component.thePortalRow = theRow;
		return component;
	}

	// Token: 0x060027B3 RID: 10163 RVA: 0x000D27D0 File Offset: 0x000D09D0
	[Token(Token = "0x60027B3")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public Portal()
	{
	}

	// Token: 0x040014F1 RID: 5361
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014F1")]
	public int thePortalRow;

	// Token: 0x040014F2 RID: 5362
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014F2")]
	public Portal next;

	// Token: 0x040014F3 RID: 5363
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014F3")]
	public Portal pre;

	// Token: 0x040014F4 RID: 5364
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014F4")]
	private Transform axis;

	// Token: 0x040014F5 RID: 5365
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40014F5")]
	public Towards Towards;
}

using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200076C RID: 1900
[Token(Token = "0x200076C")]
public class Portal : MonoBehaviour
{
	// Token: 0x0600267F RID: 9855 RVA: 0x000CD5DC File Offset: 0x000CB7DC
	[Token(Token = "0x600267F")]
	[Address(RVA = "0x5E69F0", Offset = "0x5E4FF0", VA = "0x1805E69F0")]
	private void Awake()
	{
		Transform transform = base.transform.Find("Shadow").transform;
		this.axis = transform;
		throw new NullReferenceException();
	}

	// Token: 0x06002680 RID: 9856 RVA: 0x000CD60C File Offset: 0x000CB80C
	[Token(Token = "0x6002680")]
	[Address(RVA = "0x5E70C0", Offset = "0x5E56C0", VA = "0x1805E70C0")]
	private void Start()
	{
		SortingGroup component = base.GetComponent<SortingGroup>();
		int num = this.thePortalRow;
		string text = string.Format("particle{0}", component);
		component.sortingLayerName = text;
	}

	// Token: 0x06002681 RID: 9857 RVA: 0x000CD640 File Offset: 0x000CB840
	[Token(Token = "0x6002681")]
	[Address(RVA = "0x5E6D50", Offset = "0x5E5350", VA = "0x1805E6D50")]
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

	// Token: 0x06002682 RID: 9858 RVA: 0x000CD6D4 File Offset: 0x000CB8D4
	[Token(Token = "0x6002682")]
	[Address(RVA = "0x5E6CF0", Offset = "0x5E52F0", VA = "0x1805E6CF0")]
	public void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06002683 RID: 9859 RVA: 0x000CD6EC File Offset: 0x000CB8EC
	[Token(Token = "0x6002683")]
	[Address(RVA = "0x5E6A60", Offset = "0x5E5060", VA = "0x1805E6A60")]
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

	// Token: 0x06002684 RID: 9860 RVA: 0x000CD770 File Offset: 0x000CB970
	[Token(Token = "0x6002684")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public Portal()
	{
	}

	// Token: 0x04001415 RID: 5141
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001415")]
	public int thePortalRow;

	// Token: 0x04001416 RID: 5142
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001416")]
	public Portal next;

	// Token: 0x04001417 RID: 5143
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001417")]
	public Portal pre;

	// Token: 0x04001418 RID: 5144
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001418")]
	private Transform axis;

	// Token: 0x04001419 RID: 5145
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001419")]
	public Towards Towards;
}

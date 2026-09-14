using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200079D RID: 1949
[Token(Token = "0x200079D")]
public class DroppedItem : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x170001D4 RID: 468
	// (get) Token: 0x06002790 RID: 10128 RVA: 0x000D19A4 File Offset: 0x000CFBA4
	[Token(Token = "0x170001D4")]
	public int Priority
	{
		[Token(Token = "0x6002790")]
		[Address(RVA = "0x63A040", Offset = "0x638640", VA = "0x18063A040")]
		get
		{
			NotImplementedException ex = new NotImplementedException();
			return 0;
		}
	}

	// Token: 0x06002791 RID: 10129 RVA: 0x000D19B8 File Offset: 0x000CFBB8
	[Token(Token = "0x6002791")]
	[Address(RVA = "0x639C50", Offset = "0x638250", VA = "0x180639C50")]
	private void Awake()
	{
		bool flag;
		if (!flag)
		{
			Rigidbody2D rigidbody2D = this.AddComponent<Rigidbody2D>();
			this.rb = rigidbody2D;
		}
		this.rb.interpolation = (RigidbodyInterpolation2D)((uint)1);
		this.rb.gravityScale = 1.5f;
	}

	// Token: 0x06002792 RID: 10130 RVA: 0x000D19FC File Offset: 0x000CFBFC
	[Token(Token = "0x6002792")]
	[Address(RVA = "0x639FB0", Offset = "0x6385B0", VA = "0x180639FB0")]
	private void Start()
	{
		Rigidbody2D rigidbody2D = this.rb;
		float num2;
		float num = global::UnityEngine.Random.Range(num2, 3f);
	}

	// Token: 0x06002793 RID: 10131 RVA: 0x000D1A24 File Offset: 0x000CFC24
	[Token(Token = "0x6002793")]
	[Address(RVA = "0x63A020", Offset = "0x638620", VA = "0x18063A020")]
	private void Update()
	{
		if (this.onUpdate != 0)
		{
		}
	}

	// Token: 0x06002794 RID: 10132 RVA: 0x000D1A3C File Offset: 0x000CFC3C
	[Token(Token = "0x6002794")]
	[Address(RVA = "0x639D70", Offset = "0x638370", VA = "0x180639D70")]
	private void FixedUpdate()
	{
		Transform transform = base.transform;
		Vector3 vector;
		if (this.landY > vector.y && !this.land)
		{
			Action<DroppedItem> action = this.onLand;
			this.land = true;
			if (action != 0)
			{
			}
			this.rb.isKinematic = true;
			Rigidbody2D rigidbody2D = this.rb;
			return;
		}
	}

	// Token: 0x06002795 RID: 10133 RVA: 0x000D1A94 File Offset: 0x000CFC94
	[Token(Token = "0x6002795")]
	[Address(RVA = "0x639E50", Offset = "0x638450", VA = "0x180639E50")]
	public void MoveAndDie(Transform target, float speed, float minDistanceToDie = 0.1f, float minDistanceToSmall = 3f, float minScale = 0.05f, float distanceToMove = 1f)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002796 RID: 10134 RVA: 0x000D1AB4 File Offset: 0x000CFCB4
	[Token(Token = "0x6002796")]
	[Address(RVA = "0x639D00", Offset = "0x638300", VA = "0x180639D00")]
	public void Die()
	{
		if (this.onDeath != 0)
		{
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06002797 RID: 10135 RVA: 0x000D1AD8 File Offset: 0x000CFCD8
	[Token(Token = "0x6002797")]
	[Address(RVA = "0x639F80", Offset = "0x638580", VA = "0x180639F80", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
		if (!this.land || this.onClick != 0)
		{
		}
	}

	// Token: 0x06002798 RID: 10136 RVA: 0x000D1AF8 File Offset: 0x000CFCF8
	[Token(Token = "0x6002798")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public DroppedItem()
	{
	}

	// Token: 0x040014D3 RID: 5331
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014D3")]
	private Rigidbody2D rb;

	// Token: 0x040014D4 RID: 5332
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014D4")]
	public bool land;

	// Token: 0x040014D5 RID: 5333
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40014D5")]
	public float landY;

	// Token: 0x040014D6 RID: 5334
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014D6")]
	public Action<DroppedItem> onLand;

	// Token: 0x040014D7 RID: 5335
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014D7")]
	public Action<DroppedItem> onUpdate;

	// Token: 0x040014D8 RID: 5336
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40014D8")]
	public Action<DroppedItem> onDeath;

	// Token: 0x040014D9 RID: 5337
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40014D9")]
	public Action<DroppedItem> onClick;
}

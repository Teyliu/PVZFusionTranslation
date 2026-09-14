using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000764 RID: 1892
[Token(Token = "0x2000764")]
public class DroppedItem : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x1700018A RID: 394
	// (get) Token: 0x06002661 RID: 9825 RVA: 0x000CC940 File Offset: 0x000CAB40
	[Token(Token = "0x1700018A")]
	public int Priority
	{
		[Token(Token = "0x6002661")]
		[Address(RVA = "0x5D7150", Offset = "0x5D5750", VA = "0x1805D7150")]
		get
		{
			NotImplementedException ex = new NotImplementedException();
			return 0;
		}
	}

	// Token: 0x06002662 RID: 9826 RVA: 0x000CC954 File Offset: 0x000CAB54
	[Token(Token = "0x6002662")]
	[Address(RVA = "0x5D6D60", Offset = "0x5D5360", VA = "0x1805D6D60")]
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

	// Token: 0x06002663 RID: 9827 RVA: 0x000CC998 File Offset: 0x000CAB98
	[Token(Token = "0x6002663")]
	[Address(RVA = "0x5D70C0", Offset = "0x5D56C0", VA = "0x1805D70C0")]
	private void Start()
	{
		Rigidbody2D rigidbody2D = this.rb;
		float num2;
		float num = global::UnityEngine.Random.Range(num2, 3f);
	}

	// Token: 0x06002664 RID: 9828 RVA: 0x000CC9C0 File Offset: 0x000CABC0
	[Token(Token = "0x6002664")]
	[Address(RVA = "0x5D7130", Offset = "0x5D5730", VA = "0x1805D7130")]
	private void Update()
	{
		if (this.onUpdate != 0)
		{
		}
	}

	// Token: 0x06002665 RID: 9829 RVA: 0x000CC9D8 File Offset: 0x000CABD8
	[Token(Token = "0x6002665")]
	[Address(RVA = "0x5D6E80", Offset = "0x5D5480", VA = "0x1805D6E80")]
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

	// Token: 0x06002666 RID: 9830 RVA: 0x000CCA30 File Offset: 0x000CAC30
	[Token(Token = "0x6002666")]
	[Address(RVA = "0x5D6F60", Offset = "0x5D5560", VA = "0x1805D6F60")]
	public void MoveAndDie(Transform target, float speed, float minDistanceToDie = 0.1f, float minDistanceToSmall = 3f, float minScale = 0.05f, float distanceToMove = 1f)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002667 RID: 9831 RVA: 0x000CCA50 File Offset: 0x000CAC50
	[Token(Token = "0x6002667")]
	[Address(RVA = "0x5D6E10", Offset = "0x5D5410", VA = "0x1805D6E10")]
	public void Die()
	{
		if (this.onDeath != 0)
		{
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06002668 RID: 9832 RVA: 0x000CCA74 File Offset: 0x000CAC74
	[Token(Token = "0x6002668")]
	[Address(RVA = "0x5D7090", Offset = "0x5D5690", VA = "0x1805D7090", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
		if (!this.land || this.onClick != 0)
		{
		}
	}

	// Token: 0x06002669 RID: 9833 RVA: 0x000CCA94 File Offset: 0x000CAC94
	[Token(Token = "0x6002669")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public DroppedItem()
	{
	}

	// Token: 0x040013F7 RID: 5111
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013F7")]
	private Rigidbody2D rb;

	// Token: 0x040013F8 RID: 5112
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013F8")]
	public bool land;

	// Token: 0x040013F9 RID: 5113
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40013F9")]
	public float landY;

	// Token: 0x040013FA RID: 5114
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013FA")]
	public Action<DroppedItem> onLand;

	// Token: 0x040013FB RID: 5115
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40013FB")]
	public Action<DroppedItem> onUpdate;

	// Token: 0x040013FC RID: 5116
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40013FC")]
	public Action<DroppedItem> onDeath;

	// Token: 0x040013FD RID: 5117
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40013FD")]
	public Action<DroppedItem> onClick;
}

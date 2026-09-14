using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000731 RID: 1841
[Token(Token = "0x2000731")]
public class ZombieSquash : MonoBehaviour, IDamageMaker
{
	// Token: 0x17000186 RID: 390
	// (get) Token: 0x06002575 RID: 9589 RVA: 0x000C5610 File Offset: 0x000C3810
	// (set) Token: 0x06002576 RID: 9590 RVA: 0x000C5620 File Offset: 0x000C3820
	[Token(Token = "0x17000186")]
	public Team Team
	{
		[Token(Token = "0x6002575")]
		[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "4")]
		get
		{
			return Team.AI;
		}
		[Token(Token = "0x6002576")]
		[Address(RVA = "0x5D5730", Offset = "0x5D3D30", VA = "0x1805D5730", Slot = "5")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x06002577 RID: 9591 RVA: 0x000C5634 File Offset: 0x000C3834
	[Token(Token = "0x6002577")]
	[Address(RVA = "0x5D4EF0", Offset = "0x5D34F0", VA = "0x1805D4EF0")]
	private void Start()
	{
		Mouse instance = Mouse.Instance;
		int num = this.targetColumn;
		float boxXFromColumn = instance.GetBoxXFromColumn(num);
		Mouse instance2 = Mouse.Instance;
		int num2 = this.targetRow;
		float landY = instance2.GetLandY(boxXFromColumn, num2);
		this.lowerPosition.y = landY;
		this.lowerPosition = boxXFromColumn;
		this.upperPosition.y = landY;
		this.upperPosition = boxXFromColumn;
		SortingGroup component = base.GetComponent<SortingGroup>();
		int num3 = this.targetRow;
		string text = string.Format("bullet{0}", component);
		component.sortingLayerName = text;
	}

	// Token: 0x06002578 RID: 9592 RVA: 0x000C56C4 File Offset: 0x000C38C4
	[Token(Token = "0x6002578")]
	[Address(RVA = "0x5D4EE0", Offset = "0x5D34E0", VA = "0x1805D4EE0")]
	private void Progress1()
	{
	}

	// Token: 0x06002579 RID: 9593 RVA: 0x000C56D4 File Offset: 0x000C38D4
	[Token(Token = "0x6002579")]
	[Address(RVA = "0x5D4E70", Offset = "0x5D3470", VA = "0x1805D4E70")]
	private void DelayProgress()
	{
		base.GetComponent<Animator>().Play("jumppop");
	}

	// Token: 0x0600257A RID: 9594 RVA: 0x000C56F8 File Offset: 0x000C38F8
	[Token(Token = "0x600257A")]
	[Address(RVA = "0x5D5020", Offset = "0x5D3620", VA = "0x1805D5020")]
	private void Update()
	{
		ulong num4;
		do
		{
			int num = 0;
			if (this.progress == 1)
			{
				goto IL_00D6;
			}
			if (this.progress != 3)
			{
				return;
			}
			Transform transform = base.transform;
			float num2 = this.moveSpeed;
			float deltaTime = Time.deltaTime;
			Transform transform2 = base.transform;
			Transform transform3 = base.transform;
			Vector2 vector = this.lowerPosition;
			float timeScale = Time.timeScale;
			if (timeScale <= 1f)
			{
			}
			if (timeScale * 0.1f <= vector)
			{
				return;
			}
			global::UnityEngine.Object.Destroy(base.gameObject, 0.75f);
			int num3 = this.targetRow;
			List<Plant> list = Lawnf.Get1x1Plants(this.targetColumn, num3);
			bool flag;
			if (!flag || !TypeMgr.UncrashablePlant(num))
			{
			}
		}
		while (num4 != (ulong)0L);
		GameAPP.PlaySound(74, 0.5f, 1f);
		ScreenShake.TriggerShake(0.05f);
		BoardAction boardAction = Board.Instance.boardAction;
		return;
		IL_00D6:
		Transform transform4 = base.transform;
		float deltaTime2 = Time.deltaTime;
		Transform transform5 = base.transform;
		Vector3 vector2;
		float z = vector2.z;
		Transform transform6 = base.transform;
		Vector2 vector3 = this.upperPosition;
		if (Time.timeScale <= 1f)
		{
		}
		float num5;
		while (num5 <= vector3)
		{
		}
		base.Invoke("DelayProgress", 0.25f);
		throw new NullReferenceException();
	}

	// Token: 0x0600257B RID: 9595 RVA: 0x000C5848 File Offset: 0x000C3A48
	[Token(Token = "0x600257B")]
	[Address(RVA = "0x5D4E30", Offset = "0x5D3430", VA = "0x1805D4E30", Slot = "6")]
	public bool CanAttack(IDamageable target)
	{
		NotImplementedException ex = new NotImplementedException();
		return false;
	}

	// Token: 0x0600257C RID: 9596 RVA: 0x000C585C File Offset: 0x000C3A5C
	[Token(Token = "0x600257C")]
	[Address(RVA = "0x5D5720", Offset = "0x5D3D20", VA = "0x1805D5720")]
	public ZombieSquash()
	{
	}

	// Token: 0x040012CD RID: 4813
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40012CD")]
	public int targetRow;

	// Token: 0x040012CE RID: 4814
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40012CE")]
	public int targetColumn;

	// Token: 0x040012CF RID: 4815
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012CF")]
	public bool isMindControl;

	// Token: 0x040012D0 RID: 4816
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40012D0")]
	private Vector2 upperPosition;

	// Token: 0x040012D1 RID: 4817
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40012D1")]
	private Vector2 lowerPosition;

	// Token: 0x040012D2 RID: 4818
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40012D2")]
	private readonly float moveSpeed = 5.5f;

	// Token: 0x040012D3 RID: 4819
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40012D3")]
	private int progress;

	// Token: 0x040012D4 RID: 4820
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40012D4")]
	public bool jala;
}

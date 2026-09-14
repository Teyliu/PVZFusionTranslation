using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200076A RID: 1898
[Token(Token = "0x200076A")]
public class ZombieSquash : MonoBehaviour, IDamageMaker
{
	// Token: 0x170001CD RID: 461
	// (get) Token: 0x0600269A RID: 9882 RVA: 0x000CA53C File Offset: 0x000C873C
	// (set) Token: 0x0600269B RID: 9883 RVA: 0x000CA54C File Offset: 0x000C874C
	[Token(Token = "0x170001CD")]
	public Team Team
	{
		[Token(Token = "0x600269A")]
		[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "4")]
		get
		{
			return Team.AI;
		}
		[Token(Token = "0x600269B")]
		[Address(RVA = "0x636ED0", Offset = "0x6354D0", VA = "0x180636ED0", Slot = "5")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x0600269C RID: 9884 RVA: 0x000CA560 File Offset: 0x000C8760
	[Token(Token = "0x600269C")]
	[Address(RVA = "0x636340", Offset = "0x634940", VA = "0x180636340")]
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

	// Token: 0x0600269D RID: 9885 RVA: 0x000CA5F0 File Offset: 0x000C87F0
	[Token(Token = "0x600269D")]
	[Address(RVA = "0x636330", Offset = "0x634930", VA = "0x180636330")]
	private void Progress1()
	{
	}

	// Token: 0x0600269E RID: 9886 RVA: 0x000CA600 File Offset: 0x000C8800
	[Token(Token = "0x600269E")]
	[Address(RVA = "0x6362C0", Offset = "0x6348C0", VA = "0x1806362C0")]
	private void DelayProgress()
	{
		base.GetComponent<Animator>().Play("jumppop");
	}

	// Token: 0x0600269F RID: 9887 RVA: 0x000CA624 File Offset: 0x000C8824
	[Token(Token = "0x600269F")]
	[Address(RVA = "0x636470", Offset = "0x634A70", VA = "0x180636470")]
	private void Update()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			if (this.progress == 1)
			{
				goto IL_0155;
			}
			if (this.progress != 3)
			{
				return;
			}
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			Vector3 vector;
			float z = vector.z;
			float num3 = this.moveSpeed;
			float deltaTime = Time.deltaTime;
			float z2 = vector.z;
			Transform transform3 = base.transform;
			Vector3 vector2;
			float z3 = vector2.z;
			Vector2 vector3 = this.lowerPosition;
			global::UnityEngine.Object.Destroy(base.gameObject, 0.75f);
			int num4 = this.targetRow;
			List<Plant> list = Lawnf.Get1x1Plants(this.targetColumn, num4);
			bool flag;
			if (flag)
			{
				num2++;
				if (!TypeMgr.UncrashablePlant(num))
				{
				}
			}
		}
		while (num2 != 0);
		int num5 = 0;
		int num6 = 0;
		GameAPP.PlaySound(74, 0.5f, 1f);
		ScreenShake.TriggerShake(0.05f);
		BoardAction boardAction = Board.Instance.boardAction;
		if (num2 != 0)
		{
			CreateZombie instance = CreateZombie.Instance;
			float num7 = global::UnityEngine.Random.Range(-0.5f, 0.5f);
			if (num5 >= 3)
			{
				goto IL_0131;
			}
			CreateZombie instance2 = CreateZombie.Instance;
			float num8 = global::UnityEngine.Random.Range(-0.5f, 0.5f);
			num5++;
		}
		CreateZombie instance3 = CreateZombie.Instance;
		float num9 = global::UnityEngine.Random.Range(-0.5f, 0.5f);
		IL_0131:
		ParticleManager instance4 = ParticleManager.Instance;
		Vector3 vector4;
		float z4 = vector4.z;
		ulong num10;
		Particle particle = instance4.SetParticle((ParticleType)((uint)11), num5, num2, num10 != 0UL, (float)num6);
		return;
		IL_0155:
		Transform transform4 = base.transform;
		Transform transform5 = base.transform;
		float num11 = this.moveSpeed;
		float deltaTime2 = Time.deltaTime;
		if (num2 == 0)
		{
		}
		Transform transform6 = base.transform;
		Vector2 vector5 = this.upperPosition;
		base.Invoke("DelayProgress", 0.25f);
		throw new NullReferenceException();
	}

	// Token: 0x060026A0 RID: 9888 RVA: 0x000CA7E4 File Offset: 0x000C89E4
	[Token(Token = "0x60026A0")]
	[Address(RVA = "0x636280", Offset = "0x634880", VA = "0x180636280", Slot = "6")]
	public bool CanAttack(IDamageable target)
	{
		NotImplementedException ex = new NotImplementedException();
		return false;
	}

	// Token: 0x060026A1 RID: 9889 RVA: 0x000CA7F8 File Offset: 0x000C89F8
	[Token(Token = "0x60026A1")]
	[Address(RVA = "0x636EC0", Offset = "0x6354C0", VA = "0x180636EC0")]
	public ZombieSquash()
	{
	}

	// Token: 0x040013A2 RID: 5026
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013A2")]
	public int targetRow;

	// Token: 0x040013A3 RID: 5027
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40013A3")]
	public int targetColumn;

	// Token: 0x040013A4 RID: 5028
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013A4")]
	public bool isMindControl;

	// Token: 0x040013A5 RID: 5029
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40013A5")]
	public ZombieType ZombieType;

	// Token: 0x040013A6 RID: 5030
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013A6")]
	private Vector2 upperPosition;

	// Token: 0x040013A7 RID: 5031
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40013A7")]
	private Vector2 lowerPosition;

	// Token: 0x040013A8 RID: 5032
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40013A8")]
	private readonly float moveSpeed = 5.5f;

	// Token: 0x040013A9 RID: 5033
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40013A9")]
	private int progress;

	// Token: 0x040013AA RID: 5034
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40013AA")]
	public bool jala;
}

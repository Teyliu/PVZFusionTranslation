using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200039E RID: 926
[Token(Token = "0x200039E")]
public class FlyingDragon : MonoBehaviour
{
	// Token: 0x06001102 RID: 4354 RVA: 0x00060A84 File Offset: 0x0005EC84
	[Token(Token = "0x6001102")]
	[Address(RVA = "0x488CA0", Offset = "0x4872A0", VA = "0x180488CA0")]
	private void Awake()
	{
		this.status = (int)((ulong)0L);
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x00060AA8 File Offset: 0x0005ECA8
	[Token(Token = "0x6001103")]
	[Address(RVA = "0x4890B0", Offset = "0x4876B0", VA = "0x1804890B0")]
	private void PositionUpdate()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = this.status;
		if (num != 0)
		{
			if (num != 0)
			{
				if (num != 1)
				{
					goto IL_0147;
				}
				global::UnityEngine.Object.Destroy(base.gameObject);
			}
			Board board = this.board;
			Mouse instance = Mouse.Instance;
			int columnNum = board.columnNum;
			float boxXFromColumn = instance.GetBoxXFromColumn(columnNum);
			int thePlantRow = this.plant.thePlantRow;
			float landY = Mouse.Instance.GetLandY(boxXFromColumn, thePlantRow);
			Transform transform2 = base.transform;
			this.status = (int)((ulong)2L);
			float deltaTime = Time.deltaTime;
			this.speed = deltaTime;
		}
		Mouse instance2 = Mouse.Instance;
		int num2 = 0;
		float boxXFromColumn2 = instance2.GetBoxXFromColumn(num2);
		int thePlantRow2 = this.plant.thePlantRow;
		float landY2 = Mouse.Instance.GetLandY(boxXFromColumn2, thePlantRow2);
		float num3 = this.speed;
		float deltaTime2 = Time.deltaTime;
		this.speed = num3;
		float num4 = Time.deltaTime * 6f;
		this.moreX = num4;
		Transform transform3 = base.transform;
		Mouse instance3 = Mouse.Instance;
		int num5 = 0;
		float boxXFromColumn3 = instance3.GetBoxXFromColumn(num5);
		float num6 = this.speed;
		Animator animator = this.anim;
		this.status = (int)((ulong)1L);
		this.speed = num6;
		animator.SetTrigger("shoot");
		this.attack = true;
		IL_0147:
		Transform transform4 = base.transform;
		Transform transform5 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		float deltaTime3 = Time.deltaTime;
		if (0 == 0)
		{
		}
		Transform transform6 = base.transform;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		float deltaTime4 = Time.deltaTime;
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x00060C48 File Offset: 0x0005EE48
	[Token(Token = "0x6001104")]
	[Address(RVA = "0x489620", Offset = "0x487C20", VA = "0x180489620")]
	private void Update()
	{
		Plant plant = this.plant;
		int num = 0;
		if (!(plant == num))
		{
			this.PositionUpdate();
			return;
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06001105 RID: 4357 RVA: 0x00060C7C File Offset: 0x0005EE7C
	[Token(Token = "0x6001105")]
	[Address(RVA = "0x488D50", Offset = "0x487350", VA = "0x180488D50")]
	private void FixedUpdate()
	{
		int num = 0;
		if ((this.attack ? 1 : 0) != num)
		{
			Plant plant = this.plant;
			int num2 = 0;
			if (plant != num2)
			{
				Transform transform = base.transform;
				int num3 = this.plant.zombieLayer;
				Collider2D[] array;
				if (num < array.Length)
				{
					bool flag;
					if (flag)
					{
						int thePlantRow = this.plant.thePlantRow;
						BoardAction boardAction = this.board.boardAction;
						Plant plant2 = this.plant;
						PlantType thePlantType = plant2.thePlantType;
						int attackDamage = plant2.attackDamage;
					}
					num++;
				}
			}
		}
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x00060D10 File Offset: 0x0005EF10
	[Token(Token = "0x6001106")]
	[Address(RVA = "0x488CF0", Offset = "0x4872F0", VA = "0x180488CF0")]
	private void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06001107 RID: 4359 RVA: 0x00060D28 File Offset: 0x0005EF28
	[Token(Token = "0x6001107")]
	[Address(RVA = "0x489720", Offset = "0x487D20", VA = "0x180489720")]
	public FlyingDragon()
	{
	}

	// Token: 0x04000BEA RID: 3050
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BEA")]
	public Plant plant;

	// Token: 0x04000BEB RID: 3051
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BEB")]
	public Board board;

	// Token: 0x04000BEC RID: 3052
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BEC")]
	private int status;

	// Token: 0x04000BED RID: 3053
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000BED")]
	private float speed = 10f;

	// Token: 0x04000BEE RID: 3054
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BEE")]
	private float moreX;

	// Token: 0x04000BEF RID: 3055
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BEF")]
	private Animator anim;

	// Token: 0x04000BF0 RID: 3056
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000BF0")]
	private bool attack;
}

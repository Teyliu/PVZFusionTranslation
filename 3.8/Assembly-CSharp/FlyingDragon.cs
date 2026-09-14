using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200038B RID: 907
[Token(Token = "0x200038B")]
public class FlyingDragon : MonoBehaviour
{
	// Token: 0x060010A8 RID: 4264 RVA: 0x0005F538 File Offset: 0x0005D738
	[Token(Token = "0x60010A8")]
	[Address(RVA = "0x435400", Offset = "0x433A00", VA = "0x180435400")]
	private void Awake()
	{
		this.status = (int)((ulong)0L);
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x0005F55C File Offset: 0x0005D75C
	[Token(Token = "0x60010A9")]
	[Address(RVA = "0x435810", Offset = "0x433E10", VA = "0x180435810")]
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

	// Token: 0x060010AA RID: 4266 RVA: 0x0005F6FC File Offset: 0x0005D8FC
	[Token(Token = "0x60010AA")]
	[Address(RVA = "0x435D80", Offset = "0x434380", VA = "0x180435D80")]
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

	// Token: 0x060010AB RID: 4267 RVA: 0x0005F730 File Offset: 0x0005D930
	[Token(Token = "0x60010AB")]
	[Address(RVA = "0x4354B0", Offset = "0x433AB0", VA = "0x1804354B0")]
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

	// Token: 0x060010AC RID: 4268 RVA: 0x0005F7C4 File Offset: 0x0005D9C4
	[Token(Token = "0x60010AC")]
	[Address(RVA = "0x435450", Offset = "0x433A50", VA = "0x180435450")]
	private void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x0005F7DC File Offset: 0x0005D9DC
	[Token(Token = "0x60010AD")]
	[Address(RVA = "0x435E80", Offset = "0x434480", VA = "0x180435E80")]
	public FlyingDragon()
	{
	}

	// Token: 0x04000B8F RID: 2959
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B8F")]
	public Plant plant;

	// Token: 0x04000B90 RID: 2960
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B90")]
	public Board board;

	// Token: 0x04000B91 RID: 2961
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B91")]
	private int status;

	// Token: 0x04000B92 RID: 2962
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000B92")]
	private float speed = 10f;

	// Token: 0x04000B93 RID: 2963
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B93")]
	private float moreX;

	// Token: 0x04000B94 RID: 2964
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B94")]
	private Animator anim;

	// Token: 0x04000B95 RID: 2965
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B95")]
	private bool attack;
}

using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000370 RID: 880
[Token(Token = "0x2000370")]
public class CherryLittleFly : UltimateLittleFly
{
	// Token: 0x0600101F RID: 4127 RVA: 0x0005C69C File Offset: 0x0005A89C
	[Token(Token = "0x600101F")]
	[Address(RVA = "0x479480", Offset = "0x477A80", VA = "0x180479480", Slot = "5")]
	protected override void Update()
	{
		int num = 0;
		Plant parentPlant = this.parentPlant;
		int num2 = 0;
		if (!(parentPlant == num2))
		{
			Zombie target = this.target;
			int num3 = 0;
			if (!(target == num3))
			{
				if (this.target.TryGetComponent<Collider2D>(num3))
				{
					Zombie target2 = this.target;
					if (base.CheckZombie(target2))
					{
						Transform axis = this.axis;
						Transform transform = base.transform;
						Transform transform2 = base.transform;
					}
				}
				this.target = num;
			}
			Zombie zombie = base.GetZombie();
			this.target = zombie;
			this.onTarget = num != 0;
			Transform transform3 = base.transform;
			float num4 = this.offset * 5f;
			Transform transform4 = base.transform;
			Transform transform5 = base.transform;
			Transform axis2 = this.parentPlant.axis;
			Vector3 vector;
			float z = vector.z;
			float deltaTime = Time.deltaTime;
			if (num == 0)
			{
			}
			Transform transform6 = base.transform;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			float deltaTime2 = Time.deltaTime;
			Transform axis3 = this.axis;
			Transform transform7 = base.transform;
			Transform transform8 = base.transform;
			Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
			this.Die();
			BoardAction boardAction = Board.Instance.boardAction;
			Transform transform9 = base.transform;
			Zombie target3 = this.target;
			PlantType fromType = this.fromType;
			int num5 = this.dmg;
			Transform transform10 = base.transform;
			Zombie target4 = this.target;
			PlantType fromType2 = this.fromType;
			return;
		}
		this.Die();
		throw new NullReferenceException();
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x0005C814 File Offset: 0x0005AA14
	[Token(Token = "0x6001020")]
	[Address(RVA = "0x479340", Offset = "0x477940", VA = "0x180479340", Slot = "8")]
	public override void Die()
	{
		Plant parentPlant = this.parentPlant;
		int num = 0;
		if (parentPlant != num)
		{
			Plant parentPlant2 = this.parentPlant;
			bool flag;
			if (flag)
			{
				Board instance = Board.Instance;
			}
		}
		Board instance2 = Board.Instance;
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x0005C860 File Offset: 0x0005AA60
	[Token(Token = "0x6001021")]
	[Address(RVA = "0x479C80", Offset = "0x478280", VA = "0x180479C80")]
	public CherryLittleFly()
	{
	}

	// Token: 0x04000BAB RID: 2987
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000BAB")]
	public int dmg;
}

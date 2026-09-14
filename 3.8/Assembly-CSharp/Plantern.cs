using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003FF RID: 1023
[Token(Token = "0x20003FF")]
public class Plantern : Plant
{
	// Token: 0x060012D8 RID: 4824 RVA: 0x0006A298 File Offset: 0x00068498
	[Token(Token = "0x60012D8")]
	[Address(RVA = "0x45C160", Offset = "0x45A760", VA = "0x18045C160", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(85, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		this.lightPos.z = z;
		GameObject light = this.GetLight();
		this.lanternLight = light;
		throw new NullReferenceException();
	}

	// Token: 0x060012D9 RID: 4825 RVA: 0x0006A2EC File Offset: 0x000684EC
	[Token(Token = "0x60012D9")]
	[Address(RVA = "0x45BEA0", Offset = "0x45A4A0", VA = "0x18045BEA0", Slot = "69")]
	protected virtual GameObject GetLight()
	{
		GameObject gameObject = GameAPP.particlePrefab[40];
		float z = this.lightPos.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		return gameObject2;
	}

	// Token: 0x060012DA RID: 4826 RVA: 0x0006A330 File Offset: 0x00068530
	[Token(Token = "0x60012DA")]
	[Address(RVA = "0x447170", Offset = "0x445770", VA = "0x180447170", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Transform transform = this.lanternLight.transform;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x0006A364 File Offset: 0x00068564
	[Token(Token = "0x60012DB")]
	[Address(RVA = "0x45BDE0", Offset = "0x45A3E0", VA = "0x18045BDE0", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		ulong num;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -1, (int)num);
		global::UnityEngine.Object.Destroy(this.lanternLight);
	}

	// Token: 0x060012DC RID: 4828 RVA: 0x0006A3A4 File Offset: 0x000685A4
	[Token(Token = "0x60012DC")]
	[Address(RVA = "0x45C090", Offset = "0x45A690", VA = "0x18045C090", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, originalRow, -1, (int)num);
		ulong num2;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, (int)num2, 1, (int)num);
	}

	// Token: 0x060012DD RID: 4829 RVA: 0x0006A3D4 File Offset: 0x000685D4
	[Token(Token = "0x60012DD")]
	[Address(RVA = "0x45C000", Offset = "0x45A600", VA = "0x18045C000", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(theColumn, theRow, 1, (int)num);
	}

	// Token: 0x060012DE RID: 4830 RVA: 0x0006A3F8 File Offset: 0x000685F8
	[Token(Token = "0x60012DE")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public Plantern()
	{
	}

	// Token: 0x04000C35 RID: 3125
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C35")]
	protected GameObject lanternLight;

	// Token: 0x04000C36 RID: 3126
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C36")]
	protected Vector3 lightPos;
}

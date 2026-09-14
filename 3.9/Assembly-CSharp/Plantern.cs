using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200041A RID: 1050
[Token(Token = "0x200041A")]
public class Plantern : Plant
{
	// Token: 0x0600134E RID: 4942 RVA: 0x0006C0CC File Offset: 0x0006A2CC
	[Token(Token = "0x600134E")]
	[Address(RVA = "0x4B2650", Offset = "0x4B0C50", VA = "0x1804B2650", Slot = "15")]
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

	// Token: 0x0600134F RID: 4943 RVA: 0x0006C120 File Offset: 0x0006A320
	[Token(Token = "0x600134F")]
	[Address(RVA = "0x4B2390", Offset = "0x4B0990", VA = "0x1804B2390", Slot = "68")]
	protected virtual GameObject GetLight()
	{
		GameObject gameObject = GameAPP.particlePrefab[40];
		float z = this.lightPos.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		return gameObject2;
	}

	// Token: 0x06001350 RID: 4944 RVA: 0x0006C164 File Offset: 0x0006A364
	[Token(Token = "0x6001350")]
	[Address(RVA = "0x49B600", Offset = "0x499C00", VA = "0x18049B600", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Transform transform = this.lanternLight.transform;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06001351 RID: 4945 RVA: 0x0006C198 File Offset: 0x0006A398
	[Token(Token = "0x6001351")]
	[Address(RVA = "0x4B22D0", Offset = "0x4B08D0", VA = "0x1804B22D0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		ulong num;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -1, (int)num);
		global::UnityEngine.Object.Destroy(this.lanternLight);
	}

	// Token: 0x06001352 RID: 4946 RVA: 0x0006C1D8 File Offset: 0x0006A3D8
	[Token(Token = "0x6001352")]
	[Address(RVA = "0x4B2580", Offset = "0x4B0B80", VA = "0x1804B2580", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, originalRow, -1, (int)num);
		ulong num2;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, (int)num2, 1, (int)num);
	}

	// Token: 0x06001353 RID: 4947 RVA: 0x0006C208 File Offset: 0x0006A408
	[Token(Token = "0x6001353")]
	[Address(RVA = "0x4B24F0", Offset = "0x4B0AF0", VA = "0x1804B24F0", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(theColumn, theRow, 1, (int)num);
	}

	// Token: 0x06001354 RID: 4948 RVA: 0x0006C22C File Offset: 0x0006A42C
	[Token(Token = "0x6001354")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public Plantern()
	{
	}

	// Token: 0x04000CB0 RID: 3248
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CB0")]
	protected GameObject lanternLight;

	// Token: 0x04000CB1 RID: 3249
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000CB1")]
	protected Vector3 lightPos;
}

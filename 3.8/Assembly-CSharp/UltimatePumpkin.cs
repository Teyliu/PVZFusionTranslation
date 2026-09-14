using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200048A RID: 1162
[Token(Token = "0x200048A")]
public class UltimatePumpkin : SuperPumpkin
{
	// Token: 0x060015B1 RID: 5553 RVA: 0x000783B0 File Offset: 0x000765B0
	[Token(Token = "0x60015B1")]
	[Address(RVA = "0x491DA0", Offset = "0x4903A0", VA = "0x180491DA0")]
	private void Samer()
	{
		List<Plant> plants = MagnetSystem.GetPlants(this);
		Predicate<Plant> <>9__1_ = UltimatePumpkin.<>c.<>9__1_0;
		if (<>9__1_ == 0)
		{
			Predicate<Plant> predicate;
			UltimatePumpkin.<>c.<>9__1_0 = predicate;
		}
		List<Plant> list = plants.FindAll(<>9__1_);
		int size = list._size;
		int num = size - 1;
		if (size > 1)
		{
			Plant plant = list[num];
			int num2 = 0;
			plant.Die((Plant.DieReason)num2);
			CreatePlant instance = CreatePlant.Instance;
			Transform axis = plant.axis;
			Vector3 vector;
			float z = vector.z;
		}
	}

	// Token: 0x060015B2 RID: 5554 RVA: 0x0007842C File Offset: 0x0007662C
	[Token(Token = "0x60015B2")]
	[Address(RVA = "0x4910B0", Offset = "0x48F6B0", VA = "0x1804910B0", Slot = "40")]
	protected override void AttributeEvent()
	{
		int num;
		bool flag;
		do
		{
			this.Samer();
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			num = 0;
			if (flag)
			{
				int num2 = 0;
				CreatePlant instance = CreatePlant.Instance;
				float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(num2);
				float boxYFromRow = Mouse.Instance.GetBoxYFromRow(num2);
				Board board = this.board;
				base.AttributeCountdown = 30f;
			}
		}
		while (num != 0);
		num++;
		num++;
		CreatePlant instance2 = CreatePlant.Instance;
		int num3 = 0;
		Plant plant;
		if (!(plant != num3))
		{
			num++;
		}
		int num4 = 0;
		ulong num5;
		bool flag2 = plant.Upgrade(num3, num5 != 0UL, num4 != 0);
		float boxXFromColumn2 = Mouse.Instance.GetBoxXFromColumn(flag ? 1 : 0);
		float boxYFromRow2 = Mouse.Instance.GetBoxYFromRow(num);
	}

	// Token: 0x060015B3 RID: 5555 RVA: 0x00078528 File Offset: 0x00076728
	[Token(Token = "0x60015B3")]
	[Address(RVA = "0x491620", Offset = "0x48FC20", VA = "0x180491620", Slot = "70")]
	protected override void CreateFly()
	{
		GameObject gameObject = this.GetFly();
		LittleFly littleFly = this.littleFly;
		int num = 0;
		if (littleFly == num)
		{
			Transform axis = this.axis;
			float num2 = global::UnityEngine.Random.Range(1.3f, 1.5f);
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
			GameObject gameObject2;
			LittleFly component = gameObject2.GetComponent<LittleFly>();
			this.littleFly = component;
			LittleFly littleFly2 = this.littleFly;
			int thePlantRow = this.thePlantRow;
			littleFly2.theFlyRow = thePlantRow;
			this.littleFly.parentPlant = this;
			LittleFly littleFly3 = this.littleFly;
			PlantType thePlantType = this.thePlantType;
			littleFly3.fromType = thePlantType;
		}
		bool flag;
		if (flag)
		{
			LittleFly littleFly4 = this.littleFly2;
			int num3 = 0;
			if (littleFly4 == num3)
			{
				Transform axis2 = this.axis;
				float num4 = global::UnityEngine.Random.Range(1.3f, 1.5f);
				Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
				Transform transform2 = this.board.transform;
				GameObject gameObject3;
				LittleFly component2 = gameObject3.GetComponent<LittleFly>();
				this.littleFly2 = component2;
				LittleFly littleFly5 = this.littleFly2;
				int thePlantRow2 = this.thePlantRow;
				littleFly5.theFlyRow = thePlantRow2;
				this.littleFly2.parentPlant = this;
				this.littleFly2.positionOffset = 0.3f;
				LittleFly littleFly6 = this.littleFly2;
				PlantType thePlantType2 = this.thePlantType;
				littleFly6.fromType = thePlantType2;
			}
			LittleFly littleFly7 = this.littleFly3;
			int num5 = 0;
			if (littleFly7 == num5)
			{
				Transform axis3 = this.axis;
				float num6 = global::UnityEngine.Random.Range(1.3f, 1.5f);
				Quaternion identityQuaternion3 = Quaternion.identityQuaternion;
				Transform transform3 = this.board.transform;
				GameObject gameObject4;
				LittleFly component3 = gameObject4.GetComponent<LittleFly>();
				this.littleFly3 = component3;
				LittleFly littleFly8 = this.littleFly3;
				int thePlantRow3 = this.thePlantRow;
				littleFly8.theFlyRow = thePlantRow3;
				this.littleFly3.parentPlant = this;
				this.littleFly3.positionOffset = 0.6f;
				LittleFly littleFly9 = this.littleFly3;
				PlantType thePlantType3 = this.thePlantType;
				littleFly9.fromType = thePlantType3;
			}
		}
	}

	// Token: 0x060015B4 RID: 5556 RVA: 0x00078728 File Offset: 0x00076928
	[Token(Token = "0x60015B4")]
	[Address(RVA = "0x4920A0", Offset = "0x4906A0", VA = "0x1804920A0")]
	public void Supplement()
	{
		GameObject gameObject = this.GetFly();
		LittleFly littleFly = this.littleFly2;
		int num = 0;
		if (littleFly == num)
		{
			Transform axis = this.axis;
			float num2 = global::UnityEngine.Random.Range(1.3f, 1.5f);
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
			GameObject gameObject2;
			LittleFly component = gameObject2.GetComponent<LittleFly>();
			this.littleFly2 = component;
			LittleFly littleFly2 = this.littleFly2;
			int thePlantRow = this.thePlantRow;
			littleFly2.theFlyRow = thePlantRow;
			this.littleFly2.parentPlant = this;
			this.littleFly2.positionOffset = 0.3f;
			LittleFly littleFly3 = this.littleFly2;
			PlantType thePlantType = this.thePlantType;
			littleFly3.fromType = thePlantType;
		}
		LittleFly littleFly4 = this.littleFly3;
		int num3 = 0;
		if (littleFly4 == num3)
		{
			Transform axis2 = this.axis;
			float num4 = global::UnityEngine.Random.Range(1.3f, 1.5f);
			Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
			Transform transform2 = this.board.transform;
			GameObject gameObject3;
			LittleFly component2 = gameObject3.GetComponent<LittleFly>();
			this.littleFly3 = component2;
			LittleFly littleFly5 = this.littleFly3;
			int thePlantRow2 = this.thePlantRow;
			littleFly5.theFlyRow = thePlantRow2;
			this.littleFly3.parentPlant = this;
			this.littleFly3.positionOffset = 0.6f;
			LittleFly littleFly6 = this.littleFly3;
			PlantType thePlantType2 = this.thePlantType;
			littleFly6.fromType = thePlantType2;
		}
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x0007888C File Offset: 0x00076A8C
	[Token(Token = "0x60015B5")]
	[Address(RVA = "0x491C10", Offset = "0x490210", VA = "0x180491C10", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		LittleFly littleFly = this.littleFly2;
		int num = 0;
		if (littleFly != num)
		{
			this.littleFly2.Die();
		}
		LittleFly littleFly2 = this.littleFly3;
		int num2 = 0;
		if (littleFly2 != num2)
		{
			this.littleFly3.Die();
		}
	}

	// Token: 0x060015B6 RID: 5558 RVA: 0x000788DC File Offset: 0x00076ADC
	[Token(Token = "0x60015B6")]
	[Address(RVA = "0x491D00", Offset = "0x490300", VA = "0x180491D00", Slot = "71")]
	protected override GameObject GetFly()
	{
		GameObject gameObject = this.fly;
		int num = 0;
		if (!(gameObject != num))
		{
			return Resources.Load<GameObject>("Plants/Pumpkin/UltimatePumpkin/UltimateLittleFly");
		}
		return this.fly;
	}

	// Token: 0x060015B7 RID: 5559 RVA: 0x00078910 File Offset: 0x00076B10
	[Token(Token = "0x60015B7")]
	[Address(RVA = "0x433500", Offset = "0x431B00", VA = "0x180433500")]
	public UltimatePumpkin()
	{
	}

	// Token: 0x04000D49 RID: 3401
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000D49")]
	public GameObject fly;
}

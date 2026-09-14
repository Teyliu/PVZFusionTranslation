using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004AC RID: 1196
[Token(Token = "0x20004AC")]
public class UltimatePumpkin : SuperPumpkin
{
	// Token: 0x06001651 RID: 5713 RVA: 0x0007AD34 File Offset: 0x00078F34
	[Token(Token = "0x6001651")]
	[Address(RVA = "0x4EB250", Offset = "0x4E9850", VA = "0x1804EB250")]
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

	// Token: 0x06001652 RID: 5714 RVA: 0x0007ADB0 File Offset: 0x00078FB0
	[Token(Token = "0x6001652")]
	[Address(RVA = "0x4EA560", Offset = "0x4E8B60", VA = "0x1804EA560", Slot = "39")]
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

	// Token: 0x06001653 RID: 5715 RVA: 0x0007AEAC File Offset: 0x000790AC
	[Token(Token = "0x6001653")]
	[Address(RVA = "0x4EAAD0", Offset = "0x4E90D0", VA = "0x1804EAAD0", Slot = "69")]
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

	// Token: 0x06001654 RID: 5716 RVA: 0x0007B0AC File Offset: 0x000792AC
	[Token(Token = "0x6001654")]
	[Address(RVA = "0x4EB550", Offset = "0x4E9B50", VA = "0x1804EB550")]
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

	// Token: 0x06001655 RID: 5717 RVA: 0x0007B210 File Offset: 0x00079410
	[Token(Token = "0x6001655")]
	[Address(RVA = "0x4EB0C0", Offset = "0x4E96C0", VA = "0x1804EB0C0", Slot = "52")]
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

	// Token: 0x06001656 RID: 5718 RVA: 0x0007B260 File Offset: 0x00079460
	[Token(Token = "0x6001656")]
	[Address(RVA = "0x4EB1B0", Offset = "0x4E97B0", VA = "0x1804EB1B0", Slot = "70")]
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

	// Token: 0x06001657 RID: 5719 RVA: 0x0007B294 File Offset: 0x00079494
	[Token(Token = "0x6001657")]
	[Address(RVA = "0x471840", Offset = "0x46FE40", VA = "0x180471840")]
	public UltimatePumpkin()
	{
	}

	// Token: 0x04000DE2 RID: 3554
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000DE2")]
	public GameObject fly;
}

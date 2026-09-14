using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Tilemaps;

// Token: 0x02000755 RID: 1877
[Token(Token = "0x2000755")]
public class Garden : MonoBehaviour
{
	// Token: 0x06002615 RID: 9749 RVA: 0x000CA0AC File Offset: 0x000C82AC
	[Token(Token = "0x6002615")]
	[Address(RVA = "0x5DD810", Offset = "0x5DBE10", VA = "0x1805DD810")]
	private void Awake()
	{
		Garden.Instance = this;
		this.LoadPlants();
		this.LoadEquipments();
		this.free = true;
	}

	// Token: 0x06002616 RID: 9750 RVA: 0x000CA0D4 File Offset: 0x000C82D4
	[Token(Token = "0x6002616")]
	[Address(RVA = "0x5E2440", Offset = "0x5E0A40", VA = "0x1805E2440")]
	private void Update()
	{
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		Tilemap tilemap = this.tilemap;
		int num = 0;
		Vector3Int vector3Int;
		int z2 = vector3Int.m_Z;
		this.mouseCell = z2;
		this.MouseInputCheck();
		this.MouseUpdate();
		if (this.freeBoxFlashTimer > (float)num)
		{
			float num2 = Time.time * 8f * 0.15f;
			if (num > (int)num2 || num2 > 0.3f)
			{
			}
			Tilemap tilemap2 = this.freeBox;
			float num3 = this.freeBoxFlashTimer;
			float deltaTime = Time.deltaTime;
			this.freeBoxFlashTimer = num3;
			this.freeBoxFlashTimer = 0f;
			Tilemap tilemap3 = this.freeBox;
		}
	}

	// Token: 0x06002617 RID: 9751 RVA: 0x000CA188 File Offset: 0x000C8388
	[Token(Token = "0x6002617")]
	[Address(RVA = "0x5DD880", Offset = "0x5DBE80", VA = "0x1805DD880")]
	private void FlashUpdate()
	{
		float num = Time.time * 8f;
		int num2 = 0;
		float num3 = num * 0.15f;
		if (num2 > (int)num3 || num3 > 0.3f)
		{
		}
		Tilemap tilemap = this.freeBox;
		float num4 = this.freeBoxFlashTimer;
		float deltaTime = Time.deltaTime;
		this.freeBoxFlashTimer = num4;
		this.freeBoxFlashTimer = 0f;
		Tilemap tilemap2 = this.freeBox;
	}

	// Token: 0x06002618 RID: 9752 RVA: 0x000CA1F8 File Offset: 0x000C83F8
	[Token(Token = "0x6002618")]
	[Address(RVA = "0x5DFA20", Offset = "0x5DE020", VA = "0x1805DFA20")]
	private void MouseUpdate()
	{
		GameObject gameObject = this.frameRange;
		int num = 0;
		bool flag = gameObject != num;
		int num2 = 0;
		if (flag)
		{
			Tilemap tilemap = this.tilemap;
			Vector2Int vector2Int = this.mouseStartCell;
			Tilemap tilemap2 = this.tilemap;
			Vector2Int vector2Int2 = this.mouseCell;
			GameObject gameObject2 = this.frameRange;
			int num3 = 0;
			gameObject2.transform.position = num3;
			GameObject gameObject3 = this.frameRange;
			int num4 = 0;
			Transform transform = gameObject3.transform;
			Vector2Int vector2Int3 = this.mouseStartCell;
			int num6;
			int num5 = num6 + 1;
			num5++;
			transform.localScale = num4;
		}
		GameObject gameObject4 = this.previewFollowMouse;
		int num7 = 0;
		if (gameObject4 != num7)
		{
			GameObject gameObject5 = this.previewFollowMouse;
			int num8 = 0;
			gameObject5.transform.position = num8;
		}
		GameObject gameObject6 = this.previewOnWorld;
		int num9 = 0;
		if (gameObject6 != num9)
		{
			Transform transform2 = this.previewOnWorld.transform;
		}
		BaseTool baseTool = this.toolOnMouse;
		int num10 = 0;
		if (!(baseTool != num10))
		{
			BigGardenPlant bigGardenPlant = this.highLightPlant;
			int num11 = 0;
			if (bigGardenPlant != num11)
			{
				this.highLightPlant.HighLight(1f);
				this.highLightPlant = num2;
			}
			GardenEquipment gardenEquipment = this.highLightEquipment;
			int num12 = 0;
			if (gardenEquipment != num12)
			{
				GameMaterial.SetBrightness(this.highLightEquipment.spriteRenderers, 1f);
				this.highLightEquipment = num2;
			}
			return;
		}
		GameObject gameObject7;
		Transform transform3 = gameObject7.transform;
		int num13 = 0;
		GameObject gameObject8;
		gameObject8.transform.position = num13;
		throw new NullReferenceException();
	}

	// Token: 0x06002619 RID: 9753 RVA: 0x000CA374 File Offset: 0x000C8574
	[Token(Token = "0x6002619")]
	[Address(RVA = "0x5DDC60", Offset = "0x5DC260", VA = "0x1805DDC60")]
	private void HighLightUpdate()
	{
		for (;;)
		{
			BigGardenPlant bigGardenPlant = this.highLightPlant;
			int num = 0;
			if (bigGardenPlant == num)
			{
				goto IL_0039;
			}
			BigGardenPlant bigGardenPlant2;
			if (this.highLightPlant != bigGardenPlant2)
			{
				this.highLightPlant.HighLight(1f);
				this.highLightPlant = bigGardenPlant2;
				goto IL_0039;
			}
			IL_0067:
			GardenEquipment gardenEquipment = this.highLightEquipment;
			int num2 = 0;
			if (!(gardenEquipment == num2))
			{
				break;
			}
			int num3 = 0;
			GardenEquipment gardenEquipment2;
			if (gardenEquipment2 != num3)
			{
				goto Block_6;
			}
			continue;
			IL_0039:
			BigGardenPlant bigGardenPlant3;
			this.highLightPlant = bigGardenPlant3;
			BigGardenPlant bigGardenPlant4 = this.highLightPlant;
			int num4 = 0;
			if (bigGardenPlant4 != num4)
			{
				this.highLightPlant.HighLight(2.4f);
				goto IL_0067;
			}
			goto IL_0067;
		}
		GardenEquipment gardenEquipment3;
		if (this.highLightEquipment != gardenEquipment3)
		{
			GameMaterial.SetBrightness(this.highLightEquipment.spriteRenderers, 1f);
			this.highLightEquipment = gardenEquipment3;
			GardenEquipment gardenEquipment2 = this.highLightEquipment;
			int num5 = 0;
			if (gardenEquipment2 != num5)
			{
				GardenEquipment gardenEquipment4 = this.highLightEquipment;
				gardenEquipment4.HighLight(2.4f);
			}
		}
		return;
		Block_6:
		throw new NullReferenceException();
	}

	// Token: 0x0600261A RID: 9754 RVA: 0x000CA474 File Offset: 0x000C8674
	[Token(Token = "0x600261A")]
	[Address(RVA = "0x5DE770", Offset = "0x5DCD70", VA = "0x1805DE770")]
	private void MouseInputCheck()
	{
		int num = 0;
		if (Input.GetMouseButtonDown(0))
		{
			if ((this.free ? 1 : 0) == num)
			{
				GardenCard gardenCard = this.cardOnMouse;
				int num2 = 0;
				if (!(gardenCard != num2))
				{
					PropCard propCard = this.propCardOnMouse;
					int num3 = 0;
					if (!(propCard != num3))
					{
						BigGardenPlant bigGardenPlant = this.plantOnMouse;
						int num4 = 0;
						if (!(bigGardenPlant != num4))
						{
							GardenEquipment gardenEquipment = this.equipmentOnMouse;
							int num5 = 0;
							if (!(gardenEquipment != num5))
							{
								List<BigGardenPlant> list = this.plantOnFrame;
								BaseTool baseTool = this.toolOnMouse;
								int num6 = 0;
								if (!(baseTool != num6))
								{
									goto IL_0491;
								}
								if (this.toolOnMouse != 0)
								{
									Vector2Int vector2Int = this.mouseCell;
									this.mouseStartCell = vector2Int;
									this.framing = true;
									GameObject gameObject = Resources.Load<GameObject>("Garden/Equip/AutoRange/FrameRange");
									Quaternion identityQuaternion = Quaternion.identityQuaternion;
									Transform transform = base.transform;
									GameObject gameObject2;
									this.frameRange = gameObject2;
								}
								this.free = true;
								int num7 = 0;
								BigGardenPlant bigGardenPlant2;
								if (!(bigGardenPlant2 != num7))
								{
									int num8 = 0;
									GardenEquipment gardenEquipment2;
									if (!(gardenEquipment2 != num8))
									{
										goto IL_0127;
									}
									this.toolOnMouse.Use(gardenEquipment2);
								}
								this.toolOnMouse.Use(bigGardenPlant2);
								IL_0127:
								this.toolOnMouse.PutDown();
								this.toolOnMouse = num;
								uint num9;
								GameAPP.PlaySound((int)num9, 0.5f, 1f);
								this.MoveFrame();
							}
							bool flag;
							if (!flag)
							{
								goto IL_0491;
							}
						}
						BigGardenPlant bigGardenPlant3 = this.plantOnMouse;
						bool flag2;
						if (!flag2)
						{
							goto IL_0491;
						}
					}
					bool flag3;
					if (!flag3)
					{
						goto IL_0491;
					}
					PropCard propCard2 = this.propCardOnMouse;
					Vector2Int vector2Int2 = this.mouseCell;
					int y = this.mouseCell.m_Y;
					EquipmentData data = propCard2.data;
					data.theColumn = vector2Int2;
					data.theRow = y;
					data.set = true;
					GameObject shadow = propCard2.shadow;
					int num10 = 0;
					shadow.SetActive(num10 != 0);
					GardenEquipment gardenEquipment3 = GardenEquipment.SetEquipment(this, data);
					GameObject gameObject3 = GameAPP.particlePrefab[1];
					Transform transform2 = gardenEquipment3.transform;
					Vector3 vector;
					float z = vector.z;
					Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
					Transform transform3 = base.transform;
					uint num11;
					GameAPP.PlaySound((int)num11, 0.5f, 1f);
					propCard2.UseOnce();
					this.propCardOnMouse = num;
					global::UnityEngine.Object.Destroy(this.previewFollowMouse);
					global::UnityEngine.Object.Destroy(this.previewOnWorld);
					this.free = true;
					SaveInfo.Instance.SavePlayerData();
				}
				TreasureCardData data2 = this.cardOnMouse.data;
				bool flag4;
				if (!flag4)
				{
					goto IL_0491;
				}
				GardenCard gardenCard2 = this.cardOnMouse;
				Vector2Int vector2Int3 = this.mouseCell;
				int y2 = this.mouseCell.m_Y;
				PlantType thePlantType = gardenCard2.data.thePlantType;
				int x = vector2Int3.m_X;
				BigGardenPlant bigGardenPlant4 = BigGardenPlant.CreatePlant(this, thePlantType, x, y2);
				Tilemap tilemap = this.waterBox;
				bool flag5;
				if (!flag5)
				{
					GameObject gameObject4 = GameAPP.particlePrefab[1];
					Transform transform4 = bigGardenPlant4.transform;
					Quaternion identityQuaternion3 = Quaternion.identityQuaternion;
					Transform transform5 = base.transform;
					uint num12;
					GameAPP.PlaySound((int)num12, 0.5f, 1f);
				}
				GameObject gameObject5 = GameAPP.particlePrefab[32];
				Transform transform6 = bigGardenPlant4.transform;
				Quaternion identityQuaternion4 = Quaternion.identityQuaternion;
				Transform transform7 = base.transform;
				gardenCard2.data.LoadGarden(bigGardenPlant4);
				gardenCard2.data.inGraden = true;
				gardenCard2.data.theColumn = vector2Int3;
				gardenCard2.data.theRow = y2;
				TreasureCardData data3 = gardenCard2.data;
				bigGardenPlant4.data = data3;
				global::UnityEngine.Object.Destroy(this.previewFollowMouse);
				global::UnityEngine.Object.Destroy(this.previewOnWorld);
				global::UnityEngine.Object.Destroy(gardenCard2.gameObject);
				this.free = true;
				SaveInfo.Instance.SavePlayerData();
			}
			Vector2 zeroVector = Vector2.zeroVector;
			RaycastHit2D[] array;
			if (num < array.Length)
			{
				Collider2D collider2D;
				if (collider2D.TryGetComponent<UIButton>(num))
				{
					return;
				}
				num++;
			}
			if (num < array.Length)
			{
				Collider2D collider2D2;
				if (!collider2D2.TryGetComponent<GardenCard>(num))
				{
					Collider2D collider2D3;
					if (!collider2D3.TryGetComponent<BaseTool>(num))
					{
						int num13 = 0;
						Collider2D collider2D4;
						if (!collider2D4.TryGetComponent<PropCard>(num13))
						{
							num++;
						}
						int num14 = 0;
						bool flag6;
						if (flag6)
						{
							this.propCardOnMouse = num14;
							uint num15;
							GameAPP.PlaySound((int)num15, 0.5f, 1f);
							this.free = num != 0;
						}
						uint num16;
						GameAPP.PlaySound((int)num16, 0.5f, 1f);
					}
					this.toolOnMouse = num;
					this.free = num != 0;
					uint num17;
					GameAPP.PlaySound((int)num17, 0.5f, 1f);
				}
				this.cardOnMouse = num;
				CursorChange.SetDefaultCursor();
				uint num18;
				GameAPP.PlaySound((int)num18, 0.5f, 1f);
				this.free = num != 0;
			}
			if (this.ui.Interactable)
			{
				int num19 = 0;
				BigGardenPlant bigGardenPlant5;
				if (!(bigGardenPlant5 != num19))
				{
					int num20 = 0;
					GardenEquipment gardenEquipment4;
					if (!(gardenEquipment4 != num20))
					{
						goto IL_0491;
					}
					UIResourcesLoader uimanager = GameAPP.UIManager;
				}
				UIResourcesLoader uimanager2 = GameAPP.UIManager;
			}
		}
		IL_0491:
		if (Input.GetMouseButtonUp(0) && this.framing)
		{
			BaseTool baseTool2 = this.toolOnMouse;
			if (baseTool2 != 0)
			{
				Vector2Int vector2Int4 = this.mouseCell;
				this.mouseEndCell = vector2Int4;
				baseTool2.PutDown();
				this.toolOnMouse = num;
				uint num21;
				GameAPP.PlaySound((int)num21, 0.5f, 1f);
				this.SelectFrame();
			}
			global::UnityEngine.Object.Destroy(this.frameRange);
		}
		uint num22;
		if (Input.GetMouseButtonDown((int)num22))
		{
			this.RightClick();
		}
	}

	// Token: 0x0600261B RID: 9755 RVA: 0x000CA988 File Offset: 0x000C8B88
	[Token(Token = "0x600261B")]
	[Address(RVA = "0x5E1020", Offset = "0x5DF620", VA = "0x1805E1020")]
	private void SelectFrame()
	{
		Vector2Int vector2Int = this.mouseStartCell;
		Vector2Int vector2Int2 = this.mouseEndCell;
		int i;
		if (vector2Int >= vector2Int2)
		{
			i = vector2Int2.m_X;
		}
		int x;
		if (this.mouseStartCell <= vector2Int2)
		{
			x = vector2Int2.m_X;
		}
		int j = this.mouseStartCell.m_Y;
		int y = this.mouseEndCell.m_Y;
		if (j >= y)
		{
			j = y;
		}
		int num = this.mouseStartCell.m_Y;
		if (num <= y)
		{
			num = y;
		}
		BigGardenPlant plant = this.GetPlant(i, j);
		int num2 = 0;
		if (plant != num2)
		{
			List<BigGardenPlant> list = this.plantOnFrame;
		}
		j++;
		while (j <= num)
		{
		}
		i++;
		while (i <= x)
		{
		}
		List<BigGardenPlant> list2 = this.plantOnFrame;
		this.free = true;
		this.framing = false;
	}

	// Token: 0x0600261C RID: 9756 RVA: 0x000CAB2C File Offset: 0x000C8D2C
	[Token(Token = "0x600261C")]
	[Address(RVA = "0x5E0BA0", Offset = "0x5DF1A0", VA = "0x1805E0BA0")]
	private void RightClick()
	{
		GardenCard gardenCard = this.cardOnMouse;
		int num = 0;
		bool flag = gardenCard != num;
		int num2 = 0;
		if (flag)
		{
			GameAPP.PlaySound(20, 0.5f, 1f);
			GameObject shadow = this.cardOnMouse.shadow;
			int num3 = 0;
			shadow.SetActive(num3 != 0);
			this.cardOnMouse = num2;
			global::UnityEngine.Object.Destroy(this.previewFollowMouse);
			global::UnityEngine.Object.Destroy(this.previewOnWorld);
			this.free = true;
		}
		BaseTool baseTool = this.toolOnMouse;
		int num4 = 0;
		if (baseTool != num4)
		{
			GameAPP.PlaySound(20, 0.5f, 1f);
			this.toolOnMouse.PutDown();
			this.toolOnMouse = num2;
			this.free = true;
		}
		PropCard propCard = this.propCardOnMouse;
		int num5 = 0;
		if (propCard != num5)
		{
			GameAPP.PlaySound(20, 0.5f, 1f);
			GameObject shadow2 = this.propCardOnMouse.shadow;
			int num6 = 0;
			shadow2.SetActive(num6 != 0);
			this.propCardOnMouse = num2;
			global::UnityEngine.Object.Destroy(this.previewFollowMouse);
			global::UnityEngine.Object.Destroy(this.previewOnWorld);
			this.free = true;
		}
		BigGardenPlant bigGardenPlant = this.plantOnMouse;
		int num7 = 0;
		if (bigGardenPlant != num7)
		{
			GameAPP.PlaySound(20, 0.5f, 1f);
			this.plantOnMouse = num2;
			global::UnityEngine.Object.Destroy(this.previewFollowMouse);
			global::UnityEngine.Object.Destroy(this.previewOnWorld);
			this.free = true;
		}
		List<BigGardenPlant> list = this.plantOnFrame;
		this.framing = num2 != 0;
		int size = list._size;
		list._size = num2;
		if (size > 0)
		{
		}
		GameAPP.PlaySound(20, 0.5f, 1f);
		global::UnityEngine.Object.Destroy(this.previewFollowMouse);
		global::UnityEngine.Object.Destroy(this.previewOnWorld);
		this.free = true;
		GardenEquipment gardenEquipment = this.equipmentOnMouse;
		int num8 = 0;
		if (gardenEquipment != num8)
		{
			GameAPP.PlaySound(20, 0.5f, 1f);
			this.equipmentOnMouse = num2;
			global::UnityEngine.Object.Destroy(this.previewFollowMouse);
			global::UnityEngine.Object.Destroy(this.previewOnWorld);
			this.free = true;
		}
	}

	// Token: 0x0600261D RID: 9757 RVA: 0x000CAD3C File Offset: 0x000C8F3C
	[Token(Token = "0x600261D")]
	[Address(RVA = "0x5E17A0", Offset = "0x5DFDA0", VA = "0x1805E17A0")]
	private void SetPlantByCard(GardenCard card, int theColumn, int theRow)
	{
		PlantType thePlantType = card.data.thePlantType;
		BigGardenPlant bigGardenPlant = BigGardenPlant.CreatePlant(this, thePlantType, theColumn, theRow);
		Tilemap tilemap = this.waterBox;
		bool flag;
		if (!flag)
		{
			GameObject gameObject = GameAPP.particlePrefab[1];
			Transform transform = bigGardenPlant.transform;
			Vector3 vector;
			float z = vector.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform2 = base.transform;
			GameAPP.PlaySound(22, 0.5f, 1f);
		}
		GameObject gameObject2 = GameAPP.particlePrefab[32];
		Transform transform3 = bigGardenPlant.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
		Transform transform4 = base.transform;
		GameAPP.PlaySound((SoundType)((uint)24), 0.5f, 1f);
		card.data.LoadGarden(bigGardenPlant);
		card.data.inGraden = true;
		card.data.theColumn = theColumn;
		card.data.theRow = theRow;
		TreasureCardData data = card.data;
		bigGardenPlant.data = data;
		global::UnityEngine.Object.Destroy(this.previewFollowMouse);
		global::UnityEngine.Object.Destroy(this.previewOnWorld);
		global::UnityEngine.Object.Destroy(card.gameObject);
		this.free = true;
		SaveInfo.Instance.SavePlayerData();
	}

	// Token: 0x0600261E RID: 9758 RVA: 0x000CAE64 File Offset: 0x000C9064
	[Token(Token = "0x600261E")]
	[Address(RVA = "0x5E21E0", Offset = "0x5E07E0", VA = "0x1805E21E0")]
	private void SetPropByCard(PropCard card, int theColumn, int theRow)
	{
		EquipmentData data = card.data;
		data.theColumn = theColumn;
		data.theRow = theRow;
		data.set = true;
		GameObject shadow = card.shadow;
		int num = 0;
		shadow.SetActive(num != 0);
		GardenEquipment gardenEquipment = GardenEquipment.SetEquipment(this, data);
		GameObject gameObject = GameAPP.particlePrefab[1];
		Transform transform = gardenEquipment.transform;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform2 = base.transform;
		GameAPP.PlaySound(22, 0.5f, 1f);
		card.UseOnce();
		this.propCardOnMouse = (ulong)0L;
		global::UnityEngine.Object.Destroy(this.previewFollowMouse);
		global::UnityEngine.Object.Destroy(this.previewOnWorld);
		this.free = true;
		SaveInfo.Instance.SavePlayerData();
	}

	// Token: 0x0600261F RID: 9759 RVA: 0x000CAF20 File Offset: 0x000C9120
	[Token(Token = "0x600261F")]
	[Address(RVA = "0x5E0660", Offset = "0x5DEC60", VA = "0x1805E0660")]
	private void MovePlantByGlove(BigGardenPlant plant, int theColumn, int theRow)
	{
		int num = 0;
		TreasureCardData data = plant.data;
		int theRow2 = data.theRow;
		int theColumn2 = data.theColumn;
		Dictionary<ValueTuple<int, int>, BigGardenPlant> dictionary = this.plants;
		Dictionary<ValueTuple<int, int>, BigGardenPlant> dictionary2 = this.plants;
		bool flag;
		if (flag)
		{
			GameObject gameObject;
			global::UnityEngine.Object.Destroy(gameObject);
		}
		Dictionary<ValueTuple<int, int>, BigGardenPlant> dictionary3 = this.plants;
		Transform transform = plant.transform;
		plant.data.theColumn = theColumn;
		plant.data.theRow = theRow;
		plant.theColumn = theColumn;
		plant.theRow = theRow;
		Tilemap tilemap = this.waterBox;
		bool flag2;
		Transform transform3;
		if (!flag2)
		{
			GameObject gameObject2 = GameAPP.particlePrefab[1];
			Transform transform2 = plant.transform;
			transform3 = base.transform;
			GameAPP.PlaySound(22, 0.5f, 1f);
		}
		GameObject gameObject3 = GameAPP.particlePrefab[32];
		Transform transform4 = transform3.transform;
		Vector3 position = transform3.position;
		Transform transform5 = base.transform;
		GameAPP.PlaySound((SoundType)((uint)24), 0.5f, 1f);
		SaveInfo.Instance.SavePlayerData();
		this.plantOnMouse = num;
		global::UnityEngine.Object.Destroy(this.previewFollowMouse);
		global::UnityEngine.Object.Destroy(this.previewOnWorld);
		this.free = true;
	}

	// Token: 0x06002620 RID: 9760 RVA: 0x000CB044 File Offset: 0x000C9244
	[Token(Token = "0x6002620")]
	[Address(RVA = "0x5DFFA0", Offset = "0x5DE5A0", VA = "0x1805DFFA0")]
	private void MoveEquipmentByGlove(GardenEquipment equipment, int theColumn, int theRow)
	{
		int num = 0;
		EquipmentData data = equipment.data;
		int theRow2 = data.theRow;
		int theColumn2 = data.theColumn;
		bool flag = this.equipments.Remove(num);
		Dictionary<ValueTuple<int, int>, GardenEquipment> dictionary = this.equipments;
		if (dictionary.Remove(num, num))
		{
			dictionary._count = num;
			GameObject gameObject;
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.equipments[num] = equipment;
		Transform transform = equipment.transform;
		Vector3 vector;
		float z = vector.z;
		equipment.data.theColumn = theColumn;
		equipment.data.theRow = theRow;
		GameObject gameObject2 = GameAPP.particlePrefab[1];
		Transform transform2 = equipment.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform3 = base.transform;
		GameAPP.PlaySound(22, 0.5f, 1f);
		SaveInfo.Instance.SavePlayerData();
		this.equipmentOnMouse = num;
		global::UnityEngine.Object.Destroy(this.previewFollowMouse);
		global::UnityEngine.Object.Destroy(this.previewOnWorld);
		this.free = true;
	}

	// Token: 0x06002621 RID: 9761 RVA: 0x000CB144 File Offset: 0x000C9344
	[Token(Token = "0x6002621")]
	[Address(RVA = "0x5E03A0", Offset = "0x5DE9A0", VA = "0x1805E03A0")]
	private void MoveFrame()
	{
		int num;
		do
		{
			num = 0;
			int num2 = 0;
			Vector2Int vector2Int = this.mouseStartCell;
			int y = this.mouseStartCell.m_Y;
			if (vector2Int <= this.mouseEndCell)
			{
				Vector2Int vector2Int2 = this.mouseEndCell;
			}
			List<BigGardenPlant> list = this.plantOnFrame;
			bool flag;
			if (flag)
			{
				Vector2Int vector2Int3 = this.mouseCell;
				bool flag2;
				while (!flag2)
				{
				}
				this.MovePlantByGlove(num2, num, num);
			}
		}
		while (num != 0);
	}

	// Token: 0x06002622 RID: 9762 RVA: 0x000CB1B4 File Offset: 0x000C93B4
	[Token(Token = "0x6002622")]
	[Address(RVA = "0x5DE4A0", Offset = "0x5DCAA0", VA = "0x1805DE4A0")]
	private void LoadPlants()
	{
		int num3;
		do
		{
			int num = 0;
			List<TreasureCardData> list = new List(TreasureData.treasureCards);
			Predicate<TreasureCardData> <>9__41_ = Garden.<>c.<>9__41_0;
			if (<>9__41_ == 0)
			{
				Predicate<TreasureCardData> predicate;
				Garden.<>c.<>9__41_0 = predicate;
			}
			int num2 = list.RemoveAll(<>9__41_);
			num3 = 0;
			bool flag;
			if (flag)
			{
				BigGardenPlant bigGardenPlant;
				bigGardenPlant.data = num;
			}
		}
		while (num3 != 0);
	}

	// Token: 0x06002623 RID: 9763 RVA: 0x000CB20C File Offset: 0x000C940C
	[Token(Token = "0x6002623")]
	[Address(RVA = "0x5DE340", Offset = "0x5DC940", VA = "0x1805DE340")]
	private void LoadEquipments()
	{
		ulong num2;
		do
		{
			int num = 0;
			List<EquipmentData> equipmentData = TreasureData.equipmentData;
			bool flag;
			if (flag)
			{
				GardenEquipment gardenEquipment = GardenEquipment.SetEquipment(this, num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002624 RID: 9764 RVA: 0x000CB240 File Offset: 0x000C9440
	[Token(Token = "0x6002624")]
	[Address(RVA = "0x5DDF90", Offset = "0x5DC590", VA = "0x1805DDF90")]
	private bool IsFreeBox(int theColumn, int theRow, PlantType thePlantType = PlantType.Nothing)
	{
		Dictionary<ValueTuple<int, int>, BigGardenPlant> dictionary = this.plants;
		Dictionary<ValueTuple<int, int>, GardenEquipment> dictionary2 = this.equipments;
		Tilemap tilemap = this.freeBox;
		bool flag;
		if (flag)
		{
			int num = 0;
			bool flag2;
			if (flag2 && !this.waterBox.HasTile(num))
			{
				InGameText instance = InGameText.Instance;
				int num2 = 0;
				instance.ShowText("请种在水中", 3f, num2 != 0);
			}
			int num3 = 0;
			bool flag3;
			if (!flag3 && this.waterBox.HasTile(num3))
			{
				InGameText instance2 = InGameText.Instance;
			}
		}
		InGameText instance3 = InGameText.Instance;
		int num4 = 0;
		instance3.ShowText("该格子在可种植区域外", 3f, num4 != 0);
		this.freeBoxFlashTimer = 3f;
		GameAPP.PlaySound(26, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06002625 RID: 9765 RVA: 0x000CB310 File Offset: 0x000C9510
	[Token(Token = "0x6002625")]
	[Address(RVA = "0x5DDA50", Offset = "0x5DC050", VA = "0x1805DDA50")]
	public BigGardenPlant GetPlant(int theColumn, int theRow)
	{
		Dictionary<ValueTuple<int, int>, BigGardenPlant> dictionary = this.plants;
		int num = 0;
		bool flag = dictionary.TryGetValue(num, num);
		throw new NullReferenceException();
	}

	// Token: 0x06002626 RID: 9766 RVA: 0x000CB338 File Offset: 0x000C9538
	[Token(Token = "0x6002626")]
	[Address(RVA = "0x5DD9A0", Offset = "0x5DBFA0", VA = "0x1805DD9A0")]
	public GardenEquipment GetGardenEquipment(int theColumn, int theRow)
	{
		Dictionary<ValueTuple<int, int>, GardenEquipment> dictionary = this.equipments;
		int num = 0;
		bool flag = dictionary.TryGetValue(num, num);
		throw new NullReferenceException();
	}

	// Token: 0x06002627 RID: 9767 RVA: 0x000CB360 File Offset: 0x000C9560
	[Token(Token = "0x6002627")]
	[Address(RVA = "0x5DDB00", Offset = "0x5DC100", VA = "0x1805DDB00")]
	public List<BigGardenPlant> GetPlants(int theColumn, int theRow, int range)
	{
		List<BigGardenPlant> list = new List();
		Dictionary<ValueTuple<int, int>, BigGardenPlant> dictionary = this.plants;
		bool flag;
		if (flag)
		{
		}
		return list;
	}

	// Token: 0x06002628 RID: 9768 RVA: 0x000CB394 File Offset: 0x000C9594
	[Token(Token = "0x6002628")]
	[Address(RVA = "0x5E1BC0", Offset = "0x5E01C0", VA = "0x1805E1BC0")]
	public ValueTuple<GameObject, GameObject> SetPreview(PlantType thePlantType)
	{
		SortingGroup sortingGroup;
		sortingGroup.sortingLayerName = "Default";
		SortingGroup sortingGroup2;
		sortingGroup2.sortingOrder = 2;
		throw new NullReferenceException();
	}

	// Token: 0x06002629 RID: 9769 RVA: 0x000CB3C8 File Offset: 0x000C95C8
	[Token(Token = "0x6002629")]
	[Address(RVA = "0x5E1DB0", Offset = "0x5E03B0", VA = "0x1805E1DB0")]
	public void SetPreview(EquipmentType theEquipmentType, int range = 3)
	{
		GameObject gameObject;
		this.previewOnWorld = gameObject;
		this.previewOnWorld.GetComponent<SortingGroup>().sortingLayerName = "Default";
		this.previewOnWorld.GetComponent<SortingGroup>().sortingOrder = 2;
		Transform transform = this.previewOnWorld.transform;
		int num = 0;
		SpriteRenderer component = transform.GetChild(num).GetComponent<SpriteRenderer>();
		GameObject gameObject2 = Resources.Load<GameObject>("Garden/Equip/AutoRange/AutoRange");
		Transform transform2 = this.previewOnWorld.transform;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		GameObject gameObject3;
		Transform transform3 = gameObject3.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		Transform transform4 = gameObject3.transform;
		Transform transform5 = this.previewOnWorld.transform;
		transform4.parentInternal = transform5;
		Transform transform6 = gameObject3.transform;
		GameObject gameObject4;
		this.previewFollowMouse = gameObject4;
		this.previewFollowMouse.GetComponent<SortingGroup>().sortingLayerName = "up1";
		this.previewFollowMouse.GetComponent<SortingGroup>().sortingOrder = 30000;
	}

	// Token: 0x0600262A RID: 9770 RVA: 0x000CB4BC File Offset: 0x000C96BC
	[Token(Token = "0x600262A")]
	[Address(RVA = "0x5DE2B0", Offset = "0x5DC8B0", VA = "0x1805DE2B0")]
	public bool IsWaterBox(int theColumn, int theRow)
	{
		Tilemap tilemap = this.waterBox;
		bool flag;
		return flag;
	}

	// Token: 0x0600262B RID: 9771 RVA: 0x000CB4DC File Offset: 0x000C96DC
	[Token(Token = "0x600262B")]
	[Address(RVA = "0x5DE300", Offset = "0x5DC900", VA = "0x1805DE300")]
	public bool IsWaterBox(Vector3Int box)
	{
		Tilemap tilemap = this.waterBox;
		int z = box.m_Z;
		bool flag;
		return flag;
	}

	// Token: 0x0600262C RID: 9772 RVA: 0x000CB500 File Offset: 0x000C9700
	[Token(Token = "0x600262C")]
	[Address(RVA = "0x5E1580", Offset = "0x5DFB80", VA = "0x1805E1580")]
	public GameObject SetParticle(ParticleType particleType, Vector2 position)
	{
		int num;
		GameObject gameObject;
		do
		{
			num = 0;
			Dictionary<ParticleType, GameObject> particlePrefabs = GameAPP.resourcesManager.particlePrefabs;
			bool flag;
			if (!flag)
			{
			}
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = base.transform;
		}
		while (gameObject.TryGetComponent<SortingGroup>(num));
		gameObject.AddComponent<SortingGroup>().sortingOrder = 2;
		return gameObject;
	}

	// Token: 0x0600262D RID: 9773 RVA: 0x000CB554 File Offset: 0x000C9754
	[Token(Token = "0x600262D")]
	[Address(RVA = "0x5E2640", Offset = "0x5E0C40", VA = "0x1805E2640")]
	public Garden()
	{
		List<BigGardenPlant> list = new List();
		this.plantOnFrame = list;
		Dictionary<ValueTuple<int, int>, BigGardenPlant> dictionary = new Dictionary();
		this.plants = dictionary;
		Dictionary<ValueTuple<int, int>, GardenEquipment> dictionary2 = new Dictionary();
		this.equipments = dictionary2;
		base..ctor();
	}

	// Token: 0x040013A9 RID: 5033
	[Token(Token = "0x40013A9")]
	public static Garden Instance;

	// Token: 0x040013AA RID: 5034
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013AA")]
	[Header("引用")]
	public Tilemap tilemap;

	// Token: 0x040013AB RID: 5035
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013AB")]
	public Tilemap treeTile;

	// Token: 0x040013AC RID: 5036
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013AC")]
	public Tilemap freeBox;

	// Token: 0x040013AD RID: 5037
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40013AD")]
	public Tilemap waterBox;

	// Token: 0x040013AE RID: 5038
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40013AE")]
	public GardenPlayer player;

	// Token: 0x040013AF RID: 5039
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40013AF")]
	public BigGardenUI ui;

	// Token: 0x040013B0 RID: 5040
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40013B0")]
	[Header("鼠标位置")]
	public Vector2 mousePosition;

	// Token: 0x040013B1 RID: 5041
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40013B1")]
	public Vector2Int mouseCell;

	// Token: 0x040013B2 RID: 5042
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40013B2")]
	public Vector2Int mouseStartCell;

	// Token: 0x040013B3 RID: 5043
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40013B3")]
	public Vector2Int mouseEndCell;

	// Token: 0x040013B4 RID: 5044
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40013B4")]
	[Header("鼠标数据")]
	public bool free;

	// Token: 0x040013B5 RID: 5045
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40013B5")]
	public BaseTool toolOnMouse;

	// Token: 0x040013B6 RID: 5046
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40013B6")]
	public GardenCard cardOnMouse;

	// Token: 0x040013B7 RID: 5047
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40013B7")]
	public PropCard propCardOnMouse;

	// Token: 0x040013B8 RID: 5048
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40013B8")]
	public BigGardenPlant plantOnMouse;

	// Token: 0x040013B9 RID: 5049
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40013B9")]
	public GardenEquipment equipmentOnMouse;

	// Token: 0x040013BA RID: 5050
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40013BA")]
	public GameObject previewFollowMouse;

	// Token: 0x040013BB RID: 5051
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40013BB")]
	public GameObject previewOnWorld;

	// Token: 0x040013BC RID: 5052
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40013BC")]
	[Header("框选数据")]
	public List<BigGardenPlant> plantOnFrame;

	// Token: 0x040013BD RID: 5053
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40013BD")]
	public GameObject frameRange;

	// Token: 0x040013BE RID: 5054
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40013BE")]
	[TupleElementNames(new string[] { "theColumn", "theRow" })]
	[Header("植物数据")]
	public Dictionary<ValueTuple<int, int>, BigGardenPlant> plants;

	// Token: 0x040013BF RID: 5055
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40013BF")]
	public BigGardenPlant highLightPlant;

	// Token: 0x040013C0 RID: 5056
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40013C0")]
	[TupleElementNames(new string[] { "theColumn", "theRow" })]
	[Header("设备数据")]
	public Dictionary<ValueTuple<int, int>, GardenEquipment> equipments;

	// Token: 0x040013C1 RID: 5057
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40013C1")]
	public GardenEquipment highLightEquipment;

	// Token: 0x040013C2 RID: 5058
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40013C2")]
	[Header("私有变量")]
	private float freeBoxFlashTimer;

	// Token: 0x040013C3 RID: 5059
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x40013C3")]
	private bool framing;

	// Token: 0x040013C4 RID: 5060
	[Token(Token = "0x40013C4")]
	[Header("常量")]
	private const int particleLayer = 2;
}

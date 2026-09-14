using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Tilemaps;

// Token: 0x0200078E RID: 1934
[Token(Token = "0x200078E")]
public class Garden : MonoBehaviour
{
	// Token: 0x0600273C RID: 10044 RVA: 0x000CF11C File Offset: 0x000CD31C
	[Token(Token = "0x600273C")]
	[Address(RVA = "0x640730", Offset = "0x63ED30", VA = "0x180640730")]
	private void Awake()
	{
		Garden.Instance = this;
		this.LoadPlants();
		this.LoadEquipments();
		this.free = true;
	}

	// Token: 0x0600273D RID: 10045 RVA: 0x000CF144 File Offset: 0x000CD344
	[Token(Token = "0x600273D")]
	[Address(RVA = "0x645670", Offset = "0x643C70", VA = "0x180645670")]
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

	// Token: 0x0600273E RID: 10046 RVA: 0x000CF1F8 File Offset: 0x000CD3F8
	[Token(Token = "0x600273E")]
	[Address(RVA = "0x6407A0", Offset = "0x63EDA0", VA = "0x1806407A0")]
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

	// Token: 0x0600273F RID: 10047 RVA: 0x000CF268 File Offset: 0x000CD468
	[Token(Token = "0x600273F")]
	[Address(RVA = "0x642A40", Offset = "0x641040", VA = "0x180642A40")]
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
			Tilemap tilemap3 = this.tilemap;
			int y = this.mouseCell.m_Y;
		}
		BaseTool baseTool = this.toolOnMouse;
		int num10 = 0;
		if (!(baseTool != num10))
		{
			BigGardenPlant bigGardenPlant = this.highLightPlant;
			int num11 = 0;
			if (bigGardenPlant != num11)
			{
				GameMaterial.SetBrightness(this.highLightPlant.spriteRenderers, 1f);
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

	// Token: 0x06002740 RID: 10048 RVA: 0x000CF400 File Offset: 0x000CD600
	[Token(Token = "0x6002740")]
	[Address(RVA = "0x640B80", Offset = "0x63F180", VA = "0x180640B80")]
	private void HighLightUpdate()
	{
		for (;;)
		{
			BigGardenPlant bigGardenPlant = this.highLightPlant;
			int num = 0;
			if (bigGardenPlant == num)
			{
				goto IL_0063;
			}
			BigGardenPlant bigGardenPlant2;
			if (this.highLightPlant != bigGardenPlant2)
			{
				GameMaterial.SetBrightness(this.highLightPlant.spriteRenderers, 1f);
				this.highLightPlant = bigGardenPlant2;
				BigGardenPlant bigGardenPlant3 = this.highLightPlant;
				int num2 = 0;
				if (bigGardenPlant3 != num2)
				{
					this.highLightPlant.HighLight(2.4f);
					goto IL_0063;
				}
			}
			IL_0097:
			GardenEquipment gardenEquipment = this.highLightEquipment;
			int num3 = 0;
			if (!(gardenEquipment == num3))
			{
				break;
			}
			int num4 = 0;
			GardenEquipment gardenEquipment2;
			if (gardenEquipment2 != num4)
			{
				goto Block_7;
			}
			continue;
			IL_0063:
			BigGardenPlant bigGardenPlant4;
			this.highLightPlant = bigGardenPlant4;
			BigGardenPlant bigGardenPlant5 = this.highLightPlant;
			int num5 = 0;
			if (bigGardenPlant5 != num5)
			{
				GameMaterial.SetBrightness(this.highLightPlant.spriteRenderers, 2.4f);
				goto IL_0097;
			}
			goto IL_0097;
		}
		GardenEquipment gardenEquipment3;
		if (this.highLightEquipment != gardenEquipment3)
		{
			GameMaterial.SetBrightness(this.highLightEquipment.spriteRenderers, 1f);
			this.highLightEquipment = gardenEquipment3;
			GardenEquipment gardenEquipment2 = this.highLightEquipment;
			int num6 = 0;
			if (gardenEquipment2 != num6)
			{
				GardenEquipment gardenEquipment4 = this.highLightEquipment;
				gardenEquipment4.HighLight(2.4f);
			}
		}
		return;
		Block_7:
		throw new NullReferenceException();
	}

	// Token: 0x06002741 RID: 10049 RVA: 0x000CF530 File Offset: 0x000CD730
	[Token(Token = "0x6002741")]
	[Address(RVA = "0x641790", Offset = "0x63FD90", VA = "0x180641790")]
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

	// Token: 0x06002742 RID: 10050 RVA: 0x000CFA44 File Offset: 0x000CDC44
	[Token(Token = "0x6002742")]
	[Address(RVA = "0x644100", Offset = "0x642700", VA = "0x180644100")]
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

	// Token: 0x06002743 RID: 10051 RVA: 0x000CFC14 File Offset: 0x000CDE14
	[Token(Token = "0x6002743")]
	[Address(RVA = "0x643C80", Offset = "0x642280", VA = "0x180643C80")]
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

	// Token: 0x06002744 RID: 10052 RVA: 0x000CFE24 File Offset: 0x000CE024
	[Token(Token = "0x6002744")]
	[Address(RVA = "0x6449D0", Offset = "0x642FD0", VA = "0x1806449D0")]
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

	// Token: 0x06002745 RID: 10053 RVA: 0x000CFF4C File Offset: 0x000CE14C
	[Token(Token = "0x6002745")]
	[Address(RVA = "0x645410", Offset = "0x643A10", VA = "0x180645410")]
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

	// Token: 0x06002746 RID: 10054 RVA: 0x000D0008 File Offset: 0x000CE208
	[Token(Token = "0x6002746")]
	[Address(RVA = "0x643710", Offset = "0x641D10", VA = "0x180643710")]
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
		Tilemap tilemap = this.tilemap;
		plant.data.theColumn = theColumn;
		plant.data.theRow = theRow;
		plant.theColumn = theColumn;
		plant.theRow = theRow;
		Tilemap tilemap2 = this.waterBox;
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

	// Token: 0x06002747 RID: 10055 RVA: 0x000D0134 File Offset: 0x000CE334
	[Token(Token = "0x6002747")]
	[Address(RVA = "0x643030", Offset = "0x641630", VA = "0x180643030")]
	private void MoveEquipmentByGlove(GardenEquipment equipment, int theColumn, int theRow)
	{
		int num = 0;
		EquipmentData data = equipment.data;
		int theRow2 = data.theRow;
		int theColumn2 = data.theColumn;
		Dictionary<ValueTuple<int, int>, GardenEquipment> dictionary = this.equipments;
		Dictionary<ValueTuple<int, int>, GardenEquipment> dictionary2 = this.equipments;
		bool flag;
		if (flag)
		{
			dictionary2._count = num;
			GameObject gameObject;
			global::UnityEngine.Object.Destroy(gameObject);
		}
		Dictionary<ValueTuple<int, int>, GardenEquipment> dictionary3 = this.equipments;
		Transform transform = equipment.transform;
		Tilemap tilemap = this.tilemap;
		equipment.data.theColumn = theColumn;
		equipment.data.theRow = theRow;
		GameObject gameObject2 = GameAPP.particlePrefab[1];
		Transform transform2 = equipment.transform;
		Transform transform3 = base.transform;
		GameAPP.PlaySound(22, 0.5f, 1f);
		SaveInfo.Instance.SavePlayerData();
		this.equipmentOnMouse = num;
		global::UnityEngine.Object.Destroy(this.previewFollowMouse);
		global::UnityEngine.Object.Destroy(this.previewOnWorld);
		this.free = true;
	}

	// Token: 0x06002748 RID: 10056 RVA: 0x000D0214 File Offset: 0x000CE414
	[Token(Token = "0x6002748")]
	[Address(RVA = "0x643450", Offset = "0x641A50", VA = "0x180643450")]
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

	// Token: 0x06002749 RID: 10057 RVA: 0x000D0284 File Offset: 0x000CE484
	[Token(Token = "0x6002749")]
	[Address(RVA = "0x6414C0", Offset = "0x63FAC0", VA = "0x1806414C0")]
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

	// Token: 0x0600274A RID: 10058 RVA: 0x000D02DC File Offset: 0x000CE4DC
	[Token(Token = "0x600274A")]
	[Address(RVA = "0x641360", Offset = "0x63F960", VA = "0x180641360")]
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

	// Token: 0x0600274B RID: 10059 RVA: 0x000D0310 File Offset: 0x000CE510
	[Token(Token = "0x600274B")]
	[Address(RVA = "0x640F80", Offset = "0x63F580", VA = "0x180640F80")]
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
			}
			int num2 = 0;
			bool flag3;
			if (!flag3 && this.waterBox.HasTile(num2))
			{
				InGameText instance2 = InGameText.Instance;
			}
		}
		InGameText instance3 = InGameText.Instance;
		this.freeBoxFlashTimer = 3f;
		GameAPP.PlaySound(26, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x0600274C RID: 10060 RVA: 0x000D03B4 File Offset: 0x000CE5B4
	[Token(Token = "0x600274C")]
	[Address(RVA = "0x640970", Offset = "0x63EF70", VA = "0x180640970")]
	public BigGardenPlant GetPlant(int theColumn, int theRow)
	{
		Dictionary<ValueTuple<int, int>, BigGardenPlant> dictionary = this.plants;
		int num = 0;
		bool flag = dictionary.TryGetValue(num, num);
		throw new NullReferenceException();
	}

	// Token: 0x0600274D RID: 10061 RVA: 0x000D03DC File Offset: 0x000CE5DC
	[Token(Token = "0x600274D")]
	[Address(RVA = "0x6408C0", Offset = "0x63EEC0", VA = "0x1806408C0")]
	public GardenEquipment GetGardenEquipment(int theColumn, int theRow)
	{
		Dictionary<ValueTuple<int, int>, GardenEquipment> dictionary = this.equipments;
		int num = 0;
		bool flag = dictionary.TryGetValue(num, num);
		throw new NullReferenceException();
	}

	// Token: 0x0600274E RID: 10062 RVA: 0x000D0404 File Offset: 0x000CE604
	[Token(Token = "0x600274E")]
	[Address(RVA = "0x640A20", Offset = "0x63F020", VA = "0x180640A20")]
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

	// Token: 0x0600274F RID: 10063 RVA: 0x000D0438 File Offset: 0x000CE638
	[Token(Token = "0x600274F")]
	[Address(RVA = "0x644DF0", Offset = "0x6433F0", VA = "0x180644DF0")]
	public ValueTuple<GameObject, GameObject> SetPreview(PlantType thePlantType)
	{
		SortingGroup sortingGroup;
		sortingGroup.sortingLayerName = "Default";
		SortingGroup sortingGroup2;
		sortingGroup2.sortingOrder = 2;
		throw new NullReferenceException();
	}

	// Token: 0x06002750 RID: 10064 RVA: 0x000D046C File Offset: 0x000CE66C
	[Token(Token = "0x6002750")]
	[Address(RVA = "0x644FE0", Offset = "0x6435E0", VA = "0x180644FE0")]
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

	// Token: 0x06002751 RID: 10065 RVA: 0x000D0560 File Offset: 0x000CE760
	[Token(Token = "0x6002751")]
	[Address(RVA = "0x6412D0", Offset = "0x63F8D0", VA = "0x1806412D0")]
	public bool IsWaterBox(int theColumn, int theRow)
	{
		Tilemap tilemap = this.waterBox;
		bool flag;
		return flag;
	}

	// Token: 0x06002752 RID: 10066 RVA: 0x000D0580 File Offset: 0x000CE780
	[Token(Token = "0x6002752")]
	[Address(RVA = "0x641320", Offset = "0x63F920", VA = "0x180641320")]
	public bool IsWaterBox(Vector3Int box)
	{
		Tilemap tilemap = this.waterBox;
		int z = box.m_Z;
		bool flag;
		return flag;
	}

	// Token: 0x06002753 RID: 10067 RVA: 0x000D05A4 File Offset: 0x000CE7A4
	[Token(Token = "0x6002753")]
	[Address(RVA = "0x6447B0", Offset = "0x642DB0", VA = "0x1806447B0")]
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

	// Token: 0x06002754 RID: 10068 RVA: 0x000D05F8 File Offset: 0x000CE7F8
	[Token(Token = "0x6002754")]
	[Address(RVA = "0x645870", Offset = "0x643E70", VA = "0x180645870")]
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

	// Token: 0x04001481 RID: 5249
	[Token(Token = "0x4001481")]
	public static Garden Instance;

	// Token: 0x04001482 RID: 5250
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001482")]
	[Header("引用")]
	public Tilemap tilemap;

	// Token: 0x04001483 RID: 5251
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001483")]
	public Tilemap treeTile;

	// Token: 0x04001484 RID: 5252
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001484")]
	public Tilemap freeBox;

	// Token: 0x04001485 RID: 5253
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001485")]
	public Tilemap waterBox;

	// Token: 0x04001486 RID: 5254
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001486")]
	public GardenPlayer player;

	// Token: 0x04001487 RID: 5255
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001487")]
	public BigGardenUI ui;

	// Token: 0x04001488 RID: 5256
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001488")]
	[Header("鼠标位置")]
	public Vector2 mousePosition;

	// Token: 0x04001489 RID: 5257
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001489")]
	public Vector2Int mouseCell;

	// Token: 0x0400148A RID: 5258
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400148A")]
	public Vector2Int mouseStartCell;

	// Token: 0x0400148B RID: 5259
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400148B")]
	public Vector2Int mouseEndCell;

	// Token: 0x0400148C RID: 5260
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400148C")]
	[Header("鼠标数据")]
	public bool free;

	// Token: 0x0400148D RID: 5261
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400148D")]
	public BaseTool toolOnMouse;

	// Token: 0x0400148E RID: 5262
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400148E")]
	public GardenCard cardOnMouse;

	// Token: 0x0400148F RID: 5263
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400148F")]
	public PropCard propCardOnMouse;

	// Token: 0x04001490 RID: 5264
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001490")]
	public BigGardenPlant plantOnMouse;

	// Token: 0x04001491 RID: 5265
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001491")]
	public GardenEquipment equipmentOnMouse;

	// Token: 0x04001492 RID: 5266
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001492")]
	public GameObject previewFollowMouse;

	// Token: 0x04001493 RID: 5267
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001493")]
	public GameObject previewOnWorld;

	// Token: 0x04001494 RID: 5268
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001494")]
	[Header("框选数据")]
	public List<BigGardenPlant> plantOnFrame;

	// Token: 0x04001495 RID: 5269
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001495")]
	public GameObject frameRange;

	// Token: 0x04001496 RID: 5270
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4001496")]
	[Header("植物数据")]
	[TupleElementNames(new string[] { "theColumn", "theRow" })]
	public Dictionary<ValueTuple<int, int>, BigGardenPlant> plants;

	// Token: 0x04001497 RID: 5271
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4001497")]
	public BigGardenPlant highLightPlant;

	// Token: 0x04001498 RID: 5272
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4001498")]
	[Header("设备数据")]
	[TupleElementNames(new string[] { "theColumn", "theRow" })]
	public Dictionary<ValueTuple<int, int>, GardenEquipment> equipments;

	// Token: 0x04001499 RID: 5273
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4001499")]
	public GardenEquipment highLightEquipment;

	// Token: 0x0400149A RID: 5274
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400149A")]
	[Header("私有变量")]
	private float freeBoxFlashTimer;

	// Token: 0x0400149B RID: 5275
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x400149B")]
	private bool framing;

	// Token: 0x0400149C RID: 5276
	[Token(Token = "0x400149C")]
	[Header("常量")]
	private const int particleLayer = 2;
}

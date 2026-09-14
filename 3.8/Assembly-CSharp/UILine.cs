using System;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200089F RID: 2207
[Token(Token = "0x200089F")]
[RequireComponent(typeof(Image))]
public class UILine : MonoBehaviour
{
	// Token: 0x06002CF9 RID: 11513 RVA: 0x000F7E84 File Offset: 0x000F6084
	[Token(Token = "0x6002CF9")]
	[Address(RVA = "0x694D40", Offset = "0x693340", VA = "0x180694D40")]
	private void Awake()
	{
		bool flag;
		if (!flag)
		{
			Image image = this.AddComponent<Image>();
			this.image = image;
		}
		Transform transform = this.image.transform;
	}

	// Token: 0x06002CFA RID: 11514 RVA: 0x000F7EB8 File Offset: 0x000F60B8
	[Token(Token = "0x6002CFA")]
	[Address(RVA = "0x694E20", Offset = "0x693420", VA = "0x180694E20")]
	public void SetColor(Color color)
	{
		Image image = this.image;
	}

	// Token: 0x06002CFB RID: 11515 RVA: 0x000F7ED4 File Offset: 0x000F60D4
	[Token(Token = "0x6002CFB")]
	[Address(RVA = "0x694E60", Offset = "0x693460", VA = "0x180694E60")]
	[ProButton]
	public void UpdatePosition()
	{
		Transform transform = base.transform;
		Vector2 vector = this.startPosition;
		float y = this.endPosition.y;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
	}

	// Token: 0x06002CFC RID: 11516 RVA: 0x000F7F1C File Offset: 0x000F611C
	[Token(Token = "0x6002CFC")]
	[Address(RVA = "0x695050", Offset = "0x693650", VA = "0x180695050")]
	[ProButton]
	public void UpdateRectPosition()
	{
		Transform transform = base.transform;
		Vector2 vector = this.startPosition;
		float y = this.endPosition.y;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
	}

	// Token: 0x06002CFD RID: 11517 RVA: 0x000F7F64 File Offset: 0x000F6164
	[Token(Token = "0x6002CFD")]
	[Address(RVA = "0x695260", Offset = "0x693860", VA = "0x180695260")]
	public UILine()
	{
	}

	// Token: 0x04001B19 RID: 6937
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B19")]
	private Image image;

	// Token: 0x04001B1A RID: 6938
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001B1A")]
	public Vector2 startPosition;

	// Token: 0x04001B1B RID: 6939
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001B1B")]
	public Vector2 endPosition;

	// Token: 0x04001B1C RID: 6940
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001B1C")]
	public float width = 1f;
}

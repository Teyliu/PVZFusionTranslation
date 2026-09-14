using System;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020008DB RID: 2267
[Token(Token = "0x20008DB")]
[RequireComponent(typeof(Image))]
public class UILine : MonoBehaviour
{
	// Token: 0x06002E2B RID: 11819 RVA: 0x000FC9F4 File Offset: 0x000FABF4
	[Token(Token = "0x6002E2B")]
	[Address(RVA = "0x70ED00", Offset = "0x70D300", VA = "0x18070ED00")]
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

	// Token: 0x06002E2C RID: 11820 RVA: 0x000FCA28 File Offset: 0x000FAC28
	[Token(Token = "0x6002E2C")]
	[Address(RVA = "0x70EDE0", Offset = "0x70D3E0", VA = "0x18070EDE0")]
	public void SetColor(Color color)
	{
		Image image = this.image;
	}

	// Token: 0x06002E2D RID: 11821 RVA: 0x000FCA44 File Offset: 0x000FAC44
	[Token(Token = "0x6002E2D")]
	[Address(RVA = "0x70EE20", Offset = "0x70D420", VA = "0x18070EE20")]
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

	// Token: 0x06002E2E RID: 11822 RVA: 0x000FCA8C File Offset: 0x000FAC8C
	[Token(Token = "0x6002E2E")]
	[Address(RVA = "0x70F010", Offset = "0x70D610", VA = "0x18070F010")]
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

	// Token: 0x06002E2F RID: 11823 RVA: 0x000FCAD4 File Offset: 0x000FACD4
	[Token(Token = "0x6002E2F")]
	[Address(RVA = "0x70F220", Offset = "0x70D820", VA = "0x18070F220")]
	public UILine()
	{
	}

	// Token: 0x04001C07 RID: 7175
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001C07")]
	private Image image;

	// Token: 0x04001C08 RID: 7176
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001C08")]
	public Vector2 startPosition;

	// Token: 0x04001C09 RID: 7177
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001C09")]
	public Vector2 endPosition;

	// Token: 0x04001C0A RID: 7178
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001C0A")]
	public float width = 1f;
}

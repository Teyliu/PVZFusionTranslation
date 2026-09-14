using System;
using Cpp2IlInjected;

namespace OpenBLive.Runtime.Utilities
{
	// Token: 0x02000E38 RID: 3640
	[Token(Token = "0x2000E38")]
	internal class BigEndianBitConverter : EndianBitConverter
	{
		// Token: 0x06004B0A RID: 19210 RVA: 0x00171784 File Offset: 0x0016F984
		[Token(Token = "0x6004B0A")]
		[Address(RVA = "0x8CA920", Offset = "0x8C8F20", VA = "0x1808CA920")]
		internal BigEndianBitConverter()
		{
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06004B0B RID: 19211 RVA: 0x00171798 File Offset: 0x0016F998
		[Token(Token = "0x1700096D")]
		public override bool IsLittleEndian
		{
			[Token(Token = "0x6004B0B")]
			[Address(RVA = "0x8CA970", Offset = "0x8C8F70", VA = "0x1808CA970", Slot = "4")]
			get;
		}

		// Token: 0x06004B0C RID: 19212 RVA: 0x001717AC File Offset: 0x0016F9AC
		[Token(Token = "0x6004B0C")]
		[Address(RVA = "0x8CA420", Offset = "0x8C8A20", VA = "0x1808CA420", Slot = "5")]
		public override byte[] GetBytes(short value)
		{
			byte[] array = new byte[2];
			array[0] = (byte)value;
			array[0] = (byte)value;
			return array;
		}

		// Token: 0x06004B0D RID: 19213 RVA: 0x001717D8 File Offset: 0x0016F9D8
		[Token(Token = "0x6004B0D")]
		[Address(RVA = "0x8CA390", Offset = "0x8C8990", VA = "0x1808CA390", Slot = "6")]
		public override byte[] GetBytes(int value)
		{
			byte[] array = new byte[4];
			array[0] = (byte)value;
			array[0] = (byte)value;
			array[0] = (byte)value;
			array[0] = (byte)value;
			return array;
		}

		// Token: 0x06004B0E RID: 19214 RVA: 0x00171814 File Offset: 0x0016FA14
		[Token(Token = "0x6004B0E")]
		[Address(RVA = "0x8CA490", Offset = "0x8C8A90", VA = "0x1808CA490", Slot = "7")]
		public override byte[] GetBytes(long value)
		{
			byte[] array = new byte[8];
			array[0] = (byte)value;
			array[0] = (byte)value;
			array[0] = (byte)value;
			array[0] = (byte)value;
			array[0] = (byte)value;
			array[0] = (byte)value;
			array[0] = (byte)value;
			array[0] = (byte)value;
			return array;
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x00171870 File Offset: 0x0016FA70
		[Token(Token = "0x6004B0F")]
		[Address(RVA = "0x8CA570", Offset = "0x8C8B70", VA = "0x1808CA570", Slot = "8")]
		public override short ToInt16(byte[] value, int startIndex)
		{
			if (value != 0)
			{
				int num = value.Length;
				num = startIndex + 1;
				return 0;
			}
			return 0;
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x00171898 File Offset: 0x0016FA98
		[Token(Token = "0x6004B10")]
		[Address(RVA = "0x8CA650", Offset = "0x8C8C50", VA = "0x1808CA650", Slot = "9")]
		public override int ToInt32(byte[] value, int startIndex)
		{
			if (value != 0)
			{
				int num = value.Length;
				num = startIndex + 1;
				num = startIndex + 2;
				return 0;
			}
			return 0;
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x001718C4 File Offset: 0x0016FAC4
		[Token(Token = "0x6004B11")]
		[Address(RVA = "0x8CA770", Offset = "0x8C8D70", VA = "0x1808CA770", Slot = "10")]
		public override long ToInt64(byte[] value, int startIndex)
		{
			if (value != 0)
			{
				int num = value.Length;
				num = startIndex + 1;
				num = startIndex + 2;
				num = startIndex + 3;
				return 0L;
			}
			return 0L;
		}
	}
}

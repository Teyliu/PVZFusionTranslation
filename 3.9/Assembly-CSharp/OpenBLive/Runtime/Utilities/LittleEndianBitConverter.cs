using System;
using Cpp2IlInjected;

namespace OpenBLive.Runtime.Utilities
{
	// Token: 0x02000E3D RID: 3645
	[Token(Token = "0x2000E3D")]
	internal class LittleEndianBitConverter : EndianBitConverter
	{
		// Token: 0x06004B32 RID: 19250 RVA: 0x00171CD0 File Offset: 0x0016FED0
		[Token(Token = "0x6004B32")]
		[Address(RVA = "0x8CDA50", Offset = "0x8CC050", VA = "0x1808CDA50")]
		internal LittleEndianBitConverter()
		{
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06004B33 RID: 19251 RVA: 0x00171CEC File Offset: 0x0016FEEC
		[Token(Token = "0x17000971")]
		public override bool IsLittleEndian
		{
			[Token(Token = "0x6004B33")]
			[Address(RVA = "0x8CA970", Offset = "0x8C8F70", VA = "0x1808CA970", Slot = "4")]
			get;
		} = true;

		// Token: 0x06004B34 RID: 19252 RVA: 0x00171D00 File Offset: 0x0016FF00
		[Token(Token = "0x6004B34")]
		[Address(RVA = "0x8CD4B0", Offset = "0x8CBAB0", VA = "0x1808CD4B0", Slot = "5")]
		public override byte[] GetBytes(short value)
		{
			byte[] array = new byte[2];
			array[0] = (byte)value;
			array[0] = (byte)value;
			return array;
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x00171D2C File Offset: 0x0016FF2C
		[Token(Token = "0x6004B35")]
		[Address(RVA = "0x8CD600", Offset = "0x8CBC00", VA = "0x1808CD600", Slot = "6")]
		public override byte[] GetBytes(int value)
		{
			byte[] array = new byte[4];
			array[0] = (byte)value;
			array[0] = (byte)value;
			array[0] = (byte)value;
			array[0] = (byte)value;
			return array;
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x00171D68 File Offset: 0x0016FF68
		[Token(Token = "0x6004B36")]
		[Address(RVA = "0x8CD520", Offset = "0x8CBB20", VA = "0x1808CD520", Slot = "7")]
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

		// Token: 0x06004B37 RID: 19255 RVA: 0x00171DC4 File Offset: 0x0016FFC4
		[Token(Token = "0x6004B37")]
		[Address(RVA = "0x8CD690", Offset = "0x8CBC90", VA = "0x1808CD690", Slot = "8")]
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

		// Token: 0x06004B38 RID: 19256 RVA: 0x00171DEC File Offset: 0x0016FFEC
		[Token(Token = "0x6004B38")]
		[Address(RVA = "0x8CD770", Offset = "0x8CBD70", VA = "0x1808CD770", Slot = "9")]
		public override int ToInt32(byte[] value, int startIndex)
		{
			if (value != 0)
			{
				int num = value.Length;
				num = startIndex + 1;
				num = startIndex + 2;
				num = startIndex + 3;
				return 0;
			}
			return 0;
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x00171E20 File Offset: 0x00170020
		[Token(Token = "0x6004B39")]
		[Address(RVA = "0x8CD890", Offset = "0x8CBE90", VA = "0x1808CD890", Slot = "10")]
		public override long ToInt64(byte[] value, int startIndex)
		{
			if (value != 0)
			{
				int num = value.Length;
				num = startIndex + 1;
				num = startIndex + 2;
				num = startIndex + 3;
				num = startIndex + 4;
				num = startIndex + 5;
				num = startIndex + 6;
				num = startIndex + 7;
				return 0L;
			}
			return 0L;
		}
	}
}

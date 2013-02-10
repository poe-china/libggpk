﻿using System.IO;

namespace LibDat.Files
{
	public class GrantedEffects : BaseDat
	{
		[StringIndex]
		public int Index0 { get; set; }
		public bool Flag0 { get; set; }
		public int Unknown0 { get; set; }
		public int Unknown1 { get; set; }
		public int Unknown2 { get; set; }
		public int Unknown3 { get; set; }
		public int Unknown4 { get; set; }
		public int Unknown5 { get; set; }

		public GrantedEffects(BinaryReader inStream)
		{
			Index0 = inStream.ReadInt32();
			Flag0 = inStream.ReadBoolean();
			Unknown0 = inStream.ReadInt32();
			Unknown1 = inStream.ReadInt32();
			Unknown2 = inStream.ReadInt32();
			Unknown3 = inStream.ReadInt32();
			Unknown4 = inStream.ReadInt32();
			Unknown5 = inStream.ReadInt32();
		}

		public override void Save(BinaryWriter outStream)
		{
			outStream.Write(Index0);
			outStream.Write(Flag0);
			outStream.Write(Unknown0);
			outStream.Write(Unknown1);
			outStream.Write(Unknown2);
			outStream.Write(Unknown3);
			outStream.Write(Unknown4);
			outStream.Write(Unknown5);
		}

		public override int GetSize()
		{
			return 0x1D;
		}
	}
}
﻿/// <summary>
/// Copyright (C) 2015 Matthew Ready.
/// </summary>
using System;
using System.IO;
using Microsoft.Xna.Framework.Content;
using PsigaXnbLib;

namespace PsigaPkgLib.Entries
{
	public class Texture3DEntry : Entry
	{
		private const string ERR_TEXTURE_SIZE = "Texture3D named \"{0}\" has negative size of {1}";
		private const string ERR_TEXTURE_DATA = "Texture3D named \"{0}\" exceeds the boundries of the file! Size is {1}";

		public string Name { get; protected set; }
		public Texture3D Texture { get; protected set; }

		private Texture3DEntry()
		{
		}

		public static Texture3DEntry Read(Stream input)
		{
			string textureName = input.ReadString();
			int size = input.ReadInt32BE();
			if (size < 0) {
				throw new EntryReadException(string.Format(ERR_TEXTURE_SIZE, textureName, size));
			}
			if (input.Length - input.Position < size) {
				throw new EntryReadException(string.Format(ERR_TEXTURE_DATA, textureName, size));
			}
			var originalPosition = input.Position;
			var crs = ContentManagerShim.GetContentReaderFromXnb(textureName, input, new BinaryReader(input));
			var entry =  new Texture3DEntry() {
				Name = textureName,
				Texture = (Texture3D)crs.ReadAsset<Texture3D>()
			};
			input.Position = originalPosition + size;
			return entry;
		}

		public override void WriteTo(Stream s)
		{
			s.WriteString(Name);
			byte[] xnb = Texture.CreateXnb();
			s.WriteInt32BE(xnb.Length);
			s.Write(xnb, 0, xnb.Length);
		}

		public override EntryType Type { get { return EntryType.Texture3D; } }
		public override string DisplayName { get { return Name; } }
	}
}
﻿using Shockky.IO;

namespace Shockky.Chunks
{
    public class UnknownChunk : ChunkItem
    {
        public byte[] Data { get; set; }

        public UnknownChunk(ShockwaveReader input, ChunkHeader header)
            : base(header)
        {
            Data = input.ReadBytes((int)header.Length);
        }

        public override int GetBodySize() => Data.Length;

        public override void WriteBodyTo(ShockwaveWriter output)
        {
            output.Write(Data);
        }
    }
}

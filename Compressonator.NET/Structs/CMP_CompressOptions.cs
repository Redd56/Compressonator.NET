﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Compressonator.NET
{
    public unsafe struct AMD_CMDS
    {
        public fixed byte cmdSet[Constants.ALL_CMD_SETS_SIZE];
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe class CMP_CompressOptions
    {
        [MarshalAs(UnmanagedType.U4)]
        public uint size;

        [MarshalAs(UnmanagedType.U1)]
        public bool useChannelWeighting;
        [MarshalAs(UnmanagedType.R4)]
        public float weightingRed;
        [MarshalAs(UnmanagedType.R4)]
        public float weightingGreen;
        [MarshalAs(UnmanagedType.R4)]
        public float weightingBlue;
        [MarshalAs(UnmanagedType.U1)]
        public bool useAdaptiveWeighting;

        [MarshalAs(UnmanagedType.U1)]
        public bool DXT1UseAlpha;
        [MarshalAs(UnmanagedType.U1)]
        public bool useGPUDecompress;
        [MarshalAs(UnmanagedType.U1)]
        public bool useCGCompress;

        [MarshalAs(UnmanagedType.U1)]
        public byte alphaThreshold;

        [MarshalAs(UnmanagedType.U1)]
        public bool disableMultiTHreading;

        [MarshalAs(UnmanagedType.U4)]
        public CMP_Speed compressionSpeed;
        [MarshalAs(UnmanagedType.U4)]
        public CMP_GPUDecode GPUDecode;
        [MarshalAs(UnmanagedType.U4)]
        public CMP_ComputeType encodeWidth;
        [MarshalAs(UnmanagedType.U4)]
        public uint numThreads;

        [MarshalAs(UnmanagedType.R4)]
        public float quality;

        [MarshalAs(UnmanagedType.U1)]
        public bool restrictColour;
        [MarshalAs(UnmanagedType.U1)]
        public bool restrictAlpha;

        [MarshalAs(UnmanagedType.U4)]
        public uint modeMask;

        [MarshalAs(UnmanagedType.I4)]
        public int numCmds;
        [MarshalAs(UnmanagedType.Struct)]
        public AMD_CMDS cmdSet;

        [MarshalAs(UnmanagedType.R4)]
        public float inputDefog;
        [MarshalAs(UnmanagedType.R4)]
        public float inputExposure;
        [MarshalAs(UnmanagedType.R4)]
        public float inputKneeLow;
        [MarshalAs(UnmanagedType.R4)]
        public float inputKneeHigh;
        [MarshalAs(UnmanagedType.R4)]
        public float inputGamma;

        [MarshalAs(UnmanagedType.I4)]
        public int cmpLevel;
        [MarshalAs(UnmanagedType.I4)]
        public int posBits;
        [MarshalAs(UnmanagedType.I4)]
        public int texCbits;
        [MarshalAs(UnmanagedType.I4)]
        public int normalBits;
        [MarshalAs(UnmanagedType.I4)]
        public int genericBits;

        [MarshalAs(UnmanagedType.I4)]
        public int vCacheSize;
        [MarshalAs(UnmanagedType.I4)]
        public int vCacheFIFOsize;
        [MarshalAs(UnmanagedType.R4)]
        public float overdrawACMR;
        [MarshalAs(UnmanagedType.I4)]
        public int simplifyLOD;
        [MarshalAs(UnmanagedType.U1)]
        public bool vertexFetch;

        [MarshalAs(UnmanagedType.U4)]
        public CMP_FORMAT sourceFormat;
        [MarshalAs(UnmanagedType.U4)]
        public CMP_FORMAT destFormat;
        [MarshalAs(UnmanagedType.U1)]
        public bool format_support_hostEncoder;

        public IntPtr printInfoStr;

        [MarshalAs(UnmanagedType.U1)]
        public bool getPerfStats;
        [MarshalAs(UnmanagedType.Struct)]
        public KernelPerformanceStats perfStats;
        [MarshalAs(UnmanagedType.U1)]
        public bool getDeviceInfo;
        [MarshalAs(UnmanagedType.Struct)]
        public KernelDeviceInfo deviceInfo;

        public CMP_CompressOptions()
        {
            Init();
        }

        void Init()
        {
            size = (uint)Marshal.SizeOf<CMP_CompressOptions>();
        }
    }
}

﻿namespace AtlusLibSharp.PS2.Graphics.Registers
{
    using System;
    using System.IO;
    using Common.Utilities;

    /// <summary>
    /// <para>This register specifies the transmission direction in the transmission between buffers, and activates transmission.</para>
    /// <para>Appropriate settings must be made by the BITBLTBUF/TRXPOS/TRXREG before activating the transmission.</para>
    /// </summary>
    public class TRXDIRRegister
    {
        private ulong _rawData;

        public TRXDIRTransmissionDirection TransmissionDirection
        {
            get { return (TRXDIRTransmissionDirection)BitHelper.GetBits(_rawData, 2, 0); }
            set { BitHelper.ClearAndSetBits(ref _rawData, 2, (ulong)value, 0); }
        }

        public TRXDIRRegister(TRXDIRTransmissionDirection transDirection)
        {
            TransmissionDirection = transDirection;
        }

        internal TRXDIRRegister(BinaryReader reader)
        {
            _rawData = reader.ReadUInt64();
        }

        internal byte[] GetBytes()
        {
            return BitConverter.GetBytes(_rawData);
        }
    }
}

﻿using System.IO;

namespace AtlusLibSharp.Persona3.RenderWare
{
    /// <summary>
    /// Represents a RenderWare node that indicates the end of an <see cref="RMDAnimationSet"/>. It does not contain any data other than itself.
    /// <para>This node is an extension to the RenderWare nodes developed by Atlus.</para>
    /// </summary>
    internal class RMDAnimationSetTerminator : RWNode
    {
        /// <summary>
        /// Initializes a new <see cref="RMDAnimationSetTerminator"/>.
        /// </summary>
        public RMDAnimationSetTerminator() : base(RWType.RMDAnimationSetTerminator) { }

        /// <summary>
        /// Initializer only to be called in <see cref="RWNodeFactory"/>.
        /// </summary>
        internal RMDAnimationSetTerminator(RWNodeFactory.RWNodeProcHeader header) : base(header) { }

        /// <summary>
        /// Inherited from <see cref="RWNode"/>. Writes the data beyond the header.
        /// </summary>
        /// <param name="writer">The <see cref="BinaryWriter"/> to write the data to.</param>
        protected internal override void InternalWriteInnerData(BinaryWriter writer) { }
    }
}

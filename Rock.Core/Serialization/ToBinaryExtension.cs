﻿using System;
using Rock.Defaults.Implementation;

namespace Rock.Serialization
{
    public static class ToBinaryExtension
    {
        public static byte[] ToBinary(this object item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            return Default.BinarySerializer.SerializeToByteArray(item, item.GetType());
        }
    }
}
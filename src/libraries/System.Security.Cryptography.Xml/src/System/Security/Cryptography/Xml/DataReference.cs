// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace System.Security.Cryptography.Xml
{
    public sealed class DataReference : EncryptedReference
    {
        public DataReference() : base()
        {
            ReferenceType = "DataReference";
        }

        public DataReference([StringSyntax(StringSyntaxAttribute.Uri)] string uri) : base(uri)
        {
            ReferenceType = "DataReference";
        }

        public DataReference([StringSyntax(StringSyntaxAttribute.Uri)] string uri, TransformChain transformChain) : base(uri, transformChain)
        {
            ReferenceType = "DataReference";
        }
    }
}

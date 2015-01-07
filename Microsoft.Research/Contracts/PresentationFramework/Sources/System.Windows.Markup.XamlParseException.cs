// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

// File System.Windows.Markup.XamlParseException.cs
// Automatically generated contract file.
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics.Contracts;
using System;

// Disable the "this variable is not used" warning as every field would imply it.
#pragma warning disable 0414
// Disable the "this variable is never assigned to".
#pragma warning disable 0067
// Disable the "this event is never assigned to".
#pragma warning disable 0649
// Disable the "this variable is never used".
#pragma warning disable 0169
// Disable the "new keyword not required" warning.
#pragma warning disable 0109
// Disable the "extern without DllImport" warning.
#pragma warning disable 0626
// Disable the "could hide other member" warning, can happen on certain properties.
#pragma warning disable 0108


namespace System.Windows.Markup
{
  public partial class XamlParseException : SystemException
  {
    #region Methods and constructors
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
    {
    }

    public XamlParseException()
    {
    }

    public XamlParseException(string message, int lineNumber, int linePosition, Exception innerException)
    {
    }

    public XamlParseException(string message, int lineNumber, int linePosition)
    {
    }

    protected XamlParseException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
    {
      Contract.Requires(info != null);
    }

    public XamlParseException(string message, Exception innerException)
    {
    }

    public XamlParseException(string message)
    {
    }
    #endregion

    #region Properties and indexers
    public Uri BaseUri
    {
      get
      {
        return default(Uri);
      }
      internal set
      {
      }
    }

    public Object KeyContext
    {
      get
      {
        return default(Object);
      }
      internal set
      {
      }
    }

    public int LineNumber
    {
      get
      {
        return default(int);
      }
      internal set
      {
      }
    }

    public int LinePosition
    {
      get
      {
        return default(int);
      }
      internal set
      {
      }
    }

    public string NameContext
    {
      get
      {
        return default(string);
      }
      internal set
      {
      }
    }

    public string UidContext
    {
      get
      {
        return default(string);
      }
      internal set
      {
      }
    }
    #endregion
  }
}
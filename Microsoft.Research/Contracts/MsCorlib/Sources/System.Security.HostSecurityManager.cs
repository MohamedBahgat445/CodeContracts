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

// File System.Security.HostSecurityManager.cs
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


namespace System.Security
{
  public partial class HostSecurityManager
  {
    #region Methods and constructors
    public virtual new System.Security.Policy.ApplicationTrust DetermineApplicationTrust(System.Security.Policy.Evidence applicationEvidence, System.Security.Policy.Evidence activatorEvidence, System.Security.Policy.TrustManagerContext context)
    {
      return default(System.Security.Policy.ApplicationTrust);
    }

    public virtual new System.Security.Policy.EvidenceBase GenerateAppDomainEvidence(Type evidenceType)
    {
      return default(System.Security.Policy.EvidenceBase);
    }

    public virtual new System.Security.Policy.EvidenceBase GenerateAssemblyEvidence(Type evidenceType, System.Reflection.Assembly assembly)
    {
      return default(System.Security.Policy.EvidenceBase);
    }

    public virtual new Type[] GetHostSuppliedAppDomainEvidenceTypes()
    {
      return default(Type[]);
    }

    public virtual new Type[] GetHostSuppliedAssemblyEvidenceTypes(System.Reflection.Assembly assembly)
    {
      return default(Type[]);
    }

    public HostSecurityManager()
    {
    }

    public virtual new System.Security.Policy.Evidence ProvideAppDomainEvidence(System.Security.Policy.Evidence inputEvidence)
    {
      return default(System.Security.Policy.Evidence);
    }

    public virtual new System.Security.Policy.Evidence ProvideAssemblyEvidence(System.Reflection.Assembly loadedAssembly, System.Security.Policy.Evidence inputEvidence)
    {
      return default(System.Security.Policy.Evidence);
    }

    public virtual new PermissionSet ResolvePolicy(System.Security.Policy.Evidence evidence)
    {
      return default(PermissionSet);
    }
    #endregion

    #region Properties and indexers
    public virtual new System.Security.Policy.PolicyLevel DomainPolicy
    {
      get
      {
        return default(System.Security.Policy.PolicyLevel);
      }
    }

    public virtual new HostSecurityManagerOptions Flags
    {
      get
      {
        return default(HostSecurityManagerOptions);
      }
    }
    #endregion
  }
}

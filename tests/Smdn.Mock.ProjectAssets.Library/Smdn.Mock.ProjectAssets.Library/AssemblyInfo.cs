// SPDX-FileCopyrightText: 2026 smdn <smdn@smdn.jp>
// SPDX-License-Identifier: MIT
using System;
using System.Linq;
using System.Reflection;

using NUnit.Framework;

namespace Smdn.Mock.ProjectAssets.Library;

[TestFixture]
public class AssemblyInfoTests {
#if RELEASE
  [TestCase("RepositoryUrl")]
  [TestCase("RepositoryBranch")]
  [TestCase("RepositoryCommit")]
  public void MetadataRepositoryInfo(string key)
  {
    var repositoryInfoMetadata = AssemblyInfo
      .GetExecutingAssembly()
      .GetCustomAttributes<AssemblyMetadataAttribute>()
      .FirstOrDefault(m => string.Equals(m.Key, key, StringComparison.Ordinal));

    Assert.That(repositoryInfoMetadata, Is.Not.Null);
    Assert.That(repositoryInfoMetadata.Value, Is.Not.Empty);
  }
#endif

#if NET6_0_OR_GREATER
  [TestCase(true, "True")]
#else
  [TestCase(false, (string?)null)]
#endif
  public void MetadataIsTrimmable(bool expectedAttributeExist, string? expectedValue)
  {
    var isTrimmableMetadata = AssemblyInfo
      .GetExecutingAssembly()
      .GetCustomAttributes<AssemblyMetadataAttribute>()
      .FirstOrDefault(static m => string.Equals(m.Key, "IsTrimmable", StringComparison.Ordinal));

    Assert.That(isTrimmableMetadata, expectedAttributeExist ? Is.Not.Null : Is.Null);

    if (expectedAttributeExist)
      Assert.That(isTrimmableMetadata.Value, Is.EqualTo(expectedValue));
  }

#if NET10_0_OR_GREATER
  [TestCase(true, "True")]
#else
  [TestCase(false, (string?)null)]
#endif
  public void MetadataIsAotCompatible(bool expectedAttributeExist, string? expectedValue)
  {
    var isAotCompatibleMetadata = AssemblyInfo
      .GetExecutingAssembly()
      .GetCustomAttributes<AssemblyMetadataAttribute>()
      .FirstOrDefault(static m => string.Equals(m.Key, "IsAotCompatible", StringComparison.Ordinal));

    Assert.That(isAotCompatibleMetadata, expectedAttributeExist ? Is.Not.Null : Is.Null);

    if (expectedAttributeExist)
      Assert.That(isAotCompatibleMetadata.Value, Is.EqualTo(expectedValue));
  }
}

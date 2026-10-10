// SPDX-FileCopyrightText: 2026 smdn <smdn@smdn.jp>
// SPDX-License-Identifier: MIT

using System.Reflection;

namespace Smdn.Mock.ProjectAssets.Library;

public static class AssemblyInfo {
  public static Assembly GetExecutingAssembly()
    => Assembly.GetExecutingAssembly();
}

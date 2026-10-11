[![GitHub license](https://img.shields.io/github/license/smdn/Smdn.Fundamentals.BuildAssets)](https://github.com/smdn/Smdn.Fundamentals.BuildAssets/blob/main/LICENSE.txt)
[![tests/main](https://img.shields.io/github/actions/workflow/status/smdn/Smdn.Fundamentals.BuildAssets/test.yml?branch=main&label=tests%2Fmain)](https://github.com/smdn/Smdn.Fundamentals.BuildAssets/actions/workflows/test.yml)
[![CodeQL](https://github.com/smdn/Smdn.Fundamentals.BuildAssets/actions/workflows/codeql-analysis.yml/badge.svg?branch=main)](https://github.com/smdn/Smdn.Fundamentals.BuildAssets/actions/workflows/codeql-analysis.yml)
[![OpenSSF Scorecard](https://api.scorecard.dev/projects/github.com/smdn/Smdn.Fundamentals.BuildAssets/badge)](https://scorecard.dev/viewer/?uri=github.com/smdn/Smdn.Fundamentals.BuildAssets)

# Smdn.Fundamentals.BuildAssets

Common MSBuild Project SDKs, build targets, and configuration assets for .NET projects and libraries across the [`smdn/Smdn.*` repositories](https://github.com/smdn?tab=repositories).

## Overview

This repository hosts a collection of MSBuild Project SDKs and build assets shared across various .NET library projects in the [`smdn/Smdn.*` repositories](https://github.com/smdn?tab=repositories).

It provides the following MSBuild packages (packaged with `DevelopmentDependency=true`):

- [![NuGet](https://img.shields.io/nuget/v/Smdn.MSBuild.ProjectAssets.Common.svg)](https://www.nuget.org/packages/Smdn.MSBuild.ProjectAssets.Common/) **[`Smdn.MSBuild.ProjectAssets.Common`](https://www.nuget.org/packages/Smdn.MSBuild.ProjectAssets.Common)**
  Provides common MSBuild project configurations, property defaults (e.g., assembly attributes), code analyzer settings (`.editorconfig`), and build/packaging tools/scripts used across .NET projects.
- [![NuGet](https://img.shields.io/nuget/v/Smdn.MSBuild.ProjectAssets.Library.svg)](https://www.nuget.org/packages/Smdn.MSBuild.ProjectAssets.Library/) **[`Smdn.MSBuild.ProjectAssets.Library`](https://www.nuget.org/packages/Smdn.MSBuild.ProjectAssets.Library)**
  Extends `Smdn.MSBuild.ProjectAssets.Common` with specialized configurations tailored for .NET library projects. This includes default settings for building and packaging, code analysis rules, trimming and Native AOT support, NUnit testing frameworks, and release/documentation tooling.
- [![NuGet](https://img.shields.io/nuget/v/Smdn.MSBuild.DefineConstants.NETSdkApi.svg)](https://www.nuget.org/packages/Smdn.MSBuild.DefineConstants.NETSdkApi/) **[`Smdn.MSBuild.DefineConstants.NETSdkApi`](https://www.nuget.org/packages/Smdn.MSBuild.DefineConstants.NETSdkApi)**
  Provides `.targets` files that automatically define compilation symbols (e.g., `SYSTEM_ARRAY_EMPTY`, `GENERIC_MATH_INTERFACES`) corresponding to the availability of .NET SDK APIs based on the target framework.

## Project Scope & Usage Disclaimers

The primary objective of this repository is to unify and standardize the build, test, and packaging processes for .NET libraries maintained within the `smdn/Smdn.*` repositories.

While these packages are open source and freely available for anyone to use, they are **primarily intended for internal use** within `smdn/Smdn.*` projects. If you choose to adopt these packages in your own projects, please be aware of the following caveats:

- **No Regression Tests**: There are no dedicated regression test suites for these SDK packages.
- **No Official Documentation**: Comprehensive documentation or user guides are not provided.
- **Frequent Breaking Changes**: Breaking changes—including feature additions, removals, and renames—may occur even within **minor** version updates, as updates are driven by the evolving requirements of internal projects.

> [!NOTE]
> This repository was extracted from [`smdn/Smdn.Fundamentals`](https://github.com/smdn/Smdn.Fundamentals). Due to the historical repository split, the git commit log may contain unrelated historical commits from the original repository.

## Related Repositories

- **[`smdn/workflows-dotnet`](https://github.com/smdn/workflows-dotnet)**
  A repository hosting shared GitHub Actions workflows for .NET projects.
  The MSBuild SDK projects in this repository include specific configuration definitions (MSBuild Targets, Properties, and Items) designed to seamlessly coordinate with the reusable CI/CD workflows provided by `smdn/workflows-dotnet`.

- **[`smdn/Smdn.Reflection.ReverseGenerating`](https://github.com/smdn/Smdn.Reflection.ReverseGenerating)**
  A .NET project that reverse-generates C# source code from assembly public APIs using reflection.
  `Smdn.MSBuild.ProjectAssets.Library` integrates a tool that automatically generates API lists in C# code format (`*.apilist.cs`) during the NuGet package creation process. Running `dotnet pack` automatically executes this generator and outputs `*.apilist.cs` files to the default path.

# For contributors
Contributions are appreciated!

If there's a feature you would like to add or a bug you would like to fix, please read [Contribution guidelines](./CONTRIBUTING.md) and create an Issue or Pull Request.

IssueやPull Requestを送る際は、[Contribution guidelines](./CONTRIBUTING.md)をご覧頂ください。　可能なら英語が望ましいですが、日本語で構いません。

# Notice
<!-- #pragma section-start NupkgReadmeFile_Notice -->
## License
This project is licensed under the terms of the [MIT License](./LICENSE.txt).

<!--
## Credits
This project uses the following components. See [ThirdPartyNotices.md](./ThirdPartyNotices.md) for detail.
-->
<!-- #pragma section-end NupkgReadmeFile_Notice -->
